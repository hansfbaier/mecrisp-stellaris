\ TEMPLATE FILE for ATSAME70N19
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence

 compiletoflash

\ available forth template words as selected by config.xml

$40044000 constant ACC ( Analog Comparator Controller )
ACC $00 + constant ACC-CR ( Control Register )
ACC $04 + constant ACC-MR ( Mode Register )
ACC $24 + constant ACC-IER ( Interrupt Enable Register )
ACC $28 + constant ACC-IDR ( Interrupt Disable Register )
ACC $2C + constant ACC-IMR ( Interrupt Mask Register )
ACC $30 + constant ACC-ISR ( Interrupt Status Register )
ACC $94 + constant ACC-ACR ( Analog Control Register )
ACC $E4 + constant ACC-WPMR ( Write Protection Mode Register )
ACC $E8 + constant ACC-WPSR ( Write Protection Status Register )
: ACC-CR. ." ACC-CR (write-only) $" ACC-CR @ hex. ACC-CR 1b. ;
: ACC-MR. ." ACC-MR () $" ACC-MR @ hex. ACC-MR 1b. ;
: ACC-IER. ." ACC-IER (write-only) $" ACC-IER @ hex. ACC-IER 1b. ;
: ACC-IDR. ." ACC-IDR (write-only) $" ACC-IDR @ hex. ACC-IDR 1b. ;
: ACC-IMR. ." ACC-IMR (read-only) $" ACC-IMR @ hex. ACC-IMR 1b. ;
: ACC-ISR. ." ACC-ISR (read-only) $" ACC-ISR @ hex. ACC-ISR 1b. ;
: ACC-ACR. ." ACC-ACR () $" ACC-ACR @ hex. ACC-ACR 1b. ;
: ACC-WPMR. ." ACC-WPMR () $" ACC-WPMR @ hex. ACC-WPMR 1b. ;
: ACC-WPSR. ." ACC-WPSR (read-only) $" ACC-WPSR @ hex. ACC-WPSR 1b. ;
: ACC.
ACC-CR.
ACC-MR.
ACC-IER.
ACC-IDR.
ACC-IMR.
ACC-ISR.
ACC-ACR.
ACC-WPMR.
ACC-WPSR.
;

$4006C000 constant AES ( Advanced Encryption Standard )
AES $00 + constant AES-CR ( Control Register )
AES $04 + constant AES-MR ( Mode Register )
AES $10 + constant AES-IER ( Interrupt Enable Register )
AES $14 + constant AES-IDR ( Interrupt Disable Register )
AES $18 + constant AES-IMR ( Interrupt Mask Register )
AES $1C + constant AES-ISR ( Interrupt Status Register )
AES $20 + constant AES-KEYWR[%s] ( Key Word Register 0 )
AES $40 + constant AES-IDATAR[%s] ( Input Data Register 0 )
AES $50 + constant AES-ODATAR[%s] ( Output Data Register 0 )
AES $60 + constant AES-IVR[%s] ( Initialization Vector Register 0 )
AES $70 + constant AES-AADLENR ( Additional Authenticated Data Length Register )
AES $74 + constant AES-CLENR ( Plaintext/Ciphertext Length Register )
AES $78 + constant AES-GHASHR[%s] ( GCM Intermediate Hash Word Register 0 )
AES $88 + constant AES-TAGR[%s] ( GCM Authentication Tag Word Register 0 )
AES $98 + constant AES-CTRR ( GCM Encryption Counter Value Register )
AES $9C + constant AES-GCMHR[%s] ( GCM H Word Register 0 )
: AES-CR. ." AES-CR (write-only) $" AES-CR @ hex. AES-CR 1b. ;
: AES-MR. ." AES-MR () $" AES-MR @ hex. AES-MR 1b. ;
: AES-IER. ." AES-IER (write-only) $" AES-IER @ hex. AES-IER 1b. ;
: AES-IDR. ." AES-IDR (write-only) $" AES-IDR @ hex. AES-IDR 1b. ;
: AES-IMR. ." AES-IMR (read-only) $" AES-IMR @ hex. AES-IMR 1b. ;
: AES-ISR. ." AES-ISR (read-only) $" AES-ISR @ hex. AES-ISR 1b. ;
: AES-KEYWR[%s]. ." AES-KEYWR[%s] (write-only) $" AES-KEYWR[%s] @ hex. AES-KEYWR[%s] 1b. ;
: AES-IDATAR[%s]. ." AES-IDATAR[%s] (write-only) $" AES-IDATAR[%s] @ hex. AES-IDATAR[%s] 1b. ;
: AES-ODATAR[%s]. ." AES-ODATAR[%s] (read-only) $" AES-ODATAR[%s] @ hex. AES-ODATAR[%s] 1b. ;
: AES-IVR[%s]. ." AES-IVR[%s] (write-only) $" AES-IVR[%s] @ hex. AES-IVR[%s] 1b. ;
: AES-AADLENR. ." AES-AADLENR () $" AES-AADLENR @ hex. AES-AADLENR 1b. ;
: AES-CLENR. ." AES-CLENR () $" AES-CLENR @ hex. AES-CLENR 1b. ;
: AES-GHASHR[%s]. ." AES-GHASHR[%s] () $" AES-GHASHR[%s] @ hex. AES-GHASHR[%s] 1b. ;
: AES-TAGR[%s]. ." AES-TAGR[%s] (read-only) $" AES-TAGR[%s] @ hex. AES-TAGR[%s] 1b. ;
: AES-CTRR. ." AES-CTRR (read-only) $" AES-CTRR @ hex. AES-CTRR 1b. ;
: AES-GCMHR[%s]. ." AES-GCMHR[%s] () $" AES-GCMHR[%s] @ hex. AES-GCMHR[%s] 1b. ;
: AES.
AES-CR.
AES-MR.
AES-IER.
AES-IDR.
AES-IMR.
AES-ISR.
AES-KEYWR[%s].
AES-IDATAR[%s].
AES-ODATAR[%s].
AES-IVR[%s].
AES-AADLENR.
AES-CLENR.
AES-GHASHR[%s].
AES-TAGR[%s].
AES-CTRR.
AES-GCMHR[%s].
;

$4003C000 constant AFEC0 ( Analog Front-End Controller )
AFEC0 $00 + constant AFEC0-CR ( AFEC Control Register )
AFEC0 $04 + constant AFEC0-MR ( AFEC Mode Register )
AFEC0 $08 + constant AFEC0-EMR ( AFEC Extended Mode Register )
AFEC0 $0C + constant AFEC0-SEQ1R ( AFEC Channel Sequence 1 Register )
AFEC0 $10 + constant AFEC0-SEQ2R ( AFEC Channel Sequence 2 Register )
AFEC0 $14 + constant AFEC0-CHER ( AFEC Channel Enable Register )
AFEC0 $18 + constant AFEC0-CHDR ( AFEC Channel Disable Register )
AFEC0 $1C + constant AFEC0-CHSR ( AFEC Channel Status Register )
AFEC0 $20 + constant AFEC0-LCDR ( AFEC Last Converted Data Register )
AFEC0 $24 + constant AFEC0-IER ( AFEC Interrupt Enable Register )
AFEC0 $28 + constant AFEC0-IDR ( AFEC Interrupt Disable Register )
AFEC0 $2C + constant AFEC0-IMR ( AFEC Interrupt Mask Register )
AFEC0 $30 + constant AFEC0-ISR ( AFEC Interrupt Status Register )
AFEC0 $4C + constant AFEC0-OVER ( AFEC Overrun Status Register )
AFEC0 $50 + constant AFEC0-CWR ( AFEC Compare Window Register )
AFEC0 $54 + constant AFEC0-CGR ( AFEC Channel Gain Register )
AFEC0 $60 + constant AFEC0-DIFFR ( AFEC Channel Differential Register )
AFEC0 $64 + constant AFEC0-CSELR ( AFEC Channel Selection Register )
AFEC0 $68 + constant AFEC0-CDR ( AFEC Channel Data Register )
AFEC0 $6C + constant AFEC0-COCR ( AFEC Channel Offset Compensation Register )
AFEC0 $70 + constant AFEC0-TEMPMR ( AFEC Temperature Sensor Mode Register )
AFEC0 $74 + constant AFEC0-TEMPCWR ( AFEC Temperature Compare Window Register )
AFEC0 $94 + constant AFEC0-ACR ( AFEC Analog Control Register )
AFEC0 $A0 + constant AFEC0-SHMR ( AFEC Sample & Hold Mode Register )
AFEC0 $D0 + constant AFEC0-COSR ( AFEC Correction Select Register )
AFEC0 $D4 + constant AFEC0-CVR ( AFEC Correction Values Register )
AFEC0 $D8 + constant AFEC0-CECR ( AFEC Channel Error Correction Register )
AFEC0 $E4 + constant AFEC0-WPMR ( AFEC Write Protection Mode Register )
AFEC0 $E8 + constant AFEC0-WPSR ( AFEC Write Protection Status Register )
: AFEC0-CR. ." AFEC0-CR (write-only) $" AFEC0-CR @ hex. AFEC0-CR 1b. ;
: AFEC0-MR. ." AFEC0-MR () $" AFEC0-MR @ hex. AFEC0-MR 1b. ;
: AFEC0-EMR. ." AFEC0-EMR () $" AFEC0-EMR @ hex. AFEC0-EMR 1b. ;
: AFEC0-SEQ1R. ." AFEC0-SEQ1R () $" AFEC0-SEQ1R @ hex. AFEC0-SEQ1R 1b. ;
: AFEC0-SEQ2R. ." AFEC0-SEQ2R () $" AFEC0-SEQ2R @ hex. AFEC0-SEQ2R 1b. ;
: AFEC0-CHER. ." AFEC0-CHER (write-only) $" AFEC0-CHER @ hex. AFEC0-CHER 1b. ;
: AFEC0-CHDR. ." AFEC0-CHDR (write-only) $" AFEC0-CHDR @ hex. AFEC0-CHDR 1b. ;
: AFEC0-CHSR. ." AFEC0-CHSR (read-only) $" AFEC0-CHSR @ hex. AFEC0-CHSR 1b. ;
: AFEC0-LCDR. ." AFEC0-LCDR (read-only) $" AFEC0-LCDR @ hex. AFEC0-LCDR 1b. ;
: AFEC0-IER. ." AFEC0-IER (write-only) $" AFEC0-IER @ hex. AFEC0-IER 1b. ;
: AFEC0-IDR. ." AFEC0-IDR (write-only) $" AFEC0-IDR @ hex. AFEC0-IDR 1b. ;
: AFEC0-IMR. ." AFEC0-IMR (read-only) $" AFEC0-IMR @ hex. AFEC0-IMR 1b. ;
: AFEC0-ISR. ." AFEC0-ISR (read-only) $" AFEC0-ISR @ hex. AFEC0-ISR 1b. ;
: AFEC0-OVER. ." AFEC0-OVER (read-only) $" AFEC0-OVER @ hex. AFEC0-OVER 1b. ;
: AFEC0-CWR. ." AFEC0-CWR () $" AFEC0-CWR @ hex. AFEC0-CWR 1b. ;
: AFEC0-CGR. ." AFEC0-CGR () $" AFEC0-CGR @ hex. AFEC0-CGR 1b. ;
: AFEC0-DIFFR. ." AFEC0-DIFFR () $" AFEC0-DIFFR @ hex. AFEC0-DIFFR 1b. ;
: AFEC0-CSELR. ." AFEC0-CSELR () $" AFEC0-CSELR @ hex. AFEC0-CSELR 1b. ;
: AFEC0-CDR. ." AFEC0-CDR (read-only) $" AFEC0-CDR @ hex. AFEC0-CDR 1b. ;
: AFEC0-COCR. ." AFEC0-COCR () $" AFEC0-COCR @ hex. AFEC0-COCR 1b. ;
: AFEC0-TEMPMR. ." AFEC0-TEMPMR () $" AFEC0-TEMPMR @ hex. AFEC0-TEMPMR 1b. ;
: AFEC0-TEMPCWR. ." AFEC0-TEMPCWR () $" AFEC0-TEMPCWR @ hex. AFEC0-TEMPCWR 1b. ;
: AFEC0-ACR. ." AFEC0-ACR () $" AFEC0-ACR @ hex. AFEC0-ACR 1b. ;
: AFEC0-SHMR. ." AFEC0-SHMR () $" AFEC0-SHMR @ hex. AFEC0-SHMR 1b. ;
: AFEC0-COSR. ." AFEC0-COSR () $" AFEC0-COSR @ hex. AFEC0-COSR 1b. ;
: AFEC0-CVR. ." AFEC0-CVR () $" AFEC0-CVR @ hex. AFEC0-CVR 1b. ;
: AFEC0-CECR. ." AFEC0-CECR () $" AFEC0-CECR @ hex. AFEC0-CECR 1b. ;
: AFEC0-WPMR. ." AFEC0-WPMR () $" AFEC0-WPMR @ hex. AFEC0-WPMR 1b. ;
: AFEC0-WPSR. ." AFEC0-WPSR (read-only) $" AFEC0-WPSR @ hex. AFEC0-WPSR 1b. ;
: AFEC0.
AFEC0-CR.
AFEC0-MR.
AFEC0-EMR.
AFEC0-SEQ1R.
AFEC0-SEQ2R.
AFEC0-CHER.
AFEC0-CHDR.
AFEC0-CHSR.
AFEC0-LCDR.
AFEC0-IER.
AFEC0-IDR.
AFEC0-IMR.
AFEC0-ISR.
AFEC0-OVER.
AFEC0-CWR.
AFEC0-CGR.
AFEC0-DIFFR.
AFEC0-CSELR.
AFEC0-CDR.
AFEC0-COCR.
AFEC0-TEMPMR.
AFEC0-TEMPCWR.
AFEC0-ACR.
AFEC0-SHMR.
AFEC0-COSR.
AFEC0-CVR.
AFEC0-CECR.
AFEC0-WPMR.
AFEC0-WPSR.
;

$40064000 constant AFEC1 ( Analog Front-End Controller )
AFEC1 $00 + constant AFEC1-CR ( AFEC Control Register )
AFEC1 $04 + constant AFEC1-MR ( AFEC Mode Register )
AFEC1 $08 + constant AFEC1-EMR ( AFEC Extended Mode Register )
AFEC1 $0C + constant AFEC1-SEQ1R ( AFEC Channel Sequence 1 Register )
AFEC1 $10 + constant AFEC1-SEQ2R ( AFEC Channel Sequence 2 Register )
AFEC1 $14 + constant AFEC1-CHER ( AFEC Channel Enable Register )
AFEC1 $18 + constant AFEC1-CHDR ( AFEC Channel Disable Register )
AFEC1 $1C + constant AFEC1-CHSR ( AFEC Channel Status Register )
AFEC1 $20 + constant AFEC1-LCDR ( AFEC Last Converted Data Register )
AFEC1 $24 + constant AFEC1-IER ( AFEC Interrupt Enable Register )
AFEC1 $28 + constant AFEC1-IDR ( AFEC Interrupt Disable Register )
AFEC1 $2C + constant AFEC1-IMR ( AFEC Interrupt Mask Register )
AFEC1 $30 + constant AFEC1-ISR ( AFEC Interrupt Status Register )
AFEC1 $4C + constant AFEC1-OVER ( AFEC Overrun Status Register )
AFEC1 $50 + constant AFEC1-CWR ( AFEC Compare Window Register )
AFEC1 $54 + constant AFEC1-CGR ( AFEC Channel Gain Register )
AFEC1 $60 + constant AFEC1-DIFFR ( AFEC Channel Differential Register )
AFEC1 $64 + constant AFEC1-CSELR ( AFEC Channel Selection Register )
AFEC1 $68 + constant AFEC1-CDR ( AFEC Channel Data Register )
AFEC1 $6C + constant AFEC1-COCR ( AFEC Channel Offset Compensation Register )
AFEC1 $70 + constant AFEC1-TEMPMR ( AFEC Temperature Sensor Mode Register )
AFEC1 $74 + constant AFEC1-TEMPCWR ( AFEC Temperature Compare Window Register )
AFEC1 $94 + constant AFEC1-ACR ( AFEC Analog Control Register )
AFEC1 $A0 + constant AFEC1-SHMR ( AFEC Sample & Hold Mode Register )
AFEC1 $D0 + constant AFEC1-COSR ( AFEC Correction Select Register )
AFEC1 $D4 + constant AFEC1-CVR ( AFEC Correction Values Register )
AFEC1 $D8 + constant AFEC1-CECR ( AFEC Channel Error Correction Register )
AFEC1 $E4 + constant AFEC1-WPMR ( AFEC Write Protection Mode Register )
AFEC1 $E8 + constant AFEC1-WPSR ( AFEC Write Protection Status Register )
: AFEC1-CR. ." AFEC1-CR (write-only) $" AFEC1-CR @ hex. AFEC1-CR 1b. ;
: AFEC1-MR. ." AFEC1-MR () $" AFEC1-MR @ hex. AFEC1-MR 1b. ;
: AFEC1-EMR. ." AFEC1-EMR () $" AFEC1-EMR @ hex. AFEC1-EMR 1b. ;
: AFEC1-SEQ1R. ." AFEC1-SEQ1R () $" AFEC1-SEQ1R @ hex. AFEC1-SEQ1R 1b. ;
: AFEC1-SEQ2R. ." AFEC1-SEQ2R () $" AFEC1-SEQ2R @ hex. AFEC1-SEQ2R 1b. ;
: AFEC1-CHER. ." AFEC1-CHER (write-only) $" AFEC1-CHER @ hex. AFEC1-CHER 1b. ;
: AFEC1-CHDR. ." AFEC1-CHDR (write-only) $" AFEC1-CHDR @ hex. AFEC1-CHDR 1b. ;
: AFEC1-CHSR. ." AFEC1-CHSR (read-only) $" AFEC1-CHSR @ hex. AFEC1-CHSR 1b. ;
: AFEC1-LCDR. ." AFEC1-LCDR (read-only) $" AFEC1-LCDR @ hex. AFEC1-LCDR 1b. ;
: AFEC1-IER. ." AFEC1-IER (write-only) $" AFEC1-IER @ hex. AFEC1-IER 1b. ;
: AFEC1-IDR. ." AFEC1-IDR (write-only) $" AFEC1-IDR @ hex. AFEC1-IDR 1b. ;
: AFEC1-IMR. ." AFEC1-IMR (read-only) $" AFEC1-IMR @ hex. AFEC1-IMR 1b. ;
: AFEC1-ISR. ." AFEC1-ISR (read-only) $" AFEC1-ISR @ hex. AFEC1-ISR 1b. ;
: AFEC1-OVER. ." AFEC1-OVER (read-only) $" AFEC1-OVER @ hex. AFEC1-OVER 1b. ;
: AFEC1-CWR. ." AFEC1-CWR () $" AFEC1-CWR @ hex. AFEC1-CWR 1b. ;
: AFEC1-CGR. ." AFEC1-CGR () $" AFEC1-CGR @ hex. AFEC1-CGR 1b. ;
: AFEC1-DIFFR. ." AFEC1-DIFFR () $" AFEC1-DIFFR @ hex. AFEC1-DIFFR 1b. ;
: AFEC1-CSELR. ." AFEC1-CSELR () $" AFEC1-CSELR @ hex. AFEC1-CSELR 1b. ;
: AFEC1-CDR. ." AFEC1-CDR (read-only) $" AFEC1-CDR @ hex. AFEC1-CDR 1b. ;
: AFEC1-COCR. ." AFEC1-COCR () $" AFEC1-COCR @ hex. AFEC1-COCR 1b. ;
: AFEC1-TEMPMR. ." AFEC1-TEMPMR () $" AFEC1-TEMPMR @ hex. AFEC1-TEMPMR 1b. ;
: AFEC1-TEMPCWR. ." AFEC1-TEMPCWR () $" AFEC1-TEMPCWR @ hex. AFEC1-TEMPCWR 1b. ;
: AFEC1-ACR. ." AFEC1-ACR () $" AFEC1-ACR @ hex. AFEC1-ACR 1b. ;
: AFEC1-SHMR. ." AFEC1-SHMR () $" AFEC1-SHMR @ hex. AFEC1-SHMR 1b. ;
: AFEC1-COSR. ." AFEC1-COSR () $" AFEC1-COSR @ hex. AFEC1-COSR 1b. ;
: AFEC1-CVR. ." AFEC1-CVR () $" AFEC1-CVR @ hex. AFEC1-CVR 1b. ;
: AFEC1-CECR. ." AFEC1-CECR () $" AFEC1-CECR @ hex. AFEC1-CECR 1b. ;
: AFEC1-WPMR. ." AFEC1-WPMR () $" AFEC1-WPMR @ hex. AFEC1-WPMR 1b. ;
: AFEC1-WPSR. ." AFEC1-WPSR (read-only) $" AFEC1-WPSR @ hex. AFEC1-WPSR 1b. ;
: AFEC1.
AFEC1-CR.
AFEC1-MR.
AFEC1-EMR.
AFEC1-SEQ1R.
AFEC1-SEQ2R.
AFEC1-CHER.
AFEC1-CHDR.
AFEC1-CHSR.
AFEC1-LCDR.
AFEC1-IER.
AFEC1-IDR.
AFEC1-IMR.
AFEC1-ISR.
AFEC1-OVER.
AFEC1-CWR.
AFEC1-CGR.
AFEC1-DIFFR.
AFEC1-CSELR.
AFEC1-CDR.
AFEC1-COCR.
AFEC1-TEMPMR.
AFEC1-TEMPCWR.
AFEC1-ACR.
AFEC1-SHMR.
AFEC1-COSR.
AFEC1-CVR.
AFEC1-CECR.
AFEC1-WPMR.
AFEC1-WPSR.
;

$400E0940 constant CHIPID ( Chip Identifier )
CHIPID $0 + constant CHIPID-CIDR ( Chip ID Register )
CHIPID $4 + constant CHIPID-EXID ( Chip ID Extension Register )
: CHIPID-CIDR. ." CHIPID-CIDR (read-only) $" CHIPID-CIDR @ hex. CHIPID-CIDR 1b. ;
: CHIPID-EXID. ." CHIPID-EXID (read-only) $" CHIPID-EXID @ hex. CHIPID-EXID 1b. ;
: CHIPID.
CHIPID-CIDR.
CHIPID-EXID.
;

$40040000 constant DACC ( Digital-to-Analog Converter Controller )
DACC $00 + constant DACC-CR ( Control Register )
DACC $04 + constant DACC-MR ( Mode Register )
DACC $08 + constant DACC-TRIGR ( Trigger Register )
DACC $10 + constant DACC-CHER ( Channel Enable Register )
DACC $14 + constant DACC-CHDR ( Channel Disable Register )
DACC $18 + constant DACC-CHSR ( Channel Status Register )
DACC $1C + constant DACC-CDR[%s] ( Conversion Data Register 0 )
DACC $24 + constant DACC-IER ( Interrupt Enable Register )
DACC $28 + constant DACC-IDR ( Interrupt Disable Register )
DACC $2C + constant DACC-IMR ( Interrupt Mask Register )
DACC $30 + constant DACC-ISR ( Interrupt Status Register )
DACC $94 + constant DACC-ACR ( Analog Current Register )
DACC $E4 + constant DACC-WPMR ( Write Protection Mode Register )
DACC $E8 + constant DACC-WPSR ( Write Protection Status Register )
: DACC-CR. ." DACC-CR (write-only) $" DACC-CR @ hex. DACC-CR 1b. ;
: DACC-MR. ." DACC-MR () $" DACC-MR @ hex. DACC-MR 1b. ;
: DACC-TRIGR. ." DACC-TRIGR () $" DACC-TRIGR @ hex. DACC-TRIGR 1b. ;
: DACC-CHER. ." DACC-CHER (write-only) $" DACC-CHER @ hex. DACC-CHER 1b. ;
: DACC-CHDR. ." DACC-CHDR (write-only) $" DACC-CHDR @ hex. DACC-CHDR 1b. ;
: DACC-CHSR. ." DACC-CHSR (read-only) $" DACC-CHSR @ hex. DACC-CHSR 1b. ;
: DACC-CDR[%s]. ." DACC-CDR[%s] (write-only) $" DACC-CDR[%s] @ hex. DACC-CDR[%s] 1b. ;
: DACC-IER. ." DACC-IER (write-only) $" DACC-IER @ hex. DACC-IER 1b. ;
: DACC-IDR. ." DACC-IDR (write-only) $" DACC-IDR @ hex. DACC-IDR 1b. ;
: DACC-IMR. ." DACC-IMR (read-only) $" DACC-IMR @ hex. DACC-IMR 1b. ;
: DACC-ISR. ." DACC-ISR (read-only) $" DACC-ISR @ hex. DACC-ISR 1b. ;
: DACC-ACR. ." DACC-ACR () $" DACC-ACR @ hex. DACC-ACR 1b. ;
: DACC-WPMR. ." DACC-WPMR () $" DACC-WPMR @ hex. DACC-WPMR 1b. ;
: DACC-WPSR. ." DACC-WPSR (read-only) $" DACC-WPSR @ hex. DACC-WPSR 1b. ;
: DACC.
DACC-CR.
DACC-MR.
DACC-TRIGR.
DACC-CHER.
DACC-CHDR.
DACC-CHSR.
DACC-CDR[%s].
DACC-IER.
DACC-IDR.
DACC-IMR.
DACC-ISR.
DACC-ACR.
DACC-WPMR.
DACC-WPSR.
;

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

