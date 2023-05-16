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