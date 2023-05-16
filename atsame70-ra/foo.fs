
USER_FLASH_BASE constant ufb
FLASH_BASE      constant fb

$8000 constant offset
flash_base offset + constant foo
: crashme
    foo erase-page
    wait-flash-ready
    flash-status
    foo $80 $10203040 memfill
    foo write-page
    flash-status
;

: diag-fault
    SCB-DFSR.
    SCB-MMFAR.
    SCB-AFSR.
    SCB-BFAR.
    SCB-HFSR.
    SCB-CFSR.
    begin again
;