$40050000 constant GMAC ( Gigabit Ethernet MAC )
GMAC $000 + constant GMAC-NCR ( Network Control Register )
GMAC $004 + constant GMAC-NCFGR ( Network Configuration Register )
GMAC $008 + constant GMAC-NSR ( Network Status Register )
GMAC $00C + constant GMAC-UR ( User Register )
GMAC $010 + constant GMAC-DCFGR ( DMA Configuration Register )
GMAC $014 + constant GMAC-TSR ( Transmit Status Register )
GMAC $018 + constant GMAC-RBQB ( Receive Buffer Queue Base Address Register )
GMAC $01C + constant GMAC-TBQB ( Transmit Buffer Queue Base Address Register )
GMAC $020 + constant GMAC-RSR ( Receive Status Register )
GMAC $024 + constant GMAC-ISR ( Interrupt Status Register )
GMAC $028 + constant GMAC-IER ( Interrupt Enable Register )
GMAC $02C + constant GMAC-IDR ( Interrupt Disable Register )
GMAC $030 + constant GMAC-IMR ( Interrupt Mask Register )
GMAC $034 + constant GMAC-MAN ( PHY Maintenance Register )
GMAC $038 + constant GMAC-RPQ ( Received Pause Quantum Register )
GMAC $03C + constant GMAC-TPQ ( Transmit Pause Quantum Register )
GMAC $040 + constant GMAC-TPSF ( TX Partial Store and Forward Register )
GMAC $044 + constant GMAC-RPSF ( RX Partial Store and Forward Register )
GMAC $048 + constant GMAC-RJFML ( RX Jumbo Frame Max Length Register )
GMAC $080 + constant GMAC-HRB ( Hash Register Bottom )
GMAC $084 + constant GMAC-HRT ( Hash Register Top )
GMAC $0A8 + constant GMAC-TIDM1 ( Type ID Match 1 Register )
GMAC $0AC + constant GMAC-TIDM2 ( Type ID Match 2 Register )
GMAC $0B0 + constant GMAC-TIDM3 ( Type ID Match 3 Register )
GMAC $0B4 + constant GMAC-TIDM4 ( Type ID Match 4 Register )
GMAC $0B8 + constant GMAC-WOL ( Wake on LAN Register )
GMAC $0BC + constant GMAC-IPGS ( IPG Stretch Register )
GMAC $0C0 + constant GMAC-SVLAN ( Stacked VLAN Register )
GMAC $0C4 + constant GMAC-TPFCP ( Transmit PFC Pause Register )
GMAC $0C8 + constant GMAC-SAMB1 ( Specific Address 1 Mask Bottom Register )
GMAC $0CC + constant GMAC-SAMT1 ( Specific Address 1 Mask Top Register )
GMAC $0DC + constant GMAC-NSC ( 1588 Timer Nanosecond Comparison Register )
GMAC $0E0 + constant GMAC-SCL ( 1588 Timer Second Comparison Low Register )
GMAC $0E4 + constant GMAC-SCH ( 1588 Timer Second Comparison High Register )
GMAC $0E8 + constant GMAC-EFTSH ( PTP Event Frame Transmitted Seconds High Register )
GMAC $0EC + constant GMAC-EFRSH ( PTP Event Frame Received Seconds High Register )
GMAC $0F0 + constant GMAC-PEFTSH ( PTP Peer Event Frame Transmitted Seconds High Register )
GMAC $0F4 + constant GMAC-PEFRSH ( PTP Peer Event Frame Received Seconds High Register )
GMAC $100 + constant GMAC-OTLO ( Octets Transmitted Low Register )
GMAC $104 + constant GMAC-OTHI ( Octets Transmitted High Register )
GMAC $108 + constant GMAC-FT ( Frames Transmitted Register )
GMAC $10C + constant GMAC-BCFT ( Broadcast Frames Transmitted Register )
GMAC $110 + constant GMAC-MFT ( Multicast Frames Transmitted Register )
GMAC $114 + constant GMAC-PFT ( Pause Frames Transmitted Register )
GMAC $118 + constant GMAC-BFT64 ( 64 Byte Frames Transmitted Register )
GMAC $11C + constant GMAC-TBFT127 ( 65 to 127 Byte Frames Transmitted Register )
GMAC $120 + constant GMAC-TBFT255 ( 128 to 255 Byte Frames Transmitted Register )
GMAC $124 + constant GMAC-TBFT511 ( 256 to 511 Byte Frames Transmitted Register )
GMAC $128 + constant GMAC-TBFT1023 ( 512 to 1023 Byte Frames Transmitted Register )
GMAC $12C + constant GMAC-TBFT1518 ( 1024 to 1518 Byte Frames Transmitted Register )
GMAC $130 + constant GMAC-GTBFT1518 ( Greater Than 1518 Byte Frames Transmitted Register )
GMAC $134 + constant GMAC-TUR ( Transmit Underruns Register )
GMAC $138 + constant GMAC-SCF ( Single Collision Frames Register )
GMAC $13C + constant GMAC-MCF ( Multiple Collision Frames Register )
GMAC $140 + constant GMAC-EC ( Excessive Collisions Register )
GMAC $144 + constant GMAC-LC ( Late Collisions Register )
GMAC $148 + constant GMAC-DTF ( Deferred Transmission Frames Register )
GMAC $14C + constant GMAC-CSE ( Carrier Sense Errors Register )
GMAC $150 + constant GMAC-ORLO ( Octets Received Low Received Register )
GMAC $154 + constant GMAC-ORHI ( Octets Received High Received Register )
GMAC $158 + constant GMAC-FR ( Frames Received Register )
GMAC $15C + constant GMAC-BCFR ( Broadcast Frames Received Register )
GMAC $160 + constant GMAC-MFR ( Multicast Frames Received Register )
GMAC $164 + constant GMAC-PFR ( Pause Frames Received Register )
GMAC $168 + constant GMAC-BFR64 ( 64 Byte Frames Received Register )
GMAC $16C + constant GMAC-TBFR127 ( 65 to 127 Byte Frames Received Register )
GMAC $170 + constant GMAC-TBFR255 ( 128 to 255 Byte Frames Received Register )
GMAC $174 + constant GMAC-TBFR511 ( 256 to 511 Byte Frames Received Register )
GMAC $178 + constant GMAC-TBFR1023 ( 512 to 1023 Byte Frames Received Register )
GMAC $17C + constant GMAC-TBFR1518 ( 1024 to 1518 Byte Frames Received Register )
GMAC $180 + constant GMAC-TMXBFR ( 1519 to Maximum Byte Frames Received Register )
GMAC $184 + constant GMAC-UFR ( Undersize Frames Received Register )
GMAC $188 + constant GMAC-OFR ( Oversize Frames Received Register )
GMAC $18C + constant GMAC-JR ( Jabbers Received Register )
GMAC $190 + constant GMAC-FCSE ( Frame Check Sequence Errors Register )
GMAC $194 + constant GMAC-LFFE ( Length Field Frame Errors Register )
GMAC $198 + constant GMAC-RSE ( Receive Symbol Errors Register )
GMAC $19C + constant GMAC-AE ( Alignment Errors Register )
GMAC $1A0 + constant GMAC-RRE ( Receive Resource Errors Register )
GMAC $1A4 + constant GMAC-ROE ( Receive Overrun Register )
GMAC $1A8 + constant GMAC-IHCE ( IP Header Checksum Errors Register )
GMAC $1AC + constant GMAC-TCE ( TCP Checksum Errors Register )
GMAC $1B0 + constant GMAC-UCE ( UDP Checksum Errors Register )
GMAC $1BC + constant GMAC-TISUBN ( 1588 Timer Increment Sub-nanoseconds Register )
GMAC $1C0 + constant GMAC-TSH ( 1588 Timer Seconds High Register )
GMAC $1D0 + constant GMAC-TSL ( 1588 Timer Seconds Low Register )
GMAC $1D4 + constant GMAC-TN ( 1588 Timer Nanoseconds Register )
GMAC $1D8 + constant GMAC-TA ( 1588 Timer Adjust Register )
GMAC $1DC + constant GMAC-TI ( 1588 Timer Increment Register )
GMAC $1E0 + constant GMAC-EFTSL ( PTP Event Frame Transmitted Seconds Low Register )
GMAC $1E4 + constant GMAC-EFTN ( PTP Event Frame Transmitted Nanoseconds Register )
GMAC $1E8 + constant GMAC-EFRSL ( PTP Event Frame Received Seconds Low Register )
GMAC $1EC + constant GMAC-EFRN ( PTP Event Frame Received Nanoseconds Register )
GMAC $1F0 + constant GMAC-PEFTSL ( PTP Peer Event Frame Transmitted Seconds Low Register )
GMAC $1F4 + constant GMAC-PEFTN ( PTP Peer Event Frame Transmitted Nanoseconds Register )
GMAC $1F8 + constant GMAC-PEFRSL ( PTP Peer Event Frame Received Seconds Low Register )
GMAC $1FC + constant GMAC-PEFRN ( PTP Peer Event Frame Received Nanoseconds Register )
GMAC $3FC + constant GMAC-ISRPQ[%s] ( Interrupt Status Register Priority Queue index = 1 0 )
GMAC $43C + constant GMAC-TBQBAPQ[%s] ( Transmit Buffer Queue Base Address Register Priority Queue index = 1 0 )
GMAC $47C + constant GMAC-RBQBAPQ[%s] ( Receive Buffer Queue Base Address Register Priority Queue index = 1 0 )
GMAC $49C + constant GMAC-RBSRPQ[%s] ( Receive Buffer Size Register Priority Queue index = 1 0 )
GMAC $4BC + constant GMAC-CBSCR ( Credit-Based Shaping Control Register )
GMAC $4C0 + constant GMAC-CBSISQA ( Credit-Based Shaping IdleSlope Register for Queue A )
GMAC $4C4 + constant GMAC-CBSISQB ( Credit-Based Shaping IdleSlope Register for Queue B )
GMAC $500 + constant GMAC-ST1RPQ[%s] ( Screening Type 1 Register Priority Queue index = 0 0 )
GMAC $540 + constant GMAC-ST2RPQ[%s] ( Screening Type 2 Register Priority Queue index = 0 0 )
GMAC $5FC + constant GMAC-IERPQ[%s] ( Interrupt Enable Register Priority Queue index = 1 0 )
GMAC $61C + constant GMAC-IDRPQ[%s] ( Interrupt Disable Register Priority Queue index = 1 0 )
GMAC $63C + constant GMAC-IMRPQ[%s] ( Interrupt Mask Register Priority Queue index = 1 0 )
GMAC $6E0 + constant GMAC-ST2ER[%s] ( Screening Type 2 Ethertype Register index = 0 0 )
GMAC $700 + constant GMAC-ST2CW00 ( Screening Type 2 Compare Word 0 Register index = 0 )
GMAC $704 + constant GMAC-ST2CW10 ( Screening Type 2 Compare Word 1 Register index = 0 )
GMAC $708 + constant GMAC-ST2CW01 ( Screening Type 2 Compare Word 0 Register index = 1 )
GMAC $70C + constant GMAC-ST2CW11 ( Screening Type 2 Compare Word 1 Register index = 1 )
GMAC $710 + constant GMAC-ST2CW02 ( Screening Type 2 Compare Word 0 Register index = 2 )
GMAC $714 + constant GMAC-ST2CW12 ( Screening Type 2 Compare Word 1 Register index = 2 )
GMAC $718 + constant GMAC-ST2CW03 ( Screening Type 2 Compare Word 0 Register index = 3 )
GMAC $71C + constant GMAC-ST2CW13 ( Screening Type 2 Compare Word 1 Register index = 3 )
GMAC $720 + constant GMAC-ST2CW04 ( Screening Type 2 Compare Word 0 Register index = 4 )
GMAC $724 + constant GMAC-ST2CW14 ( Screening Type 2 Compare Word 1 Register index = 4 )
GMAC $728 + constant GMAC-ST2CW05 ( Screening Type 2 Compare Word 0 Register index = 5 )
GMAC $72C + constant GMAC-ST2CW15 ( Screening Type 2 Compare Word 1 Register index = 5 )
GMAC $730 + constant GMAC-ST2CW06 ( Screening Type 2 Compare Word 0 Register index = 6 )
GMAC $734 + constant GMAC-ST2CW16 ( Screening Type 2 Compare Word 1 Register index = 6 )
GMAC $738 + constant GMAC-ST2CW07 ( Screening Type 2 Compare Word 0 Register index = 7 )
GMAC $73C + constant GMAC-ST2CW17 ( Screening Type 2 Compare Word 1 Register index = 7 )
GMAC $740 + constant GMAC-ST2CW08 ( Screening Type 2 Compare Word 0 Register index = 8 )
GMAC $744 + constant GMAC-ST2CW18 ( Screening Type 2 Compare Word 1 Register index = 8 )
GMAC $748 + constant GMAC-ST2CW09 ( Screening Type 2 Compare Word 0 Register index = 9 )
GMAC $74C + constant GMAC-ST2CW19 ( Screening Type 2 Compare Word 1 Register index = 9 )
GMAC $750 + constant GMAC-ST2CW010 ( Screening Type 2 Compare Word 0 Register index = 10 )
GMAC $754 + constant GMAC-ST2CW110 ( Screening Type 2 Compare Word 1 Register index = 10 )
GMAC $758 + constant GMAC-ST2CW011 ( Screening Type 2 Compare Word 0 Register index = 11 )
GMAC $75C + constant GMAC-ST2CW111 ( Screening Type 2 Compare Word 1 Register index = 11 )
GMAC $760 + constant GMAC-ST2CW012 ( Screening Type 2 Compare Word 0 Register index = 12 )
GMAC $764 + constant GMAC-ST2CW112 ( Screening Type 2 Compare Word 1 Register index = 12 )
GMAC $768 + constant GMAC-ST2CW013 ( Screening Type 2 Compare Word 0 Register index = 13 )
GMAC $76C + constant GMAC-ST2CW113 ( Screening Type 2 Compare Word 1 Register index = 13 )
GMAC $770 + constant GMAC-ST2CW014 ( Screening Type 2 Compare Word 0 Register index = 14 )
GMAC $774 + constant GMAC-ST2CW114 ( Screening Type 2 Compare Word 1 Register index = 14 )
GMAC $778 + constant GMAC-ST2CW015 ( Screening Type 2 Compare Word 0 Register index = 15 )
GMAC $77C + constant GMAC-ST2CW115 ( Screening Type 2 Compare Word 1 Register index = 15 )
GMAC $780 + constant GMAC-ST2CW016 ( Screening Type 2 Compare Word 0 Register index = 16 )
GMAC $784 + constant GMAC-ST2CW116 ( Screening Type 2 Compare Word 1 Register index = 16 )
GMAC $788 + constant GMAC-ST2CW017 ( Screening Type 2 Compare Word 0 Register index = 17 )
GMAC $78C + constant GMAC-ST2CW117 ( Screening Type 2 Compare Word 1 Register index = 17 )
GMAC $790 + constant GMAC-ST2CW018 ( Screening Type 2 Compare Word 0 Register index = 18 )
GMAC $794 + constant GMAC-ST2CW118 ( Screening Type 2 Compare Word 1 Register index = 18 )
GMAC $798 + constant GMAC-ST2CW019 ( Screening Type 2 Compare Word 0 Register index = 19 )
GMAC $79C + constant GMAC-ST2CW119 ( Screening Type 2 Compare Word 1 Register index = 19 )
GMAC $7A0 + constant GMAC-ST2CW020 ( Screening Type 2 Compare Word 0 Register index = 20 )
GMAC $7A4 + constant GMAC-ST2CW120 ( Screening Type 2 Compare Word 1 Register index = 20 )
GMAC $7A8 + constant GMAC-ST2CW021 ( Screening Type 2 Compare Word 0 Register index = 21 )
GMAC $7AC + constant GMAC-ST2CW121 ( Screening Type 2 Compare Word 1 Register index = 21 )
GMAC $7B0 + constant GMAC-ST2CW022 ( Screening Type 2 Compare Word 0 Register index = 22 )
GMAC $7B4 + constant GMAC-ST2CW122 ( Screening Type 2 Compare Word 1 Register index = 22 )
GMAC $7B8 + constant GMAC-ST2CW023 ( Screening Type 2 Compare Word 0 Register index = 23 )
GMAC $7BC + constant GMAC-ST2CW123 ( Screening Type 2 Compare Word 1 Register index = 23 )
: GMAC-NCR. ." GMAC-NCR () $" GMAC-NCR @ hex. GMAC-NCR 1b. ;
: GMAC-NCFGR. ." GMAC-NCFGR () $" GMAC-NCFGR @ hex. GMAC-NCFGR 1b. ;
: GMAC-NSR. ." GMAC-NSR (read-only) $" GMAC-NSR @ hex. GMAC-NSR 1b. ;
: GMAC-UR. ." GMAC-UR () $" GMAC-UR @ hex. GMAC-UR 1b. ;
: GMAC-DCFGR. ." GMAC-DCFGR () $" GMAC-DCFGR @ hex. GMAC-DCFGR 1b. ;
: GMAC-TSR. ." GMAC-TSR () $" GMAC-TSR @ hex. GMAC-TSR 1b. ;
: GMAC-RBQB. ." GMAC-RBQB () $" GMAC-RBQB @ hex. GMAC-RBQB 1b. ;
: GMAC-TBQB. ." GMAC-TBQB () $" GMAC-TBQB @ hex. GMAC-TBQB 1b. ;
: GMAC-RSR. ." GMAC-RSR () $" GMAC-RSR @ hex. GMAC-RSR 1b. ;
: GMAC-ISR. ." GMAC-ISR (read-only) $" GMAC-ISR @ hex. GMAC-ISR 1b. ;
: GMAC-IER. ." GMAC-IER (write-only) $" GMAC-IER @ hex. GMAC-IER 1b. ;
: GMAC-IDR. ." GMAC-IDR (write-only) $" GMAC-IDR @ hex. GMAC-IDR 1b. ;
: GMAC-IMR. ." GMAC-IMR () $" GMAC-IMR @ hex. GMAC-IMR 1b. ;
: GMAC-MAN. ." GMAC-MAN () $" GMAC-MAN @ hex. GMAC-MAN 1b. ;
: GMAC-RPQ. ." GMAC-RPQ (read-only) $" GMAC-RPQ @ hex. GMAC-RPQ 1b. ;
: GMAC-TPQ. ." GMAC-TPQ () $" GMAC-TPQ @ hex. GMAC-TPQ 1b. ;
: GMAC-TPSF. ." GMAC-TPSF () $" GMAC-TPSF @ hex. GMAC-TPSF 1b. ;
: GMAC-RPSF. ." GMAC-RPSF () $" GMAC-RPSF @ hex. GMAC-RPSF 1b. ;
: GMAC-RJFML. ." GMAC-RJFML () $" GMAC-RJFML @ hex. GMAC-RJFML 1b. ;
: GMAC-HRB. ." GMAC-HRB () $" GMAC-HRB @ hex. GMAC-HRB 1b. ;
: GMAC-HRT. ." GMAC-HRT () $" GMAC-HRT @ hex. GMAC-HRT 1b. ;
: GMAC-TIDM1. ." GMAC-TIDM1 () $" GMAC-TIDM1 @ hex. GMAC-TIDM1 1b. ;
: GMAC-TIDM2. ." GMAC-TIDM2 () $" GMAC-TIDM2 @ hex. GMAC-TIDM2 1b. ;
: GMAC-TIDM3. ." GMAC-TIDM3 () $" GMAC-TIDM3 @ hex. GMAC-TIDM3 1b. ;
: GMAC-TIDM4. ." GMAC-TIDM4 () $" GMAC-TIDM4 @ hex. GMAC-TIDM4 1b. ;
: GMAC-WOL. ." GMAC-WOL () $" GMAC-WOL @ hex. GMAC-WOL 1b. ;
: GMAC-IPGS. ." GMAC-IPGS () $" GMAC-IPGS @ hex. GMAC-IPGS 1b. ;
: GMAC-SVLAN. ." GMAC-SVLAN () $" GMAC-SVLAN @ hex. GMAC-SVLAN 1b. ;
: GMAC-TPFCP. ." GMAC-TPFCP () $" GMAC-TPFCP @ hex. GMAC-TPFCP 1b. ;
: GMAC-SAMB1. ." GMAC-SAMB1 () $" GMAC-SAMB1 @ hex. GMAC-SAMB1 1b. ;
: GMAC-SAMT1. ." GMAC-SAMT1 () $" GMAC-SAMT1 @ hex. GMAC-SAMT1 1b. ;
: GMAC-NSC. ." GMAC-NSC () $" GMAC-NSC @ hex. GMAC-NSC 1b. ;
: GMAC-SCL. ." GMAC-SCL () $" GMAC-SCL @ hex. GMAC-SCL 1b. ;
: GMAC-SCH. ." GMAC-SCH () $" GMAC-SCH @ hex. GMAC-SCH 1b. ;
: GMAC-EFTSH. ." GMAC-EFTSH (read-only) $" GMAC-EFTSH @ hex. GMAC-EFTSH 1b. ;
: GMAC-EFRSH. ." GMAC-EFRSH (read-only) $" GMAC-EFRSH @ hex. GMAC-EFRSH 1b. ;
: GMAC-PEFTSH. ." GMAC-PEFTSH (read-only) $" GMAC-PEFTSH @ hex. GMAC-PEFTSH 1b. ;
: GMAC-PEFRSH. ." GMAC-PEFRSH (read-only) $" GMAC-PEFRSH @ hex. GMAC-PEFRSH 1b. ;
: GMAC-OTLO. ." GMAC-OTLO (read-only) $" GMAC-OTLO @ hex. GMAC-OTLO 1b. ;
: GMAC-OTHI. ." GMAC-OTHI (read-only) $" GMAC-OTHI @ hex. GMAC-OTHI 1b. ;
: GMAC-FT. ." GMAC-FT (read-only) $" GMAC-FT @ hex. GMAC-FT 1b. ;
: GMAC-BCFT. ." GMAC-BCFT (read-only) $" GMAC-BCFT @ hex. GMAC-BCFT 1b. ;
: GMAC-MFT. ." GMAC-MFT (read-only) $" GMAC-MFT @ hex. GMAC-MFT 1b. ;
: GMAC-PFT. ." GMAC-PFT (read-only) $" GMAC-PFT @ hex. GMAC-PFT 1b. ;
: GMAC-BFT64. ." GMAC-BFT64 (read-only) $" GMAC-BFT64 @ hex. GMAC-BFT64 1b. ;
: GMAC-TBFT127. ." GMAC-TBFT127 (read-only) $" GMAC-TBFT127 @ hex. GMAC-TBFT127 1b. ;
: GMAC-TBFT255. ." GMAC-TBFT255 (read-only) $" GMAC-TBFT255 @ hex. GMAC-TBFT255 1b. ;
: GMAC-TBFT511. ." GMAC-TBFT511 (read-only) $" GMAC-TBFT511 @ hex. GMAC-TBFT511 1b. ;
: GMAC-TBFT1023. ." GMAC-TBFT1023 (read-only) $" GMAC-TBFT1023 @ hex. GMAC-TBFT1023 1b. ;
: GMAC-TBFT1518. ." GMAC-TBFT1518 (read-only) $" GMAC-TBFT1518 @ hex. GMAC-TBFT1518 1b. ;
: GMAC-GTBFT1518. ." GMAC-GTBFT1518 (read-only) $" GMAC-GTBFT1518 @ hex. GMAC-GTBFT1518 1b. ;
: GMAC-TUR. ." GMAC-TUR (read-only) $" GMAC-TUR @ hex. GMAC-TUR 1b. ;
: GMAC-SCF. ." GMAC-SCF (read-only) $" GMAC-SCF @ hex. GMAC-SCF 1b. ;
: GMAC-MCF. ." GMAC-MCF (read-only) $" GMAC-MCF @ hex. GMAC-MCF 1b. ;
: GMAC-EC. ." GMAC-EC (read-only) $" GMAC-EC @ hex. GMAC-EC 1b. ;
: GMAC-LC. ." GMAC-LC (read-only) $" GMAC-LC @ hex. GMAC-LC 1b. ;
: GMAC-DTF. ." GMAC-DTF (read-only) $" GMAC-DTF @ hex. GMAC-DTF 1b. ;
: GMAC-CSE. ." GMAC-CSE (read-only) $" GMAC-CSE @ hex. GMAC-CSE 1b. ;
: GMAC-ORLO. ." GMAC-ORLO (read-only) $" GMAC-ORLO @ hex. GMAC-ORLO 1b. ;
: GMAC-ORHI. ." GMAC-ORHI (read-only) $" GMAC-ORHI @ hex. GMAC-ORHI 1b. ;
: GMAC-FR. ." GMAC-FR (read-only) $" GMAC-FR @ hex. GMAC-FR 1b. ;
: GMAC-BCFR. ." GMAC-BCFR (read-only) $" GMAC-BCFR @ hex. GMAC-BCFR 1b. ;
: GMAC-MFR. ." GMAC-MFR (read-only) $" GMAC-MFR @ hex. GMAC-MFR 1b. ;
: GMAC-PFR. ." GMAC-PFR (read-only) $" GMAC-PFR @ hex. GMAC-PFR 1b. ;
: GMAC-BFR64. ." GMAC-BFR64 (read-only) $" GMAC-BFR64 @ hex. GMAC-BFR64 1b. ;
: GMAC-TBFR127. ." GMAC-TBFR127 (read-only) $" GMAC-TBFR127 @ hex. GMAC-TBFR127 1b. ;
: GMAC-TBFR255. ." GMAC-TBFR255 (read-only) $" GMAC-TBFR255 @ hex. GMAC-TBFR255 1b. ;
: GMAC-TBFR511. ." GMAC-TBFR511 (read-only) $" GMAC-TBFR511 @ hex. GMAC-TBFR511 1b. ;
: GMAC-TBFR1023. ." GMAC-TBFR1023 (read-only) $" GMAC-TBFR1023 @ hex. GMAC-TBFR1023 1b. ;
: GMAC-TBFR1518. ." GMAC-TBFR1518 (read-only) $" GMAC-TBFR1518 @ hex. GMAC-TBFR1518 1b. ;
: GMAC-TMXBFR. ." GMAC-TMXBFR (read-only) $" GMAC-TMXBFR @ hex. GMAC-TMXBFR 1b. ;
: GMAC-UFR. ." GMAC-UFR (read-only) $" GMAC-UFR @ hex. GMAC-UFR 1b. ;
: GMAC-OFR. ." GMAC-OFR (read-only) $" GMAC-OFR @ hex. GMAC-OFR 1b. ;
: GMAC-JR. ." GMAC-JR (read-only) $" GMAC-JR @ hex. GMAC-JR 1b. ;
: GMAC-FCSE. ." GMAC-FCSE (read-only) $" GMAC-FCSE @ hex. GMAC-FCSE 1b. ;
: GMAC-LFFE. ." GMAC-LFFE (read-only) $" GMAC-LFFE @ hex. GMAC-LFFE 1b. ;
: GMAC-RSE. ." GMAC-RSE (read-only) $" GMAC-RSE @ hex. GMAC-RSE 1b. ;
: GMAC-AE. ." GMAC-AE (read-only) $" GMAC-AE @ hex. GMAC-AE 1b. ;
: GMAC-RRE. ." GMAC-RRE (read-only) $" GMAC-RRE @ hex. GMAC-RRE 1b. ;
: GMAC-ROE. ." GMAC-ROE (read-only) $" GMAC-ROE @ hex. GMAC-ROE 1b. ;
: GMAC-IHCE. ." GMAC-IHCE (read-only) $" GMAC-IHCE @ hex. GMAC-IHCE 1b. ;
: GMAC-TCE. ." GMAC-TCE (read-only) $" GMAC-TCE @ hex. GMAC-TCE 1b. ;
: GMAC-UCE. ." GMAC-UCE (read-only) $" GMAC-UCE @ hex. GMAC-UCE 1b. ;
: GMAC-TISUBN. ." GMAC-TISUBN () $" GMAC-TISUBN @ hex. GMAC-TISUBN 1b. ;
: GMAC-TSH. ." GMAC-TSH () $" GMAC-TSH @ hex. GMAC-TSH 1b. ;
: GMAC-TSL. ." GMAC-TSL () $" GMAC-TSL @ hex. GMAC-TSL 1b. ;
: GMAC-TN. ." GMAC-TN () $" GMAC-TN @ hex. GMAC-TN 1b. ;
: GMAC-TA. ." GMAC-TA (write-only) $" GMAC-TA @ hex. GMAC-TA 1b. ;
: GMAC-TI. ." GMAC-TI () $" GMAC-TI @ hex. GMAC-TI 1b. ;
: GMAC-EFTSL. ." GMAC-EFTSL (read-only) $" GMAC-EFTSL @ hex. GMAC-EFTSL 1b. ;
: GMAC-EFTN. ." GMAC-EFTN (read-only) $" GMAC-EFTN @ hex. GMAC-EFTN 1b. ;
: GMAC-EFRSL. ." GMAC-EFRSL (read-only) $" GMAC-EFRSL @ hex. GMAC-EFRSL 1b. ;
: GMAC-EFRN. ." GMAC-EFRN (read-only) $" GMAC-EFRN @ hex. GMAC-EFRN 1b. ;
: GMAC-PEFTSL. ." GMAC-PEFTSL (read-only) $" GMAC-PEFTSL @ hex. GMAC-PEFTSL 1b. ;
: GMAC-PEFTN. ." GMAC-PEFTN (read-only) $" GMAC-PEFTN @ hex. GMAC-PEFTN 1b. ;
: GMAC-PEFRSL. ." GMAC-PEFRSL (read-only) $" GMAC-PEFRSL @ hex. GMAC-PEFRSL 1b. ;
: GMAC-PEFRN. ." GMAC-PEFRN (read-only) $" GMAC-PEFRN @ hex. GMAC-PEFRN 1b. ;
: GMAC-ISRPQ[%s]. ." GMAC-ISRPQ[%s] (read-only) $" GMAC-ISRPQ[%s] @ hex. GMAC-ISRPQ[%s] 1b. ;
: GMAC-TBQBAPQ[%s]. ." GMAC-TBQBAPQ[%s] () $" GMAC-TBQBAPQ[%s] @ hex. GMAC-TBQBAPQ[%s] 1b. ;
: GMAC-RBQBAPQ[%s]. ." GMAC-RBQBAPQ[%s] () $" GMAC-RBQBAPQ[%s] @ hex. GMAC-RBQBAPQ[%s] 1b. ;
: GMAC-RBSRPQ[%s]. ." GMAC-RBSRPQ[%s] () $" GMAC-RBSRPQ[%s] @ hex. GMAC-RBSRPQ[%s] 1b. ;
: GMAC-CBSCR. ." GMAC-CBSCR () $" GMAC-CBSCR @ hex. GMAC-CBSCR 1b. ;
: GMAC-CBSISQA. ." GMAC-CBSISQA () $" GMAC-CBSISQA @ hex. GMAC-CBSISQA 1b. ;
: GMAC-CBSISQB. ." GMAC-CBSISQB () $" GMAC-CBSISQB @ hex. GMAC-CBSISQB 1b. ;
: GMAC-ST1RPQ[%s]. ." GMAC-ST1RPQ[%s] () $" GMAC-ST1RPQ[%s] @ hex. GMAC-ST1RPQ[%s] 1b. ;
: GMAC-ST2RPQ[%s]. ." GMAC-ST2RPQ[%s] () $" GMAC-ST2RPQ[%s] @ hex. GMAC-ST2RPQ[%s] 1b. ;
: GMAC-IERPQ[%s]. ." GMAC-IERPQ[%s] (write-only) $" GMAC-IERPQ[%s] @ hex. GMAC-IERPQ[%s] 1b. ;
: GMAC-IDRPQ[%s]. ." GMAC-IDRPQ[%s] (write-only) $" GMAC-IDRPQ[%s] @ hex. GMAC-IDRPQ[%s] 1b. ;
: GMAC-IMRPQ[%s]. ." GMAC-IMRPQ[%s] () $" GMAC-IMRPQ[%s] @ hex. GMAC-IMRPQ[%s] 1b. ;
: GMAC-ST2ER[%s]. ." GMAC-ST2ER[%s] () $" GMAC-ST2ER[%s] @ hex. GMAC-ST2ER[%s] 1b. ;
: GMAC-ST2CW00. ." GMAC-ST2CW00 () $" GMAC-ST2CW00 @ hex. GMAC-ST2CW00 1b. ;
: GMAC-ST2CW10. ." GMAC-ST2CW10 () $" GMAC-ST2CW10 @ hex. GMAC-ST2CW10 1b. ;
: GMAC-ST2CW01. ." GMAC-ST2CW01 () $" GMAC-ST2CW01 @ hex. GMAC-ST2CW01 1b. ;
: GMAC-ST2CW11. ." GMAC-ST2CW11 () $" GMAC-ST2CW11 @ hex. GMAC-ST2CW11 1b. ;
: GMAC-ST2CW02. ." GMAC-ST2CW02 () $" GMAC-ST2CW02 @ hex. GMAC-ST2CW02 1b. ;
: GMAC-ST2CW12. ." GMAC-ST2CW12 () $" GMAC-ST2CW12 @ hex. GMAC-ST2CW12 1b. ;
: GMAC-ST2CW03. ." GMAC-ST2CW03 () $" GMAC-ST2CW03 @ hex. GMAC-ST2CW03 1b. ;
: GMAC-ST2CW13. ." GMAC-ST2CW13 () $" GMAC-ST2CW13 @ hex. GMAC-ST2CW13 1b. ;
: GMAC-ST2CW04. ." GMAC-ST2CW04 () $" GMAC-ST2CW04 @ hex. GMAC-ST2CW04 1b. ;
: GMAC-ST2CW14. ." GMAC-ST2CW14 () $" GMAC-ST2CW14 @ hex. GMAC-ST2CW14 1b. ;
: GMAC-ST2CW05. ." GMAC-ST2CW05 () $" GMAC-ST2CW05 @ hex. GMAC-ST2CW05 1b. ;
: GMAC-ST2CW15. ." GMAC-ST2CW15 () $" GMAC-ST2CW15 @ hex. GMAC-ST2CW15 1b. ;
: GMAC-ST2CW06. ." GMAC-ST2CW06 () $" GMAC-ST2CW06 @ hex. GMAC-ST2CW06 1b. ;
: GMAC-ST2CW16. ." GMAC-ST2CW16 () $" GMAC-ST2CW16 @ hex. GMAC-ST2CW16 1b. ;
: GMAC-ST2CW07. ." GMAC-ST2CW07 () $" GMAC-ST2CW07 @ hex. GMAC-ST2CW07 1b. ;
: GMAC-ST2CW17. ." GMAC-ST2CW17 () $" GMAC-ST2CW17 @ hex. GMAC-ST2CW17 1b. ;
: GMAC-ST2CW08. ." GMAC-ST2CW08 () $" GMAC-ST2CW08 @ hex. GMAC-ST2CW08 1b. ;
: GMAC-ST2CW18. ." GMAC-ST2CW18 () $" GMAC-ST2CW18 @ hex. GMAC-ST2CW18 1b. ;
: GMAC-ST2CW09. ." GMAC-ST2CW09 () $" GMAC-ST2CW09 @ hex. GMAC-ST2CW09 1b. ;
: GMAC-ST2CW19. ." GMAC-ST2CW19 () $" GMAC-ST2CW19 @ hex. GMAC-ST2CW19 1b. ;
: GMAC-ST2CW010. ." GMAC-ST2CW010 () $" GMAC-ST2CW010 @ hex. GMAC-ST2CW010 1b. ;
: GMAC-ST2CW110. ." GMAC-ST2CW110 () $" GMAC-ST2CW110 @ hex. GMAC-ST2CW110 1b. ;
: GMAC-ST2CW011. ." GMAC-ST2CW011 () $" GMAC-ST2CW011 @ hex. GMAC-ST2CW011 1b. ;
: GMAC-ST2CW111. ." GMAC-ST2CW111 () $" GMAC-ST2CW111 @ hex. GMAC-ST2CW111 1b. ;
: GMAC-ST2CW012. ." GMAC-ST2CW012 () $" GMAC-ST2CW012 @ hex. GMAC-ST2CW012 1b. ;
: GMAC-ST2CW112. ." GMAC-ST2CW112 () $" GMAC-ST2CW112 @ hex. GMAC-ST2CW112 1b. ;
: GMAC-ST2CW013. ." GMAC-ST2CW013 () $" GMAC-ST2CW013 @ hex. GMAC-ST2CW013 1b. ;
: GMAC-ST2CW113. ." GMAC-ST2CW113 () $" GMAC-ST2CW113 @ hex. GMAC-ST2CW113 1b. ;
: GMAC-ST2CW014. ." GMAC-ST2CW014 () $" GMAC-ST2CW014 @ hex. GMAC-ST2CW014 1b. ;
: GMAC-ST2CW114. ." GMAC-ST2CW114 () $" GMAC-ST2CW114 @ hex. GMAC-ST2CW114 1b. ;
: GMAC-ST2CW015. ." GMAC-ST2CW015 () $" GMAC-ST2CW015 @ hex. GMAC-ST2CW015 1b. ;
: GMAC-ST2CW115. ." GMAC-ST2CW115 () $" GMAC-ST2CW115 @ hex. GMAC-ST2CW115 1b. ;
: GMAC-ST2CW016. ." GMAC-ST2CW016 () $" GMAC-ST2CW016 @ hex. GMAC-ST2CW016 1b. ;
: GMAC-ST2CW116. ." GMAC-ST2CW116 () $" GMAC-ST2CW116 @ hex. GMAC-ST2CW116 1b. ;
: GMAC-ST2CW017. ." GMAC-ST2CW017 () $" GMAC-ST2CW017 @ hex. GMAC-ST2CW017 1b. ;
: GMAC-ST2CW117. ." GMAC-ST2CW117 () $" GMAC-ST2CW117 @ hex. GMAC-ST2CW117 1b. ;
: GMAC-ST2CW018. ." GMAC-ST2CW018 () $" GMAC-ST2CW018 @ hex. GMAC-ST2CW018 1b. ;
: GMAC-ST2CW118. ." GMAC-ST2CW118 () $" GMAC-ST2CW118 @ hex. GMAC-ST2CW118 1b. ;
: GMAC-ST2CW019. ." GMAC-ST2CW019 () $" GMAC-ST2CW019 @ hex. GMAC-ST2CW019 1b. ;
: GMAC-ST2CW119. ." GMAC-ST2CW119 () $" GMAC-ST2CW119 @ hex. GMAC-ST2CW119 1b. ;
: GMAC-ST2CW020. ." GMAC-ST2CW020 () $" GMAC-ST2CW020 @ hex. GMAC-ST2CW020 1b. ;
: GMAC-ST2CW120. ." GMAC-ST2CW120 () $" GMAC-ST2CW120 @ hex. GMAC-ST2CW120 1b. ;
: GMAC-ST2CW021. ." GMAC-ST2CW021 () $" GMAC-ST2CW021 @ hex. GMAC-ST2CW021 1b. ;
: GMAC-ST2CW121. ." GMAC-ST2CW121 () $" GMAC-ST2CW121 @ hex. GMAC-ST2CW121 1b. ;
: GMAC-ST2CW022. ." GMAC-ST2CW022 () $" GMAC-ST2CW022 @ hex. GMAC-ST2CW022 1b. ;
: GMAC-ST2CW122. ." GMAC-ST2CW122 () $" GMAC-ST2CW122 @ hex. GMAC-ST2CW122 1b. ;
: GMAC-ST2CW023. ." GMAC-ST2CW023 () $" GMAC-ST2CW023 @ hex. GMAC-ST2CW023 1b. ;
: GMAC-ST2CW123. ." GMAC-ST2CW123 () $" GMAC-ST2CW123 @ hex. GMAC-ST2CW123 1b. ;
: GMAC.
GMAC-NCR.
GMAC-NCFGR.
GMAC-NSR.
GMAC-UR.
GMAC-DCFGR.
GMAC-TSR.
GMAC-RBQB.
GMAC-TBQB.
GMAC-RSR.
GMAC-ISR.
GMAC-IER.
GMAC-IDR.
GMAC-IMR.
GMAC-MAN.
GMAC-RPQ.
GMAC-TPQ.
GMAC-TPSF.
GMAC-RPSF.
GMAC-RJFML.
GMAC-HRB.
GMAC-HRT.
GMAC-TIDM1.
GMAC-TIDM2.
GMAC-TIDM3.
GMAC-TIDM4.
GMAC-WOL.
GMAC-IPGS.
GMAC-SVLAN.
GMAC-TPFCP.
GMAC-SAMB1.
GMAC-SAMT1.
GMAC-NSC.
GMAC-SCL.
GMAC-SCH.
GMAC-EFTSH.
GMAC-EFRSH.
GMAC-PEFTSH.
GMAC-PEFRSH.
GMAC-OTLO.
GMAC-OTHI.
GMAC-FT.
GMAC-BCFT.
GMAC-MFT.
GMAC-PFT.
GMAC-BFT64.
GMAC-TBFT127.
GMAC-TBFT255.
GMAC-TBFT511.
GMAC-TBFT1023.
GMAC-TBFT1518.
GMAC-GTBFT1518.
GMAC-TUR.
GMAC-SCF.
GMAC-MCF.
GMAC-EC.
GMAC-LC.
GMAC-DTF.
GMAC-CSE.
GMAC-ORLO.
GMAC-ORHI.
GMAC-FR.
GMAC-BCFR.
GMAC-MFR.
GMAC-PFR.
GMAC-BFR64.
GMAC-TBFR127.
GMAC-TBFR255.
GMAC-TBFR511.
GMAC-TBFR1023.
GMAC-TBFR1518.
GMAC-TMXBFR.
GMAC-UFR.
GMAC-OFR.
GMAC-JR.
GMAC-FCSE.
GMAC-LFFE.
GMAC-RSE.
GMAC-AE.
GMAC-RRE.
GMAC-ROE.
GMAC-IHCE.
GMAC-TCE.
GMAC-UCE.
GMAC-TISUBN.
GMAC-TSH.
GMAC-TSL.
GMAC-TN.
GMAC-TA.
GMAC-TI.
GMAC-EFTSL.
GMAC-EFTN.
GMAC-EFRSL.
GMAC-EFRN.
GMAC-PEFTSL.
GMAC-PEFTN.
GMAC-PEFRSL.
GMAC-PEFRN.
GMAC-ISRPQ[%s].
GMAC-TBQBAPQ[%s].
GMAC-RBQBAPQ[%s].
GMAC-RBSRPQ[%s].
GMAC-CBSCR.
GMAC-CBSISQA.
GMAC-CBSISQB.
GMAC-ST1RPQ[%s].
GMAC-ST2RPQ[%s].
GMAC-IERPQ[%s].
GMAC-IDRPQ[%s].
GMAC-IMRPQ[%s].
GMAC-ST2ER[%s].
GMAC-ST2CW00.
GMAC-ST2CW10.
GMAC-ST2CW01.
GMAC-ST2CW11.
GMAC-ST2CW02.
GMAC-ST2CW12.
GMAC-ST2CW03.
GMAC-ST2CW13.
GMAC-ST2CW04.
GMAC-ST2CW14.
GMAC-ST2CW05.
GMAC-ST2CW15.
GMAC-ST2CW06.
GMAC-ST2CW16.
GMAC-ST2CW07.
GMAC-ST2CW17.
GMAC-ST2CW08.
GMAC-ST2CW18.
GMAC-ST2CW09.
GMAC-ST2CW19.
GMAC-ST2CW010.
GMAC-ST2CW110.
GMAC-ST2CW011.
GMAC-ST2CW111.
GMAC-ST2CW012.
GMAC-ST2CW112.
GMAC-ST2CW013.
GMAC-ST2CW113.
GMAC-ST2CW014.
GMAC-ST2CW114.
GMAC-ST2CW015.
GMAC-ST2CW115.
GMAC-ST2CW016.
GMAC-ST2CW116.
GMAC-ST2CW017.
GMAC-ST2CW117.
GMAC-ST2CW018.
GMAC-ST2CW118.
GMAC-ST2CW019.
GMAC-ST2CW119.
GMAC-ST2CW020.
GMAC-ST2CW120.
GMAC-ST2CW021.
GMAC-ST2CW121.
GMAC-ST2CW022.
GMAC-ST2CW122.
GMAC-ST2CW023.
GMAC-ST2CW123.
;

$400E1890 constant GPBR ( General Purpose Backup Registers )
GPBR $0 + constant GPBR-SYS_GPBR[%s] ( General Purpose Backup Register 0 )
: GPBR-SYS_GPBR[%s]. ." GPBR-SYS_GPBR[%s] () $" GPBR-SYS_GPBR[%s] @ hex. GPBR-SYS_GPBR[%s] 1b. ;
: GPBR.
GPBR-SYS_GPBR[%s].
;

$40000000 constant HSMCI ( High Speed MultiMedia Card Interface )
HSMCI $00 + constant HSMCI-CR ( Control Register )
HSMCI $04 + constant HSMCI-MR ( Mode Register )
HSMCI $08 + constant HSMCI-DTOR ( Data Timeout Register )
HSMCI $0C + constant HSMCI-SDCR ( SD/SDIO Card Register )
HSMCI $10 + constant HSMCI-ARGR ( Argument Register )
HSMCI $14 + constant HSMCI-CMDR ( Command Register )
HSMCI $18 + constant HSMCI-BLKR ( Block Register )
HSMCI $1C + constant HSMCI-CSTOR ( Completion Signal Timeout Register )
HSMCI $20 + constant HSMCI-RSPR[%s] ( Response Register 0 )
HSMCI $30 + constant HSMCI-RDR ( Receive Data Register )
HSMCI $34 + constant HSMCI-TDR ( Transmit Data Register )
HSMCI $40 + constant HSMCI-SR ( Status Register )
HSMCI $44 + constant HSMCI-IER ( Interrupt Enable Register )
HSMCI $48 + constant HSMCI-IDR ( Interrupt Disable Register )
HSMCI $4C + constant HSMCI-IMR ( Interrupt Mask Register )
HSMCI $50 + constant HSMCI-DMA ( DMA Configuration Register )
HSMCI $54 + constant HSMCI-CFG ( Configuration Register )
HSMCI $E4 + constant HSMCI-WPMR ( Write Protection Mode Register )
HSMCI $E8 + constant HSMCI-WPSR ( Write Protection Status Register )
HSMCI $200 + constant HSMCI-FIFO[%s] ( FIFO Memory Aperture0 0 )
: HSMCI-CR. ." HSMCI-CR (write-only) $" HSMCI-CR @ hex. HSMCI-CR 1b. ;
: HSMCI-MR. ." HSMCI-MR () $" HSMCI-MR @ hex. HSMCI-MR 1b. ;
: HSMCI-DTOR. ." HSMCI-DTOR () $" HSMCI-DTOR @ hex. HSMCI-DTOR 1b. ;
: HSMCI-SDCR. ." HSMCI-SDCR () $" HSMCI-SDCR @ hex. HSMCI-SDCR 1b. ;
: HSMCI-ARGR. ." HSMCI-ARGR () $" HSMCI-ARGR @ hex. HSMCI-ARGR 1b. ;
: HSMCI-CMDR. ." HSMCI-CMDR (write-only) $" HSMCI-CMDR @ hex. HSMCI-CMDR 1b. ;
: HSMCI-BLKR. ." HSMCI-BLKR () $" HSMCI-BLKR @ hex. HSMCI-BLKR 1b. ;
: HSMCI-CSTOR. ." HSMCI-CSTOR () $" HSMCI-CSTOR @ hex. HSMCI-CSTOR 1b. ;
: HSMCI-RSPR[%s]. ." HSMCI-RSPR[%s] (read-only) $" HSMCI-RSPR[%s] @ hex. HSMCI-RSPR[%s] 1b. ;
: HSMCI-RDR. ." HSMCI-RDR (read-only) $" HSMCI-RDR @ hex. HSMCI-RDR 1b. ;
: HSMCI-TDR. ." HSMCI-TDR (write-only) $" HSMCI-TDR @ hex. HSMCI-TDR 1b. ;
: HSMCI-SR. ." HSMCI-SR (read-only) $" HSMCI-SR @ hex. HSMCI-SR 1b. ;
: HSMCI-IER. ." HSMCI-IER (write-only) $" HSMCI-IER @ hex. HSMCI-IER 1b. ;
: HSMCI-IDR. ." HSMCI-IDR (write-only) $" HSMCI-IDR @ hex. HSMCI-IDR 1b. ;
: HSMCI-IMR. ." HSMCI-IMR (read-only) $" HSMCI-IMR @ hex. HSMCI-IMR 1b. ;
: HSMCI-DMA. ." HSMCI-DMA () $" HSMCI-DMA @ hex. HSMCI-DMA 1b. ;
: HSMCI-CFG. ." HSMCI-CFG () $" HSMCI-CFG @ hex. HSMCI-CFG 1b. ;
: HSMCI-WPMR. ." HSMCI-WPMR () $" HSMCI-WPMR @ hex. HSMCI-WPMR 1b. ;
: HSMCI-WPSR. ." HSMCI-WPSR (read-only) $" HSMCI-WPSR @ hex. HSMCI-WPSR 1b. ;
: HSMCI-FIFO[%s]. ." HSMCI-FIFO[%s] () $" HSMCI-FIFO[%s] @ hex. HSMCI-FIFO[%s] 1b. ;
: HSMCI.
HSMCI-CR.
HSMCI-MR.
HSMCI-DTOR.
HSMCI-SDCR.
HSMCI-ARGR.
HSMCI-CMDR.
HSMCI-BLKR.
HSMCI-CSTOR.
HSMCI-RSPR[%s].
HSMCI-RDR.
HSMCI-TDR.
HSMCI-SR.
HSMCI-IER.
HSMCI-IDR.
HSMCI-IMR.
HSMCI-DMA.
HSMCI-CFG.
HSMCI-WPMR.
HSMCI-WPSR.
HSMCI-FIFO[%s].
;

