$400E0C00 constant EFC ( Embedded Flash Controller )
EFC $00 + constant EFC-EEFC_FMR ( EEFC Flash Mode Register )
EFC $04 + constant EFC-EEFC_FCR ( EEFC Flash Command Register )
EFC $08 + constant EFC-EEFC_FSR ( EEFC Flash Status Register )
EFC $0C + constant EFC-EEFC_FRR ( EEFC Flash Result Register )
EFC $E4 + constant EFC-EEFC_WPMR ( Write Protection Mode Register )
: EFC-EEFC_FMR. ." EFC-EEFC_FMR () $" EFC-EEFC_FMR @ hex. EFC-EEFC_FMR 1b. ;
: EFC-EEFC_FCR. ." EFC-EEFC_FCR (write-only) $" EFC-EEFC_FCR @ hex. EFC-EEFC_FCR 1b. ;
: EFC-EEFC_FSR. ." EFC-EEFC_FSR (read-only) $" EFC-EEFC_FSR @ hex. EFC-EEFC_FSR 1b. ;
: EFC-EEFC_FRR. ." EFC-EEFC_FRR (read-only) $" EFC-EEFC_FRR @ hex. EFC-EEFC_FRR 1b. ;
: EFC-EEFC_WPMR. ." EFC-EEFC_WPMR () $" EFC-EEFC_WPMR @ hex. EFC-EEFC_WPMR 1b. ;
: EFC.
EFC-EEFC_FMR.
EFC-EEFC_FCR.
EFC-EEFC_FSR.
EFC-EEFC_FRR.
EFC-EEFC_WPMR.
;


\ EFC-EEFC_FMR ()
: EFC-EEFC_FMR_FRDY   %1 0 lshift EFC-EEFC_FMR bis! ;  \ EFC-EEFC_FMR_FRDY    Flash Ready Interrupt Enable
: EFC-EEFC_FMR_FWS   ( %XXXX -- ) 8 lshift EFC-EEFC_FMR bis! ;  \ EFC-EEFC_FMR_FWS    Flash Wait State
: EFC-EEFC_FMR_SCOD   %1 16 lshift EFC-EEFC_FMR bis! ;  \ EFC-EEFC_FMR_SCOD    Sequential Code Optimization Disable
: EFC-EEFC_FMR_CLOE   %1 26 lshift EFC-EEFC_FMR bis! ;  \ EFC-EEFC_FMR_CLOE    Code Loop Optimization Enable

\ EFC-EEFC_FCR (write-only)
: EFC-EEFC_FCR_FCMD   ( %XXXXXXXX -- ) 0 lshift EFC-EEFC_FCR bis! ;  \ EFC-EEFC_FCR_FCMD    Flash Command
: EFC-EEFC_FCR_FARG   ( %XXXXXXXXXXXXXXXX -- ) 8 lshift EFC-EEFC_FCR bis! ;  \ EFC-EEFC_FCR_FARG    Flash Command Argument
: EFC-EEFC_FCR_FKEY   ( %XXXXXXXX -- ) 24 lshift EFC-EEFC_FCR bis! ;  \ EFC-EEFC_FCR_FKEY    Flash Writing Protection Key

\ EFC-EEFC_FSR (read-only)
: EFC-EEFC_FSR_FRDY   %1 0 lshift EFC-EEFC_FSR bis! ;  \ EFC-EEFC_FSR_FRDY    Flash Ready Status cleared when Flash is busy
: EFC-EEFC_FSR_FCMDE   %1 1 lshift EFC-EEFC_FSR bis! ;  \ EFC-EEFC_FSR_FCMDE    Flash Command Error Status cleared on read or by writing EEFC_FCR
: EFC-EEFC_FSR_FLOCKE   %1 2 lshift EFC-EEFC_FSR bis! ;  \ EFC-EEFC_FSR_FLOCKE    Flash Lock Error Status cleared on read
: EFC-EEFC_FSR_FLERR   %1 3 lshift EFC-EEFC_FSR bis! ;  \ EFC-EEFC_FSR_FLERR    Flash Error Status cleared when a programming operation starts
: EFC-EEFC_FSR_UECCELSB   %1 16 lshift EFC-EEFC_FSR bis! ;  \ EFC-EEFC_FSR_UECCELSB    Unique ECC Error on LSB Part of the Memory Flash Data Bus cleared on read
: EFC-EEFC_FSR_MECCELSB   %1 17 lshift EFC-EEFC_FSR bis! ;  \ EFC-EEFC_FSR_MECCELSB    Multiple ECC Error on LSB Part of the Memory Flash Data Bus cleared on read
: EFC-EEFC_FSR_UECCEMSB   %1 18 lshift EFC-EEFC_FSR bis! ;  \ EFC-EEFC_FSR_UECCEMSB    Unique ECC Error on MSB Part of the Memory Flash Data Bus cleared on read
: EFC-EEFC_FSR_MECCEMSB   %1 19 lshift EFC-EEFC_FSR bis! ;  \ EFC-EEFC_FSR_MECCEMSB    Multiple ECC Error on MSB Part of the Memory Flash Data Bus cleared on read

\ EFC-EEFC_FRR (read-only)
: EFC-EEFC_FRR_FVALUE   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift EFC-EEFC_FRR bis! ;  \ EFC-EEFC_FRR_FVALUE    Flash Result Value

\ EFC-EEFC_WPMR ()
: EFC-EEFC_WPMR_WPEN   %1 0 lshift EFC-EEFC_WPMR bis! ;  \ EFC-EEFC_WPMR_WPEN    Write Protection Enable
: EFC-EEFC_WPMR_WPKEY   ( %XXXXXXXXXXXXXXXXXXXXXXXX -- ) 8 lshift EFC-EEFC_WPMR bis! ;  \ EFC-EEFC_WPMR_WPKEY    Write Protection Key
