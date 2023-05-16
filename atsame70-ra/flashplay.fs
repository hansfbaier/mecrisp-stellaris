: compiletoflash compiletoram ;

#include pretty.fs
#include 1b.fs
#include eefc.fs
#include scb.fs
#include util.fs

: flash-ready
    EFC-EEFC_FSR @
    1 and
    1 =
;

\ flash commands
$5A000000 constant EFC-CMD-GET_FLASH_DESCRIPTOR
$5A000001 constant EFC-CMD-WRITE_PAGE
$5A000002 constant EFC-CMD-WRITE_PAGE_AND_LOCK
$5A000003 constant EFC-CMD-ERASE_AND_WRITE_PAGE
$5A000004 constant EFC-CMD-ERASE_WRITE_PAGE_AND_LOCK
$5A000005 constant EFC-CMD-ERASE_ALL
$5A000007 constant EFC-CMD-ERASE_PAGES
$5A000008 constant EFC-CMD-SET_LOCK_BIT
$5A000009 constant EFC-CMD-CLEAR_LOCK_BIT
$5A00000A constant EFC-CMD-GET_LOCK_BIT
$5A00000B constant EFC-CMD-SET_GPNVM_BIT
$5A00000C constant EFC-CMD-CLEAR_GPNVM_BIT
$5A00000D constant EFC-CMD-GET_GPNVM_BIT
$5A00000E constant EFC-CMD-START_READ_UNIQUE_IDENTIFIER
$5A00000F constant EFC-CMD-STOP_READ_UNIQUE_IDENTIFIER
$5A000010 constant EFC-CMD-GET_CALIB_BIT
$5A000011 constant EFC-CMD-ERASE_SECTOR
$5A000012 constant EFC-CMD-WRITE_USER_SIGNATURE
$5A000013 constant EFC-CMD-ERASE_USER_SIGNATURE
$5A000014 constant EFC-CMD-START_READ_USER_SIGNATURE
$5A000015 constant EFC-CMD-STOP_READ_USER_SIGNATURE

$00400000 constant FLASH_BASE
FLASH_BASE $8000 + constant USER_FLASH_BASE

: page-of-address ( addr -- pagenr)
    FLASH_BASE - ( flash-offset )
    $200 /        ( pageno )
;

: flash-status
    EFC-EEFC_FSR @
    cr
    ." Flash status:" cr
    dup 1  0 lshift and 0<> if ." flash ready " else ." flash busy" cr then
    dup 1  1 lshift and 0<> if ." invalid command " cr then
    dup 1  2 lshift and 0<> if ." write attempt on locked region " cr then
    dup 1  3 lshift and 0<> if ." EraseVerify/WriteVerify failed " cr then
    dup 1 16 lshift and 0<> if ." one error detected and corrected on 64 LSB" cr then
    dup 1 17 lshift and 0<> if ." multiple errors detected and *not* corrected on 64 LSB" cr then
    dup 1 18 lshift and 0<> if ." one error detected and corrected on 64 MSB" cr then
    dup 1 19 lshift and 0<> if ." multiple errors detected and *not* corrected on 64 MSB" cr then
    cr
    drop
;

: flash-mode
    EFC-EEFC_FMR @
    cr
    ." flash interrupt:              " dup 1           and 0<> if ." enabled" else ." disabled" then cr
    ." sequential code optimization: " dup 1 16 lshift and 0<> if ." enabled" else ." disabled" then cr
    ." code loop optimization:       " dup 1 26 lshift and 0<> if ." enabled" else ." disabled" then cr
    cr
    drop
;

: wait-flash-ready
    begin
        EFC-EEFC_FSR @
        1 and
    1 = until
;

: write-command ( param command -- )
    swap                        ( command param )
    8 lshift                    ( command param )
    or                          ( command+param )
    cr ." write command: " dup hex.
    wait-flash-ready
    EFC-EEFC_FCR !               ( -- )
    wait-flash-ready
    flash-status
;

: write-page ( addr -- )
    page-of-address        ( page )
    cr ." about to write page: " dup hex. cr
    EFC-CMD-WRITE_PAGE     ( page cmd )
    write-command
;

: lock-page ( addr -- )
    page-of-address        ( page )
    cr ." about to lock page: " dup hex. cr
    EFC-CMD-SET_LOCK_BIT   ( page cmd )
    write-command
;

: unlock-page ( addr -- )
    page-of-address        ( page      )
    cr ." about to unlock page: " dup hex. cr
    EFC-CMD-CLEAR_LOCK_BIT ( page cmd )
    write-command
;

: erase-page ( addr -- )
    page-of-address        ( page      )
    2 or
    EFC-CMD-ERASE_PAGES    ( page cmd )
    write-command
;

: get-flash-descriptor ( -- descriptor )
    EFC-CMD-GET_FLASH_DESCRIPTOR 0 write-command
    EFC-EEFC_FRR @
    EFC-EEFC_FRR @
    EFC-EEFC_FRR @
    EFC-EEFC_FRR @
    EFC-EEFC_FRR @
    EFC-EEFC_FRR @
    EFC-EEFC_FRR @
    hex .s
;

: flash-info ( -- )
    get-flash-descriptor
    6 pick ." flash ID:                    0x" hex. cr
    5 pick ." flash size:                  0x" hex. cr
    4 pick ." page  size:                  0x" hex. cr
    3 pick ." no planes:                   0x" hex. cr
    2 pick ." no bytes in plane:           0x" hex. cr
    1 pick ." no lock bits:                0x" hex. cr
           ." no bytes in 1st lock region: 0x" hex. cr
    cr
    2drop
    2drop
    2drop
    begin
        EFC-EEFC_FRR @
           ." Further lock region bits:    0x"
        dup hex. cr
    0= until
;

: show-result-register
    begin
        EFC-EEFC_FRR @
        dup . cr
    0= until
;

: lock-kernel-pages
    FLASH_BASE
    begin
        dup                        ( addr addr )
        ." lock addr: " dup hex.
        wait-flash-ready
        lock-page
        $200 +
        dup
        .s
    USER_FLASH_BASE = until
;

: unlock-kernel-pages
    FLASH_BASE
    begin
        dup                        ( addr addr )
        ." unlock addr: " dup hex.
        wait-flash-ready
        unlock-page
        $200 +
        dup
        .s
    USER_FLASH_BASE = until
;

#include foo.fs