$40048000 constant ICM ( Integrity Check Monitor )
ICM $00 + constant ICM-CFG ( Configuration Register )
ICM $04 + constant ICM-CTRL ( Control Register )
ICM $08 + constant ICM-SR ( Status Register )
ICM $10 + constant ICM-IER ( Interrupt Enable Register )
ICM $14 + constant ICM-IDR ( Interrupt Disable Register )
ICM $18 + constant ICM-IMR ( Interrupt Mask Register )
ICM $1C + constant ICM-ISR ( Interrupt Status Register )
ICM $20 + constant ICM-UASR ( Undefined Access Status Register )
ICM $30 + constant ICM-DSCR ( Region Descriptor Area Start Address Register )
ICM $34 + constant ICM-HASH ( Region Hash Area Start Address Register )
ICM $38 + constant ICM-UIHVAL[%s] ( User Initial Hash Value 0 Register 0 )
: ICM-CFG. ." ICM-CFG () $" ICM-CFG @ hex. ICM-CFG 1b. ;
: ICM-CTRL. ." ICM-CTRL (write-only) $" ICM-CTRL @ hex. ICM-CTRL 1b. ;
: ICM-SR. ." ICM-SR (read-only) $" ICM-SR @ hex. ICM-SR 1b. ;
: ICM-IER. ." ICM-IER (write-only) $" ICM-IER @ hex. ICM-IER 1b. ;
: ICM-IDR. ." ICM-IDR (write-only) $" ICM-IDR @ hex. ICM-IDR 1b. ;
: ICM-IMR. ." ICM-IMR (read-only) $" ICM-IMR @ hex. ICM-IMR 1b. ;
: ICM-ISR. ." ICM-ISR (read-only) $" ICM-ISR @ hex. ICM-ISR 1b. ;
: ICM-UASR. ." ICM-UASR (read-only) $" ICM-UASR @ hex. ICM-UASR 1b. ;
: ICM-DSCR. ." ICM-DSCR () $" ICM-DSCR @ hex. ICM-DSCR 1b. ;
: ICM-HASH. ." ICM-HASH () $" ICM-HASH @ hex. ICM-HASH 1b. ;
: ICM-UIHVAL[%s]. ." ICM-UIHVAL[%s] (write-only) $" ICM-UIHVAL[%s] @ hex. ICM-UIHVAL[%s] 1b. ;
: ICM.
ICM-CFG.
ICM-CTRL.
ICM-SR.
ICM-IER.
ICM-IDR.
ICM-IMR.
ICM-ISR.
ICM-UASR.
ICM-DSCR.
ICM-HASH.
ICM-UIHVAL[%s].
;

$4004C000 constant ISI ( Image Sensor Interface )
ISI $00 + constant ISI-CFG1 ( ISI Configuration 1 Register )
ISI $04 + constant ISI-CFG2 ( ISI Configuration 2 Register )
ISI $08 + constant ISI-PSIZE ( ISI Preview Size Register )
ISI $0C + constant ISI-PDECF ( ISI Preview Decimation Factor Register )
ISI $10 + constant ISI-Y2R_SET0 ( ISI Color Space Conversion YCrCb To RGB Set 0 Register )
ISI $14 + constant ISI-Y2R_SET1 ( ISI Color Space Conversion YCrCb To RGB Set 1 Register )
ISI $18 + constant ISI-R2Y_SET0 ( ISI Color Space Conversion RGB To YCrCb Set 0 Register )
ISI $1C + constant ISI-R2Y_SET1 ( ISI Color Space Conversion RGB To YCrCb Set 1 Register )
ISI $20 + constant ISI-R2Y_SET2 ( ISI Color Space Conversion RGB To YCrCb Set 2 Register )
ISI $24 + constant ISI-CR ( ISI Control Register )
ISI $28 + constant ISI-SR ( ISI Status Register )
ISI $2C + constant ISI-IER ( ISI Interrupt Enable Register )
ISI $30 + constant ISI-IDR ( ISI Interrupt Disable Register )
ISI $34 + constant ISI-IMR ( ISI Interrupt Mask Register )
ISI $38 + constant ISI-DMA_CHER ( DMA Channel Enable Register )
ISI $3C + constant ISI-DMA_CHDR ( DMA Channel Disable Register )
ISI $40 + constant ISI-DMA_CHSR ( DMA Channel Status Register )
ISI $44 + constant ISI-DMA_P_ADDR ( DMA Preview Base Address Register )
ISI $48 + constant ISI-DMA_P_CTRL ( DMA Preview Control Register )
ISI $4C + constant ISI-DMA_P_DSCR ( DMA Preview Descriptor Address Register )
ISI $50 + constant ISI-DMA_C_ADDR ( DMA Codec Base Address Register )
ISI $54 + constant ISI-DMA_C_CTRL ( DMA Codec Control Register )
ISI $58 + constant ISI-DMA_C_DSCR ( DMA Codec Descriptor Address Register )
ISI $E4 + constant ISI-WPMR ( Write Protection Mode Register )
ISI $E8 + constant ISI-WPSR ( Write Protection Status Register )
: ISI-CFG1. ." ISI-CFG1 () $" ISI-CFG1 @ hex. ISI-CFG1 1b. ;
: ISI-CFG2. ." ISI-CFG2 () $" ISI-CFG2 @ hex. ISI-CFG2 1b. ;
: ISI-PSIZE. ." ISI-PSIZE () $" ISI-PSIZE @ hex. ISI-PSIZE 1b. ;
: ISI-PDECF. ." ISI-PDECF () $" ISI-PDECF @ hex. ISI-PDECF 1b. ;
: ISI-Y2R_SET0. ." ISI-Y2R_SET0 () $" ISI-Y2R_SET0 @ hex. ISI-Y2R_SET0 1b. ;
: ISI-Y2R_SET1. ." ISI-Y2R_SET1 () $" ISI-Y2R_SET1 @ hex. ISI-Y2R_SET1 1b. ;
: ISI-R2Y_SET0. ." ISI-R2Y_SET0 () $" ISI-R2Y_SET0 @ hex. ISI-R2Y_SET0 1b. ;
: ISI-R2Y_SET1. ." ISI-R2Y_SET1 () $" ISI-R2Y_SET1 @ hex. ISI-R2Y_SET1 1b. ;
: ISI-R2Y_SET2. ." ISI-R2Y_SET2 () $" ISI-R2Y_SET2 @ hex. ISI-R2Y_SET2 1b. ;
: ISI-CR. ." ISI-CR (write-only) $" ISI-CR @ hex. ISI-CR 1b. ;
: ISI-SR. ." ISI-SR (read-only) $" ISI-SR @ hex. ISI-SR 1b. ;
: ISI-IER. ." ISI-IER (write-only) $" ISI-IER @ hex. ISI-IER 1b. ;
: ISI-IDR. ." ISI-IDR (write-only) $" ISI-IDR @ hex. ISI-IDR 1b. ;
: ISI-IMR. ." ISI-IMR (read-only) $" ISI-IMR @ hex. ISI-IMR 1b. ;
: ISI-DMA_CHER. ." ISI-DMA_CHER (write-only) $" ISI-DMA_CHER @ hex. ISI-DMA_CHER 1b. ;
: ISI-DMA_CHDR. ." ISI-DMA_CHDR (write-only) $" ISI-DMA_CHDR @ hex. ISI-DMA_CHDR 1b. ;
: ISI-DMA_CHSR. ." ISI-DMA_CHSR (read-only) $" ISI-DMA_CHSR @ hex. ISI-DMA_CHSR 1b. ;
: ISI-DMA_P_ADDR. ." ISI-DMA_P_ADDR () $" ISI-DMA_P_ADDR @ hex. ISI-DMA_P_ADDR 1b. ;
: ISI-DMA_P_CTRL. ." ISI-DMA_P_CTRL () $" ISI-DMA_P_CTRL @ hex. ISI-DMA_P_CTRL 1b. ;
: ISI-DMA_P_DSCR. ." ISI-DMA_P_DSCR () $" ISI-DMA_P_DSCR @ hex. ISI-DMA_P_DSCR 1b. ;
: ISI-DMA_C_ADDR. ." ISI-DMA_C_ADDR () $" ISI-DMA_C_ADDR @ hex. ISI-DMA_C_ADDR 1b. ;
: ISI-DMA_C_CTRL. ." ISI-DMA_C_CTRL () $" ISI-DMA_C_CTRL @ hex. ISI-DMA_C_CTRL 1b. ;
: ISI-DMA_C_DSCR. ." ISI-DMA_C_DSCR () $" ISI-DMA_C_DSCR @ hex. ISI-DMA_C_DSCR 1b. ;
: ISI-WPMR. ." ISI-WPMR () $" ISI-WPMR @ hex. ISI-WPMR 1b. ;
: ISI-WPSR. ." ISI-WPSR (read-only) $" ISI-WPSR @ hex. ISI-WPSR 1b. ;
: ISI.
ISI-CFG1.
ISI-CFG2.
ISI-PSIZE.
ISI-PDECF.
ISI-Y2R_SET0.
ISI-Y2R_SET1.
ISI-R2Y_SET0.
ISI-R2Y_SET1.
ISI-R2Y_SET2.
ISI-CR.
ISI-SR.
ISI-IER.
ISI-IDR.
ISI-IMR.
ISI-DMA_CHER.
ISI-DMA_CHDR.
ISI-DMA_CHSR.
ISI-DMA_P_ADDR.
ISI-DMA_P_CTRL.
ISI-DMA_P_DSCR.
ISI-DMA_C_ADDR.
ISI-DMA_C_CTRL.
ISI-DMA_C_DSCR.
ISI-WPMR.
ISI-WPSR.
;

$40088000 constant MATRIX ( AHB Bus Matrix )
MATRIX $0 + constant MATRIX-MCFG[%s] ( Master Configuration Register 0 )
MATRIX $40 + constant MATRIX-SCFG[%s] ( Slave Configuration Register 0 )
MATRIX $0100 + constant MATRIX-MRCR ( Master Remap Control Register )
MATRIX $0110 + constant MATRIX-CCFG_CAN0 ( CAN0 Configuration Register )
MATRIX $0114 + constant MATRIX-CCFG_SYSIO ( System I/O and CAN1 Configuration Register )
MATRIX $0124 + constant MATRIX-CCFG_SMCNFCS ( SMC NAND Flash Chip Select Configuration Register )
MATRIX $01E4 + constant MATRIX-WPMR ( Write Protection Mode Register )
MATRIX $01E8 + constant MATRIX-WPSR ( Write Protection Status Register )
: MATRIX-MCFG[%s]. ." MATRIX-MCFG[%s] () $" MATRIX-MCFG[%s] @ hex. MATRIX-MCFG[%s] 1b. ;
: MATRIX-SCFG[%s]. ." MATRIX-SCFG[%s] () $" MATRIX-SCFG[%s] @ hex. MATRIX-SCFG[%s] 1b. ;
: MATRIX-MRCR. ." MATRIX-MRCR () $" MATRIX-MRCR @ hex. MATRIX-MRCR 1b. ;
: MATRIX-CCFG_CAN0. ." MATRIX-CCFG_CAN0 () $" MATRIX-CCFG_CAN0 @ hex. MATRIX-CCFG_CAN0 1b. ;
: MATRIX-CCFG_SYSIO. ." MATRIX-CCFG_SYSIO () $" MATRIX-CCFG_SYSIO @ hex. MATRIX-CCFG_SYSIO 1b. ;
: MATRIX-CCFG_SMCNFCS. ." MATRIX-CCFG_SMCNFCS () $" MATRIX-CCFG_SMCNFCS @ hex. MATRIX-CCFG_SMCNFCS 1b. ;
: MATRIX-WPMR. ." MATRIX-WPMR () $" MATRIX-WPMR @ hex. MATRIX-WPMR 1b. ;
: MATRIX-WPSR. ." MATRIX-WPSR (read-only) $" MATRIX-WPSR @ hex. MATRIX-WPSR 1b. ;
: MATRIX.
MATRIX-MCFG[%s].
MATRIX-SCFG[%s].
MATRIX-MRCR.
MATRIX-CCFG_CAN0.
MATRIX-CCFG_SYSIO.
MATRIX-CCFG_SMCNFCS.
MATRIX-WPMR.
MATRIX-WPSR.
;

$40030000 constant MCAN0 ( Controller Area Network )
MCAN0 $08 + constant MCAN0-CUST ( Customer Register )
MCAN0 $0C + constant MCAN0-FBTP ( Fast Bit Timing and Prescaler Register )
MCAN0 $10 + constant MCAN0-TEST ( Test Register )
MCAN0 $14 + constant MCAN0-RWD ( RAM Watchdog Register )
MCAN0 $18 + constant MCAN0-CCCR ( CC Control Register )
MCAN0 $1C + constant MCAN0-BTP ( Bit Timing and Prescaler Register )
MCAN0 $20 + constant MCAN0-TSCC ( Timestamp Counter Configuration Register )
MCAN0 $24 + constant MCAN0-TSCV ( Timestamp Counter Value Register )
MCAN0 $28 + constant MCAN0-TOCC ( Timeout Counter Configuration Register )
MCAN0 $2C + constant MCAN0-TOCV ( Timeout Counter Value Register )
MCAN0 $40 + constant MCAN0-ECR ( Error Counter Register )
MCAN0 $44 + constant MCAN0-PSR ( Protocol Status Register )
MCAN0 $50 + constant MCAN0-IR ( Interrupt Register )
MCAN0 $54 + constant MCAN0-IE ( Interrupt Enable Register )
MCAN0 $58 + constant MCAN0-ILS ( Interrupt Line Select Register )
MCAN0 $5C + constant MCAN0-ILE ( Interrupt Line Enable Register )
MCAN0 $80 + constant MCAN0-GFC ( Global Filter Configuration Register )
MCAN0 $84 + constant MCAN0-SIDFC ( Standard ID Filter Configuration Register )
MCAN0 $88 + constant MCAN0-XIDFC ( Extended ID Filter Configuration Register )
MCAN0 $90 + constant MCAN0-XIDAM ( Extended ID AND Mask Register )
MCAN0 $94 + constant MCAN0-HPMS ( High Priority Message Status Register )
MCAN0 $98 + constant MCAN0-NDAT1 ( New Data 1 Register )
MCAN0 $9C + constant MCAN0-NDAT2 ( New Data 2 Register )
MCAN0 $A0 + constant MCAN0-RXF0C ( Receive FIFO 0 Configuration Register )
MCAN0 $A4 + constant MCAN0-RXF0S ( Receive FIFO 0 Status Register )
MCAN0 $A8 + constant MCAN0-RXF0A ( Receive FIFO 0 Acknowledge Register )
MCAN0 $AC + constant MCAN0-RXBC ( Receive Rx Buffer Configuration Register )
MCAN0 $B0 + constant MCAN0-RXF1C ( Receive FIFO 1 Configuration Register )
MCAN0 $B4 + constant MCAN0-RXF1S ( Receive FIFO 1 Status Register )
MCAN0 $B8 + constant MCAN0-RXF1A ( Receive FIFO 1 Acknowledge Register )
MCAN0 $BC + constant MCAN0-RXESC ( Receive Buffer / FIFO Element Size Configuration Register )
MCAN0 $C0 + constant MCAN0-TXBC ( Transmit Buffer Configuration Register )
MCAN0 $C4 + constant MCAN0-TXFQS ( Transmit FIFO/Queue Status Register )
MCAN0 $C8 + constant MCAN0-TXESC ( Transmit Buffer Element Size Configuration Register )
MCAN0 $CC + constant MCAN0-TXBRP ( Transmit Buffer Request Pending Register )
MCAN0 $D0 + constant MCAN0-TXBAR ( Transmit Buffer Add Request Register )
MCAN0 $D4 + constant MCAN0-TXBCR ( Transmit Buffer Cancellation Request Register )
MCAN0 $D8 + constant MCAN0-TXBTO ( Transmit Buffer Transmission Occurred Register )
MCAN0 $DC + constant MCAN0-TXBCF ( Transmit Buffer Cancellation Finished Register )
MCAN0 $E0 + constant MCAN0-TXBTIE ( Transmit Buffer Transmission Interrupt Enable Register )
MCAN0 $E4 + constant MCAN0-TXBCIE ( Transmit Buffer Cancellation Finished Interrupt Enable Register )
MCAN0 $F0 + constant MCAN0-TXEFC ( Transmit Event FIFO Configuration Register )
MCAN0 $F4 + constant MCAN0-TXEFS ( Transmit Event FIFO Status Register )
MCAN0 $F8 + constant MCAN0-TXEFA ( Transmit Event FIFO Acknowledge Register )
: MCAN0-CUST. ." MCAN0-CUST () $" MCAN0-CUST @ hex. MCAN0-CUST 1b. ;
: MCAN0-FBTP. ." MCAN0-FBTP () $" MCAN0-FBTP @ hex. MCAN0-FBTP 1b. ;
: MCAN0-TEST. ." MCAN0-TEST () $" MCAN0-TEST @ hex. MCAN0-TEST 1b. ;
: MCAN0-RWD. ." MCAN0-RWD () $" MCAN0-RWD @ hex. MCAN0-RWD 1b. ;
: MCAN0-CCCR. ." MCAN0-CCCR () $" MCAN0-CCCR @ hex. MCAN0-CCCR 1b. ;
: MCAN0-BTP. ." MCAN0-BTP () $" MCAN0-BTP @ hex. MCAN0-BTP 1b. ;
: MCAN0-TSCC. ." MCAN0-TSCC () $" MCAN0-TSCC @ hex. MCAN0-TSCC 1b. ;
: MCAN0-TSCV. ." MCAN0-TSCV () $" MCAN0-TSCV @ hex. MCAN0-TSCV 1b. ;
: MCAN0-TOCC. ." MCAN0-TOCC () $" MCAN0-TOCC @ hex. MCAN0-TOCC 1b. ;
: MCAN0-TOCV. ." MCAN0-TOCV () $" MCAN0-TOCV @ hex. MCAN0-TOCV 1b. ;
: MCAN0-ECR. ." MCAN0-ECR (read-only) $" MCAN0-ECR @ hex. MCAN0-ECR 1b. ;
: MCAN0-PSR. ." MCAN0-PSR (read-only) $" MCAN0-PSR @ hex. MCAN0-PSR 1b. ;
: MCAN0-IR. ." MCAN0-IR () $" MCAN0-IR @ hex. MCAN0-IR 1b. ;
: MCAN0-IE. ." MCAN0-IE () $" MCAN0-IE @ hex. MCAN0-IE 1b. ;
: MCAN0-ILS. ." MCAN0-ILS () $" MCAN0-ILS @ hex. MCAN0-ILS 1b. ;
: MCAN0-ILE. ." MCAN0-ILE () $" MCAN0-ILE @ hex. MCAN0-ILE 1b. ;
: MCAN0-GFC. ." MCAN0-GFC () $" MCAN0-GFC @ hex. MCAN0-GFC 1b. ;
: MCAN0-SIDFC. ." MCAN0-SIDFC () $" MCAN0-SIDFC @ hex. MCAN0-SIDFC 1b. ;
: MCAN0-XIDFC. ." MCAN0-XIDFC () $" MCAN0-XIDFC @ hex. MCAN0-XIDFC 1b. ;
: MCAN0-XIDAM. ." MCAN0-XIDAM () $" MCAN0-XIDAM @ hex. MCAN0-XIDAM 1b. ;
: MCAN0-HPMS. ." MCAN0-HPMS (read-only) $" MCAN0-HPMS @ hex. MCAN0-HPMS 1b. ;
: MCAN0-NDAT1. ." MCAN0-NDAT1 () $" MCAN0-NDAT1 @ hex. MCAN0-NDAT1 1b. ;
: MCAN0-NDAT2. ." MCAN0-NDAT2 () $" MCAN0-NDAT2 @ hex. MCAN0-NDAT2 1b. ;
: MCAN0-RXF0C. ." MCAN0-RXF0C () $" MCAN0-RXF0C @ hex. MCAN0-RXF0C 1b. ;
: MCAN0-RXF0S. ." MCAN0-RXF0S (read-only) $" MCAN0-RXF0S @ hex. MCAN0-RXF0S 1b. ;
: MCAN0-RXF0A. ." MCAN0-RXF0A () $" MCAN0-RXF0A @ hex. MCAN0-RXF0A 1b. ;
: MCAN0-RXBC. ." MCAN0-RXBC () $" MCAN0-RXBC @ hex. MCAN0-RXBC 1b. ;
: MCAN0-RXF1C. ." MCAN0-RXF1C () $" MCAN0-RXF1C @ hex. MCAN0-RXF1C 1b. ;
: MCAN0-RXF1S. ." MCAN0-RXF1S (read-only) $" MCAN0-RXF1S @ hex. MCAN0-RXF1S 1b. ;
: MCAN0-RXF1A. ." MCAN0-RXF1A () $" MCAN0-RXF1A @ hex. MCAN0-RXF1A 1b. ;
: MCAN0-RXESC. ." MCAN0-RXESC () $" MCAN0-RXESC @ hex. MCAN0-RXESC 1b. ;
: MCAN0-TXBC. ." MCAN0-TXBC () $" MCAN0-TXBC @ hex. MCAN0-TXBC 1b. ;
: MCAN0-TXFQS. ." MCAN0-TXFQS (read-only) $" MCAN0-TXFQS @ hex. MCAN0-TXFQS 1b. ;
: MCAN0-TXESC. ." MCAN0-TXESC () $" MCAN0-TXESC @ hex. MCAN0-TXESC 1b. ;
: MCAN0-TXBRP. ." MCAN0-TXBRP (read-only) $" MCAN0-TXBRP @ hex. MCAN0-TXBRP 1b. ;
: MCAN0-TXBAR. ." MCAN0-TXBAR () $" MCAN0-TXBAR @ hex. MCAN0-TXBAR 1b. ;
: MCAN0-TXBCR. ." MCAN0-TXBCR () $" MCAN0-TXBCR @ hex. MCAN0-TXBCR 1b. ;
: MCAN0-TXBTO. ." MCAN0-TXBTO (read-only) $" MCAN0-TXBTO @ hex. MCAN0-TXBTO 1b. ;
: MCAN0-TXBCF. ." MCAN0-TXBCF (read-only) $" MCAN0-TXBCF @ hex. MCAN0-TXBCF 1b. ;
: MCAN0-TXBTIE. ." MCAN0-TXBTIE () $" MCAN0-TXBTIE @ hex. MCAN0-TXBTIE 1b. ;
: MCAN0-TXBCIE. ." MCAN0-TXBCIE () $" MCAN0-TXBCIE @ hex. MCAN0-TXBCIE 1b. ;
: MCAN0-TXEFC. ." MCAN0-TXEFC () $" MCAN0-TXEFC @ hex. MCAN0-TXEFC 1b. ;
: MCAN0-TXEFS. ." MCAN0-TXEFS (read-only) $" MCAN0-TXEFS @ hex. MCAN0-TXEFS 1b. ;
: MCAN0-TXEFA. ." MCAN0-TXEFA () $" MCAN0-TXEFA @ hex. MCAN0-TXEFA 1b. ;
: MCAN0.
MCAN0-CUST.
MCAN0-FBTP.
MCAN0-TEST.
MCAN0-RWD.
MCAN0-CCCR.
MCAN0-BTP.
MCAN0-TSCC.
MCAN0-TSCV.
MCAN0-TOCC.
MCAN0-TOCV.
MCAN0-ECR.
MCAN0-PSR.
MCAN0-IR.
MCAN0-IE.
MCAN0-ILS.
MCAN0-ILE.
MCAN0-GFC.
MCAN0-SIDFC.
MCAN0-XIDFC.
MCAN0-XIDAM.
MCAN0-HPMS.
MCAN0-NDAT1.
MCAN0-NDAT2.
MCAN0-RXF0C.
MCAN0-RXF0S.
MCAN0-RXF0A.
MCAN0-RXBC.
MCAN0-RXF1C.
MCAN0-RXF1S.
MCAN0-RXF1A.
MCAN0-RXESC.
MCAN0-TXBC.
MCAN0-TXFQS.
MCAN0-TXESC.
MCAN0-TXBRP.
MCAN0-TXBAR.
MCAN0-TXBCR.
MCAN0-TXBTO.
MCAN0-TXBCF.
MCAN0-TXBTIE.
MCAN0-TXBCIE.
MCAN0-TXEFC.
MCAN0-TXEFS.
MCAN0-TXEFA.
;

$40034000 constant MCAN1 ( Controller Area Network )
MCAN1 $08 + constant MCAN1-CUST ( Customer Register )
MCAN1 $0C + constant MCAN1-FBTP ( Fast Bit Timing and Prescaler Register )
MCAN1 $10 + constant MCAN1-TEST ( Test Register )
MCAN1 $14 + constant MCAN1-RWD ( RAM Watchdog Register )
MCAN1 $18 + constant MCAN1-CCCR ( CC Control Register )
MCAN1 $1C + constant MCAN1-BTP ( Bit Timing and Prescaler Register )
MCAN1 $20 + constant MCAN1-TSCC ( Timestamp Counter Configuration Register )
MCAN1 $24 + constant MCAN1-TSCV ( Timestamp Counter Value Register )
MCAN1 $28 + constant MCAN1-TOCC ( Timeout Counter Configuration Register )
MCAN1 $2C + constant MCAN1-TOCV ( Timeout Counter Value Register )
MCAN1 $40 + constant MCAN1-ECR ( Error Counter Register )
MCAN1 $44 + constant MCAN1-PSR ( Protocol Status Register )
MCAN1 $50 + constant MCAN1-IR ( Interrupt Register )
MCAN1 $54 + constant MCAN1-IE ( Interrupt Enable Register )
MCAN1 $58 + constant MCAN1-ILS ( Interrupt Line Select Register )
MCAN1 $5C + constant MCAN1-ILE ( Interrupt Line Enable Register )
MCAN1 $80 + constant MCAN1-GFC ( Global Filter Configuration Register )
MCAN1 $84 + constant MCAN1-SIDFC ( Standard ID Filter Configuration Register )
MCAN1 $88 + constant MCAN1-XIDFC ( Extended ID Filter Configuration Register )
MCAN1 $90 + constant MCAN1-XIDAM ( Extended ID AND Mask Register )
MCAN1 $94 + constant MCAN1-HPMS ( High Priority Message Status Register )
MCAN1 $98 + constant MCAN1-NDAT1 ( New Data 1 Register )
MCAN1 $9C + constant MCAN1-NDAT2 ( New Data 2 Register )
MCAN1 $A0 + constant MCAN1-RXF0C ( Receive FIFO 0 Configuration Register )
MCAN1 $A4 + constant MCAN1-RXF0S ( Receive FIFO 0 Status Register )
MCAN1 $A8 + constant MCAN1-RXF0A ( Receive FIFO 0 Acknowledge Register )
MCAN1 $AC + constant MCAN1-RXBC ( Receive Rx Buffer Configuration Register )
MCAN1 $B0 + constant MCAN1-RXF1C ( Receive FIFO 1 Configuration Register )
MCAN1 $B4 + constant MCAN1-RXF1S ( Receive FIFO 1 Status Register )
MCAN1 $B8 + constant MCAN1-RXF1A ( Receive FIFO 1 Acknowledge Register )
MCAN1 $BC + constant MCAN1-RXESC ( Receive Buffer / FIFO Element Size Configuration Register )
MCAN1 $C0 + constant MCAN1-TXBC ( Transmit Buffer Configuration Register )
MCAN1 $C4 + constant MCAN1-TXFQS ( Transmit FIFO/Queue Status Register )
MCAN1 $C8 + constant MCAN1-TXESC ( Transmit Buffer Element Size Configuration Register )
MCAN1 $CC + constant MCAN1-TXBRP ( Transmit Buffer Request Pending Register )
MCAN1 $D0 + constant MCAN1-TXBAR ( Transmit Buffer Add Request Register )
MCAN1 $D4 + constant MCAN1-TXBCR ( Transmit Buffer Cancellation Request Register )
MCAN1 $D8 + constant MCAN1-TXBTO ( Transmit Buffer Transmission Occurred Register )
MCAN1 $DC + constant MCAN1-TXBCF ( Transmit Buffer Cancellation Finished Register )
MCAN1 $E0 + constant MCAN1-TXBTIE ( Transmit Buffer Transmission Interrupt Enable Register )
MCAN1 $E4 + constant MCAN1-TXBCIE ( Transmit Buffer Cancellation Finished Interrupt Enable Register )
MCAN1 $F0 + constant MCAN1-TXEFC ( Transmit Event FIFO Configuration Register )
MCAN1 $F4 + constant MCAN1-TXEFS ( Transmit Event FIFO Status Register )
MCAN1 $F8 + constant MCAN1-TXEFA ( Transmit Event FIFO Acknowledge Register )
: MCAN1-CUST. ." MCAN1-CUST () $" MCAN1-CUST @ hex. MCAN1-CUST 1b. ;
: MCAN1-FBTP. ." MCAN1-FBTP () $" MCAN1-FBTP @ hex. MCAN1-FBTP 1b. ;
: MCAN1-TEST. ." MCAN1-TEST () $" MCAN1-TEST @ hex. MCAN1-TEST 1b. ;
: MCAN1-RWD. ." MCAN1-RWD () $" MCAN1-RWD @ hex. MCAN1-RWD 1b. ;
: MCAN1-CCCR. ." MCAN1-CCCR () $" MCAN1-CCCR @ hex. MCAN1-CCCR 1b. ;
: MCAN1-BTP. ." MCAN1-BTP () $" MCAN1-BTP @ hex. MCAN1-BTP 1b. ;
: MCAN1-TSCC. ." MCAN1-TSCC () $" MCAN1-TSCC @ hex. MCAN1-TSCC 1b. ;
: MCAN1-TSCV. ." MCAN1-TSCV () $" MCAN1-TSCV @ hex. MCAN1-TSCV 1b. ;
: MCAN1-TOCC. ." MCAN1-TOCC () $" MCAN1-TOCC @ hex. MCAN1-TOCC 1b. ;
: MCAN1-TOCV. ." MCAN1-TOCV () $" MCAN1-TOCV @ hex. MCAN1-TOCV 1b. ;
: MCAN1-ECR. ." MCAN1-ECR (read-only) $" MCAN1-ECR @ hex. MCAN1-ECR 1b. ;
: MCAN1-PSR. ." MCAN1-PSR (read-only) $" MCAN1-PSR @ hex. MCAN1-PSR 1b. ;
: MCAN1-IR. ." MCAN1-IR () $" MCAN1-IR @ hex. MCAN1-IR 1b. ;
: MCAN1-IE. ." MCAN1-IE () $" MCAN1-IE @ hex. MCAN1-IE 1b. ;
: MCAN1-ILS. ." MCAN1-ILS () $" MCAN1-ILS @ hex. MCAN1-ILS 1b. ;
: MCAN1-ILE. ." MCAN1-ILE () $" MCAN1-ILE @ hex. MCAN1-ILE 1b. ;
: MCAN1-GFC. ." MCAN1-GFC () $" MCAN1-GFC @ hex. MCAN1-GFC 1b. ;
: MCAN1-SIDFC. ." MCAN1-SIDFC () $" MCAN1-SIDFC @ hex. MCAN1-SIDFC 1b. ;
: MCAN1-XIDFC. ." MCAN1-XIDFC () $" MCAN1-XIDFC @ hex. MCAN1-XIDFC 1b. ;
: MCAN1-XIDAM. ." MCAN1-XIDAM () $" MCAN1-XIDAM @ hex. MCAN1-XIDAM 1b. ;
: MCAN1-HPMS. ." MCAN1-HPMS (read-only) $" MCAN1-HPMS @ hex. MCAN1-HPMS 1b. ;
: MCAN1-NDAT1. ." MCAN1-NDAT1 () $" MCAN1-NDAT1 @ hex. MCAN1-NDAT1 1b. ;
: MCAN1-NDAT2. ." MCAN1-NDAT2 () $" MCAN1-NDAT2 @ hex. MCAN1-NDAT2 1b. ;
: MCAN1-RXF0C. ." MCAN1-RXF0C () $" MCAN1-RXF0C @ hex. MCAN1-RXF0C 1b. ;
: MCAN1-RXF0S. ." MCAN1-RXF0S (read-only) $" MCAN1-RXF0S @ hex. MCAN1-RXF0S 1b. ;
: MCAN1-RXF0A. ." MCAN1-RXF0A () $" MCAN1-RXF0A @ hex. MCAN1-RXF0A 1b. ;
: MCAN1-RXBC. ." MCAN1-RXBC () $" MCAN1-RXBC @ hex. MCAN1-RXBC 1b. ;
: MCAN1-RXF1C. ." MCAN1-RXF1C () $" MCAN1-RXF1C @ hex. MCAN1-RXF1C 1b. ;
: MCAN1-RXF1S. ." MCAN1-RXF1S (read-only) $" MCAN1-RXF1S @ hex. MCAN1-RXF1S 1b. ;
: MCAN1-RXF1A. ." MCAN1-RXF1A () $" MCAN1-RXF1A @ hex. MCAN1-RXF1A 1b. ;
: MCAN1-RXESC. ." MCAN1-RXESC () $" MCAN1-RXESC @ hex. MCAN1-RXESC 1b. ;
: MCAN1-TXBC. ." MCAN1-TXBC () $" MCAN1-TXBC @ hex. MCAN1-TXBC 1b. ;
: MCAN1-TXFQS. ." MCAN1-TXFQS (read-only) $" MCAN1-TXFQS @ hex. MCAN1-TXFQS 1b. ;
: MCAN1-TXESC. ." MCAN1-TXESC () $" MCAN1-TXESC @ hex. MCAN1-TXESC 1b. ;
: MCAN1-TXBRP. ." MCAN1-TXBRP (read-only) $" MCAN1-TXBRP @ hex. MCAN1-TXBRP 1b. ;
: MCAN1-TXBAR. ." MCAN1-TXBAR () $" MCAN1-TXBAR @ hex. MCAN1-TXBAR 1b. ;
: MCAN1-TXBCR. ." MCAN1-TXBCR () $" MCAN1-TXBCR @ hex. MCAN1-TXBCR 1b. ;
: MCAN1-TXBTO. ." MCAN1-TXBTO (read-only) $" MCAN1-TXBTO @ hex. MCAN1-TXBTO 1b. ;
: MCAN1-TXBCF. ." MCAN1-TXBCF (read-only) $" MCAN1-TXBCF @ hex. MCAN1-TXBCF 1b. ;
: MCAN1-TXBTIE. ." MCAN1-TXBTIE () $" MCAN1-TXBTIE @ hex. MCAN1-TXBTIE 1b. ;
: MCAN1-TXBCIE. ." MCAN1-TXBCIE () $" MCAN1-TXBCIE @ hex. MCAN1-TXBCIE 1b. ;
: MCAN1-TXEFC. ." MCAN1-TXEFC () $" MCAN1-TXEFC @ hex. MCAN1-TXEFC 1b. ;
: MCAN1-TXEFS. ." MCAN1-TXEFS (read-only) $" MCAN1-TXEFS @ hex. MCAN1-TXEFS 1b. ;
: MCAN1-TXEFA. ." MCAN1-TXEFA () $" MCAN1-TXEFA @ hex. MCAN1-TXEFA 1b. ;
: MCAN1.
MCAN1-CUST.
MCAN1-FBTP.
MCAN1-TEST.
MCAN1-RWD.
MCAN1-CCCR.
MCAN1-BTP.
MCAN1-TSCC.
MCAN1-TSCV.
MCAN1-TOCC.
MCAN1-TOCV.
MCAN1-ECR.
MCAN1-PSR.
MCAN1-IR.
MCAN1-IE.
MCAN1-ILS.
MCAN1-ILE.
MCAN1-GFC.
MCAN1-SIDFC.
MCAN1-XIDFC.
MCAN1-XIDAM.
MCAN1-HPMS.
MCAN1-NDAT1.
MCAN1-NDAT2.
MCAN1-RXF0C.
MCAN1-RXF0S.
MCAN1-RXF0A.
MCAN1-RXBC.
MCAN1-RXF1C.
MCAN1-RXF1S.
MCAN1-RXF1A.
MCAN1-RXESC.
MCAN1-TXBC.
MCAN1-TXFQS.
MCAN1-TXESC.
MCAN1-TXBRP.
MCAN1-TXBAR.
MCAN1-TXBCR.
MCAN1-TXBTO.
MCAN1-TXBCF.
MCAN1-TXBTIE.
MCAN1-TXBCIE.
MCAN1-TXEFC.
MCAN1-TXEFS.
MCAN1-TXEFA.
;

$400E0E00 constant PIOA ( Parallel Input/Output Controller )
PIOA $0000 + constant PIOA-PER ( PIO Enable Register )
PIOA $0004 + constant PIOA-PDR ( PIO Disable Register )
PIOA $0008 + constant PIOA-PSR ( PIO Status Register )
PIOA $0010 + constant PIOA-OER ( Output Enable Register )
PIOA $0014 + constant PIOA-ODR ( Output Disable Register )
PIOA $0018 + constant PIOA-OSR ( Output Status Register )
PIOA $0020 + constant PIOA-IFER ( Glitch Input Filter Enable Register )
PIOA $0024 + constant PIOA-IFDR ( Glitch Input Filter Disable Register )
PIOA $0028 + constant PIOA-IFSR ( Glitch Input Filter Status Register )
PIOA $0030 + constant PIOA-SODR ( Set Output Data Register )
PIOA $0034 + constant PIOA-CODR ( Clear Output Data Register )
PIOA $0038 + constant PIOA-ODSR ( Output Data Status Register )
PIOA $003C + constant PIOA-PDSR ( Pin Data Status Register )
PIOA $0040 + constant PIOA-IER ( Interrupt Enable Register )
PIOA $0044 + constant PIOA-IDR ( Interrupt Disable Register )
PIOA $0048 + constant PIOA-IMR ( Interrupt Mask Register )
PIOA $004C + constant PIOA-ISR ( Interrupt Status Register )
PIOA $0050 + constant PIOA-MDER ( Multi-driver Enable Register )
PIOA $0054 + constant PIOA-MDDR ( Multi-driver Disable Register )
PIOA $0058 + constant PIOA-MDSR ( Multi-driver Status Register )
PIOA $0060 + constant PIOA-PUDR ( Pull-up Disable Register )
PIOA $0064 + constant PIOA-PUER ( Pull-up Enable Register )
PIOA $0068 + constant PIOA-PUSR ( Pad Pull-up Status Register )
PIOA $70 + constant PIOA-ABCDSR[%s] ( Peripheral ABCD Select Register 0 )
PIOA $0080 + constant PIOA-IFSCDR ( Input Filter Slow Clock Disable Register )
PIOA $0084 + constant PIOA-IFSCER ( Input Filter Slow Clock Enable Register )
PIOA $0088 + constant PIOA-IFSCSR ( Input Filter Slow Clock Status Register )
PIOA $008C + constant PIOA-SCDR ( Slow Clock Divider Debouncing Register )
PIOA $0090 + constant PIOA-PPDDR ( Pad Pull-down Disable Register )
PIOA $0094 + constant PIOA-PPDER ( Pad Pull-down Enable Register )
PIOA $0098 + constant PIOA-PPDSR ( Pad Pull-down Status Register )
PIOA $00A0 + constant PIOA-OWER ( Output Write Enable )
PIOA $00A4 + constant PIOA-OWDR ( Output Write Disable )
PIOA $00A8 + constant PIOA-OWSR ( Output Write Status Register )
PIOA $00B0 + constant PIOA-AIMER ( Additional Interrupt Modes Enable Register )
PIOA $00B4 + constant PIOA-AIMDR ( Additional Interrupt Modes Disable Register )
PIOA $00B8 + constant PIOA-AIMMR ( Additional Interrupt Modes Mask Register )
PIOA $00C0 + constant PIOA-ESR ( Edge Select Register )
PIOA $00C4 + constant PIOA-LSR ( Level Select Register )
PIOA $00C8 + constant PIOA-ELSR ( Edge/Level Status Register )
PIOA $00D0 + constant PIOA-FELLSR ( Falling Edge/Low-Level Select Register )
PIOA $00D4 + constant PIOA-REHLSR ( Rising Edge/High-Level Select Register )
PIOA $00D8 + constant PIOA-FRLHSR ( Fall/Rise - Low/High Status Register )
PIOA $00E0 + constant PIOA-LOCKSR ( Lock Status )
PIOA $00E4 + constant PIOA-WPMR ( Write Protection Mode Register )
PIOA $00E8 + constant PIOA-WPSR ( Write Protection Status Register )
PIOA $0100 + constant PIOA-SCHMITT ( Schmitt Trigger Register )
PIOA $0118 + constant PIOA-DRIVER ( I/O Drive Register )
PIOA $0150 + constant PIOA-PCMR ( Parallel Capture Mode Register )
PIOA $0154 + constant PIOA-PCIER ( Parallel Capture Interrupt Enable Register )
PIOA $0158 + constant PIOA-PCIDR ( Parallel Capture Interrupt Disable Register )
PIOA $015C + constant PIOA-PCIMR ( Parallel Capture Interrupt Mask Register )
PIOA $0160 + constant PIOA-PCISR ( Parallel Capture Interrupt Status Register )
PIOA $0164 + constant PIOA-PCRHR ( Parallel Capture Reception Holding Register )
: PIOA-PER. ." PIOA-PER (write-only) $" PIOA-PER @ hex. PIOA-PER 1b. ;
: PIOA-PDR. ." PIOA-PDR (write-only) $" PIOA-PDR @ hex. PIOA-PDR 1b. ;
: PIOA-PSR. ." PIOA-PSR (read-only) $" PIOA-PSR @ hex. PIOA-PSR 1b. ;
: PIOA-OER. ." PIOA-OER (write-only) $" PIOA-OER @ hex. PIOA-OER 1b. ;
: PIOA-ODR. ." PIOA-ODR (write-only) $" PIOA-ODR @ hex. PIOA-ODR 1b. ;
: PIOA-OSR. ." PIOA-OSR (read-only) $" PIOA-OSR @ hex. PIOA-OSR 1b. ;
: PIOA-IFER. ." PIOA-IFER (write-only) $" PIOA-IFER @ hex. PIOA-IFER 1b. ;
: PIOA-IFDR. ." PIOA-IFDR (write-only) $" PIOA-IFDR @ hex. PIOA-IFDR 1b. ;
: PIOA-IFSR. ." PIOA-IFSR (read-only) $" PIOA-IFSR @ hex. PIOA-IFSR 1b. ;
: PIOA-SODR. ." PIOA-SODR (write-only) $" PIOA-SODR @ hex. PIOA-SODR 1b. ;
: PIOA-CODR. ." PIOA-CODR (write-only) $" PIOA-CODR @ hex. PIOA-CODR 1b. ;
: PIOA-ODSR. ." PIOA-ODSR () $" PIOA-ODSR @ hex. PIOA-ODSR 1b. ;
: PIOA-PDSR. ." PIOA-PDSR (read-only) $" PIOA-PDSR @ hex. PIOA-PDSR 1b. ;
: PIOA-IER. ." PIOA-IER (write-only) $" PIOA-IER @ hex. PIOA-IER 1b. ;
: PIOA-IDR. ." PIOA-IDR (write-only) $" PIOA-IDR @ hex. PIOA-IDR 1b. ;
: PIOA-IMR. ." PIOA-IMR (read-only) $" PIOA-IMR @ hex. PIOA-IMR 1b. ;
: PIOA-ISR. ." PIOA-ISR (read-only) $" PIOA-ISR @ hex. PIOA-ISR 1b. ;
: PIOA-MDER. ." PIOA-MDER (write-only) $" PIOA-MDER @ hex. PIOA-MDER 1b. ;
: PIOA-MDDR. ." PIOA-MDDR (write-only) $" PIOA-MDDR @ hex. PIOA-MDDR 1b. ;
: PIOA-MDSR. ." PIOA-MDSR (read-only) $" PIOA-MDSR @ hex. PIOA-MDSR 1b. ;
: PIOA-PUDR. ." PIOA-PUDR (write-only) $" PIOA-PUDR @ hex. PIOA-PUDR 1b. ;
: PIOA-PUER. ." PIOA-PUER (write-only) $" PIOA-PUER @ hex. PIOA-PUER 1b. ;
: PIOA-PUSR. ." PIOA-PUSR (read-only) $" PIOA-PUSR @ hex. PIOA-PUSR 1b. ;
: PIOA-ABCDSR[%s]. ." PIOA-ABCDSR[%s] () $" PIOA-ABCDSR[%s] @ hex. PIOA-ABCDSR[%s] 1b. ;
: PIOA-IFSCDR. ." PIOA-IFSCDR (write-only) $" PIOA-IFSCDR @ hex. PIOA-IFSCDR 1b. ;
: PIOA-IFSCER. ." PIOA-IFSCER (write-only) $" PIOA-IFSCER @ hex. PIOA-IFSCER 1b. ;
: PIOA-IFSCSR. ." PIOA-IFSCSR (read-only) $" PIOA-IFSCSR @ hex. PIOA-IFSCSR 1b. ;
: PIOA-SCDR. ." PIOA-SCDR () $" PIOA-SCDR @ hex. PIOA-SCDR 1b. ;
: PIOA-PPDDR. ." PIOA-PPDDR (write-only) $" PIOA-PPDDR @ hex. PIOA-PPDDR 1b. ;
: PIOA-PPDER. ." PIOA-PPDER (write-only) $" PIOA-PPDER @ hex. PIOA-PPDER 1b. ;
: PIOA-PPDSR. ." PIOA-PPDSR (read-only) $" PIOA-PPDSR @ hex. PIOA-PPDSR 1b. ;
: PIOA-OWER. ." PIOA-OWER (write-only) $" PIOA-OWER @ hex. PIOA-OWER 1b. ;
: PIOA-OWDR. ." PIOA-OWDR (write-only) $" PIOA-OWDR @ hex. PIOA-OWDR 1b. ;
: PIOA-OWSR. ." PIOA-OWSR (read-only) $" PIOA-OWSR @ hex. PIOA-OWSR 1b. ;
: PIOA-AIMER. ." PIOA-AIMER (write-only) $" PIOA-AIMER @ hex. PIOA-AIMER 1b. ;
: PIOA-AIMDR. ." PIOA-AIMDR (write-only) $" PIOA-AIMDR @ hex. PIOA-AIMDR 1b. ;
: PIOA-AIMMR. ." PIOA-AIMMR (read-only) $" PIOA-AIMMR @ hex. PIOA-AIMMR 1b. ;
: PIOA-ESR. ." PIOA-ESR (write-only) $" PIOA-ESR @ hex. PIOA-ESR 1b. ;
: PIOA-LSR. ." PIOA-LSR (write-only) $" PIOA-LSR @ hex. PIOA-LSR 1b. ;
: PIOA-ELSR. ." PIOA-ELSR (read-only) $" PIOA-ELSR @ hex. PIOA-ELSR 1b. ;
: PIOA-FELLSR. ." PIOA-FELLSR (write-only) $" PIOA-FELLSR @ hex. PIOA-FELLSR 1b. ;
: PIOA-REHLSR. ." PIOA-REHLSR (write-only) $" PIOA-REHLSR @ hex. PIOA-REHLSR 1b. ;
: PIOA-FRLHSR. ." PIOA-FRLHSR (read-only) $" PIOA-FRLHSR @ hex. PIOA-FRLHSR 1b. ;
: PIOA-LOCKSR. ." PIOA-LOCKSR (read-only) $" PIOA-LOCKSR @ hex. PIOA-LOCKSR 1b. ;
: PIOA-WPMR. ." PIOA-WPMR () $" PIOA-WPMR @ hex. PIOA-WPMR 1b. ;
: PIOA-WPSR. ." PIOA-WPSR (read-only) $" PIOA-WPSR @ hex. PIOA-WPSR 1b. ;
: PIOA-SCHMITT. ." PIOA-SCHMITT () $" PIOA-SCHMITT @ hex. PIOA-SCHMITT 1b. ;
: PIOA-DRIVER. ." PIOA-DRIVER () $" PIOA-DRIVER @ hex. PIOA-DRIVER 1b. ;
: PIOA-PCMR. ." PIOA-PCMR () $" PIOA-PCMR @ hex. PIOA-PCMR 1b. ;
: PIOA-PCIER. ." PIOA-PCIER (write-only) $" PIOA-PCIER @ hex. PIOA-PCIER 1b. ;
: PIOA-PCIDR. ." PIOA-PCIDR (write-only) $" PIOA-PCIDR @ hex. PIOA-PCIDR 1b. ;
: PIOA-PCIMR. ." PIOA-PCIMR (read-only) $" PIOA-PCIMR @ hex. PIOA-PCIMR 1b. ;
: PIOA-PCISR. ." PIOA-PCISR (read-only) $" PIOA-PCISR @ hex. PIOA-PCISR 1b. ;
: PIOA-PCRHR. ." PIOA-PCRHR (read-only) $" PIOA-PCRHR @ hex. PIOA-PCRHR 1b. ;
: PIOA.
PIOA-PER.
PIOA-PDR.
PIOA-PSR.
PIOA-OER.
PIOA-ODR.
PIOA-OSR.
PIOA-IFER.
PIOA-IFDR.
PIOA-IFSR.
PIOA-SODR.
PIOA-CODR.
PIOA-ODSR.
PIOA-PDSR.
PIOA-IER.
PIOA-IDR.
PIOA-IMR.
PIOA-ISR.
PIOA-MDER.
PIOA-MDDR.
PIOA-MDSR.
PIOA-PUDR.
PIOA-PUER.
PIOA-PUSR.
PIOA-ABCDSR[%s].
PIOA-IFSCDR.
PIOA-IFSCER.
PIOA-IFSCSR.
PIOA-SCDR.
PIOA-PPDDR.
PIOA-PPDER.
PIOA-PPDSR.
PIOA-OWER.
PIOA-OWDR.
PIOA-OWSR.
PIOA-AIMER.
PIOA-AIMDR.
PIOA-AIMMR.
PIOA-ESR.
PIOA-LSR.
PIOA-ELSR.
PIOA-FELLSR.
PIOA-REHLSR.
PIOA-FRLHSR.
PIOA-LOCKSR.
PIOA-WPMR.
PIOA-WPSR.
PIOA-SCHMITT.
PIOA-DRIVER.
PIOA-PCMR.
PIOA-PCIER.
PIOA-PCIDR.
PIOA-PCIMR.
PIOA-PCISR.
PIOA-PCRHR.
;

$400E1000 constant PIOB ( Parallel Input/Output Controller )
PIOB $0000 + constant PIOB-PER ( PIO Enable Register )
PIOB $0004 + constant PIOB-PDR ( PIO Disable Register )
PIOB $0008 + constant PIOB-PSR ( PIO Status Register )
PIOB $0010 + constant PIOB-OER ( Output Enable Register )
PIOB $0014 + constant PIOB-ODR ( Output Disable Register )
PIOB $0018 + constant PIOB-OSR ( Output Status Register )
PIOB $0020 + constant PIOB-IFER ( Glitch Input Filter Enable Register )
PIOB $0024 + constant PIOB-IFDR ( Glitch Input Filter Disable Register )
PIOB $0028 + constant PIOB-IFSR ( Glitch Input Filter Status Register )
PIOB $0030 + constant PIOB-SODR ( Set Output Data Register )
PIOB $0034 + constant PIOB-CODR ( Clear Output Data Register )
PIOB $0038 + constant PIOB-ODSR ( Output Data Status Register )
PIOB $003C + constant PIOB-PDSR ( Pin Data Status Register )
PIOB $0040 + constant PIOB-IER ( Interrupt Enable Register )
PIOB $0044 + constant PIOB-IDR ( Interrupt Disable Register )
PIOB $0048 + constant PIOB-IMR ( Interrupt Mask Register )
PIOB $004C + constant PIOB-ISR ( Interrupt Status Register )
PIOB $0050 + constant PIOB-MDER ( Multi-driver Enable Register )
PIOB $0054 + constant PIOB-MDDR ( Multi-driver Disable Register )
PIOB $0058 + constant PIOB-MDSR ( Multi-driver Status Register )
PIOB $0060 + constant PIOB-PUDR ( Pull-up Disable Register )
PIOB $0064 + constant PIOB-PUER ( Pull-up Enable Register )
PIOB $0068 + constant PIOB-PUSR ( Pad Pull-up Status Register )
PIOB $70 + constant PIOB-ABCDSR[%s] ( Peripheral ABCD Select Register 0 )
PIOB $0080 + constant PIOB-IFSCDR ( Input Filter Slow Clock Disable Register )
PIOB $0084 + constant PIOB-IFSCER ( Input Filter Slow Clock Enable Register )
PIOB $0088 + constant PIOB-IFSCSR ( Input Filter Slow Clock Status Register )
PIOB $008C + constant PIOB-SCDR ( Slow Clock Divider Debouncing Register )
PIOB $0090 + constant PIOB-PPDDR ( Pad Pull-down Disable Register )
PIOB $0094 + constant PIOB-PPDER ( Pad Pull-down Enable Register )
PIOB $0098 + constant PIOB-PPDSR ( Pad Pull-down Status Register )
PIOB $00A0 + constant PIOB-OWER ( Output Write Enable )
PIOB $00A4 + constant PIOB-OWDR ( Output Write Disable )
PIOB $00A8 + constant PIOB-OWSR ( Output Write Status Register )
PIOB $00B0 + constant PIOB-AIMER ( Additional Interrupt Modes Enable Register )
PIOB $00B4 + constant PIOB-AIMDR ( Additional Interrupt Modes Disable Register )
PIOB $00B8 + constant PIOB-AIMMR ( Additional Interrupt Modes Mask Register )
PIOB $00C0 + constant PIOB-ESR ( Edge Select Register )
PIOB $00C4 + constant PIOB-LSR ( Level Select Register )
PIOB $00C8 + constant PIOB-ELSR ( Edge/Level Status Register )
PIOB $00D0 + constant PIOB-FELLSR ( Falling Edge/Low-Level Select Register )
PIOB $00D4 + constant PIOB-REHLSR ( Rising Edge/High-Level Select Register )
PIOB $00D8 + constant PIOB-FRLHSR ( Fall/Rise - Low/High Status Register )
PIOB $00E0 + constant PIOB-LOCKSR ( Lock Status )
PIOB $00E4 + constant PIOB-WPMR ( Write Protection Mode Register )
PIOB $00E8 + constant PIOB-WPSR ( Write Protection Status Register )
PIOB $0100 + constant PIOB-SCHMITT ( Schmitt Trigger Register )
PIOB $0118 + constant PIOB-DRIVER ( I/O Drive Register )
PIOB $0150 + constant PIOB-PCMR ( Parallel Capture Mode Register )
PIOB $0154 + constant PIOB-PCIER ( Parallel Capture Interrupt Enable Register )
PIOB $0158 + constant PIOB-PCIDR ( Parallel Capture Interrupt Disable Register )
PIOB $015C + constant PIOB-PCIMR ( Parallel Capture Interrupt Mask Register )
PIOB $0160 + constant PIOB-PCISR ( Parallel Capture Interrupt Status Register )
PIOB $0164 + constant PIOB-PCRHR ( Parallel Capture Reception Holding Register )
: PIOB-PER. ." PIOB-PER (write-only) $" PIOB-PER @ hex. PIOB-PER 1b. ;
: PIOB-PDR. ." PIOB-PDR (write-only) $" PIOB-PDR @ hex. PIOB-PDR 1b. ;
: PIOB-PSR. ." PIOB-PSR (read-only) $" PIOB-PSR @ hex. PIOB-PSR 1b. ;
: PIOB-OER. ." PIOB-OER (write-only) $" PIOB-OER @ hex. PIOB-OER 1b. ;
: PIOB-ODR. ." PIOB-ODR (write-only) $" PIOB-ODR @ hex. PIOB-ODR 1b. ;
: PIOB-OSR. ." PIOB-OSR (read-only) $" PIOB-OSR @ hex. PIOB-OSR 1b. ;
: PIOB-IFER. ." PIOB-IFER (write-only) $" PIOB-IFER @ hex. PIOB-IFER 1b. ;
: PIOB-IFDR. ." PIOB-IFDR (write-only) $" PIOB-IFDR @ hex. PIOB-IFDR 1b. ;
: PIOB-IFSR. ." PIOB-IFSR (read-only) $" PIOB-IFSR @ hex. PIOB-IFSR 1b. ;
: PIOB-SODR. ." PIOB-SODR (write-only) $" PIOB-SODR @ hex. PIOB-SODR 1b. ;
: PIOB-CODR. ." PIOB-CODR (write-only) $" PIOB-CODR @ hex. PIOB-CODR 1b. ;
: PIOB-ODSR. ." PIOB-ODSR () $" PIOB-ODSR @ hex. PIOB-ODSR 1b. ;
: PIOB-PDSR. ." PIOB-PDSR (read-only) $" PIOB-PDSR @ hex. PIOB-PDSR 1b. ;
: PIOB-IER. ." PIOB-IER (write-only) $" PIOB-IER @ hex. PIOB-IER 1b. ;
: PIOB-IDR. ." PIOB-IDR (write-only) $" PIOB-IDR @ hex. PIOB-IDR 1b. ;
: PIOB-IMR. ." PIOB-IMR (read-only) $" PIOB-IMR @ hex. PIOB-IMR 1b. ;
: PIOB-ISR. ." PIOB-ISR (read-only) $" PIOB-ISR @ hex. PIOB-ISR 1b. ;
: PIOB-MDER. ." PIOB-MDER (write-only) $" PIOB-MDER @ hex. PIOB-MDER 1b. ;
: PIOB-MDDR. ." PIOB-MDDR (write-only) $" PIOB-MDDR @ hex. PIOB-MDDR 1b. ;
: PIOB-MDSR. ." PIOB-MDSR (read-only) $" PIOB-MDSR @ hex. PIOB-MDSR 1b. ;
: PIOB-PUDR. ." PIOB-PUDR (write-only) $" PIOB-PUDR @ hex. PIOB-PUDR 1b. ;
: PIOB-PUER. ." PIOB-PUER (write-only) $" PIOB-PUER @ hex. PIOB-PUER 1b. ;
: PIOB-PUSR. ." PIOB-PUSR (read-only) $" PIOB-PUSR @ hex. PIOB-PUSR 1b. ;
: PIOB-ABCDSR[%s]. ." PIOB-ABCDSR[%s] () $" PIOB-ABCDSR[%s] @ hex. PIOB-ABCDSR[%s] 1b. ;
: PIOB-IFSCDR. ." PIOB-IFSCDR (write-only) $" PIOB-IFSCDR @ hex. PIOB-IFSCDR 1b. ;
: PIOB-IFSCER. ." PIOB-IFSCER (write-only) $" PIOB-IFSCER @ hex. PIOB-IFSCER 1b. ;
: PIOB-IFSCSR. ." PIOB-IFSCSR (read-only) $" PIOB-IFSCSR @ hex. PIOB-IFSCSR 1b. ;
: PIOB-SCDR. ." PIOB-SCDR () $" PIOB-SCDR @ hex. PIOB-SCDR 1b. ;
: PIOB-PPDDR. ." PIOB-PPDDR (write-only) $" PIOB-PPDDR @ hex. PIOB-PPDDR 1b. ;
: PIOB-PPDER. ." PIOB-PPDER (write-only) $" PIOB-PPDER @ hex. PIOB-PPDER 1b. ;
: PIOB-PPDSR. ." PIOB-PPDSR (read-only) $" PIOB-PPDSR @ hex. PIOB-PPDSR 1b. ;
: PIOB-OWER. ." PIOB-OWER (write-only) $" PIOB-OWER @ hex. PIOB-OWER 1b. ;
: PIOB-OWDR. ." PIOB-OWDR (write-only) $" PIOB-OWDR @ hex. PIOB-OWDR 1b. ;
: PIOB-OWSR. ." PIOB-OWSR (read-only) $" PIOB-OWSR @ hex. PIOB-OWSR 1b. ;
: PIOB-AIMER. ." PIOB-AIMER (write-only) $" PIOB-AIMER @ hex. PIOB-AIMER 1b. ;
: PIOB-AIMDR. ." PIOB-AIMDR (write-only) $" PIOB-AIMDR @ hex. PIOB-AIMDR 1b. ;
: PIOB-AIMMR. ." PIOB-AIMMR (read-only) $" PIOB-AIMMR @ hex. PIOB-AIMMR 1b. ;
: PIOB-ESR. ." PIOB-ESR (write-only) $" PIOB-ESR @ hex. PIOB-ESR 1b. ;
: PIOB-LSR. ." PIOB-LSR (write-only) $" PIOB-LSR @ hex. PIOB-LSR 1b. ;
: PIOB-ELSR. ." PIOB-ELSR (read-only) $" PIOB-ELSR @ hex. PIOB-ELSR 1b. ;
: PIOB-FELLSR. ." PIOB-FELLSR (write-only) $" PIOB-FELLSR @ hex. PIOB-FELLSR 1b. ;
: PIOB-REHLSR. ." PIOB-REHLSR (write-only) $" PIOB-REHLSR @ hex. PIOB-REHLSR 1b. ;
: PIOB-FRLHSR. ." PIOB-FRLHSR (read-only) $" PIOB-FRLHSR @ hex. PIOB-FRLHSR 1b. ;
: PIOB-LOCKSR. ." PIOB-LOCKSR (read-only) $" PIOB-LOCKSR @ hex. PIOB-LOCKSR 1b. ;
: PIOB-WPMR. ." PIOB-WPMR () $" PIOB-WPMR @ hex. PIOB-WPMR 1b. ;
: PIOB-WPSR. ." PIOB-WPSR (read-only) $" PIOB-WPSR @ hex. PIOB-WPSR 1b. ;
: PIOB-SCHMITT. ." PIOB-SCHMITT () $" PIOB-SCHMITT @ hex. PIOB-SCHMITT 1b. ;
: PIOB-DRIVER. ." PIOB-DRIVER () $" PIOB-DRIVER @ hex. PIOB-DRIVER 1b. ;
: PIOB-PCMR. ." PIOB-PCMR () $" PIOB-PCMR @ hex. PIOB-PCMR 1b. ;
: PIOB-PCIER. ." PIOB-PCIER (write-only) $" PIOB-PCIER @ hex. PIOB-PCIER 1b. ;
: PIOB-PCIDR. ." PIOB-PCIDR (write-only) $" PIOB-PCIDR @ hex. PIOB-PCIDR 1b. ;
: PIOB-PCIMR. ." PIOB-PCIMR (read-only) $" PIOB-PCIMR @ hex. PIOB-PCIMR 1b. ;
: PIOB-PCISR. ." PIOB-PCISR (read-only) $" PIOB-PCISR @ hex. PIOB-PCISR 1b. ;
: PIOB-PCRHR. ." PIOB-PCRHR (read-only) $" PIOB-PCRHR @ hex. PIOB-PCRHR 1b. ;
: PIOB.
PIOB-PER.
PIOB-PDR.
PIOB-PSR.
PIOB-OER.
PIOB-ODR.
PIOB-OSR.
PIOB-IFER.
PIOB-IFDR.
PIOB-IFSR.
PIOB-SODR.
PIOB-CODR.
PIOB-ODSR.
PIOB-PDSR.
PIOB-IER.
PIOB-IDR.
PIOB-IMR.
PIOB-ISR.
PIOB-MDER.
PIOB-MDDR.
PIOB-MDSR.
PIOB-PUDR.
PIOB-PUER.
PIOB-PUSR.
PIOB-ABCDSR[%s].
PIOB-IFSCDR.
PIOB-IFSCER.
PIOB-IFSCSR.
PIOB-SCDR.
PIOB-PPDDR.
PIOB-PPDER.
PIOB-PPDSR.
PIOB-OWER.
PIOB-OWDR.
PIOB-OWSR.
PIOB-AIMER.
PIOB-AIMDR.
PIOB-AIMMR.
PIOB-ESR.
PIOB-LSR.
PIOB-ELSR.
PIOB-FELLSR.
PIOB-REHLSR.
PIOB-FRLHSR.
PIOB-LOCKSR.
PIOB-WPMR.
PIOB-WPSR.
PIOB-SCHMITT.
PIOB-DRIVER.
PIOB-PCMR.
PIOB-PCIER.
PIOB-PCIDR.
PIOB-PCIMR.
PIOB-PCISR.
PIOB-PCRHR.
;

$400E1400 constant PIOD ( Parallel Input/Output Controller )
PIOD $0000 + constant PIOD-PER ( PIO Enable Register )
PIOD $0004 + constant PIOD-PDR ( PIO Disable Register )
PIOD $0008 + constant PIOD-PSR ( PIO Status Register )
PIOD $0010 + constant PIOD-OER ( Output Enable Register )
PIOD $0014 + constant PIOD-ODR ( Output Disable Register )
PIOD $0018 + constant PIOD-OSR ( Output Status Register )
PIOD $0020 + constant PIOD-IFER ( Glitch Input Filter Enable Register )
PIOD $0024 + constant PIOD-IFDR ( Glitch Input Filter Disable Register )
PIOD $0028 + constant PIOD-IFSR ( Glitch Input Filter Status Register )
PIOD $0030 + constant PIOD-SODR ( Set Output Data Register )
PIOD $0034 + constant PIOD-CODR ( Clear Output Data Register )
PIOD $0038 + constant PIOD-ODSR ( Output Data Status Register )
PIOD $003C + constant PIOD-PDSR ( Pin Data Status Register )
PIOD $0040 + constant PIOD-IER ( Interrupt Enable Register )
PIOD $0044 + constant PIOD-IDR ( Interrupt Disable Register )
PIOD $0048 + constant PIOD-IMR ( Interrupt Mask Register )
PIOD $004C + constant PIOD-ISR ( Interrupt Status Register )
PIOD $0050 + constant PIOD-MDER ( Multi-driver Enable Register )
PIOD $0054 + constant PIOD-MDDR ( Multi-driver Disable Register )
PIOD $0058 + constant PIOD-MDSR ( Multi-driver Status Register )
PIOD $0060 + constant PIOD-PUDR ( Pull-up Disable Register )
PIOD $0064 + constant PIOD-PUER ( Pull-up Enable Register )
PIOD $0068 + constant PIOD-PUSR ( Pad Pull-up Status Register )
PIOD $70 + constant PIOD-ABCDSR[%s] ( Peripheral ABCD Select Register 0 )
PIOD $0080 + constant PIOD-IFSCDR ( Input Filter Slow Clock Disable Register )
PIOD $0084 + constant PIOD-IFSCER ( Input Filter Slow Clock Enable Register )
PIOD $0088 + constant PIOD-IFSCSR ( Input Filter Slow Clock Status Register )
PIOD $008C + constant PIOD-SCDR ( Slow Clock Divider Debouncing Register )
PIOD $0090 + constant PIOD-PPDDR ( Pad Pull-down Disable Register )
PIOD $0094 + constant PIOD-PPDER ( Pad Pull-down Enable Register )
PIOD $0098 + constant PIOD-PPDSR ( Pad Pull-down Status Register )
PIOD $00A0 + constant PIOD-OWER ( Output Write Enable )
PIOD $00A4 + constant PIOD-OWDR ( Output Write Disable )
PIOD $00A8 + constant PIOD-OWSR ( Output Write Status Register )
PIOD $00B0 + constant PIOD-AIMER ( Additional Interrupt Modes Enable Register )
PIOD $00B4 + constant PIOD-AIMDR ( Additional Interrupt Modes Disable Register )
PIOD $00B8 + constant PIOD-AIMMR ( Additional Interrupt Modes Mask Register )
PIOD $00C0 + constant PIOD-ESR ( Edge Select Register )
PIOD $00C4 + constant PIOD-LSR ( Level Select Register )
PIOD $00C8 + constant PIOD-ELSR ( Edge/Level Status Register )
PIOD $00D0 + constant PIOD-FELLSR ( Falling Edge/Low-Level Select Register )
PIOD $00D4 + constant PIOD-REHLSR ( Rising Edge/High-Level Select Register )
PIOD $00D8 + constant PIOD-FRLHSR ( Fall/Rise - Low/High Status Register )
PIOD $00E0 + constant PIOD-LOCKSR ( Lock Status )
PIOD $00E4 + constant PIOD-WPMR ( Write Protection Mode Register )
PIOD $00E8 + constant PIOD-WPSR ( Write Protection Status Register )
PIOD $0100 + constant PIOD-SCHMITT ( Schmitt Trigger Register )
PIOD $0118 + constant PIOD-DRIVER ( I/O Drive Register )
PIOD $0150 + constant PIOD-PCMR ( Parallel Capture Mode Register )
PIOD $0154 + constant PIOD-PCIER ( Parallel Capture Interrupt Enable Register )
PIOD $0158 + constant PIOD-PCIDR ( Parallel Capture Interrupt Disable Register )
PIOD $015C + constant PIOD-PCIMR ( Parallel Capture Interrupt Mask Register )
PIOD $0160 + constant PIOD-PCISR ( Parallel Capture Interrupt Status Register )
PIOD $0164 + constant PIOD-PCRHR ( Parallel Capture Reception Holding Register )
: PIOD-PER. ." PIOD-PER (write-only) $" PIOD-PER @ hex. PIOD-PER 1b. ;
: PIOD-PDR. ." PIOD-PDR (write-only) $" PIOD-PDR @ hex. PIOD-PDR 1b. ;
: PIOD-PSR. ." PIOD-PSR (read-only) $" PIOD-PSR @ hex. PIOD-PSR 1b. ;
: PIOD-OER. ." PIOD-OER (write-only) $" PIOD-OER @ hex. PIOD-OER 1b. ;
: PIOD-ODR. ." PIOD-ODR (write-only) $" PIOD-ODR @ hex. PIOD-ODR 1b. ;
: PIOD-OSR. ." PIOD-OSR (read-only) $" PIOD-OSR @ hex. PIOD-OSR 1b. ;
: PIOD-IFER. ." PIOD-IFER (write-only) $" PIOD-IFER @ hex. PIOD-IFER 1b. ;
: PIOD-IFDR. ." PIOD-IFDR (write-only) $" PIOD-IFDR @ hex. PIOD-IFDR 1b. ;
: PIOD-IFSR. ." PIOD-IFSR (read-only) $" PIOD-IFSR @ hex. PIOD-IFSR 1b. ;
: PIOD-SODR. ." PIOD-SODR (write-only) $" PIOD-SODR @ hex. PIOD-SODR 1b. ;
: PIOD-CODR. ." PIOD-CODR (write-only) $" PIOD-CODR @ hex. PIOD-CODR 1b. ;
: PIOD-ODSR. ." PIOD-ODSR () $" PIOD-ODSR @ hex. PIOD-ODSR 1b. ;
: PIOD-PDSR. ." PIOD-PDSR (read-only) $" PIOD-PDSR @ hex. PIOD-PDSR 1b. ;
: PIOD-IER. ." PIOD-IER (write-only) $" PIOD-IER @ hex. PIOD-IER 1b. ;
: PIOD-IDR. ." PIOD-IDR (write-only) $" PIOD-IDR @ hex. PIOD-IDR 1b. ;
: PIOD-IMR. ." PIOD-IMR (read-only) $" PIOD-IMR @ hex. PIOD-IMR 1b. ;
: PIOD-ISR. ." PIOD-ISR (read-only) $" PIOD-ISR @ hex. PIOD-ISR 1b. ;
: PIOD-MDER. ." PIOD-MDER (write-only) $" PIOD-MDER @ hex. PIOD-MDER 1b. ;
: PIOD-MDDR. ." PIOD-MDDR (write-only) $" PIOD-MDDR @ hex. PIOD-MDDR 1b. ;
: PIOD-MDSR. ." PIOD-MDSR (read-only) $" PIOD-MDSR @ hex. PIOD-MDSR 1b. ;
: PIOD-PUDR. ." PIOD-PUDR (write-only) $" PIOD-PUDR @ hex. PIOD-PUDR 1b. ;
: PIOD-PUER. ." PIOD-PUER (write-only) $" PIOD-PUER @ hex. PIOD-PUER 1b. ;
: PIOD-PUSR. ." PIOD-PUSR (read-only) $" PIOD-PUSR @ hex. PIOD-PUSR 1b. ;
: PIOD-ABCDSR[%s]. ." PIOD-ABCDSR[%s] () $" PIOD-ABCDSR[%s] @ hex. PIOD-ABCDSR[%s] 1b. ;
: PIOD-IFSCDR. ." PIOD-IFSCDR (write-only) $" PIOD-IFSCDR @ hex. PIOD-IFSCDR 1b. ;
: PIOD-IFSCER. ." PIOD-IFSCER (write-only) $" PIOD-IFSCER @ hex. PIOD-IFSCER 1b. ;
: PIOD-IFSCSR. ." PIOD-IFSCSR (read-only) $" PIOD-IFSCSR @ hex. PIOD-IFSCSR 1b. ;
: PIOD-SCDR. ." PIOD-SCDR () $" PIOD-SCDR @ hex. PIOD-SCDR 1b. ;
: PIOD-PPDDR. ." PIOD-PPDDR (write-only) $" PIOD-PPDDR @ hex. PIOD-PPDDR 1b. ;
: PIOD-PPDER. ." PIOD-PPDER (write-only) $" PIOD-PPDER @ hex. PIOD-PPDER 1b. ;
: PIOD-PPDSR. ." PIOD-PPDSR (read-only) $" PIOD-PPDSR @ hex. PIOD-PPDSR 1b. ;
: PIOD-OWER. ." PIOD-OWER (write-only) $" PIOD-OWER @ hex. PIOD-OWER 1b. ;
: PIOD-OWDR. ." PIOD-OWDR (write-only) $" PIOD-OWDR @ hex. PIOD-OWDR 1b. ;
: PIOD-OWSR. ." PIOD-OWSR (read-only) $" PIOD-OWSR @ hex. PIOD-OWSR 1b. ;
: PIOD-AIMER. ." PIOD-AIMER (write-only) $" PIOD-AIMER @ hex. PIOD-AIMER 1b. ;
: PIOD-AIMDR. ." PIOD-AIMDR (write-only) $" PIOD-AIMDR @ hex. PIOD-AIMDR 1b. ;
: PIOD-AIMMR. ." PIOD-AIMMR (read-only) $" PIOD-AIMMR @ hex. PIOD-AIMMR 1b. ;
: PIOD-ESR. ." PIOD-ESR (write-only) $" PIOD-ESR @ hex. PIOD-ESR 1b. ;
: PIOD-LSR. ." PIOD-LSR (write-only) $" PIOD-LSR @ hex. PIOD-LSR 1b. ;
: PIOD-ELSR. ." PIOD-ELSR (read-only) $" PIOD-ELSR @ hex. PIOD-ELSR 1b. ;
: PIOD-FELLSR. ." PIOD-FELLSR (write-only) $" PIOD-FELLSR @ hex. PIOD-FELLSR 1b. ;
: PIOD-REHLSR. ." PIOD-REHLSR (write-only) $" PIOD-REHLSR @ hex. PIOD-REHLSR 1b. ;
: PIOD-FRLHSR. ." PIOD-FRLHSR (read-only) $" PIOD-FRLHSR @ hex. PIOD-FRLHSR 1b. ;
: PIOD-LOCKSR. ." PIOD-LOCKSR (read-only) $" PIOD-LOCKSR @ hex. PIOD-LOCKSR 1b. ;
: PIOD-WPMR. ." PIOD-WPMR () $" PIOD-WPMR @ hex. PIOD-WPMR 1b. ;
: PIOD-WPSR. ." PIOD-WPSR (read-only) $" PIOD-WPSR @ hex. PIOD-WPSR 1b. ;
: PIOD-SCHMITT. ." PIOD-SCHMITT () $" PIOD-SCHMITT @ hex. PIOD-SCHMITT 1b. ;
: PIOD-DRIVER. ." PIOD-DRIVER () $" PIOD-DRIVER @ hex. PIOD-DRIVER 1b. ;
: PIOD-PCMR. ." PIOD-PCMR () $" PIOD-PCMR @ hex. PIOD-PCMR 1b. ;
: PIOD-PCIER. ." PIOD-PCIER (write-only) $" PIOD-PCIER @ hex. PIOD-PCIER 1b. ;
: PIOD-PCIDR. ." PIOD-PCIDR (write-only) $" PIOD-PCIDR @ hex. PIOD-PCIDR 1b. ;
: PIOD-PCIMR. ." PIOD-PCIMR (read-only) $" PIOD-PCIMR @ hex. PIOD-PCIMR 1b. ;
: PIOD-PCISR. ." PIOD-PCISR (read-only) $" PIOD-PCISR @ hex. PIOD-PCISR 1b. ;
: PIOD-PCRHR. ." PIOD-PCRHR (read-only) $" PIOD-PCRHR @ hex. PIOD-PCRHR 1b. ;
: PIOD.
PIOD-PER.
PIOD-PDR.
PIOD-PSR.
PIOD-OER.
PIOD-ODR.
PIOD-OSR.
PIOD-IFER.
PIOD-IFDR.
PIOD-IFSR.
PIOD-SODR.
PIOD-CODR.
PIOD-ODSR.
PIOD-PDSR.
PIOD-IER.
PIOD-IDR.
PIOD-IMR.
PIOD-ISR.
PIOD-MDER.
PIOD-MDDR.
PIOD-MDSR.
PIOD-PUDR.
PIOD-PUER.
PIOD-PUSR.
PIOD-ABCDSR[%s].
PIOD-IFSCDR.
PIOD-IFSCER.
PIOD-IFSCSR.
PIOD-SCDR.
PIOD-PPDDR.
PIOD-PPDER.
PIOD-PPDSR.
PIOD-OWER.
PIOD-OWDR.
PIOD-OWSR.
PIOD-AIMER.
PIOD-AIMDR.
PIOD-AIMMR.
PIOD-ESR.
PIOD-LSR.
PIOD-ELSR.
PIOD-FELLSR.
PIOD-REHLSR.
PIOD-FRLHSR.
PIOD-LOCKSR.
PIOD-WPMR.
PIOD-WPSR.
PIOD-SCHMITT.
PIOD-DRIVER.
PIOD-PCMR.
PIOD-PCIER.
PIOD-PCIDR.
PIOD-PCIMR.
PIOD-PCISR.
PIOD-PCRHR.
;

$400E0600 constant PMC ( Power Management Controller )
PMC $0000 + constant PMC-SCER ( System Clock Enable Register )
PMC $0004 + constant PMC-SCDR ( System Clock Disable Register )
PMC $0008 + constant PMC-SCSR ( System Clock Status Register )
PMC $0010 + constant PMC-PCER0 ( Peripheral Clock Enable Register 0 )
PMC $0014 + constant PMC-PCDR0 ( Peripheral Clock Disable Register 0 )
PMC $0018 + constant PMC-PCSR0 ( Peripheral Clock Status Register 0 )
PMC $001C + constant PMC-CKGR_UCKR ( UTMI Clock Register )
PMC $0020 + constant PMC-CKGR_MOR ( Main Oscillator Register )
PMC $0024 + constant PMC-CKGR_MCFR ( Main Clock Frequency Register )
PMC $0028 + constant PMC-CKGR_PLLAR ( PLLA Register )
PMC $0030 + constant PMC-MCKR ( Master Clock Register )
PMC $0038 + constant PMC-USB ( USB Clock Register )
PMC $40 + constant PMC-PCK[%s] ( Programmable Clock Register )
PMC $0060 + constant PMC-IER ( Interrupt Enable Register )
PMC $0064 + constant PMC-IDR ( Interrupt Disable Register )
PMC $0068 + constant PMC-SR ( Status Register )
PMC $006C + constant PMC-IMR ( Interrupt Mask Register )
PMC $0070 + constant PMC-FSMR ( Fast Startup Mode Register )
PMC $0074 + constant PMC-FSPR ( Fast Startup Polarity Register )
PMC $0078 + constant PMC-FOCR ( Fault Output Clear Register )
PMC $00E4 + constant PMC-WPMR ( Write Protection Mode Register )
PMC $00E8 + constant PMC-WPSR ( Write Protection Status Register )
PMC $0100 + constant PMC-PCER1 ( Peripheral Clock Enable Register 1 )
PMC $0104 + constant PMC-PCDR1 ( Peripheral Clock Disable Register 1 )
PMC $0108 + constant PMC-PCSR1 ( Peripheral Clock Status Register 1 )
PMC $010C + constant PMC-PCR ( Peripheral Control Register )
PMC $0110 + constant PMC-OCR ( Oscillator Calibration Register )
PMC $0114 + constant PMC-SLPWK_ER0 ( SleepWalking Enable Register 0 )
PMC $0118 + constant PMC-SLPWK_DR0 ( SleepWalking Disable Register 0 )
PMC $011C + constant PMC-SLPWK_SR0 ( SleepWalking Status Register 0 )
PMC $0120 + constant PMC-SLPWK_ASR0 ( SleepWalking Activity Status Register 0 )
PMC $0130 + constant PMC-PMMR ( PLL Maximum Multiplier Value Register )
PMC $0134 + constant PMC-SLPWK_ER1 ( SleepWalking Enable Register 1 )
PMC $0138 + constant PMC-SLPWK_DR1 ( SleepWalking Disable Register 1 )
PMC $013C + constant PMC-SLPWK_SR1 ( SleepWalking Status Register 1 )
PMC $0140 + constant PMC-SLPWK_ASR1 ( SleepWalking Activity Status Register 1 )
PMC $0144 + constant PMC-SLPWK_AIPR ( SleepWalking Activity In Progress Register )
: PMC-SCER. ." PMC-SCER (write-only) $" PMC-SCER @ hex. PMC-SCER 1b. ;
: PMC-SCDR. ." PMC-SCDR (write-only) $" PMC-SCDR @ hex. PMC-SCDR 1b. ;
: PMC-SCSR. ." PMC-SCSR (read-only) $" PMC-SCSR @ hex. PMC-SCSR 1b. ;
: PMC-PCER0. ." PMC-PCER0 (write-only) $" PMC-PCER0 @ hex. PMC-PCER0 1b. ;
: PMC-PCDR0. ." PMC-PCDR0 (write-only) $" PMC-PCDR0 @ hex. PMC-PCDR0 1b. ;
: PMC-PCSR0. ." PMC-PCSR0 (read-only) $" PMC-PCSR0 @ hex. PMC-PCSR0 1b. ;
: PMC-CKGR_UCKR. ." PMC-CKGR_UCKR () $" PMC-CKGR_UCKR @ hex. PMC-CKGR_UCKR 1b. ;
: PMC-CKGR_MOR. ." PMC-CKGR_MOR () $" PMC-CKGR_MOR @ hex. PMC-CKGR_MOR 1b. ;
: PMC-CKGR_MCFR. ." PMC-CKGR_MCFR () $" PMC-CKGR_MCFR @ hex. PMC-CKGR_MCFR 1b. ;
: PMC-CKGR_PLLAR. ." PMC-CKGR_PLLAR () $" PMC-CKGR_PLLAR @ hex. PMC-CKGR_PLLAR 1b. ;
: PMC-MCKR. ." PMC-MCKR () $" PMC-MCKR @ hex. PMC-MCKR 1b. ;
: PMC-USB. ." PMC-USB () $" PMC-USB @ hex. PMC-USB 1b. ;
: PMC-PCK[%s]. ." PMC-PCK[%s] () $" PMC-PCK[%s] @ hex. PMC-PCK[%s] 1b. ;
: PMC-IER. ." PMC-IER (write-only) $" PMC-IER @ hex. PMC-IER 1b. ;
: PMC-IDR. ." PMC-IDR (write-only) $" PMC-IDR @ hex. PMC-IDR 1b. ;
: PMC-SR. ." PMC-SR (read-only) $" PMC-SR @ hex. PMC-SR 1b. ;
: PMC-IMR. ." PMC-IMR (read-only) $" PMC-IMR @ hex. PMC-IMR 1b. ;
: PMC-FSMR. ." PMC-FSMR () $" PMC-FSMR @ hex. PMC-FSMR 1b. ;
: PMC-FSPR. ." PMC-FSPR () $" PMC-FSPR @ hex. PMC-FSPR 1b. ;
: PMC-FOCR. ." PMC-FOCR (write-only) $" PMC-FOCR @ hex. PMC-FOCR 1b. ;
: PMC-WPMR. ." PMC-WPMR () $" PMC-WPMR @ hex. PMC-WPMR 1b. ;
: PMC-WPSR. ." PMC-WPSR (read-only) $" PMC-WPSR @ hex. PMC-WPSR 1b. ;
: PMC-PCER1. ." PMC-PCER1 (write-only) $" PMC-PCER1 @ hex. PMC-PCER1 1b. ;
: PMC-PCDR1. ." PMC-PCDR1 (write-only) $" PMC-PCDR1 @ hex. PMC-PCDR1 1b. ;
: PMC-PCSR1. ." PMC-PCSR1 (read-only) $" PMC-PCSR1 @ hex. PMC-PCSR1 1b. ;
: PMC-PCR. ." PMC-PCR () $" PMC-PCR @ hex. PMC-PCR 1b. ;
: PMC-OCR. ." PMC-OCR () $" PMC-OCR @ hex. PMC-OCR 1b. ;
: PMC-SLPWK_ER0. ." PMC-SLPWK_ER0 (write-only) $" PMC-SLPWK_ER0 @ hex. PMC-SLPWK_ER0 1b. ;
: PMC-SLPWK_DR0. ." PMC-SLPWK_DR0 (write-only) $" PMC-SLPWK_DR0 @ hex. PMC-SLPWK_DR0 1b. ;
: PMC-SLPWK_SR0. ." PMC-SLPWK_SR0 (read-only) $" PMC-SLPWK_SR0 @ hex. PMC-SLPWK_SR0 1b. ;
: PMC-SLPWK_ASR0. ." PMC-SLPWK_ASR0 (read-only) $" PMC-SLPWK_ASR0 @ hex. PMC-SLPWK_ASR0 1b. ;
: PMC-PMMR. ." PMC-PMMR () $" PMC-PMMR @ hex. PMC-PMMR 1b. ;
: PMC-SLPWK_ER1. ." PMC-SLPWK_ER1 (write-only) $" PMC-SLPWK_ER1 @ hex. PMC-SLPWK_ER1 1b. ;
: PMC-SLPWK_DR1. ." PMC-SLPWK_DR1 (write-only) $" PMC-SLPWK_DR1 @ hex. PMC-SLPWK_DR1 1b. ;
: PMC-SLPWK_SR1. ." PMC-SLPWK_SR1 (read-only) $" PMC-SLPWK_SR1 @ hex. PMC-SLPWK_SR1 1b. ;
: PMC-SLPWK_ASR1. ." PMC-SLPWK_ASR1 (read-only) $" PMC-SLPWK_ASR1 @ hex. PMC-SLPWK_ASR1 1b. ;
: PMC-SLPWK_AIPR. ." PMC-SLPWK_AIPR (read-only) $" PMC-SLPWK_AIPR @ hex. PMC-SLPWK_AIPR 1b. ;
: PMC.
PMC-SCER.
PMC-SCDR.
PMC-SCSR.
PMC-PCER0.
PMC-PCDR0.
PMC-PCSR0.
PMC-CKGR_UCKR.
PMC-CKGR_MOR.
PMC-CKGR_MCFR.
PMC-CKGR_PLLAR.
PMC-MCKR.
PMC-USB.
PMC-PCK[%s].
PMC-IER.
PMC-IDR.
PMC-SR.
PMC-IMR.
PMC-FSMR.
PMC-FSPR.
PMC-FOCR.
PMC-WPMR.
PMC-WPSR.
PMC-PCER1.
PMC-PCDR1.
PMC-PCSR1.
PMC-PCR.
PMC-OCR.
PMC-SLPWK_ER0.
PMC-SLPWK_DR0.
PMC-SLPWK_SR0.
PMC-SLPWK_ASR0.
PMC-PMMR.
PMC-SLPWK_ER1.
PMC-SLPWK_DR1.
PMC-SLPWK_SR1.
PMC-SLPWK_ASR1.
PMC-SLPWK_AIPR.
;

$40020000 constant PWM0 ( Pulse Width Modulation Controller )
PWM0 $00 + constant PWM0-CLK ( PWM Clock Register )
PWM0 $04 + constant PWM0-ENA ( PWM Enable Register )
PWM0 $08 + constant PWM0-DIS ( PWM Disable Register )
PWM0 $0C + constant PWM0-SR ( PWM Status Register )
PWM0 $10 + constant PWM0-IER1 ( PWM Interrupt Enable Register 1 )
PWM0 $14 + constant PWM0-IDR1 ( PWM Interrupt Disable Register 1 )
PWM0 $18 + constant PWM0-IMR1 ( PWM Interrupt Mask Register 1 )
PWM0 $1C + constant PWM0-ISR1 ( PWM Interrupt Status Register 1 )
PWM0 $20 + constant PWM0-SCM ( PWM Sync Channels Mode Register )
PWM0 $24 + constant PWM0-DMAR ( PWM DMA Register )
PWM0 $28 + constant PWM0-SCUC ( PWM Sync Channels Update Control Register )
PWM0 $2C + constant PWM0-SCUP ( PWM Sync Channels Update Period Register )
PWM0 $30 + constant PWM0-SCUPUPD ( PWM Sync Channels Update Period Update Register )
PWM0 $34 + constant PWM0-IER2 ( PWM Interrupt Enable Register 2 )
PWM0 $38 + constant PWM0-IDR2 ( PWM Interrupt Disable Register 2 )
PWM0 $3C + constant PWM0-IMR2 ( PWM Interrupt Mask Register 2 )
PWM0 $40 + constant PWM0-ISR2 ( PWM Interrupt Status Register 2 )
PWM0 $44 + constant PWM0-OOV ( PWM Output Override Value Register )
PWM0 $48 + constant PWM0-OS ( PWM Output Selection Register )
PWM0 $4C + constant PWM0-OSS ( PWM Output Selection Set Register )
PWM0 $50 + constant PWM0-OSC ( PWM Output Selection Clear Register )
PWM0 $54 + constant PWM0-OSSUPD ( PWM Output Selection Set Update Register )
PWM0 $58 + constant PWM0-OSCUPD ( PWM Output Selection Clear Update Register )
PWM0 $5C + constant PWM0-FMR ( PWM Fault Mode Register )
PWM0 $60 + constant PWM0-FSR ( PWM Fault Status Register )
PWM0 $64 + constant PWM0-FCR ( PWM Fault Clear Register )
PWM0 $68 + constant PWM0-FPV1 ( PWM Fault Protection Value Register 1 )
PWM0 $6C + constant PWM0-FPE ( PWM Fault Protection Enable Register )
PWM0 $7C + constant PWM0-ELMR[%s] ( PWM Event Line 0 Mode Register 0 )
PWM0 $A0 + constant PWM0-SSPR ( PWM Spread Spectrum Register )
PWM0 $A4 + constant PWM0-SSPUP ( PWM Spread Spectrum Update Register )
PWM0 $B0 + constant PWM0-SMMR ( PWM Stepper Motor Mode Register )
PWM0 $C0 + constant PWM0-FPV2 ( PWM Fault Protection Value 2 Register )
PWM0 $E4 + constant PWM0-WPCR ( PWM Write Protection Control Register )
PWM0 $E8 + constant PWM0-WPSR ( PWM Write Protection Status Register )
PWM0 $400 + constant PWM0-CMUPD0 ( PWM Channel Mode Update Register ch_num = 0 )
PWM0 $420 + constant PWM0-CMUPD1 ( PWM Channel Mode Update Register ch_num = 1 )
PWM0 $42C + constant PWM0-ETRG1 ( PWM External Trigger Register trg_num = 1 )
PWM0 $430 + constant PWM0-LEBR1 ( PWM Leading-Edge Blanking Register trg_num = 1 )
PWM0 $440 + constant PWM0-CMUPD2 ( PWM Channel Mode Update Register ch_num = 2 )
PWM0 $44C + constant PWM0-ETRG2 ( PWM External Trigger Register trg_num = 2 )
PWM0 $450 + constant PWM0-LEBR2 ( PWM Leading-Edge Blanking Register trg_num = 2 )
PWM0 $460 + constant PWM0-CMUPD3 ( PWM Channel Mode Update Register ch_num = 3 )
: PWM0-CLK. ." PWM0-CLK () $" PWM0-CLK @ hex. PWM0-CLK 1b. ;
: PWM0-ENA. ." PWM0-ENA (write-only) $" PWM0-ENA @ hex. PWM0-ENA 1b. ;
: PWM0-DIS. ." PWM0-DIS (write-only) $" PWM0-DIS @ hex. PWM0-DIS 1b. ;
: PWM0-SR. ." PWM0-SR (read-only) $" PWM0-SR @ hex. PWM0-SR 1b. ;
: PWM0-IER1. ." PWM0-IER1 (write-only) $" PWM0-IER1 @ hex. PWM0-IER1 1b. ;
: PWM0-IDR1. ." PWM0-IDR1 (write-only) $" PWM0-IDR1 @ hex. PWM0-IDR1 1b. ;
: PWM0-IMR1. ." PWM0-IMR1 (read-only) $" PWM0-IMR1 @ hex. PWM0-IMR1 1b. ;
: PWM0-ISR1. ." PWM0-ISR1 (read-only) $" PWM0-ISR1 @ hex. PWM0-ISR1 1b. ;
: PWM0-SCM. ." PWM0-SCM () $" PWM0-SCM @ hex. PWM0-SCM 1b. ;
: PWM0-DMAR. ." PWM0-DMAR (write-only) $" PWM0-DMAR @ hex. PWM0-DMAR 1b. ;
: PWM0-SCUC. ." PWM0-SCUC () $" PWM0-SCUC @ hex. PWM0-SCUC 1b. ;
: PWM0-SCUP. ." PWM0-SCUP () $" PWM0-SCUP @ hex. PWM0-SCUP 1b. ;
: PWM0-SCUPUPD. ." PWM0-SCUPUPD (write-only) $" PWM0-SCUPUPD @ hex. PWM0-SCUPUPD 1b. ;
: PWM0-IER2. ." PWM0-IER2 (write-only) $" PWM0-IER2 @ hex. PWM0-IER2 1b. ;
: PWM0-IDR2. ." PWM0-IDR2 (write-only) $" PWM0-IDR2 @ hex. PWM0-IDR2 1b. ;
: PWM0-IMR2. ." PWM0-IMR2 (read-only) $" PWM0-IMR2 @ hex. PWM0-IMR2 1b. ;
: PWM0-ISR2. ." PWM0-ISR2 (read-only) $" PWM0-ISR2 @ hex. PWM0-ISR2 1b. ;
: PWM0-OOV. ." PWM0-OOV () $" PWM0-OOV @ hex. PWM0-OOV 1b. ;
: PWM0-OS. ." PWM0-OS () $" PWM0-OS @ hex. PWM0-OS 1b. ;
: PWM0-OSS. ." PWM0-OSS (write-only) $" PWM0-OSS @ hex. PWM0-OSS 1b. ;
: PWM0-OSC. ." PWM0-OSC (write-only) $" PWM0-OSC @ hex. PWM0-OSC 1b. ;
: PWM0-OSSUPD. ." PWM0-OSSUPD (write-only) $" PWM0-OSSUPD @ hex. PWM0-OSSUPD 1b. ;
: PWM0-OSCUPD. ." PWM0-OSCUPD (write-only) $" PWM0-OSCUPD @ hex. PWM0-OSCUPD 1b. ;
: PWM0-FMR. ." PWM0-FMR () $" PWM0-FMR @ hex. PWM0-FMR 1b. ;
: PWM0-FSR. ." PWM0-FSR (read-only) $" PWM0-FSR @ hex. PWM0-FSR 1b. ;
: PWM0-FCR. ." PWM0-FCR (write-only) $" PWM0-FCR @ hex. PWM0-FCR 1b. ;
: PWM0-FPV1. ." PWM0-FPV1 () $" PWM0-FPV1 @ hex. PWM0-FPV1 1b. ;
: PWM0-FPE. ." PWM0-FPE () $" PWM0-FPE @ hex. PWM0-FPE 1b. ;
: PWM0-ELMR[%s]. ." PWM0-ELMR[%s] () $" PWM0-ELMR[%s] @ hex. PWM0-ELMR[%s] 1b. ;
: PWM0-SSPR. ." PWM0-SSPR () $" PWM0-SSPR @ hex. PWM0-SSPR 1b. ;
: PWM0-SSPUP. ." PWM0-SSPUP (write-only) $" PWM0-SSPUP @ hex. PWM0-SSPUP 1b. ;
: PWM0-SMMR. ." PWM0-SMMR () $" PWM0-SMMR @ hex. PWM0-SMMR 1b. ;
: PWM0-FPV2. ." PWM0-FPV2 () $" PWM0-FPV2 @ hex. PWM0-FPV2 1b. ;
: PWM0-WPCR. ." PWM0-WPCR (write-only) $" PWM0-WPCR @ hex. PWM0-WPCR 1b. ;
: PWM0-WPSR. ." PWM0-WPSR (read-only) $" PWM0-WPSR @ hex. PWM0-WPSR 1b. ;
: PWM0-CMUPD0. ." PWM0-CMUPD0 (write-only) $" PWM0-CMUPD0 @ hex. PWM0-CMUPD0 1b. ;
: PWM0-CMUPD1. ." PWM0-CMUPD1 (write-only) $" PWM0-CMUPD1 @ hex. PWM0-CMUPD1 1b. ;
: PWM0-ETRG1. ." PWM0-ETRG1 () $" PWM0-ETRG1 @ hex. PWM0-ETRG1 1b. ;
: PWM0-LEBR1. ." PWM0-LEBR1 () $" PWM0-LEBR1 @ hex. PWM0-LEBR1 1b. ;
: PWM0-CMUPD2. ." PWM0-CMUPD2 (write-only) $" PWM0-CMUPD2 @ hex. PWM0-CMUPD2 1b. ;
: PWM0-ETRG2. ." PWM0-ETRG2 () $" PWM0-ETRG2 @ hex. PWM0-ETRG2 1b. ;
: PWM0-LEBR2. ." PWM0-LEBR2 () $" PWM0-LEBR2 @ hex. PWM0-LEBR2 1b. ;
: PWM0-CMUPD3. ." PWM0-CMUPD3 (write-only) $" PWM0-CMUPD3 @ hex. PWM0-CMUPD3 1b. ;
: PWM0.
PWM0-CLK.
PWM0-ENA.
PWM0-DIS.
PWM0-SR.
PWM0-IER1.
PWM0-IDR1.
PWM0-IMR1.
PWM0-ISR1.
PWM0-SCM.
PWM0-DMAR.
PWM0-SCUC.
PWM0-SCUP.
PWM0-SCUPUPD.
PWM0-IER2.
PWM0-IDR2.
PWM0-IMR2.
PWM0-ISR2.
PWM0-OOV.
PWM0-OS.
PWM0-OSS.
PWM0-OSC.
PWM0-OSSUPD.
PWM0-OSCUPD.
PWM0-FMR.
PWM0-FSR.
PWM0-FCR.
PWM0-FPV1.
PWM0-FPE.
PWM0-ELMR[%s].
PWM0-SSPR.
PWM0-SSPUP.
PWM0-SMMR.
PWM0-FPV2.
PWM0-WPCR.
PWM0-WPSR.
PWM0-CMUPD0.
PWM0-CMUPD1.
PWM0-ETRG1.
PWM0-LEBR1.
PWM0-CMUPD2.
PWM0-ETRG2.
PWM0-LEBR2.
PWM0-CMUPD3.
;

$4005C000 constant PWM1 ( Pulse Width Modulation Controller )
PWM1 $00 + constant PWM1-CLK ( PWM Clock Register )
PWM1 $04 + constant PWM1-ENA ( PWM Enable Register )
PWM1 $08 + constant PWM1-DIS ( PWM Disable Register )
PWM1 $0C + constant PWM1-SR ( PWM Status Register )
PWM1 $10 + constant PWM1-IER1 ( PWM Interrupt Enable Register 1 )
PWM1 $14 + constant PWM1-IDR1 ( PWM Interrupt Disable Register 1 )
PWM1 $18 + constant PWM1-IMR1 ( PWM Interrupt Mask Register 1 )
PWM1 $1C + constant PWM1-ISR1 ( PWM Interrupt Status Register 1 )
PWM1 $20 + constant PWM1-SCM ( PWM Sync Channels Mode Register )
PWM1 $24 + constant PWM1-DMAR ( PWM DMA Register )
PWM1 $28 + constant PWM1-SCUC ( PWM Sync Channels Update Control Register )
PWM1 $2C + constant PWM1-SCUP ( PWM Sync Channels Update Period Register )
PWM1 $30 + constant PWM1-SCUPUPD ( PWM Sync Channels Update Period Update Register )
PWM1 $34 + constant PWM1-IER2 ( PWM Interrupt Enable Register 2 )
PWM1 $38 + constant PWM1-IDR2 ( PWM Interrupt Disable Register 2 )
PWM1 $3C + constant PWM1-IMR2 ( PWM Interrupt Mask Register 2 )
PWM1 $40 + constant PWM1-ISR2 ( PWM Interrupt Status Register 2 )
PWM1 $44 + constant PWM1-OOV ( PWM Output Override Value Register )
PWM1 $48 + constant PWM1-OS ( PWM Output Selection Register )
PWM1 $4C + constant PWM1-OSS ( PWM Output Selection Set Register )
PWM1 $50 + constant PWM1-OSC ( PWM Output Selection Clear Register )
PWM1 $54 + constant PWM1-OSSUPD ( PWM Output Selection Set Update Register )
PWM1 $58 + constant PWM1-OSCUPD ( PWM Output Selection Clear Update Register )
PWM1 $5C + constant PWM1-FMR ( PWM Fault Mode Register )
PWM1 $60 + constant PWM1-FSR ( PWM Fault Status Register )
PWM1 $64 + constant PWM1-FCR ( PWM Fault Clear Register )
PWM1 $68 + constant PWM1-FPV1 ( PWM Fault Protection Value Register 1 )
PWM1 $6C + constant PWM1-FPE ( PWM Fault Protection Enable Register )
PWM1 $7C + constant PWM1-ELMR[%s] ( PWM Event Line 0 Mode Register 0 )
PWM1 $A0 + constant PWM1-SSPR ( PWM Spread Spectrum Register )
PWM1 $A4 + constant PWM1-SSPUP ( PWM Spread Spectrum Update Register )
PWM1 $B0 + constant PWM1-SMMR ( PWM Stepper Motor Mode Register )
PWM1 $C0 + constant PWM1-FPV2 ( PWM Fault Protection Value 2 Register )
PWM1 $E4 + constant PWM1-WPCR ( PWM Write Protection Control Register )
PWM1 $E8 + constant PWM1-WPSR ( PWM Write Protection Status Register )
PWM1 $400 + constant PWM1-CMUPD0 ( PWM Channel Mode Update Register ch_num = 0 )
PWM1 $420 + constant PWM1-CMUPD1 ( PWM Channel Mode Update Register ch_num = 1 )
PWM1 $42C + constant PWM1-ETRG1 ( PWM External Trigger Register trg_num = 1 )
PWM1 $430 + constant PWM1-LEBR1 ( PWM Leading-Edge Blanking Register trg_num = 1 )
PWM1 $440 + constant PWM1-CMUPD2 ( PWM Channel Mode Update Register ch_num = 2 )
PWM1 $44C + constant PWM1-ETRG2 ( PWM External Trigger Register trg_num = 2 )
PWM1 $450 + constant PWM1-LEBR2 ( PWM Leading-Edge Blanking Register trg_num = 2 )
PWM1 $460 + constant PWM1-CMUPD3 ( PWM Channel Mode Update Register ch_num = 3 )
: PWM1-CLK. ." PWM1-CLK () $" PWM1-CLK @ hex. PWM1-CLK 1b. ;
: PWM1-ENA. ." PWM1-ENA (write-only) $" PWM1-ENA @ hex. PWM1-ENA 1b. ;
: PWM1-DIS. ." PWM1-DIS (write-only) $" PWM1-DIS @ hex. PWM1-DIS 1b. ;
: PWM1-SR. ." PWM1-SR (read-only) $" PWM1-SR @ hex. PWM1-SR 1b. ;
: PWM1-IER1. ." PWM1-IER1 (write-only) $" PWM1-IER1 @ hex. PWM1-IER1 1b. ;
: PWM1-IDR1. ." PWM1-IDR1 (write-only) $" PWM1-IDR1 @ hex. PWM1-IDR1 1b. ;
: PWM1-IMR1. ." PWM1-IMR1 (read-only) $" PWM1-IMR1 @ hex. PWM1-IMR1 1b. ;
: PWM1-ISR1. ." PWM1-ISR1 (read-only) $" PWM1-ISR1 @ hex. PWM1-ISR1 1b. ;
: PWM1-SCM. ." PWM1-SCM () $" PWM1-SCM @ hex. PWM1-SCM 1b. ;
: PWM1-DMAR. ." PWM1-DMAR (write-only) $" PWM1-DMAR @ hex. PWM1-DMAR 1b. ;
: PWM1-SCUC. ." PWM1-SCUC () $" PWM1-SCUC @ hex. PWM1-SCUC 1b. ;
: PWM1-SCUP. ." PWM1-SCUP () $" PWM1-SCUP @ hex. PWM1-SCUP 1b. ;
: PWM1-SCUPUPD. ." PWM1-SCUPUPD (write-only) $" PWM1-SCUPUPD @ hex. PWM1-SCUPUPD 1b. ;
: PWM1-IER2. ." PWM1-IER2 (write-only) $" PWM1-IER2 @ hex. PWM1-IER2 1b. ;
: PWM1-IDR2. ." PWM1-IDR2 (write-only) $" PWM1-IDR2 @ hex. PWM1-IDR2 1b. ;
: PWM1-IMR2. ." PWM1-IMR2 (read-only) $" PWM1-IMR2 @ hex. PWM1-IMR2 1b. ;
: PWM1-ISR2. ." PWM1-ISR2 (read-only) $" PWM1-ISR2 @ hex. PWM1-ISR2 1b. ;
: PWM1-OOV. ." PWM1-OOV () $" PWM1-OOV @ hex. PWM1-OOV 1b. ;
: PWM1-OS. ." PWM1-OS () $" PWM1-OS @ hex. PWM1-OS 1b. ;
: PWM1-OSS. ." PWM1-OSS (write-only) $" PWM1-OSS @ hex. PWM1-OSS 1b. ;
: PWM1-OSC. ." PWM1-OSC (write-only) $" PWM1-OSC @ hex. PWM1-OSC 1b. ;
: PWM1-OSSUPD. ." PWM1-OSSUPD (write-only) $" PWM1-OSSUPD @ hex. PWM1-OSSUPD 1b. ;
: PWM1-OSCUPD. ." PWM1-OSCUPD (write-only) $" PWM1-OSCUPD @ hex. PWM1-OSCUPD 1b. ;
: PWM1-FMR. ." PWM1-FMR () $" PWM1-FMR @ hex. PWM1-FMR 1b. ;
: PWM1-FSR. ." PWM1-FSR (read-only) $" PWM1-FSR @ hex. PWM1-FSR 1b. ;
: PWM1-FCR. ." PWM1-FCR (write-only) $" PWM1-FCR @ hex. PWM1-FCR 1b. ;
: PWM1-FPV1. ." PWM1-FPV1 () $" PWM1-FPV1 @ hex. PWM1-FPV1 1b. ;
: PWM1-FPE. ." PWM1-FPE () $" PWM1-FPE @ hex. PWM1-FPE 1b. ;
: PWM1-ELMR[%s]. ." PWM1-ELMR[%s] () $" PWM1-ELMR[%s] @ hex. PWM1-ELMR[%s] 1b. ;
: PWM1-SSPR. ." PWM1-SSPR () $" PWM1-SSPR @ hex. PWM1-SSPR 1b. ;
: PWM1-SSPUP. ." PWM1-SSPUP (write-only) $" PWM1-SSPUP @ hex. PWM1-SSPUP 1b. ;
: PWM1-SMMR. ." PWM1-SMMR () $" PWM1-SMMR @ hex. PWM1-SMMR 1b. ;
: PWM1-FPV2. ." PWM1-FPV2 () $" PWM1-FPV2 @ hex. PWM1-FPV2 1b. ;
: PWM1-WPCR. ." PWM1-WPCR (write-only) $" PWM1-WPCR @ hex. PWM1-WPCR 1b. ;
: PWM1-WPSR. ." PWM1-WPSR (read-only) $" PWM1-WPSR @ hex. PWM1-WPSR 1b. ;
: PWM1-CMUPD0. ." PWM1-CMUPD0 (write-only) $" PWM1-CMUPD0 @ hex. PWM1-CMUPD0 1b. ;
: PWM1-CMUPD1. ." PWM1-CMUPD1 (write-only) $" PWM1-CMUPD1 @ hex. PWM1-CMUPD1 1b. ;
: PWM1-ETRG1. ." PWM1-ETRG1 () $" PWM1-ETRG1 @ hex. PWM1-ETRG1 1b. ;
: PWM1-LEBR1. ." PWM1-LEBR1 () $" PWM1-LEBR1 @ hex. PWM1-LEBR1 1b. ;
: PWM1-CMUPD2. ." PWM1-CMUPD2 (write-only) $" PWM1-CMUPD2 @ hex. PWM1-CMUPD2 1b. ;
: PWM1-ETRG2. ." PWM1-ETRG2 () $" PWM1-ETRG2 @ hex. PWM1-ETRG2 1b. ;
: PWM1-LEBR2. ." PWM1-LEBR2 () $" PWM1-LEBR2 @ hex. PWM1-LEBR2 1b. ;
: PWM1-CMUPD3. ." PWM1-CMUPD3 (write-only) $" PWM1-CMUPD3 @ hex. PWM1-CMUPD3 1b. ;
: PWM1.
PWM1-CLK.
PWM1-ENA.
PWM1-DIS.
PWM1-SR.
PWM1-IER1.
PWM1-IDR1.
PWM1-IMR1.
PWM1-ISR1.
PWM1-SCM.
PWM1-DMAR.
PWM1-SCUC.
PWM1-SCUP.
PWM1-SCUPUPD.
PWM1-IER2.
PWM1-IDR2.
PWM1-IMR2.
PWM1-ISR2.
PWM1-OOV.
PWM1-OS.
PWM1-OSS.
PWM1-OSC.
PWM1-OSSUPD.
PWM1-OSCUPD.
PWM1-FMR.
PWM1-FSR.
PWM1-FCR.
PWM1-FPV1.
PWM1-FPE.
PWM1-ELMR[%s].
PWM1-SSPR.
PWM1-SSPUP.
PWM1-SMMR.
PWM1-FPV2.
PWM1-WPCR.
PWM1-WPSR.
PWM1-CMUPD0.
PWM1-CMUPD1.
PWM1-ETRG1.
PWM1-LEBR1.
PWM1-CMUPD2.
PWM1-ETRG2.
PWM1-LEBR2.
PWM1-CMUPD3.
;

$4007C000 constant QSPI ( Quad Serial Peripheral Interface )
QSPI $00 + constant QSPI-CR ( Control Register )
QSPI $04 + constant QSPI-MR ( Mode Register )
QSPI $08 + constant QSPI-RDR ( Receive Data Register )
QSPI $0C + constant QSPI-TDR ( Transmit Data Register )
QSPI $10 + constant QSPI-SR ( Status Register )
QSPI $14 + constant QSPI-IER ( Interrupt Enable Register )
QSPI $18 + constant QSPI-IDR ( Interrupt Disable Register )
QSPI $1C + constant QSPI-IMR ( Interrupt Mask Register )
QSPI $20 + constant QSPI-SCR ( Serial Clock Register )
QSPI $30 + constant QSPI-IAR ( Instruction Address Register )
QSPI $34 + constant QSPI-ICR ( Instruction Code Register )
QSPI $38 + constant QSPI-IFR ( Instruction Frame Register )
QSPI $40 + constant QSPI-SMR ( Scrambling Mode Register )
QSPI $44 + constant QSPI-SKR ( Scrambling Key Register )
QSPI $E4 + constant QSPI-WPMR ( Write Protection Mode Register )
QSPI $E8 + constant QSPI-WPSR ( Write Protection Status Register )
: QSPI-CR. ." QSPI-CR (write-only) $" QSPI-CR @ hex. QSPI-CR 1b. ;
: QSPI-MR. ." QSPI-MR () $" QSPI-MR @ hex. QSPI-MR 1b. ;
: QSPI-RDR. ." QSPI-RDR (read-only) $" QSPI-RDR @ hex. QSPI-RDR 1b. ;
: QSPI-TDR. ." QSPI-TDR (write-only) $" QSPI-TDR @ hex. QSPI-TDR 1b. ;
: QSPI-SR. ." QSPI-SR (read-only) $" QSPI-SR @ hex. QSPI-SR 1b. ;
: QSPI-IER. ." QSPI-IER (write-only) $" QSPI-IER @ hex. QSPI-IER 1b. ;
: QSPI-IDR. ." QSPI-IDR (write-only) $" QSPI-IDR @ hex. QSPI-IDR 1b. ;
: QSPI-IMR. ." QSPI-IMR (read-only) $" QSPI-IMR @ hex. QSPI-IMR 1b. ;
: QSPI-SCR. ." QSPI-SCR () $" QSPI-SCR @ hex. QSPI-SCR 1b. ;
: QSPI-IAR. ." QSPI-IAR () $" QSPI-IAR @ hex. QSPI-IAR 1b. ;
: QSPI-ICR. ." QSPI-ICR () $" QSPI-ICR @ hex. QSPI-ICR 1b. ;
: QSPI-IFR. ." QSPI-IFR () $" QSPI-IFR @ hex. QSPI-IFR 1b. ;
: QSPI-SMR. ." QSPI-SMR () $" QSPI-SMR @ hex. QSPI-SMR 1b. ;
: QSPI-SKR. ." QSPI-SKR (write-only) $" QSPI-SKR @ hex. QSPI-SKR 1b. ;
: QSPI-WPMR. ." QSPI-WPMR () $" QSPI-WPMR @ hex. QSPI-WPMR 1b. ;
: QSPI-WPSR. ." QSPI-WPSR (read-only) $" QSPI-WPSR @ hex. QSPI-WPSR 1b. ;
: QSPI.
QSPI-CR.
QSPI-MR.
QSPI-RDR.
QSPI-TDR.
QSPI-SR.
QSPI-IER.
QSPI-IDR.
QSPI-IMR.
QSPI-SCR.
QSPI-IAR.
QSPI-ICR.
QSPI-IFR.
QSPI-SMR.
QSPI-SKR.
QSPI-WPMR.
QSPI-WPSR.
;

$400E1800 constant RSTC ( Reset Controller )
RSTC $00 + constant RSTC-CR ( Control Register )
RSTC $04 + constant RSTC-SR ( Status Register )
RSTC $08 + constant RSTC-MR ( Mode Register )
: RSTC-CR. ." RSTC-CR (write-only) $" RSTC-CR @ hex. RSTC-CR 1b. ;
: RSTC-SR. ." RSTC-SR (read-only) $" RSTC-SR @ hex. RSTC-SR 1b. ;
: RSTC-MR. ." RSTC-MR () $" RSTC-MR @ hex. RSTC-MR 1b. ;
: RSTC.
RSTC-CR.
RSTC-SR.
RSTC-MR.
;

$400E1900 constant RSWDT ( Reinforced Safety Watchdog Timer )
RSWDT $00 + constant RSWDT-CR ( Control Register )
RSWDT $04 + constant RSWDT-MR ( Mode Register )
RSWDT $08 + constant RSWDT-SR ( Status Register )
: RSWDT-CR. ." RSWDT-CR (write-only) $" RSWDT-CR @ hex. RSWDT-CR 1b. ;
: RSWDT-MR. ." RSWDT-MR () $" RSWDT-MR @ hex. RSWDT-MR 1b. ;
: RSWDT-SR. ." RSWDT-SR (read-only) $" RSWDT-SR @ hex. RSWDT-SR 1b. ;
: RSWDT.
RSWDT-CR.
RSWDT-MR.
RSWDT-SR.
;

$400E1860 constant RTC ( Real-time Clock )
RTC $00 + constant RTC-CR ( Control Register )
RTC $04 + constant RTC-MR ( Mode Register )
RTC $08 + constant RTC-TIMR ( Time Register )
RTC $0C + constant RTC-CALR ( Calendar Register )
RTC $10 + constant RTC-TIMALR ( Time Alarm Register )
RTC $14 + constant RTC-CALALR ( Calendar Alarm Register )
RTC $18 + constant RTC-SR ( Status Register )
RTC $1C + constant RTC-SCCR ( Status Clear Command Register )
RTC $20 + constant RTC-IER ( Interrupt Enable Register )
RTC $24 + constant RTC-IDR ( Interrupt Disable Register )
RTC $28 + constant RTC-IMR ( Interrupt Mask Register )
RTC $2C + constant RTC-VER ( Valid Entry Register )
: RTC-CR. ." RTC-CR () $" RTC-CR @ hex. RTC-CR 1b. ;
: RTC-MR. ." RTC-MR () $" RTC-MR @ hex. RTC-MR 1b. ;
: RTC-TIMR. ." RTC-TIMR () $" RTC-TIMR @ hex. RTC-TIMR 1b. ;
: RTC-CALR. ." RTC-CALR () $" RTC-CALR @ hex. RTC-CALR 1b. ;
: RTC-TIMALR. ." RTC-TIMALR () $" RTC-TIMALR @ hex. RTC-TIMALR 1b. ;
: RTC-CALALR. ." RTC-CALALR () $" RTC-CALALR @ hex. RTC-CALALR 1b. ;
: RTC-SR. ." RTC-SR (read-only) $" RTC-SR @ hex. RTC-SR 1b. ;
: RTC-SCCR. ." RTC-SCCR (write-only) $" RTC-SCCR @ hex. RTC-SCCR 1b. ;
: RTC-IER. ." RTC-IER (write-only) $" RTC-IER @ hex. RTC-IER 1b. ;
: RTC-IDR. ." RTC-IDR (write-only) $" RTC-IDR @ hex. RTC-IDR 1b. ;
: RTC-IMR. ." RTC-IMR (read-only) $" RTC-IMR @ hex. RTC-IMR 1b. ;
: RTC-VER. ." RTC-VER (read-only) $" RTC-VER @ hex. RTC-VER 1b. ;
: RTC.
RTC-CR.
RTC-MR.
RTC-TIMR.
RTC-CALR.
RTC-TIMALR.
RTC-CALALR.
RTC-SR.
RTC-SCCR.
RTC-IER.
RTC-IDR.
RTC-IMR.
RTC-VER.
;

$400E1830 constant RTT ( Real-time Timer )
RTT $00 + constant RTT-MR ( Mode Register )
RTT $04 + constant RTT-AR ( Alarm Register )
RTT $08 + constant RTT-VR ( Value Register )
RTT $0C + constant RTT-SR ( Status Register )
: RTT-MR. ." RTT-MR () $" RTT-MR @ hex. RTT-MR 1b. ;
: RTT-AR. ." RTT-AR () $" RTT-AR @ hex. RTT-AR 1b. ;
: RTT-VR. ." RTT-VR (read-only) $" RTT-VR @ hex. RTT-VR 1b. ;
: RTT-SR. ." RTT-SR (read-only) $" RTT-SR @ hex. RTT-SR 1b. ;
: RTT.
RTT-MR.
RTT-AR.
RTT-VR.
RTT-SR.
;

$40008000 constant SPI0 ( Serial Peripheral Interface )
SPI0 $00 + constant SPI0-CR ( Control Register )
SPI0 $04 + constant SPI0-MR ( Mode Register )
SPI0 $08 + constant SPI0-RDR ( Receive Data Register )
SPI0 $0C + constant SPI0-TDR ( Transmit Data Register )
SPI0 $10 + constant SPI0-SR ( Status Register )
SPI0 $14 + constant SPI0-IER ( Interrupt Enable Register )
SPI0 $18 + constant SPI0-IDR ( Interrupt Disable Register )
SPI0 $1C + constant SPI0-IMR ( Interrupt Mask Register )
SPI0 $30 + constant SPI0-CSR[%s] ( Chip Select Register 0 )
SPI0 $E4 + constant SPI0-WPMR ( Write Protection Mode Register )
SPI0 $E8 + constant SPI0-WPSR ( Write Protection Status Register )
: SPI0-CR. ." SPI0-CR (write-only) $" SPI0-CR @ hex. SPI0-CR 1b. ;
: SPI0-MR. ." SPI0-MR () $" SPI0-MR @ hex. SPI0-MR 1b. ;
: SPI0-RDR. ." SPI0-RDR (read-only) $" SPI0-RDR @ hex. SPI0-RDR 1b. ;
: SPI0-TDR. ." SPI0-TDR (write-only) $" SPI0-TDR @ hex. SPI0-TDR 1b. ;
: SPI0-SR. ." SPI0-SR (read-only) $" SPI0-SR @ hex. SPI0-SR 1b. ;
: SPI0-IER. ." SPI0-IER (write-only) $" SPI0-IER @ hex. SPI0-IER 1b. ;
: SPI0-IDR. ." SPI0-IDR (write-only) $" SPI0-IDR @ hex. SPI0-IDR 1b. ;
: SPI0-IMR. ." SPI0-IMR (read-only) $" SPI0-IMR @ hex. SPI0-IMR 1b. ;
: SPI0-CSR[%s]. ." SPI0-CSR[%s] () $" SPI0-CSR[%s] @ hex. SPI0-CSR[%s] 1b. ;
: SPI0-WPMR. ." SPI0-WPMR () $" SPI0-WPMR @ hex. SPI0-WPMR 1b. ;
: SPI0-WPSR. ." SPI0-WPSR (read-only) $" SPI0-WPSR @ hex. SPI0-WPSR 1b. ;
: SPI0.
SPI0-CR.
SPI0-MR.
SPI0-RDR.
SPI0-TDR.
SPI0-SR.
SPI0-IER.
SPI0-IDR.
SPI0-IMR.
SPI0-CSR[%s].
SPI0-WPMR.
SPI0-WPSR.
;

$40004000 constant SSC ( Synchronous Serial Controller )
SSC $0 + constant SSC-CR ( Control Register )
SSC $4 + constant SSC-CMR ( Clock Mode Register )
SSC $10 + constant SSC-RCMR ( Receive Clock Mode Register )
SSC $14 + constant SSC-RFMR ( Receive Frame Mode Register )
SSC $18 + constant SSC-TCMR ( Transmit Clock Mode Register )
SSC $1C + constant SSC-TFMR ( Transmit Frame Mode Register )
SSC $20 + constant SSC-RHR ( Receive Holding Register )
SSC $24 + constant SSC-THR ( Transmit Holding Register )
SSC $30 + constant SSC-RSHR ( Receive Sync. Holding Register )
SSC $34 + constant SSC-TSHR ( Transmit Sync. Holding Register )
SSC $38 + constant SSC-RC0R ( Receive Compare 0 Register )
SSC $3C + constant SSC-RC1R ( Receive Compare 1 Register )
SSC $40 + constant SSC-SR ( Status Register )
SSC $44 + constant SSC-IER ( Interrupt Enable Register )
SSC $48 + constant SSC-IDR ( Interrupt Disable Register )
SSC $4C + constant SSC-IMR ( Interrupt Mask Register )
SSC $E4 + constant SSC-WPMR ( Write Protection Mode Register )
SSC $E8 + constant SSC-WPSR ( Write Protection Status Register )
: SSC-CR. ." SSC-CR (write-only) $" SSC-CR @ hex. SSC-CR 1b. ;
: SSC-CMR. ." SSC-CMR () $" SSC-CMR @ hex. SSC-CMR 1b. ;
: SSC-RCMR. ." SSC-RCMR () $" SSC-RCMR @ hex. SSC-RCMR 1b. ;
: SSC-RFMR. ." SSC-RFMR () $" SSC-RFMR @ hex. SSC-RFMR 1b. ;
: SSC-TCMR. ." SSC-TCMR () $" SSC-TCMR @ hex. SSC-TCMR 1b. ;
: SSC-TFMR. ." SSC-TFMR () $" SSC-TFMR @ hex. SSC-TFMR 1b. ;
: SSC-RHR. ." SSC-RHR (read-only) $" SSC-RHR @ hex. SSC-RHR 1b. ;
: SSC-THR. ." SSC-THR (write-only) $" SSC-THR @ hex. SSC-THR 1b. ;
: SSC-RSHR. ." SSC-RSHR (read-only) $" SSC-RSHR @ hex. SSC-RSHR 1b. ;
: SSC-TSHR. ." SSC-TSHR () $" SSC-TSHR @ hex. SSC-TSHR 1b. ;
: SSC-RC0R. ." SSC-RC0R () $" SSC-RC0R @ hex. SSC-RC0R 1b. ;
: SSC-RC1R. ." SSC-RC1R () $" SSC-RC1R @ hex. SSC-RC1R 1b. ;
: SSC-SR. ." SSC-SR (read-only) $" SSC-SR @ hex. SSC-SR 1b. ;
: SSC-IER. ." SSC-IER (write-only) $" SSC-IER @ hex. SSC-IER 1b. ;
: SSC-IDR. ." SSC-IDR (write-only) $" SSC-IDR @ hex. SSC-IDR 1b. ;
: SSC-IMR. ." SSC-IMR (read-only) $" SSC-IMR @ hex. SSC-IMR 1b. ;
: SSC-WPMR. ." SSC-WPMR () $" SSC-WPMR @ hex. SSC-WPMR 1b. ;
: SSC-WPSR. ." SSC-WPSR (read-only) $" SSC-WPSR @ hex. SSC-WPSR 1b. ;
: SSC.
SSC-CR.
SSC-CMR.
SSC-RCMR.
SSC-RFMR.
SSC-TCMR.
SSC-TFMR.
SSC-RHR.
SSC-THR.
SSC-RSHR.
SSC-TSHR.
SSC-RC0R.
SSC-RC1R.
SSC-SR.
SSC-IER.
SSC-IDR.
SSC-IMR.
SSC-WPMR.
SSC-WPSR.
;

$400E1810 constant SUPC ( Supply Controller )
SUPC $00 + constant SUPC-CR ( Supply Controller Control Register )
SUPC $04 + constant SUPC-SMMR ( Supply Controller Supply Monitor Mode Register )
SUPC $08 + constant SUPC-MR ( Supply Controller Mode Register )
SUPC $0C + constant SUPC-WUMR ( Supply Controller Wake-up Mode Register )
SUPC $10 + constant SUPC-WUIR ( Supply Controller Wake-up Inputs Register )
SUPC $14 + constant SUPC-SR ( Supply Controller Status Register )
: SUPC-CR. ." SUPC-CR (write-only) $" SUPC-CR @ hex. SUPC-CR 1b. ;
: SUPC-SMMR. ." SUPC-SMMR () $" SUPC-SMMR @ hex. SUPC-SMMR 1b. ;
: SUPC-MR. ." SUPC-MR () $" SUPC-MR @ hex. SUPC-MR 1b. ;
: SUPC-WUMR. ." SUPC-WUMR () $" SUPC-WUMR @ hex. SUPC-WUMR 1b. ;
: SUPC-WUIR. ." SUPC-WUIR () $" SUPC-WUIR @ hex. SUPC-WUIR 1b. ;
: SUPC-SR. ." SUPC-SR (read-only) $" SUPC-SR @ hex. SUPC-SR 1b. ;
: SUPC.
SUPC-CR.
SUPC-SMMR.
SUPC-MR.
SUPC-WUMR.
SUPC-WUIR.
SUPC-SR.
;

$4000C000 constant TC0 ( Timer Counter )
TC0 $C0 + constant TC0-BCR ( Block Control Register )
TC0 $C4 + constant TC0-BMR ( Block Mode Register )
TC0 $C8 + constant TC0-QIER ( QDEC Interrupt Enable Register )
TC0 $CC + constant TC0-QIDR ( QDEC Interrupt Disable Register )
TC0 $D0 + constant TC0-QIMR ( QDEC Interrupt Mask Register )
TC0 $D4 + constant TC0-QISR ( QDEC Interrupt Status Register )
TC0 $D8 + constant TC0-FMR ( Fault Mode Register )
TC0 $E4 + constant TC0-WPMR ( Write Protection Mode Register )
: TC0-BCR. ." TC0-BCR (write-only) $" TC0-BCR @ hex. TC0-BCR 1b. ;
: TC0-BMR. ." TC0-BMR () $" TC0-BMR @ hex. TC0-BMR 1b. ;
: TC0-QIER. ." TC0-QIER (write-only) $" TC0-QIER @ hex. TC0-QIER 1b. ;
: TC0-QIDR. ." TC0-QIDR (write-only) $" TC0-QIDR @ hex. TC0-QIDR 1b. ;
: TC0-QIMR. ." TC0-QIMR (read-only) $" TC0-QIMR @ hex. TC0-QIMR 1b. ;
: TC0-QISR. ." TC0-QISR (read-only) $" TC0-QISR @ hex. TC0-QISR 1b. ;
: TC0-FMR. ." TC0-FMR () $" TC0-FMR @ hex. TC0-FMR 1b. ;
: TC0-WPMR. ." TC0-WPMR () $" TC0-WPMR @ hex. TC0-WPMR 1b. ;
: TC0.
TC0-BCR.
TC0-BMR.
TC0-QIER.
TC0-QIDR.
TC0-QIMR.
TC0-QISR.
TC0-FMR.
TC0-WPMR.
;

$40010000 constant TC1 ( Timer Counter )
TC1 $C0 + constant TC1-BCR ( Block Control Register )
TC1 $C4 + constant TC1-BMR ( Block Mode Register )
TC1 $C8 + constant TC1-QIER ( QDEC Interrupt Enable Register )
TC1 $CC + constant TC1-QIDR ( QDEC Interrupt Disable Register )
TC1 $D0 + constant TC1-QIMR ( QDEC Interrupt Mask Register )
TC1 $D4 + constant TC1-QISR ( QDEC Interrupt Status Register )
TC1 $D8 + constant TC1-FMR ( Fault Mode Register )
TC1 $E4 + constant TC1-WPMR ( Write Protection Mode Register )
: TC1-BCR. ." TC1-BCR (write-only) $" TC1-BCR @ hex. TC1-BCR 1b. ;
: TC1-BMR. ." TC1-BMR () $" TC1-BMR @ hex. TC1-BMR 1b. ;
: TC1-QIER. ." TC1-QIER (write-only) $" TC1-QIER @ hex. TC1-QIER 1b. ;
: TC1-QIDR. ." TC1-QIDR (write-only) $" TC1-QIDR @ hex. TC1-QIDR 1b. ;
: TC1-QIMR. ." TC1-QIMR (read-only) $" TC1-QIMR @ hex. TC1-QIMR 1b. ;
: TC1-QISR. ." TC1-QISR (read-only) $" TC1-QISR @ hex. TC1-QISR 1b. ;
: TC1-FMR. ." TC1-FMR () $" TC1-FMR @ hex. TC1-FMR 1b. ;
: TC1-WPMR. ." TC1-WPMR () $" TC1-WPMR @ hex. TC1-WPMR 1b. ;
: TC1.
TC1-BCR.
TC1-BMR.
TC1-QIER.
TC1-QIDR.
TC1-QIMR.
TC1-QISR.
TC1-FMR.
TC1-WPMR.
;

$40014000 constant TC2 ( Timer Counter )
TC2 $C0 + constant TC2-BCR ( Block Control Register )
TC2 $C4 + constant TC2-BMR ( Block Mode Register )
TC2 $C8 + constant TC2-QIER ( QDEC Interrupt Enable Register )
TC2 $CC + constant TC2-QIDR ( QDEC Interrupt Disable Register )
TC2 $D0 + constant TC2-QIMR ( QDEC Interrupt Mask Register )
TC2 $D4 + constant TC2-QISR ( QDEC Interrupt Status Register )
TC2 $D8 + constant TC2-FMR ( Fault Mode Register )
TC2 $E4 + constant TC2-WPMR ( Write Protection Mode Register )
: TC2-BCR. ." TC2-BCR (write-only) $" TC2-BCR @ hex. TC2-BCR 1b. ;
: TC2-BMR. ." TC2-BMR () $" TC2-BMR @ hex. TC2-BMR 1b. ;
: TC2-QIER. ." TC2-QIER (write-only) $" TC2-QIER @ hex. TC2-QIER 1b. ;
: TC2-QIDR. ." TC2-QIDR (write-only) $" TC2-QIDR @ hex. TC2-QIDR 1b. ;
: TC2-QIMR. ." TC2-QIMR (read-only) $" TC2-QIMR @ hex. TC2-QIMR 1b. ;
: TC2-QISR. ." TC2-QISR (read-only) $" TC2-QISR @ hex. TC2-QISR 1b. ;
: TC2-FMR. ." TC2-FMR () $" TC2-FMR @ hex. TC2-FMR 1b. ;
: TC2-WPMR. ." TC2-WPMR () $" TC2-WPMR @ hex. TC2-WPMR 1b. ;
: TC2.
TC2-BCR.
TC2-BMR.
TC2-QIER.
TC2-QIDR.
TC2-QIMR.
TC2-QISR.
TC2-FMR.
TC2-WPMR.
;

$40054000 constant TC3 ( Timer Counter )
TC3 $C0 + constant TC3-BCR ( Block Control Register )
TC3 $C4 + constant TC3-BMR ( Block Mode Register )
TC3 $C8 + constant TC3-QIER ( QDEC Interrupt Enable Register )
TC3 $CC + constant TC3-QIDR ( QDEC Interrupt Disable Register )
TC3 $D0 + constant TC3-QIMR ( QDEC Interrupt Mask Register )
TC3 $D4 + constant TC3-QISR ( QDEC Interrupt Status Register )
TC3 $D8 + constant TC3-FMR ( Fault Mode Register )
TC3 $E4 + constant TC3-WPMR ( Write Protection Mode Register )
: TC3-BCR. ." TC3-BCR (write-only) $" TC3-BCR @ hex. TC3-BCR 1b. ;
: TC3-BMR. ." TC3-BMR () $" TC3-BMR @ hex. TC3-BMR 1b. ;
: TC3-QIER. ." TC3-QIER (write-only) $" TC3-QIER @ hex. TC3-QIER 1b. ;
: TC3-QIDR. ." TC3-QIDR (write-only) $" TC3-QIDR @ hex. TC3-QIDR 1b. ;
: TC3-QIMR. ." TC3-QIMR (read-only) $" TC3-QIMR @ hex. TC3-QIMR 1b. ;
: TC3-QISR. ." TC3-QISR (read-only) $" TC3-QISR @ hex. TC3-QISR 1b. ;
: TC3-FMR. ." TC3-FMR () $" TC3-FMR @ hex. TC3-FMR 1b. ;
: TC3-WPMR. ." TC3-WPMR () $" TC3-WPMR @ hex. TC3-WPMR 1b. ;
: TC3.
TC3-BCR.
TC3-BMR.
TC3-QIER.
TC3-QIDR.
TC3-QIMR.
TC3-QISR.
TC3-FMR.
TC3-WPMR.
;

$40070000 constant TRNG ( True Random Number Generator )
TRNG $00 + constant TRNG-CR ( Control Register )
TRNG $10 + constant TRNG-IER ( Interrupt Enable Register )
TRNG $14 + constant TRNG-IDR ( Interrupt Disable Register )
TRNG $18 + constant TRNG-IMR ( Interrupt Mask Register )
TRNG $1C + constant TRNG-ISR ( Interrupt Status Register )
TRNG $50 + constant TRNG-ODATA ( Output Data Register )
: TRNG-CR. ." TRNG-CR (write-only) $" TRNG-CR @ hex. TRNG-CR 1b. ;
: TRNG-IER. ." TRNG-IER (write-only) $" TRNG-IER @ hex. TRNG-IER 1b. ;
: TRNG-IDR. ." TRNG-IDR (write-only) $" TRNG-IDR @ hex. TRNG-IDR 1b. ;
: TRNG-IMR. ." TRNG-IMR (read-only) $" TRNG-IMR @ hex. TRNG-IMR 1b. ;
: TRNG-ISR. ." TRNG-ISR (read-only) $" TRNG-ISR @ hex. TRNG-ISR 1b. ;
: TRNG-ODATA. ." TRNG-ODATA (read-only) $" TRNG-ODATA @ hex. TRNG-ODATA 1b. ;
: TRNG.
TRNG-CR.
TRNG-IER.
TRNG-IDR.
TRNG-IMR.
TRNG-ISR.
TRNG-ODATA.
;

$40018000 constant TWIHS0 ( Two-wire Interface High Speed )
TWIHS0 $00 + constant TWIHS0-CR ( Control Register )
TWIHS0 $04 + constant TWIHS0-MMR ( Master Mode Register )
TWIHS0 $08 + constant TWIHS0-SMR ( Slave Mode Register )
TWIHS0 $0C + constant TWIHS0-IADR ( Internal Address Register )
TWIHS0 $10 + constant TWIHS0-CWGR ( Clock Waveform Generator Register )
TWIHS0 $20 + constant TWIHS0-SR ( Status Register )
TWIHS0 $24 + constant TWIHS0-IER ( Interrupt Enable Register )
TWIHS0 $28 + constant TWIHS0-IDR ( Interrupt Disable Register )
TWIHS0 $2C + constant TWIHS0-IMR ( Interrupt Mask Register )
TWIHS0 $30 + constant TWIHS0-RHR ( Receive Holding Register )
TWIHS0 $34 + constant TWIHS0-THR ( Transmit Holding Register )
TWIHS0 $38 + constant TWIHS0-SMBTR ( SMBus Timing Register )
TWIHS0 $44 + constant TWIHS0-FILTR ( Filter Register )
TWIHS0 $4C + constant TWIHS0-SWMR ( SleepWalking Matching Register )
TWIHS0 $E4 + constant TWIHS0-WPMR ( Write Protection Mode Register )
TWIHS0 $E8 + constant TWIHS0-WPSR ( Write Protection Status Register )
: TWIHS0-CR. ." TWIHS0-CR (write-only) $" TWIHS0-CR @ hex. TWIHS0-CR 1b. ;
: TWIHS0-MMR. ." TWIHS0-MMR () $" TWIHS0-MMR @ hex. TWIHS0-MMR 1b. ;
: TWIHS0-SMR. ." TWIHS0-SMR () $" TWIHS0-SMR @ hex. TWIHS0-SMR 1b. ;
: TWIHS0-IADR. ." TWIHS0-IADR () $" TWIHS0-IADR @ hex. TWIHS0-IADR 1b. ;
: TWIHS0-CWGR. ." TWIHS0-CWGR () $" TWIHS0-CWGR @ hex. TWIHS0-CWGR 1b. ;
: TWIHS0-SR. ." TWIHS0-SR (read-only) $" TWIHS0-SR @ hex. TWIHS0-SR 1b. ;
: TWIHS0-IER. ." TWIHS0-IER (write-only) $" TWIHS0-IER @ hex. TWIHS0-IER 1b. ;
: TWIHS0-IDR. ." TWIHS0-IDR (write-only) $" TWIHS0-IDR @ hex. TWIHS0-IDR 1b. ;
: TWIHS0-IMR. ." TWIHS0-IMR (read-only) $" TWIHS0-IMR @ hex. TWIHS0-IMR 1b. ;
: TWIHS0-RHR. ." TWIHS0-RHR (read-only) $" TWIHS0-RHR @ hex. TWIHS0-RHR 1b. ;
: TWIHS0-THR. ." TWIHS0-THR (write-only) $" TWIHS0-THR @ hex. TWIHS0-THR 1b. ;
: TWIHS0-SMBTR. ." TWIHS0-SMBTR () $" TWIHS0-SMBTR @ hex. TWIHS0-SMBTR 1b. ;
: TWIHS0-FILTR. ." TWIHS0-FILTR () $" TWIHS0-FILTR @ hex. TWIHS0-FILTR 1b. ;
: TWIHS0-SWMR. ." TWIHS0-SWMR () $" TWIHS0-SWMR @ hex. TWIHS0-SWMR 1b. ;
: TWIHS0-WPMR. ." TWIHS0-WPMR () $" TWIHS0-WPMR @ hex. TWIHS0-WPMR 1b. ;
: TWIHS0-WPSR. ." TWIHS0-WPSR (read-only) $" TWIHS0-WPSR @ hex. TWIHS0-WPSR 1b. ;
: TWIHS0.
TWIHS0-CR.
TWIHS0-MMR.
TWIHS0-SMR.
TWIHS0-IADR.
TWIHS0-CWGR.
TWIHS0-SR.
TWIHS0-IER.
TWIHS0-IDR.
TWIHS0-IMR.
TWIHS0-RHR.
TWIHS0-THR.
TWIHS0-SMBTR.
TWIHS0-FILTR.
TWIHS0-SWMR.
TWIHS0-WPMR.
TWIHS0-WPSR.
;

$4001C000 constant TWIHS1 ( Two-wire Interface High Speed )
TWIHS1 $00 + constant TWIHS1-CR ( Control Register )
TWIHS1 $04 + constant TWIHS1-MMR ( Master Mode Register )
TWIHS1 $08 + constant TWIHS1-SMR ( Slave Mode Register )
TWIHS1 $0C + constant TWIHS1-IADR ( Internal Address Register )
TWIHS1 $10 + constant TWIHS1-CWGR ( Clock Waveform Generator Register )
TWIHS1 $20 + constant TWIHS1-SR ( Status Register )
TWIHS1 $24 + constant TWIHS1-IER ( Interrupt Enable Register )
TWIHS1 $28 + constant TWIHS1-IDR ( Interrupt Disable Register )
TWIHS1 $2C + constant TWIHS1-IMR ( Interrupt Mask Register )
TWIHS1 $30 + constant TWIHS1-RHR ( Receive Holding Register )
TWIHS1 $34 + constant TWIHS1-THR ( Transmit Holding Register )
TWIHS1 $38 + constant TWIHS1-SMBTR ( SMBus Timing Register )
TWIHS1 $44 + constant TWIHS1-FILTR ( Filter Register )
TWIHS1 $4C + constant TWIHS1-SWMR ( SleepWalking Matching Register )
TWIHS1 $E4 + constant TWIHS1-WPMR ( Write Protection Mode Register )
TWIHS1 $E8 + constant TWIHS1-WPSR ( Write Protection Status Register )
: TWIHS1-CR. ." TWIHS1-CR (write-only) $" TWIHS1-CR @ hex. TWIHS1-CR 1b. ;
: TWIHS1-MMR. ." TWIHS1-MMR () $" TWIHS1-MMR @ hex. TWIHS1-MMR 1b. ;
: TWIHS1-SMR. ." TWIHS1-SMR () $" TWIHS1-SMR @ hex. TWIHS1-SMR 1b. ;
: TWIHS1-IADR. ." TWIHS1-IADR () $" TWIHS1-IADR @ hex. TWIHS1-IADR 1b. ;
: TWIHS1-CWGR. ." TWIHS1-CWGR () $" TWIHS1-CWGR @ hex. TWIHS1-CWGR 1b. ;
: TWIHS1-SR. ." TWIHS1-SR (read-only) $" TWIHS1-SR @ hex. TWIHS1-SR 1b. ;
: TWIHS1-IER. ." TWIHS1-IER (write-only) $" TWIHS1-IER @ hex. TWIHS1-IER 1b. ;
: TWIHS1-IDR. ." TWIHS1-IDR (write-only) $" TWIHS1-IDR @ hex. TWIHS1-IDR 1b. ;
: TWIHS1-IMR. ." TWIHS1-IMR (read-only) $" TWIHS1-IMR @ hex. TWIHS1-IMR 1b. ;
: TWIHS1-RHR. ." TWIHS1-RHR (read-only) $" TWIHS1-RHR @ hex. TWIHS1-RHR 1b. ;
: TWIHS1-THR. ." TWIHS1-THR (write-only) $" TWIHS1-THR @ hex. TWIHS1-THR 1b. ;
: TWIHS1-SMBTR. ." TWIHS1-SMBTR () $" TWIHS1-SMBTR @ hex. TWIHS1-SMBTR 1b. ;
: TWIHS1-FILTR. ." TWIHS1-FILTR () $" TWIHS1-FILTR @ hex. TWIHS1-FILTR 1b. ;
: TWIHS1-SWMR. ." TWIHS1-SWMR () $" TWIHS1-SWMR @ hex. TWIHS1-SWMR 1b. ;
: TWIHS1-WPMR. ." TWIHS1-WPMR () $" TWIHS1-WPMR @ hex. TWIHS1-WPMR 1b. ;
: TWIHS1-WPSR. ." TWIHS1-WPSR (read-only) $" TWIHS1-WPSR @ hex. TWIHS1-WPSR 1b. ;
: TWIHS1.
TWIHS1-CR.
TWIHS1-MMR.
TWIHS1-SMR.
TWIHS1-IADR.
TWIHS1-CWGR.
TWIHS1-SR.
TWIHS1-IER.
TWIHS1-IDR.
TWIHS1-IMR.
TWIHS1-RHR.
TWIHS1-THR.
TWIHS1-SMBTR.
TWIHS1-FILTR.
TWIHS1-SWMR.
TWIHS1-WPMR.
TWIHS1-WPSR.
;

$40060000 constant TWIHS2 ( Two-wire Interface High Speed )
TWIHS2 $00 + constant TWIHS2-CR ( Control Register )
TWIHS2 $04 + constant TWIHS2-MMR ( Master Mode Register )
TWIHS2 $08 + constant TWIHS2-SMR ( Slave Mode Register )
TWIHS2 $0C + constant TWIHS2-IADR ( Internal Address Register )
TWIHS2 $10 + constant TWIHS2-CWGR ( Clock Waveform Generator Register )
TWIHS2 $20 + constant TWIHS2-SR ( Status Register )
TWIHS2 $24 + constant TWIHS2-IER ( Interrupt Enable Register )
TWIHS2 $28 + constant TWIHS2-IDR ( Interrupt Disable Register )
TWIHS2 $2C + constant TWIHS2-IMR ( Interrupt Mask Register )
TWIHS2 $30 + constant TWIHS2-RHR ( Receive Holding Register )
TWIHS2 $34 + constant TWIHS2-THR ( Transmit Holding Register )
TWIHS2 $38 + constant TWIHS2-SMBTR ( SMBus Timing Register )
TWIHS2 $44 + constant TWIHS2-FILTR ( Filter Register )
TWIHS2 $4C + constant TWIHS2-SWMR ( SleepWalking Matching Register )
TWIHS2 $E4 + constant TWIHS2-WPMR ( Write Protection Mode Register )
TWIHS2 $E8 + constant TWIHS2-WPSR ( Write Protection Status Register )
: TWIHS2-CR. ." TWIHS2-CR (write-only) $" TWIHS2-CR @ hex. TWIHS2-CR 1b. ;
: TWIHS2-MMR. ." TWIHS2-MMR () $" TWIHS2-MMR @ hex. TWIHS2-MMR 1b. ;
: TWIHS2-SMR. ." TWIHS2-SMR () $" TWIHS2-SMR @ hex. TWIHS2-SMR 1b. ;
: TWIHS2-IADR. ." TWIHS2-IADR () $" TWIHS2-IADR @ hex. TWIHS2-IADR 1b. ;
: TWIHS2-CWGR. ." TWIHS2-CWGR () $" TWIHS2-CWGR @ hex. TWIHS2-CWGR 1b. ;
: TWIHS2-SR. ." TWIHS2-SR (read-only) $" TWIHS2-SR @ hex. TWIHS2-SR 1b. ;
: TWIHS2-IER. ." TWIHS2-IER (write-only) $" TWIHS2-IER @ hex. TWIHS2-IER 1b. ;
: TWIHS2-IDR. ." TWIHS2-IDR (write-only) $" TWIHS2-IDR @ hex. TWIHS2-IDR 1b. ;
: TWIHS2-IMR. ." TWIHS2-IMR (read-only) $" TWIHS2-IMR @ hex. TWIHS2-IMR 1b. ;
: TWIHS2-RHR. ." TWIHS2-RHR (read-only) $" TWIHS2-RHR @ hex. TWIHS2-RHR 1b. ;
: TWIHS2-THR. ." TWIHS2-THR (write-only) $" TWIHS2-THR @ hex. TWIHS2-THR 1b. ;
: TWIHS2-SMBTR. ." TWIHS2-SMBTR () $" TWIHS2-SMBTR @ hex. TWIHS2-SMBTR 1b. ;
: TWIHS2-FILTR. ." TWIHS2-FILTR () $" TWIHS2-FILTR @ hex. TWIHS2-FILTR 1b. ;
: TWIHS2-SWMR. ." TWIHS2-SWMR () $" TWIHS2-SWMR @ hex. TWIHS2-SWMR 1b. ;
: TWIHS2-WPMR. ." TWIHS2-WPMR () $" TWIHS2-WPMR @ hex. TWIHS2-WPMR 1b. ;
: TWIHS2-WPSR. ." TWIHS2-WPSR (read-only) $" TWIHS2-WPSR @ hex. TWIHS2-WPSR 1b. ;
: TWIHS2.
TWIHS2-CR.
TWIHS2-MMR.
TWIHS2-SMR.
TWIHS2-IADR.
TWIHS2-CWGR.
TWIHS2-SR.
TWIHS2-IER.
TWIHS2-IDR.
TWIHS2-IMR.
TWIHS2-RHR.
TWIHS2-THR.
TWIHS2-SMBTR.
TWIHS2-FILTR.
TWIHS2-SWMR.
TWIHS2-WPMR.
TWIHS2-WPSR.
;

$400E0800 constant UART0 ( Universal Asynchronous Receiver Transmitter )
UART0 $0000 + constant UART0-CR ( Control Register )
UART0 $0004 + constant UART0-MR ( Mode Register )
UART0 $0008 + constant UART0-IER ( Interrupt Enable Register )
UART0 $000C + constant UART0-IDR ( Interrupt Disable Register )
UART0 $0010 + constant UART0-IMR ( Interrupt Mask Register )
UART0 $0014 + constant UART0-SR ( Status Register )
UART0 $0018 + constant UART0-RHR ( Receive Holding Register )
UART0 $001C + constant UART0-THR ( Transmit Holding Register )
UART0 $0020 + constant UART0-BRGR ( Baud Rate Generator Register )
UART0 $0024 + constant UART0-CMPR ( Comparison Register )
UART0 $00E4 + constant UART0-WPMR ( Write Protection Mode Register )
: UART0-CR. ." UART0-CR (write-only) $" UART0-CR @ hex. UART0-CR 1b. ;
: UART0-MR. ." UART0-MR () $" UART0-MR @ hex. UART0-MR 1b. ;
: UART0-IER. ." UART0-IER (write-only) $" UART0-IER @ hex. UART0-IER 1b. ;
: UART0-IDR. ." UART0-IDR (write-only) $" UART0-IDR @ hex. UART0-IDR 1b. ;
: UART0-IMR. ." UART0-IMR (read-only) $" UART0-IMR @ hex. UART0-IMR 1b. ;
: UART0-SR. ." UART0-SR (read-only) $" UART0-SR @ hex. UART0-SR 1b. ;
: UART0-RHR. ." UART0-RHR (read-only) $" UART0-RHR @ hex. UART0-RHR 1b. ;
: UART0-THR. ." UART0-THR (write-only) $" UART0-THR @ hex. UART0-THR 1b. ;
: UART0-BRGR. ." UART0-BRGR () $" UART0-BRGR @ hex. UART0-BRGR 1b. ;
: UART0-CMPR. ." UART0-CMPR () $" UART0-CMPR @ hex. UART0-CMPR 1b. ;
: UART0-WPMR. ." UART0-WPMR () $" UART0-WPMR @ hex. UART0-WPMR 1b. ;
: UART0.
UART0-CR.
UART0-MR.
UART0-IER.
UART0-IDR.
UART0-IMR.
UART0-SR.
UART0-RHR.
UART0-THR.
UART0-BRGR.
UART0-CMPR.
UART0-WPMR.
;

$400E0A00 constant UART1 ( Universal Asynchronous Receiver Transmitter )
UART1 $0000 + constant UART1-CR ( Control Register )
UART1 $0004 + constant UART1-MR ( Mode Register )
UART1 $0008 + constant UART1-IER ( Interrupt Enable Register )
UART1 $000C + constant UART1-IDR ( Interrupt Disable Register )
UART1 $0010 + constant UART1-IMR ( Interrupt Mask Register )
UART1 $0014 + constant UART1-SR ( Status Register )
UART1 $0018 + constant UART1-RHR ( Receive Holding Register )
UART1 $001C + constant UART1-THR ( Transmit Holding Register )
UART1 $0020 + constant UART1-BRGR ( Baud Rate Generator Register )
UART1 $0024 + constant UART1-CMPR ( Comparison Register )
UART1 $00E4 + constant UART1-WPMR ( Write Protection Mode Register )
: UART1-CR. ." UART1-CR (write-only) $" UART1-CR @ hex. UART1-CR 1b. ;
: UART1-MR. ." UART1-MR () $" UART1-MR @ hex. UART1-MR 1b. ;
: UART1-IER. ." UART1-IER (write-only) $" UART1-IER @ hex. UART1-IER 1b. ;
: UART1-IDR. ." UART1-IDR (write-only) $" UART1-IDR @ hex. UART1-IDR 1b. ;
: UART1-IMR. ." UART1-IMR (read-only) $" UART1-IMR @ hex. UART1-IMR 1b. ;
: UART1-SR. ." UART1-SR (read-only) $" UART1-SR @ hex. UART1-SR 1b. ;
: UART1-RHR. ." UART1-RHR (read-only) $" UART1-RHR @ hex. UART1-RHR 1b. ;
: UART1-THR. ." UART1-THR (write-only) $" UART1-THR @ hex. UART1-THR 1b. ;
: UART1-BRGR. ." UART1-BRGR () $" UART1-BRGR @ hex. UART1-BRGR 1b. ;
: UART1-CMPR. ." UART1-CMPR () $" UART1-CMPR @ hex. UART1-CMPR 1b. ;
: UART1-WPMR. ." UART1-WPMR () $" UART1-WPMR @ hex. UART1-WPMR 1b. ;
: UART1.
UART1-CR.
UART1-MR.
UART1-IER.
UART1-IDR.
UART1-IMR.
UART1-SR.
UART1-RHR.
UART1-THR.
UART1-BRGR.
UART1-CMPR.
UART1-WPMR.
;

$400E1A00 constant UART2 ( Universal Asynchronous Receiver Transmitter )
UART2 $0000 + constant UART2-CR ( Control Register )
UART2 $0004 + constant UART2-MR ( Mode Register )
UART2 $0008 + constant UART2-IER ( Interrupt Enable Register )
UART2 $000C + constant UART2-IDR ( Interrupt Disable Register )
UART2 $0010 + constant UART2-IMR ( Interrupt Mask Register )
UART2 $0014 + constant UART2-SR ( Status Register )
UART2 $0018 + constant UART2-RHR ( Receive Holding Register )
UART2 $001C + constant UART2-THR ( Transmit Holding Register )
UART2 $0020 + constant UART2-BRGR ( Baud Rate Generator Register )
UART2 $0024 + constant UART2-CMPR ( Comparison Register )
UART2 $00E4 + constant UART2-WPMR ( Write Protection Mode Register )
: UART2-CR. ." UART2-CR (write-only) $" UART2-CR @ hex. UART2-CR 1b. ;
: UART2-MR. ." UART2-MR () $" UART2-MR @ hex. UART2-MR 1b. ;
: UART2-IER. ." UART2-IER (write-only) $" UART2-IER @ hex. UART2-IER 1b. ;
: UART2-IDR. ." UART2-IDR (write-only) $" UART2-IDR @ hex. UART2-IDR 1b. ;
: UART2-IMR. ." UART2-IMR (read-only) $" UART2-IMR @ hex. UART2-IMR 1b. ;
: UART2-SR. ." UART2-SR (read-only) $" UART2-SR @ hex. UART2-SR 1b. ;
: UART2-RHR. ." UART2-RHR (read-only) $" UART2-RHR @ hex. UART2-RHR 1b. ;
: UART2-THR. ." UART2-THR (write-only) $" UART2-THR @ hex. UART2-THR 1b. ;
: UART2-BRGR. ." UART2-BRGR () $" UART2-BRGR @ hex. UART2-BRGR 1b. ;
: UART2-CMPR. ." UART2-CMPR () $" UART2-CMPR @ hex. UART2-CMPR 1b. ;
: UART2-WPMR. ." UART2-WPMR () $" UART2-WPMR @ hex. UART2-WPMR 1b. ;
: UART2.
UART2-CR.
UART2-MR.
UART2-IER.
UART2-IDR.
UART2-IMR.
UART2-SR.
UART2-RHR.
UART2-THR.
UART2-BRGR.
UART2-CMPR.
UART2-WPMR.
;

$400E1C00 constant UART3 ( Universal Asynchronous Receiver Transmitter )
UART3 $0000 + constant UART3-CR ( Control Register )
UART3 $0004 + constant UART3-MR ( Mode Register )
UART3 $0008 + constant UART3-IER ( Interrupt Enable Register )
UART3 $000C + constant UART3-IDR ( Interrupt Disable Register )
UART3 $0010 + constant UART3-IMR ( Interrupt Mask Register )
UART3 $0014 + constant UART3-SR ( Status Register )
UART3 $0018 + constant UART3-RHR ( Receive Holding Register )
UART3 $001C + constant UART3-THR ( Transmit Holding Register )
UART3 $0020 + constant UART3-BRGR ( Baud Rate Generator Register )
UART3 $0024 + constant UART3-CMPR ( Comparison Register )
UART3 $00E4 + constant UART3-WPMR ( Write Protection Mode Register )
: UART3-CR. ." UART3-CR (write-only) $" UART3-CR @ hex. UART3-CR 1b. ;
: UART3-MR. ." UART3-MR () $" UART3-MR @ hex. UART3-MR 1b. ;
: UART3-IER. ." UART3-IER (write-only) $" UART3-IER @ hex. UART3-IER 1b. ;
: UART3-IDR. ." UART3-IDR (write-only) $" UART3-IDR @ hex. UART3-IDR 1b. ;
: UART3-IMR. ." UART3-IMR (read-only) $" UART3-IMR @ hex. UART3-IMR 1b. ;
: UART3-SR. ." UART3-SR (read-only) $" UART3-SR @ hex. UART3-SR 1b. ;
: UART3-RHR. ." UART3-RHR (read-only) $" UART3-RHR @ hex. UART3-RHR 1b. ;
: UART3-THR. ." UART3-THR (write-only) $" UART3-THR @ hex. UART3-THR 1b. ;
: UART3-BRGR. ." UART3-BRGR () $" UART3-BRGR @ hex. UART3-BRGR 1b. ;
: UART3-CMPR. ." UART3-CMPR () $" UART3-CMPR @ hex. UART3-CMPR 1b. ;
: UART3-WPMR. ." UART3-WPMR () $" UART3-WPMR @ hex. UART3-WPMR 1b. ;
: UART3.
UART3-CR.
UART3-MR.
UART3-IER.
UART3-IDR.
UART3-IMR.
UART3-SR.
UART3-RHR.
UART3-THR.
UART3-BRGR.
UART3-CMPR.
UART3-WPMR.
;

$400E1E00 constant UART4 ( Universal Asynchronous Receiver Transmitter )
UART4 $0000 + constant UART4-CR ( Control Register )
UART4 $0004 + constant UART4-MR ( Mode Register )
UART4 $0008 + constant UART4-IER ( Interrupt Enable Register )
UART4 $000C + constant UART4-IDR ( Interrupt Disable Register )
UART4 $0010 + constant UART4-IMR ( Interrupt Mask Register )
UART4 $0014 + constant UART4-SR ( Status Register )
UART4 $0018 + constant UART4-RHR ( Receive Holding Register )
UART4 $001C + constant UART4-THR ( Transmit Holding Register )
UART4 $0020 + constant UART4-BRGR ( Baud Rate Generator Register )
UART4 $0024 + constant UART4-CMPR ( Comparison Register )
UART4 $00E4 + constant UART4-WPMR ( Write Protection Mode Register )
: UART4-CR. ." UART4-CR (write-only) $" UART4-CR @ hex. UART4-CR 1b. ;
: UART4-MR. ." UART4-MR () $" UART4-MR @ hex. UART4-MR 1b. ;
: UART4-IER. ." UART4-IER (write-only) $" UART4-IER @ hex. UART4-IER 1b. ;
: UART4-IDR. ." UART4-IDR (write-only) $" UART4-IDR @ hex. UART4-IDR 1b. ;
: UART4-IMR. ." UART4-IMR (read-only) $" UART4-IMR @ hex. UART4-IMR 1b. ;
: UART4-SR. ." UART4-SR (read-only) $" UART4-SR @ hex. UART4-SR 1b. ;
: UART4-RHR. ." UART4-RHR (read-only) $" UART4-RHR @ hex. UART4-RHR 1b. ;
: UART4-THR. ." UART4-THR (write-only) $" UART4-THR @ hex. UART4-THR 1b. ;
: UART4-BRGR. ." UART4-BRGR () $" UART4-BRGR @ hex. UART4-BRGR 1b. ;
: UART4-CMPR. ." UART4-CMPR () $" UART4-CMPR @ hex. UART4-CMPR 1b. ;
: UART4-WPMR. ." UART4-WPMR () $" UART4-WPMR @ hex. UART4-WPMR 1b. ;
: UART4.
UART4-CR.
UART4-MR.
UART4-IER.
UART4-IDR.
UART4-IMR.
UART4-SR.
UART4-RHR.
UART4-THR.
UART4-BRGR.
UART4-CMPR.
UART4-WPMR.
;

$40024000 constant USART0 ( Universal Synchronous Asynchronous Receiver Transmitter )
USART0 $0000 + constant USART0-US_CR ( Control Register )
USART0 $0004 + constant USART0-US_MR ( Mode Register )
USART0 $0008 + constant USART0-US_IER ( Interrupt Enable Register )
USART0 $000C + constant USART0-US_IDR ( Interrupt Disable Register )
USART0 $0010 + constant USART0-US_IMR ( Interrupt Mask Register )
USART0 $0014 + constant USART0-US_CSR ( Channel Status Register )
USART0 $0018 + constant USART0-US_RHR ( Receive Holding Register )
USART0 $001C + constant USART0-US_THR ( Transmit Holding Register )
USART0 $0020 + constant USART0-US_BRGR ( Baud Rate Generator Register )
USART0 $0024 + constant USART0-US_RTOR ( Receiver Time-out Register )
USART0 $0028 + constant USART0-US_TTGR ( Transmitter Timeguard Register )
USART0 $0040 + constant USART0-US_FIDI ( FI DI Ratio Register )
USART0 $0044 + constant USART0-US_NER ( Number of Errors Register )
USART0 $004C + constant USART0-US_IF ( IrDA Filter Register )
USART0 $0050 + constant USART0-US_MAN ( Manchester Configuration Register )
USART0 $0054 + constant USART0-US_LINMR ( LIN Mode Register )
USART0 $0058 + constant USART0-US_LINIR ( LIN Identifier Register )
USART0 $005C + constant USART0-US_LINBRR ( LIN Baud Rate Register )
USART0 $0060 + constant USART0-US_LONMR ( LON Mode Register )
USART0 $0064 + constant USART0-US_LONPR ( LON Preamble Register )
USART0 $0068 + constant USART0-US_LONDL ( LON Data Length Register )
USART0 $006C + constant USART0-US_LONL2HDR ( LON L2HDR Register )
USART0 $0070 + constant USART0-US_LONBL ( LON Backlog Register )
USART0 $0074 + constant USART0-US_LONB1TX ( LON Beta1 Tx Register )
USART0 $0078 + constant USART0-US_LONB1RX ( LON Beta1 Rx Register )
USART0 $007C + constant USART0-US_LONPRIO ( LON Priority Register )
USART0 $0080 + constant USART0-US_IDTTX ( LON IDT Tx Register )
USART0 $0084 + constant USART0-US_IDTRX ( LON IDT Rx Register )
USART0 $0088 + constant USART0-US_ICDIFF ( IC DIFF Register )
USART0 $00E4 + constant USART0-US_WPMR ( Write Protection Mode Register )
USART0 $00E8 + constant USART0-US_WPSR ( Write Protection Status Register )
: USART0-US_CR. ." USART0-US_CR (write-only) $" USART0-US_CR @ hex. USART0-US_CR 1b. ;
: USART0-US_MR. ." USART0-US_MR () $" USART0-US_MR @ hex. USART0-US_MR 1b. ;
: USART0-US_IER. ." USART0-US_IER (write-only) $" USART0-US_IER @ hex. USART0-US_IER 1b. ;
: USART0-US_IDR. ." USART0-US_IDR (write-only) $" USART0-US_IDR @ hex. USART0-US_IDR 1b. ;
: USART0-US_IMR. ." USART0-US_IMR (read-only) $" USART0-US_IMR @ hex. USART0-US_IMR 1b. ;
: USART0-US_CSR. ." USART0-US_CSR (read-only) $" USART0-US_CSR @ hex. USART0-US_CSR 1b. ;
: USART0-US_RHR. ." USART0-US_RHR (read-only) $" USART0-US_RHR @ hex. USART0-US_RHR 1b. ;
: USART0-US_THR. ." USART0-US_THR (write-only) $" USART0-US_THR @ hex. USART0-US_THR 1b. ;
: USART0-US_BRGR. ." USART0-US_BRGR () $" USART0-US_BRGR @ hex. USART0-US_BRGR 1b. ;
: USART0-US_RTOR. ." USART0-US_RTOR () $" USART0-US_RTOR @ hex. USART0-US_RTOR 1b. ;
: USART0-US_TTGR. ." USART0-US_TTGR () $" USART0-US_TTGR @ hex. USART0-US_TTGR 1b. ;
: USART0-US_FIDI. ." USART0-US_FIDI () $" USART0-US_FIDI @ hex. USART0-US_FIDI 1b. ;
: USART0-US_NER. ." USART0-US_NER (read-only) $" USART0-US_NER @ hex. USART0-US_NER 1b. ;
: USART0-US_IF. ." USART0-US_IF () $" USART0-US_IF @ hex. USART0-US_IF 1b. ;
: USART0-US_MAN. ." USART0-US_MAN () $" USART0-US_MAN @ hex. USART0-US_MAN 1b. ;
: USART0-US_LINMR. ." USART0-US_LINMR () $" USART0-US_LINMR @ hex. USART0-US_LINMR 1b. ;
: USART0-US_LINIR. ." USART0-US_LINIR () $" USART0-US_LINIR @ hex. USART0-US_LINIR 1b. ;
: USART0-US_LINBRR. ." USART0-US_LINBRR (read-only) $" USART0-US_LINBRR @ hex. USART0-US_LINBRR 1b. ;
: USART0-US_LONMR. ." USART0-US_LONMR () $" USART0-US_LONMR @ hex. USART0-US_LONMR 1b. ;
: USART0-US_LONPR. ." USART0-US_LONPR () $" USART0-US_LONPR @ hex. USART0-US_LONPR 1b. ;
: USART0-US_LONDL. ." USART0-US_LONDL () $" USART0-US_LONDL @ hex. USART0-US_LONDL 1b. ;
: USART0-US_LONL2HDR. ." USART0-US_LONL2HDR () $" USART0-US_LONL2HDR @ hex. USART0-US_LONL2HDR 1b. ;
: USART0-US_LONBL. ." USART0-US_LONBL (read-only) $" USART0-US_LONBL @ hex. USART0-US_LONBL 1b. ;
: USART0-US_LONB1TX. ." USART0-US_LONB1TX () $" USART0-US_LONB1TX @ hex. USART0-US_LONB1TX 1b. ;
: USART0-US_LONB1RX. ." USART0-US_LONB1RX () $" USART0-US_LONB1RX @ hex. USART0-US_LONB1RX 1b. ;
: USART0-US_LONPRIO. ." USART0-US_LONPRIO () $" USART0-US_LONPRIO @ hex. USART0-US_LONPRIO 1b. ;
: USART0-US_IDTTX. ." USART0-US_IDTTX () $" USART0-US_IDTTX @ hex. USART0-US_IDTTX 1b. ;
: USART0-US_IDTRX. ." USART0-US_IDTRX () $" USART0-US_IDTRX @ hex. USART0-US_IDTRX 1b. ;
: USART0-US_ICDIFF. ." USART0-US_ICDIFF () $" USART0-US_ICDIFF @ hex. USART0-US_ICDIFF 1b. ;
: USART0-US_WPMR. ." USART0-US_WPMR () $" USART0-US_WPMR @ hex. USART0-US_WPMR 1b. ;
: USART0-US_WPSR. ." USART0-US_WPSR (read-only) $" USART0-US_WPSR @ hex. USART0-US_WPSR 1b. ;
: USART0.
USART0-US_CR.
USART0-US_MR.
USART0-US_IER.
USART0-US_IDR.
USART0-US_IMR.
USART0-US_CSR.
USART0-US_RHR.
USART0-US_THR.
USART0-US_BRGR.
USART0-US_RTOR.
USART0-US_TTGR.
USART0-US_FIDI.
USART0-US_NER.
USART0-US_IF.
USART0-US_MAN.
USART0-US_LINMR.
USART0-US_LINIR.
USART0-US_LINBRR.
USART0-US_LONMR.
USART0-US_LONPR.
USART0-US_LONDL.
USART0-US_LONL2HDR.
USART0-US_LONBL.
USART0-US_LONB1TX.
USART0-US_LONB1RX.
USART0-US_LONPRIO.
USART0-US_IDTTX.
USART0-US_IDTRX.
USART0-US_ICDIFF.
USART0-US_WPMR.
USART0-US_WPSR.
;

$40028000 constant USART1 ( Universal Synchronous Asynchronous Receiver Transmitter )
USART1 $0000 + constant USART1-US_CR ( Control Register )
USART1 $0004 + constant USART1-US_MR ( Mode Register )
USART1 $0008 + constant USART1-US_IER ( Interrupt Enable Register )
USART1 $000C + constant USART1-US_IDR ( Interrupt Disable Register )
USART1 $0010 + constant USART1-US_IMR ( Interrupt Mask Register )
USART1 $0014 + constant USART1-US_CSR ( Channel Status Register )
USART1 $0018 + constant USART1-US_RHR ( Receive Holding Register )
USART1 $001C + constant USART1-US_THR ( Transmit Holding Register )
USART1 $0020 + constant USART1-US_BRGR ( Baud Rate Generator Register )
USART1 $0024 + constant USART1-US_RTOR ( Receiver Time-out Register )
USART1 $0028 + constant USART1-US_TTGR ( Transmitter Timeguard Register )
USART1 $0040 + constant USART1-US_FIDI ( FI DI Ratio Register )
USART1 $0044 + constant USART1-US_NER ( Number of Errors Register )
USART1 $004C + constant USART1-US_IF ( IrDA Filter Register )
USART1 $0050 + constant USART1-US_MAN ( Manchester Configuration Register )
USART1 $0054 + constant USART1-US_LINMR ( LIN Mode Register )
USART1 $0058 + constant USART1-US_LINIR ( LIN Identifier Register )
USART1 $005C + constant USART1-US_LINBRR ( LIN Baud Rate Register )
USART1 $0060 + constant USART1-US_LONMR ( LON Mode Register )
USART1 $0064 + constant USART1-US_LONPR ( LON Preamble Register )
USART1 $0068 + constant USART1-US_LONDL ( LON Data Length Register )
USART1 $006C + constant USART1-US_LONL2HDR ( LON L2HDR Register )
USART1 $0070 + constant USART1-US_LONBL ( LON Backlog Register )
USART1 $0074 + constant USART1-US_LONB1TX ( LON Beta1 Tx Register )
USART1 $0078 + constant USART1-US_LONB1RX ( LON Beta1 Rx Register )
USART1 $007C + constant USART1-US_LONPRIO ( LON Priority Register )
USART1 $0080 + constant USART1-US_IDTTX ( LON IDT Tx Register )
USART1 $0084 + constant USART1-US_IDTRX ( LON IDT Rx Register )
USART1 $0088 + constant USART1-US_ICDIFF ( IC DIFF Register )
USART1 $00E4 + constant USART1-US_WPMR ( Write Protection Mode Register )
USART1 $00E8 + constant USART1-US_WPSR ( Write Protection Status Register )
: USART1-US_CR. ." USART1-US_CR (write-only) $" USART1-US_CR @ hex. USART1-US_CR 1b. ;
: USART1-US_MR. ." USART1-US_MR () $" USART1-US_MR @ hex. USART1-US_MR 1b. ;
: USART1-US_IER. ." USART1-US_IER (write-only) $" USART1-US_IER @ hex. USART1-US_IER 1b. ;
: USART1-US_IDR. ." USART1-US_IDR (write-only) $" USART1-US_IDR @ hex. USART1-US_IDR 1b. ;
: USART1-US_IMR. ." USART1-US_IMR (read-only) $" USART1-US_IMR @ hex. USART1-US_IMR 1b. ;
: USART1-US_CSR. ." USART1-US_CSR (read-only) $" USART1-US_CSR @ hex. USART1-US_CSR 1b. ;
: USART1-US_RHR. ." USART1-US_RHR (read-only) $" USART1-US_RHR @ hex. USART1-US_RHR 1b. ;
: USART1-US_THR. ." USART1-US_THR (write-only) $" USART1-US_THR @ hex. USART1-US_THR 1b. ;
: USART1-US_BRGR. ." USART1-US_BRGR () $" USART1-US_BRGR @ hex. USART1-US_BRGR 1b. ;
: USART1-US_RTOR. ." USART1-US_RTOR () $" USART1-US_RTOR @ hex. USART1-US_RTOR 1b. ;
: USART1-US_TTGR. ." USART1-US_TTGR () $" USART1-US_TTGR @ hex. USART1-US_TTGR 1b. ;
: USART1-US_FIDI. ." USART1-US_FIDI () $" USART1-US_FIDI @ hex. USART1-US_FIDI 1b. ;
: USART1-US_NER. ." USART1-US_NER (read-only) $" USART1-US_NER @ hex. USART1-US_NER 1b. ;
: USART1-US_IF. ." USART1-US_IF () $" USART1-US_IF @ hex. USART1-US_IF 1b. ;
: USART1-US_MAN. ." USART1-US_MAN () $" USART1-US_MAN @ hex. USART1-US_MAN 1b. ;
: USART1-US_LINMR. ." USART1-US_LINMR () $" USART1-US_LINMR @ hex. USART1-US_LINMR 1b. ;
: USART1-US_LINIR. ." USART1-US_LINIR () $" USART1-US_LINIR @ hex. USART1-US_LINIR 1b. ;
: USART1-US_LINBRR. ." USART1-US_LINBRR (read-only) $" USART1-US_LINBRR @ hex. USART1-US_LINBRR 1b. ;
: USART1-US_LONMR. ." USART1-US_LONMR () $" USART1-US_LONMR @ hex. USART1-US_LONMR 1b. ;
: USART1-US_LONPR. ." USART1-US_LONPR () $" USART1-US_LONPR @ hex. USART1-US_LONPR 1b. ;
: USART1-US_LONDL. ." USART1-US_LONDL () $" USART1-US_LONDL @ hex. USART1-US_LONDL 1b. ;
: USART1-US_LONL2HDR. ." USART1-US_LONL2HDR () $" USART1-US_LONL2HDR @ hex. USART1-US_LONL2HDR 1b. ;
: USART1-US_LONBL. ." USART1-US_LONBL (read-only) $" USART1-US_LONBL @ hex. USART1-US_LONBL 1b. ;
: USART1-US_LONB1TX. ." USART1-US_LONB1TX () $" USART1-US_LONB1TX @ hex. USART1-US_LONB1TX 1b. ;
: USART1-US_LONB1RX. ." USART1-US_LONB1RX () $" USART1-US_LONB1RX @ hex. USART1-US_LONB1RX 1b. ;
: USART1-US_LONPRIO. ." USART1-US_LONPRIO () $" USART1-US_LONPRIO @ hex. USART1-US_LONPRIO 1b. ;
: USART1-US_IDTTX. ." USART1-US_IDTTX () $" USART1-US_IDTTX @ hex. USART1-US_IDTTX 1b. ;
: USART1-US_IDTRX. ." USART1-US_IDTRX () $" USART1-US_IDTRX @ hex. USART1-US_IDTRX 1b. ;
: USART1-US_ICDIFF. ." USART1-US_ICDIFF () $" USART1-US_ICDIFF @ hex. USART1-US_ICDIFF 1b. ;
: USART1-US_WPMR. ." USART1-US_WPMR () $" USART1-US_WPMR @ hex. USART1-US_WPMR 1b. ;
: USART1-US_WPSR. ." USART1-US_WPSR (read-only) $" USART1-US_WPSR @ hex. USART1-US_WPSR 1b. ;
: USART1.
USART1-US_CR.
USART1-US_MR.
USART1-US_IER.
USART1-US_IDR.
USART1-US_IMR.
USART1-US_CSR.
USART1-US_RHR.
USART1-US_THR.
USART1-US_BRGR.
USART1-US_RTOR.
USART1-US_TTGR.
USART1-US_FIDI.
USART1-US_NER.
USART1-US_IF.
USART1-US_MAN.
USART1-US_LINMR.
USART1-US_LINIR.
USART1-US_LINBRR.
USART1-US_LONMR.
USART1-US_LONPR.
USART1-US_LONDL.
USART1-US_LONL2HDR.
USART1-US_LONBL.
USART1-US_LONB1TX.
USART1-US_LONB1RX.
USART1-US_LONPRIO.
USART1-US_IDTTX.
USART1-US_IDTRX.
USART1-US_ICDIFF.
USART1-US_WPMR.
USART1-US_WPSR.
;

$4002C000 constant USART2 ( Universal Synchronous Asynchronous Receiver Transmitter )
USART2 $0000 + constant USART2-US_CR ( Control Register )
USART2 $0004 + constant USART2-US_MR ( Mode Register )
USART2 $0008 + constant USART2-US_IER ( Interrupt Enable Register )
USART2 $000C + constant USART2-US_IDR ( Interrupt Disable Register )
USART2 $0010 + constant USART2-US_IMR ( Interrupt Mask Register )
USART2 $0014 + constant USART2-US_CSR ( Channel Status Register )
USART2 $0018 + constant USART2-US_RHR ( Receive Holding Register )
USART2 $001C + constant USART2-US_THR ( Transmit Holding Register )
USART2 $0020 + constant USART2-US_BRGR ( Baud Rate Generator Register )
USART2 $0024 + constant USART2-US_RTOR ( Receiver Time-out Register )
USART2 $0028 + constant USART2-US_TTGR ( Transmitter Timeguard Register )
USART2 $0040 + constant USART2-US_FIDI ( FI DI Ratio Register )
USART2 $0044 + constant USART2-US_NER ( Number of Errors Register )
USART2 $004C + constant USART2-US_IF ( IrDA Filter Register )
USART2 $0050 + constant USART2-US_MAN ( Manchester Configuration Register )
USART2 $0054 + constant USART2-US_LINMR ( LIN Mode Register )
USART2 $0058 + constant USART2-US_LINIR ( LIN Identifier Register )
USART2 $005C + constant USART2-US_LINBRR ( LIN Baud Rate Register )
USART2 $0060 + constant USART2-US_LONMR ( LON Mode Register )
USART2 $0064 + constant USART2-US_LONPR ( LON Preamble Register )
USART2 $0068 + constant USART2-US_LONDL ( LON Data Length Register )
USART2 $006C + constant USART2-US_LONL2HDR ( LON L2HDR Register )
USART2 $0070 + constant USART2-US_LONBL ( LON Backlog Register )
USART2 $0074 + constant USART2-US_LONB1TX ( LON Beta1 Tx Register )
USART2 $0078 + constant USART2-US_LONB1RX ( LON Beta1 Rx Register )
USART2 $007C + constant USART2-US_LONPRIO ( LON Priority Register )
USART2 $0080 + constant USART2-US_IDTTX ( LON IDT Tx Register )
USART2 $0084 + constant USART2-US_IDTRX ( LON IDT Rx Register )
USART2 $0088 + constant USART2-US_ICDIFF ( IC DIFF Register )
USART2 $00E4 + constant USART2-US_WPMR ( Write Protection Mode Register )
USART2 $00E8 + constant USART2-US_WPSR ( Write Protection Status Register )
: USART2-US_CR. ." USART2-US_CR (write-only) $" USART2-US_CR @ hex. USART2-US_CR 1b. ;
: USART2-US_MR. ." USART2-US_MR () $" USART2-US_MR @ hex. USART2-US_MR 1b. ;
: USART2-US_IER. ." USART2-US_IER (write-only) $" USART2-US_IER @ hex. USART2-US_IER 1b. ;
: USART2-US_IDR. ." USART2-US_IDR (write-only) $" USART2-US_IDR @ hex. USART2-US_IDR 1b. ;
: USART2-US_IMR. ." USART2-US_IMR (read-only) $" USART2-US_IMR @ hex. USART2-US_IMR 1b. ;
: USART2-US_CSR. ." USART2-US_CSR (read-only) $" USART2-US_CSR @ hex. USART2-US_CSR 1b. ;
: USART2-US_RHR. ." USART2-US_RHR (read-only) $" USART2-US_RHR @ hex. USART2-US_RHR 1b. ;
: USART2-US_THR. ." USART2-US_THR (write-only) $" USART2-US_THR @ hex. USART2-US_THR 1b. ;
: USART2-US_BRGR. ." USART2-US_BRGR () $" USART2-US_BRGR @ hex. USART2-US_BRGR 1b. ;
: USART2-US_RTOR. ." USART2-US_RTOR () $" USART2-US_RTOR @ hex. USART2-US_RTOR 1b. ;
: USART2-US_TTGR. ." USART2-US_TTGR () $" USART2-US_TTGR @ hex. USART2-US_TTGR 1b. ;
: USART2-US_FIDI. ." USART2-US_FIDI () $" USART2-US_FIDI @ hex. USART2-US_FIDI 1b. ;
: USART2-US_NER. ." USART2-US_NER (read-only) $" USART2-US_NER @ hex. USART2-US_NER 1b. ;
: USART2-US_IF. ." USART2-US_IF () $" USART2-US_IF @ hex. USART2-US_IF 1b. ;
: USART2-US_MAN. ." USART2-US_MAN () $" USART2-US_MAN @ hex. USART2-US_MAN 1b. ;
: USART2-US_LINMR. ." USART2-US_LINMR () $" USART2-US_LINMR @ hex. USART2-US_LINMR 1b. ;
: USART2-US_LINIR. ." USART2-US_LINIR () $" USART2-US_LINIR @ hex. USART2-US_LINIR 1b. ;
: USART2-US_LINBRR. ." USART2-US_LINBRR (read-only) $" USART2-US_LINBRR @ hex. USART2-US_LINBRR 1b. ;
: USART2-US_LONMR. ." USART2-US_LONMR () $" USART2-US_LONMR @ hex. USART2-US_LONMR 1b. ;
: USART2-US_LONPR. ." USART2-US_LONPR () $" USART2-US_LONPR @ hex. USART2-US_LONPR 1b. ;
: USART2-US_LONDL. ." USART2-US_LONDL () $" USART2-US_LONDL @ hex. USART2-US_LONDL 1b. ;
: USART2-US_LONL2HDR. ." USART2-US_LONL2HDR () $" USART2-US_LONL2HDR @ hex. USART2-US_LONL2HDR 1b. ;
: USART2-US_LONBL. ." USART2-US_LONBL (read-only) $" USART2-US_LONBL @ hex. USART2-US_LONBL 1b. ;
: USART2-US_LONB1TX. ." USART2-US_LONB1TX () $" USART2-US_LONB1TX @ hex. USART2-US_LONB1TX 1b. ;
: USART2-US_LONB1RX. ." USART2-US_LONB1RX () $" USART2-US_LONB1RX @ hex. USART2-US_LONB1RX 1b. ;
: USART2-US_LONPRIO. ." USART2-US_LONPRIO () $" USART2-US_LONPRIO @ hex. USART2-US_LONPRIO 1b. ;
: USART2-US_IDTTX. ." USART2-US_IDTTX () $" USART2-US_IDTTX @ hex. USART2-US_IDTTX 1b. ;
: USART2-US_IDTRX. ." USART2-US_IDTRX () $" USART2-US_IDTRX @ hex. USART2-US_IDTRX 1b. ;
: USART2-US_ICDIFF. ." USART2-US_ICDIFF () $" USART2-US_ICDIFF @ hex. USART2-US_ICDIFF 1b. ;
: USART2-US_WPMR. ." USART2-US_WPMR () $" USART2-US_WPMR @ hex. USART2-US_WPMR 1b. ;
: USART2-US_WPSR. ." USART2-US_WPSR (read-only) $" USART2-US_WPSR @ hex. USART2-US_WPSR 1b. ;
: USART2.
USART2-US_CR.
USART2-US_MR.
USART2-US_IER.
USART2-US_IDR.
USART2-US_IMR.
USART2-US_CSR.
USART2-US_RHR.
USART2-US_THR.
USART2-US_BRGR.
USART2-US_RTOR.
USART2-US_TTGR.
USART2-US_FIDI.
USART2-US_NER.
USART2-US_IF.
USART2-US_MAN.
USART2-US_LINMR.
USART2-US_LINIR.
USART2-US_LINBRR.
USART2-US_LONMR.
USART2-US_LONPR.
USART2-US_LONDL.
USART2-US_LONL2HDR.
USART2-US_LONBL.
USART2-US_LONB1TX.
USART2-US_LONB1RX.
USART2-US_LONPRIO.
USART2-US_IDTTX.
USART2-US_IDTRX.
USART2-US_ICDIFF.
USART2-US_WPMR.
USART2-US_WPSR.
;

$40038000 constant USBHS ( USB High-Speed Interface )
USBHS $0000 + constant USBHS-DEVCTRL ( Device General Control Register )
USBHS $0004 + constant USBHS-DEVISR ( Device Global Interrupt Status Register )
USBHS $0008 + constant USBHS-DEVICR ( Device Global Interrupt Clear Register )
USBHS $000C + constant USBHS-DEVIFR ( Device Global Interrupt Set Register )
USBHS $0010 + constant USBHS-DEVIMR ( Device Global Interrupt Mask Register )
USBHS $0014 + constant USBHS-DEVIDR ( Device Global Interrupt Disable Register )
USBHS $0018 + constant USBHS-DEVIER ( Device Global Interrupt Enable Register )
USBHS $001C + constant USBHS-DEVEPT ( Device Endpoint Register )
USBHS $0020 + constant USBHS-DEVFNUM ( Device Frame Number Register )
USBHS $100 + constant USBHS-DEVEPTCFG[%s] ( Device Endpoint Configuration Register n = 0 0 )
USBHS $130 + constant USBHS-DEVEPTISR[%s] ( Device Endpoint Status Register n = 0 0 )
USBHS $160 + constant USBHS-DEVEPTICR[%s] ( Device Endpoint Clear Register n = 0 0 )
USBHS $190 + constant USBHS-DEVEPTIFR[%s] ( Device Endpoint Set Register n = 0 0 )
USBHS $1C0 + constant USBHS-DEVEPTIMR[%s] ( Device Endpoint Mask Register n = 0 0 )
USBHS $1F0 + constant USBHS-DEVEPTIER[%s] ( Device Endpoint Enable Register n = 0 0 )
USBHS $220 + constant USBHS-DEVEPTIDR[%s] ( Device Endpoint Disable Register n = 0 0 )
USBHS $0400 + constant USBHS-HSTCTRL ( Host General Control Register )
USBHS $0404 + constant USBHS-HSTISR ( Host Global Interrupt Status Register )
USBHS $0408 + constant USBHS-HSTICR ( Host Global Interrupt Clear Register )
USBHS $040C + constant USBHS-HSTIFR ( Host Global Interrupt Set Register )
USBHS $0410 + constant USBHS-HSTIMR ( Host Global Interrupt Mask Register )
USBHS $0414 + constant USBHS-HSTIDR ( Host Global Interrupt Disable Register )
USBHS $0418 + constant USBHS-HSTIER ( Host Global Interrupt Enable Register )
USBHS $0041C + constant USBHS-HSTPIP ( Host Pipe Register )
USBHS $0420 + constant USBHS-HSTFNUM ( Host Frame Number Register )
USBHS $0424 + constant USBHS-HSTADDR1 ( Host Address 1 Register )
USBHS $0428 + constant USBHS-HSTADDR2 ( Host Address 2 Register )
USBHS $042C + constant USBHS-HSTADDR3 ( Host Address 3 Register )
USBHS $500 + constant USBHS-HSTPIPCFG[%s] ( Host Pipe Configuration Register n = 0 0 )
USBHS $530 + constant USBHS-HSTPIPISR[%s] ( Host Pipe Status Register n = 0 0 )
USBHS $560 + constant USBHS-HSTPIPICR[%s] ( Host Pipe Clear Register n = 0 0 )
USBHS $590 + constant USBHS-HSTPIPIFR[%s] ( Host Pipe Set Register n = 0 0 )
USBHS $5C0 + constant USBHS-HSTPIPIMR[%s] ( Host Pipe Mask Register n = 0 0 )
USBHS $5F0 + constant USBHS-HSTPIPIER[%s] ( Host Pipe Enable Register n = 0 0 )
USBHS $620 + constant USBHS-HSTPIPIDR[%s] ( Host Pipe Disable Register n = 0 0 )
USBHS $650 + constant USBHS-HSTPIPINRQ[%s] ( Host Pipe IN Request Register n = 0 0 )
USBHS $680 + constant USBHS-HSTPIPERR[%s] ( Host Pipe Error Register n = 0 0 )
USBHS $0800 + constant USBHS-CTRL ( General Control Register )
USBHS $0804 + constant USBHS-SR ( General Status Register )
USBHS $0808 + constant USBHS-SCR ( General Status Clear Register )
USBHS $080C + constant USBHS-SFR ( General Status Set Register )
: USBHS-DEVCTRL. ." USBHS-DEVCTRL () $" USBHS-DEVCTRL @ hex. USBHS-DEVCTRL 1b. ;
: USBHS-DEVISR. ." USBHS-DEVISR (read-only) $" USBHS-DEVISR @ hex. USBHS-DEVISR 1b. ;
: USBHS-DEVICR. ." USBHS-DEVICR (write-only) $" USBHS-DEVICR @ hex. USBHS-DEVICR 1b. ;
: USBHS-DEVIFR. ." USBHS-DEVIFR (write-only) $" USBHS-DEVIFR @ hex. USBHS-DEVIFR 1b. ;
: USBHS-DEVIMR. ." USBHS-DEVIMR (read-only) $" USBHS-DEVIMR @ hex. USBHS-DEVIMR 1b. ;
: USBHS-DEVIDR. ." USBHS-DEVIDR (write-only) $" USBHS-DEVIDR @ hex. USBHS-DEVIDR 1b. ;
: USBHS-DEVIER. ." USBHS-DEVIER (write-only) $" USBHS-DEVIER @ hex. USBHS-DEVIER 1b. ;
: USBHS-DEVEPT. ." USBHS-DEVEPT () $" USBHS-DEVEPT @ hex. USBHS-DEVEPT 1b. ;
: USBHS-DEVFNUM. ." USBHS-DEVFNUM (read-only) $" USBHS-DEVFNUM @ hex. USBHS-DEVFNUM 1b. ;
: USBHS-DEVEPTCFG[%s]. ." USBHS-DEVEPTCFG[%s] () $" USBHS-DEVEPTCFG[%s] @ hex. USBHS-DEVEPTCFG[%s] 1b. ;
: USBHS-DEVEPTISR[%s]. ." USBHS-DEVEPTISR[%s] (read-only) $" USBHS-DEVEPTISR[%s] @ hex. USBHS-DEVEPTISR[%s] 1b. ;
: USBHS-DEVEPTICR[%s]. ." USBHS-DEVEPTICR[%s] (write-only) $" USBHS-DEVEPTICR[%s] @ hex. USBHS-DEVEPTICR[%s] 1b. ;
: USBHS-DEVEPTIFR[%s]. ." USBHS-DEVEPTIFR[%s] (write-only) $" USBHS-DEVEPTIFR[%s] @ hex. USBHS-DEVEPTIFR[%s] 1b. ;
: USBHS-DEVEPTIMR[%s]. ." USBHS-DEVEPTIMR[%s] (read-only) $" USBHS-DEVEPTIMR[%s] @ hex. USBHS-DEVEPTIMR[%s] 1b. ;
: USBHS-DEVEPTIER[%s]. ." USBHS-DEVEPTIER[%s] (write-only) $" USBHS-DEVEPTIER[%s] @ hex. USBHS-DEVEPTIER[%s] 1b. ;
: USBHS-DEVEPTIDR[%s]. ." USBHS-DEVEPTIDR[%s] (write-only) $" USBHS-DEVEPTIDR[%s] @ hex. USBHS-DEVEPTIDR[%s] 1b. ;
: USBHS-HSTCTRL. ." USBHS-HSTCTRL () $" USBHS-HSTCTRL @ hex. USBHS-HSTCTRL 1b. ;
: USBHS-HSTISR. ." USBHS-HSTISR (read-only) $" USBHS-HSTISR @ hex. USBHS-HSTISR 1b. ;
: USBHS-HSTICR. ." USBHS-HSTICR (write-only) $" USBHS-HSTICR @ hex. USBHS-HSTICR 1b. ;
: USBHS-HSTIFR. ." USBHS-HSTIFR (write-only) $" USBHS-HSTIFR @ hex. USBHS-HSTIFR 1b. ;
: USBHS-HSTIMR. ." USBHS-HSTIMR (read-only) $" USBHS-HSTIMR @ hex. USBHS-HSTIMR 1b. ;
: USBHS-HSTIDR. ." USBHS-HSTIDR (write-only) $" USBHS-HSTIDR @ hex. USBHS-HSTIDR 1b. ;
: USBHS-HSTIER. ." USBHS-HSTIER (write-only) $" USBHS-HSTIER @ hex. USBHS-HSTIER 1b. ;
: USBHS-HSTPIP. ." USBHS-HSTPIP () $" USBHS-HSTPIP @ hex. USBHS-HSTPIP 1b. ;
: USBHS-HSTFNUM. ." USBHS-HSTFNUM () $" USBHS-HSTFNUM @ hex. USBHS-HSTFNUM 1b. ;
: USBHS-HSTADDR1. ." USBHS-HSTADDR1 () $" USBHS-HSTADDR1 @ hex. USBHS-HSTADDR1 1b. ;
: USBHS-HSTADDR2. ." USBHS-HSTADDR2 () $" USBHS-HSTADDR2 @ hex. USBHS-HSTADDR2 1b. ;
: USBHS-HSTADDR3. ." USBHS-HSTADDR3 () $" USBHS-HSTADDR3 @ hex. USBHS-HSTADDR3 1b. ;
: USBHS-HSTPIPCFG[%s]. ." USBHS-HSTPIPCFG[%s] () $" USBHS-HSTPIPCFG[%s] @ hex. USBHS-HSTPIPCFG[%s] 1b. ;
: USBHS-HSTPIPISR[%s]. ." USBHS-HSTPIPISR[%s] (read-only) $" USBHS-HSTPIPISR[%s] @ hex. USBHS-HSTPIPISR[%s] 1b. ;
: USBHS-HSTPIPICR[%s]. ." USBHS-HSTPIPICR[%s] (write-only) $" USBHS-HSTPIPICR[%s] @ hex. USBHS-HSTPIPICR[%s] 1b. ;
: USBHS-HSTPIPIFR[%s]. ." USBHS-HSTPIPIFR[%s] (write-only) $" USBHS-HSTPIPIFR[%s] @ hex. USBHS-HSTPIPIFR[%s] 1b. ;
: USBHS-HSTPIPIMR[%s]. ." USBHS-HSTPIPIMR[%s] (read-only) $" USBHS-HSTPIPIMR[%s] @ hex. USBHS-HSTPIPIMR[%s] 1b. ;
: USBHS-HSTPIPIER[%s]. ." USBHS-HSTPIPIER[%s] (write-only) $" USBHS-HSTPIPIER[%s] @ hex. USBHS-HSTPIPIER[%s] 1b. ;
: USBHS-HSTPIPIDR[%s]. ." USBHS-HSTPIPIDR[%s] (write-only) $" USBHS-HSTPIPIDR[%s] @ hex. USBHS-HSTPIPIDR[%s] 1b. ;
: USBHS-HSTPIPINRQ[%s]. ." USBHS-HSTPIPINRQ[%s] () $" USBHS-HSTPIPINRQ[%s] @ hex. USBHS-HSTPIPINRQ[%s] 1b. ;
: USBHS-HSTPIPERR[%s]. ." USBHS-HSTPIPERR[%s] () $" USBHS-HSTPIPERR[%s] @ hex. USBHS-HSTPIPERR[%s] 1b. ;
: USBHS-CTRL. ." USBHS-CTRL () $" USBHS-CTRL @ hex. USBHS-CTRL 1b. ;
: USBHS-SR. ." USBHS-SR (read-only) $" USBHS-SR @ hex. USBHS-SR 1b. ;
: USBHS-SCR. ." USBHS-SCR (write-only) $" USBHS-SCR @ hex. USBHS-SCR 1b. ;
: USBHS-SFR. ." USBHS-SFR (write-only) $" USBHS-SFR @ hex. USBHS-SFR 1b. ;
: USBHS.
USBHS-DEVCTRL.
USBHS-DEVISR.
USBHS-DEVICR.
USBHS-DEVIFR.
USBHS-DEVIMR.
USBHS-DEVIDR.
USBHS-DEVIER.
USBHS-DEVEPT.
USBHS-DEVFNUM.
USBHS-DEVEPTCFG[%s].
USBHS-DEVEPTISR[%s].
USBHS-DEVEPTICR[%s].
USBHS-DEVEPTIFR[%s].
USBHS-DEVEPTIMR[%s].
USBHS-DEVEPTIER[%s].
USBHS-DEVEPTIDR[%s].
USBHS-HSTCTRL.
USBHS-HSTISR.
USBHS-HSTICR.
USBHS-HSTIFR.
USBHS-HSTIMR.
USBHS-HSTIDR.
USBHS-HSTIER.
USBHS-HSTPIP.
USBHS-HSTFNUM.
USBHS-HSTADDR1.
USBHS-HSTADDR2.
USBHS-HSTADDR3.
USBHS-HSTPIPCFG[%s].
USBHS-HSTPIPISR[%s].
USBHS-HSTPIPICR[%s].
USBHS-HSTPIPIFR[%s].
USBHS-HSTPIPIMR[%s].
USBHS-HSTPIPIER[%s].
USBHS-HSTPIPIDR[%s].
USBHS-HSTPIPINRQ[%s].
USBHS-HSTPIPERR[%s].
USBHS-CTRL.
USBHS-SR.
USBHS-SCR.
USBHS-SFR.
;

$400E0400 constant UTMI ( USB Transmitter Interface Macrocell )
UTMI $10 + constant UTMI-OHCIICR ( OHCI Interrupt Configuration Register )
UTMI $30 + constant UTMI-CKTRIM ( UTMI Clock Trimming Register )
: UTMI-OHCIICR. ." UTMI-OHCIICR () $" UTMI-OHCIICR @ hex. UTMI-OHCIICR 1b. ;
: UTMI-CKTRIM. ." UTMI-CKTRIM () $" UTMI-CKTRIM @ hex. UTMI-CKTRIM 1b. ;
: UTMI.
UTMI-OHCIICR.
UTMI-CKTRIM.
;

$400E1850 constant WDT ( Watchdog Timer )
WDT $00 + constant WDT-CR ( Control Register )
WDT $04 + constant WDT-MR ( Mode Register )
WDT $08 + constant WDT-SR ( Status Register )
: WDT-CR. ." WDT-CR (write-only) $" WDT-CR @ hex. WDT-CR 1b. ;
: WDT-MR. ." WDT-MR () $" WDT-MR @ hex. WDT-MR 1b. ;
: WDT-SR. ." WDT-SR (read-only) $" WDT-SR @ hex. WDT-SR 1b. ;
: WDT.
WDT-CR.
WDT-MR.
WDT-SR.
;

$40078000 constant XDMAC ( Extensible DMA Controller )
XDMAC $00 + constant XDMAC-GTYPE ( Global Type Register )
XDMAC $04 + constant XDMAC-GCFG ( Global Configuration Register )
XDMAC $08 + constant XDMAC-GWAC ( Global Weighted Arbiter Configuration Register )
XDMAC $0C + constant XDMAC-GIE ( Global Interrupt Enable Register )
XDMAC $10 + constant XDMAC-GID ( Global Interrupt Disable Register )
XDMAC $14 + constant XDMAC-GIM ( Global Interrupt Mask Register )
XDMAC $18 + constant XDMAC-GIS ( Global Interrupt Status Register )
XDMAC $1C + constant XDMAC-GE ( Global Channel Enable Register )
XDMAC $20 + constant XDMAC-GD ( Global Channel Disable Register )
XDMAC $24 + constant XDMAC-GS ( Global Channel Status Register )
XDMAC $28 + constant XDMAC-GRS ( Global Channel Read Suspend Register )
XDMAC $2C + constant XDMAC-GWS ( Global Channel Write Suspend Register )
XDMAC $30 + constant XDMAC-GRWS ( Global Channel Read Write Suspend Register )
XDMAC $34 + constant XDMAC-GRWR ( Global Channel Read Write Resume Register )
XDMAC $38 + constant XDMAC-GSWR ( Global Channel Software Request Register )
XDMAC $3C + constant XDMAC-GSWS ( Global Channel Software Request Status Register )
XDMAC $40 + constant XDMAC-GSWF ( Global Channel Software Flush Request Register )
: XDMAC-GTYPE. ." XDMAC-GTYPE (read-only) $" XDMAC-GTYPE @ hex. XDMAC-GTYPE 1b. ;
: XDMAC-GCFG. ." XDMAC-GCFG () $" XDMAC-GCFG @ hex. XDMAC-GCFG 1b. ;
: XDMAC-GWAC. ." XDMAC-GWAC () $" XDMAC-GWAC @ hex. XDMAC-GWAC 1b. ;
: XDMAC-GIE. ." XDMAC-GIE (write-only) $" XDMAC-GIE @ hex. XDMAC-GIE 1b. ;
: XDMAC-GID. ." XDMAC-GID (write-only) $" XDMAC-GID @ hex. XDMAC-GID 1b. ;
: XDMAC-GIM. ." XDMAC-GIM (read-only) $" XDMAC-GIM @ hex. XDMAC-GIM 1b. ;
: XDMAC-GIS. ." XDMAC-GIS (read-only) $" XDMAC-GIS @ hex. XDMAC-GIS 1b. ;
: XDMAC-GE. ." XDMAC-GE (write-only) $" XDMAC-GE @ hex. XDMAC-GE 1b. ;
: XDMAC-GD. ." XDMAC-GD (write-only) $" XDMAC-GD @ hex. XDMAC-GD 1b. ;
: XDMAC-GS. ." XDMAC-GS (read-only) $" XDMAC-GS @ hex. XDMAC-GS 1b. ;
: XDMAC-GRS. ." XDMAC-GRS () $" XDMAC-GRS @ hex. XDMAC-GRS 1b. ;
: XDMAC-GWS. ." XDMAC-GWS () $" XDMAC-GWS @ hex. XDMAC-GWS 1b. ;
: XDMAC-GRWS. ." XDMAC-GRWS (write-only) $" XDMAC-GRWS @ hex. XDMAC-GRWS 1b. ;
: XDMAC-GRWR. ." XDMAC-GRWR (write-only) $" XDMAC-GRWR @ hex. XDMAC-GRWR 1b. ;
: XDMAC-GSWR. ." XDMAC-GSWR (write-only) $" XDMAC-GSWR @ hex. XDMAC-GSWR 1b. ;
: XDMAC-GSWS. ." XDMAC-GSWS (read-only) $" XDMAC-GSWS @ hex. XDMAC-GSWS 1b. ;
: XDMAC-GSWF. ." XDMAC-GSWF (write-only) $" XDMAC-GSWF @ hex. XDMAC-GSWF 1b. ;
: XDMAC.
XDMAC-GTYPE.
XDMAC-GCFG.
XDMAC-GWAC.
XDMAC-GIE.
XDMAC-GID.
XDMAC-GIM.
XDMAC-GIS.
XDMAC-GE.
XDMAC-GD.
XDMAC-GS.
XDMAC-GRS.
XDMAC-GWS.
XDMAC-GRWS.
XDMAC-GRWR.
XDMAC-GSWR.
XDMAC-GSWS.
XDMAC-GSWF.
;

0 constant LOCKBIT (  )
LOCKBIT $0 + constant LOCKBIT-WORD0 ( Lock Bits Word 0 )
: LOCKBIT-WORD0. ." LOCKBIT-WORD0 () $" LOCKBIT-WORD0 @ hex. LOCKBIT-WORD0 1b. ;
: LOCKBIT.
LOCKBIT-WORD0.
;

$E000E000 constant SCnSCB ( System control not in SCB )
SCnSCB $00000004 + constant SCnSCB-ICTR ( Interrupt Controller Type Register )
SCnSCB $00000008 + constant SCnSCB-ACTLR ( Auxiliary Control Register )
: SCnSCB-ICTR. ." SCnSCB-ICTR (read-only) $" SCnSCB-ICTR @ hex. SCnSCB-ICTR 1b. ;
: SCnSCB-ACTLR. ." SCnSCB-ACTLR () $" SCnSCB-ACTLR @ hex. SCnSCB-ACTLR 1b. ;
: SCnSCB.
SCnSCB-ICTR.
SCnSCB-ACTLR.
;

$E000ED00 constant SCB ( System Control Block )
SCB $00000000 + constant SCB-CPUID ( CPUID Base Register )
SCB $00000004 + constant SCB-ICSR ( Interrupt Control and State Register )
SCB $00000008 + constant SCB-VTOR ( Vector Table Offset Register )
SCB $0000000c + constant SCB-AIRCR ( Application Interrupt and Reset Control Register )
SCB $00000010 + constant SCB-SCR ( System Control Register )
SCB $00000014 + constant SCB-CCR ( Configuration and Control Register )
SCB $00000018 + constant SCB-SHPR1 ( System Handler Priority Register 1 )
SCB $0000001c + constant SCB-SHPR2 ( System Handler Priority Register 2 )
SCB $00000020 + constant SCB-SHPR3 ( System Handler Priority Register 3 )
SCB $00000024 + constant SCB-SHCSR ( System Handler Control and State Register )
SCB $00000028 + constant SCB-CFSR ( Configurable Fault Status Registers )
SCB $0000002c + constant SCB-HFSR ( HardFault Status register )
SCB $00000030 + constant SCB-DFSR ( Debug Fault Status Register )
SCB $00000034 + constant SCB-MMFAR ( MemManage Fault Address Register )
SCB $00000038 + constant SCB-BFAR ( BusFault Address Register )
SCB $0000003C + constant SCB-AFSR ( Auxiliary Fault Status Register )
SCB $00000078 + constant SCB-CLIDR ( Cache Level ID Register )
SCB $0000007c + constant SCB-CTR ( Cache Type Register )
SCB $00000080 + constant SCB-CCSIDR ( Cache Size ID Register )
SCB $00000084 + constant SCB-CSSELR ( Cache Size Selection Register )
SCB $00000088 + constant SCB-CPACR ( Coprocessor Access Control Register )
SCB $00000200 + constant SCB-STIR ( Software Trigger Interrupt Register )
SCB $00000240 + constant SCB-MVFR0 ( Media and VFP Feature Register 0 )
SCB $00000244 + constant SCB-MVFR1 ( Media and VFP Feature Register 1 )
SCB $00000248 + constant SCB-MVFR2 ( Media and VFP Feature Register 2 )
: SCB-CPUID. ." SCB-CPUID (read-only) $" SCB-CPUID @ hex. SCB-CPUID 1b. ;
: SCB-ICSR. ." SCB-ICSR () $" SCB-ICSR @ hex. SCB-ICSR 1b. ;
: SCB-VTOR. ." SCB-VTOR () $" SCB-VTOR @ hex. SCB-VTOR 1b. ;
: SCB-AIRCR. ." SCB-AIRCR () $" SCB-AIRCR @ hex. SCB-AIRCR 1b. ;
: SCB-SCR. ." SCB-SCR () $" SCB-SCR @ hex. SCB-SCR 1b. ;
: SCB-CCR. ." SCB-CCR () $" SCB-CCR @ hex. SCB-CCR 1b. ;
: SCB-SHPR1. ." SCB-SHPR1 () $" SCB-SHPR1 @ hex. SCB-SHPR1 1b. ;
: SCB-SHPR2. ." SCB-SHPR2 () $" SCB-SHPR2 @ hex. SCB-SHPR2 1b. ;
: SCB-SHPR3. ." SCB-SHPR3 () $" SCB-SHPR3 @ hex. SCB-SHPR3 1b. ;
: SCB-SHCSR. ." SCB-SHCSR () $" SCB-SHCSR @ hex. SCB-SHCSR 1b. ;
: SCB-CFSR. ." SCB-CFSR () $" SCB-CFSR @ hex. SCB-CFSR 1b. ;
: SCB-HFSR. ." SCB-HFSR () $" SCB-HFSR @ hex. SCB-HFSR 1b. ;
: SCB-DFSR. ." SCB-DFSR () $" SCB-DFSR @ hex. SCB-DFSR 1b. ;
: SCB-MMFAR. ." SCB-MMFAR () $" SCB-MMFAR @ hex. SCB-MMFAR 1b. ;
: SCB-BFAR. ." SCB-BFAR () $" SCB-BFAR @ hex. SCB-BFAR 1b. ;
: SCB-AFSR. ." SCB-AFSR () $" SCB-AFSR @ hex. SCB-AFSR 1b. ;
: SCB-CLIDR. ." SCB-CLIDR (read-only) $" SCB-CLIDR @ hex. SCB-CLIDR 1b. ;
: SCB-CTR. ." SCB-CTR (read-only) $" SCB-CTR @ hex. SCB-CTR 1b. ;
: SCB-CCSIDR. ." SCB-CCSIDR (read-only) $" SCB-CCSIDR @ hex. SCB-CCSIDR 1b. ;
: SCB-CSSELR. ." SCB-CSSELR () $" SCB-CSSELR @ hex. SCB-CSSELR 1b. ;
: SCB-CPACR. ." SCB-CPACR () $" SCB-CPACR @ hex. SCB-CPACR 1b. ;
: SCB-STIR. ." SCB-STIR (write-only) $" SCB-STIR @ hex. SCB-STIR 1b. ;
: SCB-MVFR0. ." SCB-MVFR0 (read-only) $" SCB-MVFR0 @ hex. SCB-MVFR0 1b. ;
: SCB-MVFR1. ." SCB-MVFR1 (read-only) $" SCB-MVFR1 @ hex. SCB-MVFR1 1b. ;
: SCB-MVFR2. ." SCB-MVFR2 (read-only) $" SCB-MVFR2 @ hex. SCB-MVFR2 1b. ;
: SCB.
SCB-CPUID.
SCB-ICSR.
SCB-VTOR.
SCB-AIRCR.
SCB-SCR.
SCB-CCR.
SCB-SHPR1.
SCB-SHPR2.
SCB-SHPR3.
SCB-SHCSR.
SCB-CFSR.
SCB-HFSR.
SCB-DFSR.
SCB-MMFAR.
SCB-BFAR.
SCB-AFSR.
SCB-CLIDR.
SCB-CTR.
SCB-CCSIDR.
SCB-CSSELR.
SCB-CPACR.
SCB-STIR.
SCB-MVFR0.
SCB-MVFR1.
SCB-MVFR2.
;

$E000E010 constant SysTick ( System timer )
SysTick $00000000 + constant SysTick-CSR ( Control and Status Register )
SysTick $00000004 + constant SysTick-RVR ( Reload Value Register )
SysTick $00000008 + constant SysTick-CVR ( Current Value Register )
SysTick $0000000c + constant SysTick-CALIB ( Calibration Value Register )
: SysTick-CSR. ." SysTick-CSR () $" SysTick-CSR @ hex. SysTick-CSR 1b. ;
: SysTick-RVR. ." SysTick-RVR () $" SysTick-RVR @ hex. SysTick-RVR 1b. ;
: SysTick-CVR. ." SysTick-CVR () $" SysTick-CVR @ hex. SysTick-CVR 1b. ;
: SysTick-CALIB. ." SysTick-CALIB (read-only) $" SysTick-CALIB @ hex. SysTick-CALIB 1b. ;
: SysTick.
SysTick-CSR.
SysTick-RVR.
SysTick-CVR.
SysTick-CALIB.
;

$E000E100 constant NVIC ( Nested Vectored Interrupt Controller )
NVIC $00000000 + constant NVIC-ISER[%s] ( Interrupt Set Enable Register n )
NVIC $00000080 + constant NVIC-ICER[%s] ( Interrupt Clear Enable Register n )
NVIC $00000100 + constant NVIC-ISPR[%s] ( Interrupt Set Pending Register n )
NVIC $00000180 + constant NVIC-ICPR[%s] ( Interrupt Clear Pending Register n )
NVIC $00000200 + constant NVIC-IABR[%s] ( Interrupt Active bit Register n )
NVIC $00000300 + constant NVIC-IP[%s] ( Interrupt Priority Register 8Bit wide n )
NVIC $00000e00 + constant NVIC-STIR ( Software Trigger Interrupt Register )
: NVIC-ISER[%s]. ." NVIC-ISER[%s] () $" NVIC-ISER[%s] @ hex. NVIC-ISER[%s] 1b. ;
: NVIC-ICER[%s]. ." NVIC-ICER[%s] () $" NVIC-ICER[%s] @ hex. NVIC-ICER[%s] 1b. ;
: NVIC-ISPR[%s]. ." NVIC-ISPR[%s] () $" NVIC-ISPR[%s] @ hex. NVIC-ISPR[%s] 1b. ;
: NVIC-ICPR[%s]. ." NVIC-ICPR[%s] () $" NVIC-ICPR[%s] @ hex. NVIC-ICPR[%s] 1b. ;
: NVIC-IABR[%s]. ." NVIC-IABR[%s] () $" NVIC-IABR[%s] @ hex. NVIC-IABR[%s] 1b. ;
: NVIC-IP[%s]. ." NVIC-IP[%s] () $" NVIC-IP[%s] @ hex. NVIC-IP[%s] 1b. ;
: NVIC-STIR. ." NVIC-STIR (write-only) $" NVIC-STIR @ hex. NVIC-STIR 1b. ;
: NVIC.
NVIC-ISER[%s].
NVIC-ICER[%s].
NVIC-ISPR[%s].
NVIC-ICPR[%s].
NVIC-IABR[%s].
NVIC-IP[%s].
NVIC-STIR.
;

$E000ED90 constant MPU ( Memory Protection Unit )
MPU $00000000 + constant MPU-TYPE ( MPU Type Register )
MPU $00000004 + constant MPU-CTRL ( MPU Control Register )
MPU $00000008 + constant MPU-RNR ( MPU Region Number Register )
MPU $0000000C + constant MPU-RBAR ( MPU Region Base Address Register )
MPU $00000010 + constant MPU-RASR ( MPU Region Attribute and Size Register )
MPU $00000014 + constant MPU-RBAR_A1 ( MPU Alias 1 Region Base Address Register )
MPU $00000018 + constant MPU-RASR_A1 ( MPU Alias 1 Region Attribute and Size Register )
MPU $0000001c + constant MPU-RBAR_A2 ( MPU Alias 2 Region Base Address Register )
MPU $00000020 + constant MPU-RASR_A2 ( MPU Alias 2 Region Attribute and Size Register )
MPU $00000024 + constant MPU-RBAR_A3 ( MPU Alias 3 Region Base Address Register )
MPU $00000028 + constant MPU-RASR_A3 ( MPU Alias 3 Region Attribute and Size Register )
: MPU-TYPE. ." MPU-TYPE () $" MPU-TYPE @ hex. MPU-TYPE 1b. ;
: MPU-CTRL. ." MPU-CTRL () $" MPU-CTRL @ hex. MPU-CTRL 1b. ;
: MPU-RNR. ." MPU-RNR () $" MPU-RNR @ hex. MPU-RNR 1b. ;
: MPU-RBAR. ." MPU-RBAR () $" MPU-RBAR @ hex. MPU-RBAR 1b. ;
: MPU-RASR. ." MPU-RASR () $" MPU-RASR @ hex. MPU-RASR 1b. ;
: MPU-RBAR_A1. ." MPU-RBAR_A1 () $" MPU-RBAR_A1 @ hex. MPU-RBAR_A1 1b. ;
: MPU-RASR_A1. ." MPU-RASR_A1 () $" MPU-RASR_A1 @ hex. MPU-RASR_A1 1b. ;
: MPU-RBAR_A2. ." MPU-RBAR_A2 () $" MPU-RBAR_A2 @ hex. MPU-RBAR_A2 1b. ;
: MPU-RASR_A2. ." MPU-RASR_A2 () $" MPU-RASR_A2 @ hex. MPU-RASR_A2 1b. ;
: MPU-RBAR_A3. ." MPU-RBAR_A3 () $" MPU-RBAR_A3 @ hex. MPU-RBAR_A3 1b. ;
: MPU-RASR_A3. ." MPU-RASR_A3 () $" MPU-RASR_A3 @ hex. MPU-RASR_A3 1b. ;
: MPU.
MPU-TYPE.
MPU-CTRL.
MPU-RNR.
MPU-RBAR.
MPU-RASR.
MPU-RBAR_A1.
MPU-RASR_A1.
MPU-RBAR_A2.
MPU-RASR_A2.
MPU-RBAR_A3.
MPU-RASR_A3.
;

$E000EF30 constant FPU ( Floating Point Unit )
FPU $00000004 + constant FPU-FPCCR ( Floating-point Context Control Register )
FPU $00000008 + constant FPU-FPCAR ( Floating-point Context Address Register )
FPU $0000000C + constant FPU-FPDSCR ( Floating-point Default Status Control Register )
FPU $00000010 + constant FPU-MVFR0 ( Media and VFP Feature Register 0 )
FPU $00000014 + constant FPU-MVFR1 ( Media and VFP Feature Register 1 )
FPU $00000018 + constant FPU-MVFR2 ( Media and VFP Feature Register 2 )
: FPU-FPCCR. ." FPU-FPCCR () $" FPU-FPCCR @ hex. FPU-FPCCR 1b. ;
: FPU-FPCAR. ." FPU-FPCAR () $" FPU-FPCAR @ hex. FPU-FPCAR 1b. ;
: FPU-FPDSCR. ." FPU-FPDSCR () $" FPU-FPDSCR @ hex. FPU-FPDSCR 1b. ;
: FPU-MVFR0. ." FPU-MVFR0 (read-only) $" FPU-MVFR0 @ hex. FPU-MVFR0 1b. ;
: FPU-MVFR1. ." FPU-MVFR1 (read-only) $" FPU-MVFR1 @ hex. FPU-MVFR1 1b. ;
: FPU-MVFR2. ." FPU-MVFR2 (read-only) $" FPU-MVFR2 @ hex. FPU-MVFR2 1b. ;
: FPU.
FPU-FPCCR.
FPU-FPCAR.
FPU-FPDSCR.
FPU-MVFR0.
FPU-MVFR1.
FPU-MVFR2.
;


compiletoram
