\ Copyright 2019  t.porter <terry@tjporter.com.au>, licensed under the GPL V2
\ For STM32F103 Mecrisp-Stellaris by Matthias Koch 

compiletoflash

: 72mhz ( -- )	cr	      \ Increase 8Mhz RC clock to 72 MHz via 8MHz Xtal and PLL.
  $12 $40022000 !	      \ two flash mem wait states
  1 16 lshift  $40021000 bis! \ set HSEON
  begin 1 17 lshift $40021000 
       bit@ until	      \ wait for HSERDY
  1 16 lshift		      \ HSE clock is 8 MHz Xtal source for PLL
  7 18 lshift or	      \ PLL factor: 8 MHz * 9 = 72 MHz = HCLK
  4  8 lshift or	      \ PCLK1 = HCLK/2 = 36MHz
  2 14 lshift or	      \ ADCPRE = PCLK2/6
  2 or $40021004  !	      \ PLL is the system clock
  1 24 lshift $40021000 bis!  \ set PLLON
  begin 1 25 lshift $40021000 
       bit@ until	      \ wait for PLLRDY
;

compiletoram 

72mhz

\ Program Name: utils.fs  for Mecrisp-Stellaris by Matthias Koch and licensed under the GPL
\ Copyright 2019 t.porter <terry@tjporter.com.au> and licensed under the BSD license.
\ This program must be loaded before memmap.fs as it provided the pretty printing legend for generic 32 bit prints
\ Also included is "bin." which prints the binary form of a number with no spaces between numbers for easy copy and pasting purposes

compiletoflash

\ -------------------
\  Beautiful output
\ -------------------

: u.1 ( u -- ) 0 <# # #> type ;
: u.2 ( u -- ) 0 <# # # #> type ;
: u.3 ( u -- ) 0 <# # # # #> type ;
: u.4 ( u -- ) 0 <# # # # # #> type ;
: u.8 ( u -- ) 0 <# # # # # # # # # #> type ;
: h.1 ( u -- ) base @ hex swap  u.1  base ! ;
: h.2 ( u -- ) base @ hex swap  u.2  base ! ;
: h.3 ( u -- ) base @ hex swap  u.3  base ! ;
: h.4 ( u -- ) base @ hex swap  u.4  base ! ;
: h.8 ( u -- ) base @ hex swap  u.8  base ! ;

: hex.1 h.1 ;
: hex.2 h.2 ;
: hex.3 h.3 ;
: hex.4 h.4 ;

: u.ns 0 <# #s #> type ;
: const. ."  #" u.ns ;
: addr. u.8 ;
: .decimal base @ >r decimal . r> base ! ;

: bit ( u -- u ) 1 swap lshift  1-foldable ;	\ turn a bit position into a binary number.

: b8loop. ( u -- ) \ print  32 bits in 4 bit groups
0 <#
7 0 DO
# # # #
32 HOLD
LOOP
# # # # 
#>
TYPE ;

: b16loop. ( u -- ) \ print 32 bits in 2 bit groups
0 <#
15 0 DO
# #
32 HOLD
LOOP
# #
#>
TYPE ;

: b16loop-a. ( u -- ) \ print 16 bits in 1 bit groups
0  <#
15 0 DO 
#
32 HOLD
LOOP
#
#>
TYPE ;

: b32loop. ( u -- ) \ print 32 bits in 1 bit groups with vertical bars
0  <#
31 0 DO 
# 32 HOLD LOOP
# #>
TYPE ; 

: b32sloop. ( u -- ) \ print 32 bits in 1 bit groups without vertical bars
0  <#
31 0 DO
# LOOP
# #>
TYPE ;

\ Manual Use Legends ..............................................
: bin. ( u -- )  cr \ 1 bit legend - manual use
." 3322222222221111111111" cr
." 10987654321098765432109876543210 " cr
binary b32sloop. decimal cr ;

: bin1. ( u -- ) cr \ 1 bit legend - manual use
." 3|3|2|2|2|2|2|2|2|2|2|2|1|1|1|1|1|1|1|1|1|1|" cr
." 1|0|9|8|7|6|5|4|3|2|1|0|9|8|7|6|5|4|3|2|1|0|9|8|7|6|5|4|3|2|1|0 " cr
binary b32loop. decimal cr ;

: bin2. ( u -- ) cr \ 2 bit legend - manual use
." 15|14|13|12|11|10|09|08|07|06|05|04|03|02|01|00 " cr
binary b16loop. decimal cr ;

: bin4. ." Must be bin4h. or bin4l. " cr ;

: bin4l. ( u -- ) cr \ 4 bit generic legend for bits 7 - 0 - manual use
."  07   06   05   04   03   02   01   00  " cr
binary b8loop. decimal cr ;

: bin4h. ( u -- ) cr \ 4 bit generic legend for bits 15 - 8 - manual use
."  15   14   13   12   11   10   09   08  " cr
binary b8loop. decimal cr ;

: bin16. ( u -- ) cr  \ halfword legend
." 1|1|1|1|1|1|" cr
." 5|4|3|2|1|0|9|8|7|6|5|4|3|2|1|0 " cr
binary b16loop-a. decimal cr ;

compiletoram
\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\ Available forth template words as selected by config.xm 

compiletoflash
: WRITEONLY ( -- ) ." write-only" cr ;

$40021000 constant RCC ( Reset and clock control ) 
RCC $0 + constant RCC_CR (  )  \ Clock control register
RCC $4 + constant RCC_CFGR (  )  \ Clock configuration register  RCC_CFGR
RCC $8 + constant RCC_CIR (  )  \ Clock interrupt register  RCC_CIR
RCC $C + constant RCC_APB2RSTR ( read-write )  \ APB2 peripheral reset register  RCC_APB2RSTR
RCC $10 + constant RCC_APB1RSTR ( read-write )  \ APB1 peripheral reset register  RCC_APB1RSTR
RCC $14 + constant RCC_AHBENR ( read-write )  \ AHB Peripheral Clock enable register  RCC_AHBENR
RCC $18 + constant RCC_APB2ENR ( read-write )  \ APB2 peripheral clock enable register  RCC_APB2ENR
RCC $1C + constant RCC_APB1ENR ( read-write )  \ APB1 peripheral clock enable register  RCC_APB1ENR
RCC $20 + constant RCC_BDCR (  )  \ Backup domain control register  RCC_BDCR
RCC $24 + constant RCC_CSR (  )  \ Control/status register  RCC_CSR
: RCC_CR. cr ." RCC_CR.   $" RCC_CR @ dup hex.  bin1. ;
: RCC_CFGR. cr ." RCC_CFGR.   $" RCC_CFGR @ dup hex.  bin1. ;
: RCC_CIR. cr ." RCC_CIR.   $" RCC_CIR @ dup hex.  bin1. ;
: RCC_APB2RSTR. cr ." RCC_APB2RSTR.  RW   $" RCC_APB2RSTR @ dup hex.  bin1. ;
: RCC_APB1RSTR. cr ." RCC_APB1RSTR.  RW   $" RCC_APB1RSTR @ dup hex.  bin1. ;
: RCC_AHBENR. cr ." RCC_AHBENR.  RW   $" RCC_AHBENR @ dup hex.  bin1. ;
: RCC_APB2ENR. cr ." RCC_APB2ENR.  RW   $" RCC_APB2ENR @ dup hex.  bin1. ;
: RCC_APB1ENR. cr ." RCC_APB1ENR.  RW   $" RCC_APB1ENR @ dup hex.  bin1. ;
: RCC_BDCR. cr ." RCC_BDCR.   $" RCC_BDCR @ dup hex.  bin1. ;
: RCC_CSR. cr ." RCC_CSR.   $" RCC_CSR @ dup hex.  bin1. ;
: RCC.
RCC_CR.
RCC_CFGR.
RCC_CIR.
RCC_APB2RSTR.
RCC_APB1RSTR.
RCC_AHBENR.
RCC_APB2ENR.
RCC_APB1ENR.
RCC_BDCR.
RCC_CSR.
;

$40010800 constant GPIOA ( General purpose I/O ) 
GPIOA $0 + constant GPIOA_CRL ( read-write )  \ Port configuration register low  GPIOn_CRL
GPIOA $4 + constant GPIOA_CRH ( read-write )  \ Port configuration register high  GPIOn_CRL
GPIOA $8 + constant GPIOA_IDR ( read-only )  \ Port input data register  GPIOn_IDR
GPIOA $C + constant GPIOA_ODR ( read-write )  \ Port output data register  GPIOn_ODR
GPIOA $10 + constant GPIOA_BSRR ( write-only )  \ Port bit set/reset register  GPIOn_BSRR
GPIOA $14 + constant GPIOA_BRR ( write-only )  \ Port bit reset register  GPIOn_BRR
GPIOA $18 + constant GPIOA_LCKR ( read-write )  \ Port configuration lock  register
: GPIOA_CRL. cr ." GPIOA_CRL.  RW   $" GPIOA_CRL @ dup hex.  bin1. ;
: GPIOA_CRH. cr ." GPIOA_CRH.  RW   $" GPIOA_CRH @ dup hex.  bin1. ;
: GPIOA_IDR. cr ." GPIOA_IDR.  RO   $" GPIOA_IDR @ dup hex.  bin1. ;
: GPIOA_ODR. cr ." GPIOA_ODR.  RW   $" GPIOA_ODR @ dup hex.  bin1. ;
: GPIOA_BSRR. cr ." GPIOA_BSRR " WRITEONLY ; 
: GPIOA_BRR. cr ." GPIOA_BRR " WRITEONLY ; 
: GPIOA_LCKR. cr ." GPIOA_LCKR.  RW   $" GPIOA_LCKR @ dup hex.  bin1. ;
: GPIOA.
GPIOA_CRL.
GPIOA_CRH.
GPIOA_IDR.
GPIOA_ODR.
GPIOA_BSRR.
GPIOA_BRR.
GPIOA_LCKR.
;

$40010C00 constant GPIOB ( General purpose I/O ) 
GPIOB $0 + constant GPIOB_CRL ( read-write )  \ Port configuration register low  GPIOn_CRL
GPIOB $4 + constant GPIOB_CRH ( read-write )  \ Port configuration register high  GPIOn_CRL
GPIOB $8 + constant GPIOB_IDR ( read-only )  \ Port input data register  GPIOn_IDR
GPIOB $C + constant GPIOB_ODR ( read-write )  \ Port output data register  GPIOn_ODR
GPIOB $10 + constant GPIOB_BSRR ( write-only )  \ Port bit set/reset register  GPIOn_BSRR
GPIOB $14 + constant GPIOB_BRR ( write-only )  \ Port bit reset register  GPIOn_BRR
GPIOB $18 + constant GPIOB_LCKR ( read-write )  \ Port configuration lock  register
: GPIOB_CRL. cr ." GPIOB_CRL.  RW   $" GPIOB_CRL @ dup hex.  bin1. ;
: GPIOB_CRH. cr ." GPIOB_CRH.  RW   $" GPIOB_CRH @ dup hex.  bin1. ;
: GPIOB_IDR. cr ." GPIOB_IDR.  RO   $" GPIOB_IDR @ dup hex.  bin1. ;
: GPIOB_ODR. cr ." GPIOB_ODR.  RW   $" GPIOB_ODR @ dup hex.  bin1. ;
: GPIOB_BSRR. cr ." GPIOB_BSRR " WRITEONLY ; 
: GPIOB_BRR. cr ." GPIOB_BRR " WRITEONLY ; 
: GPIOB_LCKR. cr ." GPIOB_LCKR.  RW   $" GPIOB_LCKR @ dup hex.  bin1. ;
: GPIOB.
GPIOB_CRL.
GPIOB_CRH.
GPIOB_IDR.
GPIOB_ODR.
GPIOB_BSRR.
GPIOB_BRR.
GPIOB_LCKR.
;

$40011000 constant GPIOC ( General purpose I/O ) 
GPIOC $0 + constant GPIOC_CRL ( read-write )  \ Port configuration register low  GPIOn_CRL
GPIOC $4 + constant GPIOC_CRH ( read-write )  \ Port configuration register high  GPIOn_CRL
GPIOC $8 + constant GPIOC_IDR ( read-only )  \ Port input data register  GPIOn_IDR
GPIOC $C + constant GPIOC_ODR ( read-write )  \ Port output data register  GPIOn_ODR
GPIOC $10 + constant GPIOC_BSRR ( write-only )  \ Port bit set/reset register  GPIOn_BSRR
GPIOC $14 + constant GPIOC_BRR ( write-only )  \ Port bit reset register  GPIOn_BRR
GPIOC $18 + constant GPIOC_LCKR ( read-write )  \ Port configuration lock  register
: GPIOC_CRL. cr ." GPIOC_CRL.  RW   $" GPIOC_CRL @ dup hex.  bin1. ;
: GPIOC_CRH. cr ." GPIOC_CRH.  RW   $" GPIOC_CRH @ dup hex.  bin1. ;
: GPIOC_IDR. cr ." GPIOC_IDR.  RO   $" GPIOC_IDR @ dup hex.  bin1. ;
: GPIOC_ODR. cr ." GPIOC_ODR.  RW   $" GPIOC_ODR @ dup hex.  bin1. ;
: GPIOC_BSRR. cr ." GPIOC_BSRR " WRITEONLY ; 
: GPIOC_BRR. cr ." GPIOC_BRR " WRITEONLY ; 
: GPIOC_LCKR. cr ." GPIOC_LCKR.  RW   $" GPIOC_LCKR @ dup hex.  bin1. ;
: GPIOC.
GPIOC_CRL.
GPIOC_CRH.
GPIOC_IDR.
GPIOC_ODR.
GPIOC_BSRR.
GPIOC_BRR.
GPIOC_LCKR.
;

$40010400 constant EXTI ( EXTI ) 
EXTI $0 + constant EXTI_IMR ( read-write )  \ Interrupt mask register  EXTI_IMR
EXTI $4 + constant EXTI_EMR ( read-write )  \ Event mask register EXTI_EMR
EXTI $8 + constant EXTI_RTSR ( read-write )  \ Rising Trigger selection register  EXTI_RTSR
EXTI $C + constant EXTI_FTSR ( read-write )  \ Falling Trigger selection register  EXTI_FTSR
EXTI $10 + constant EXTI_SWIER ( read-write )  \ Software interrupt event register  EXTI_SWIER
EXTI $14 + constant EXTI_PR ( read-write )  \ Pending register EXTI_PR
: EXTI_IMR. cr ." EXTI_IMR.  RW   $" EXTI_IMR @ dup hex.  bin1. ;
: EXTI_EMR. cr ." EXTI_EMR.  RW   $" EXTI_EMR @ dup hex.  bin1. ;
: EXTI_RTSR. cr ." EXTI_RTSR.  RW   $" EXTI_RTSR @ dup hex.  bin1. ;
: EXTI_FTSR. cr ." EXTI_FTSR.  RW   $" EXTI_FTSR @ dup hex.  bin1. ;
: EXTI_SWIER. cr ." EXTI_SWIER.  RW   $" EXTI_SWIER @ dup hex.  bin1. ;
: EXTI_PR. cr ." EXTI_PR.  RW   $" EXTI_PR @ dup hex.  bin1. ;
: EXTI.
EXTI_IMR.
EXTI_EMR.
EXTI_RTSR.
EXTI_FTSR.
EXTI_SWIER.
EXTI_PR.
;

$40000000 constant TIM2 ( General purpose timer ) 
TIM2 $0 + constant TIM2_CR1 ( read-write )  \ control register 1
TIM2 $4 + constant TIM2_CR2 ( read-write )  \ control register 2
TIM2 $8 + constant TIM2_SMCR ( read-write )  \ slave mode control register
TIM2 $C + constant TIM2_DIER ( read-write )  \ DMA/Interrupt enable register
TIM2 $10 + constant TIM2_SR ( read-write )  \ status register
TIM2 $14 + constant TIM2_EGR ( write-only )  \ event generation register
TIM2 $18 + constant TIM2_CCMR1_Output ( read-write )  \ capture/compare mode register 1 output  mode
TIM2 $18 + constant TIM2_CCMR1_Input ( read-write )  \ capture/compare mode register 1 input  mode
TIM2 $1C + constant TIM2_CCMR2_Output ( read-write )  \ capture/compare mode register 2 output  mode
TIM2 $1C + constant TIM2_CCMR2_Input ( read-write )  \ capture/compare mode register 2 input  mode
TIM2 $20 + constant TIM2_CCER ( read-write )  \ capture/compare enable  register
TIM2 $24 + constant TIM2_CNT ( read-write )  \ counter
TIM2 $28 + constant TIM2_PSC ( read-write )  \ prescaler
TIM2 $2C + constant TIM2_ARR ( read-write )  \ auto-reload register
TIM2 $34 + constant TIM2_CCR1 ( read-write )  \ capture/compare register 1
TIM2 $38 + constant TIM2_CCR2 ( read-write )  \ capture/compare register 2
TIM2 $3C + constant TIM2_CCR3 ( read-write )  \ capture/compare register 3
TIM2 $40 + constant TIM2_CCR4 ( read-write )  \ capture/compare register 4
TIM2 $48 + constant TIM2_DCR ( read-write )  \ DMA control register
TIM2 $4C + constant TIM2_DMAR ( read-write )  \ DMA address for full transfer
: TIM2_CR1. cr ." TIM2_CR1.  RW   $" TIM2_CR1 @ dup hex.  bin1. ;
: TIM2_CR2. cr ." TIM2_CR2.  RW   $" TIM2_CR2 @ dup hex.  bin1. ;
: TIM2_SMCR. cr ." TIM2_SMCR.  RW   $" TIM2_SMCR @ dup hex.  bin1. ;
: TIM2_DIER. cr ." TIM2_DIER.  RW   $" TIM2_DIER @ dup hex.  bin1. ;
: TIM2_SR. cr ." TIM2_SR.  RW   $" TIM2_SR @ dup hex.  bin1. ;
: TIM2_EGR. cr ." TIM2_EGR " WRITEONLY ; 
: TIM2_CCMR1_Output. cr ." TIM2_CCMR1_Output.  RW   $" TIM2_CCMR1_Output @ dup hex.  bin1. ;
: TIM2_CCMR1_Input. cr ." TIM2_CCMR1_Input.  RW   $" TIM2_CCMR1_Input @ dup hex.  bin1. ;
: TIM2_CCMR2_Output. cr ." TIM2_CCMR2_Output.  RW   $" TIM2_CCMR2_Output @ dup hex.  bin1. ;
: TIM2_CCMR2_Input. cr ." TIM2_CCMR2_Input.  RW   $" TIM2_CCMR2_Input @ dup hex.  bin1. ;
: TIM2_CCER. cr ." TIM2_CCER.  RW   $" TIM2_CCER @ dup hex.  bin1. ;
: TIM2_CNT. cr ." TIM2_CNT.  RW   $" TIM2_CNT @ dup hex.  bin1. ;
: TIM2_PSC. cr ." TIM2_PSC.  RW   $" TIM2_PSC @ dup hex.  bin1. ;
: TIM2_ARR. cr ." TIM2_ARR.  RW   $" TIM2_ARR @ dup hex.  bin1. ;
: TIM2_CCR1. cr ." TIM2_CCR1.  RW   $" TIM2_CCR1 @ dup hex.  bin1. ;
: TIM2_CCR2. cr ." TIM2_CCR2.  RW   $" TIM2_CCR2 @ dup hex.  bin1. ;
: TIM2_CCR3. cr ." TIM2_CCR3.  RW   $" TIM2_CCR3 @ dup hex.  bin1. ;
: TIM2_CCR4. cr ." TIM2_CCR4.  RW   $" TIM2_CCR4 @ dup hex.  bin1. ;
: TIM2_DCR. cr ." TIM2_DCR.  RW   $" TIM2_DCR @ dup hex.  bin1. ;
: TIM2_DMAR. cr ." TIM2_DMAR.  RW   $" TIM2_DMAR @ dup hex.  bin1. ;
: TIM2.
TIM2_CR1.
TIM2_CR2.
TIM2_SMCR.
TIM2_DIER.
TIM2_SR.
TIM2_EGR.
TIM2_CCMR1_Output.
TIM2_CCMR1_Input.
TIM2_CCMR2_Output.
TIM2_CCMR2_Input.
TIM2_CCER.
TIM2_CNT.
TIM2_PSC.
TIM2_ARR.
TIM2_CCR1.
TIM2_CCR2.
TIM2_CCR3.
TIM2_CCR4.
TIM2_DCR.
TIM2_DMAR.
;

$40005400 constant I2C1 ( Inter integrated circuit ) 
I2C1 $0 + constant I2C1_CR1 ( read-write )  \ Control register 1
I2C1 $4 + constant I2C1_CR2 ( read-write )  \ Control register 2
I2C1 $8 + constant I2C1_OAR1 ( read-write )  \ Own address register 1
I2C1 $C + constant I2C1_OAR2 ( read-write )  \ Own address register 2
I2C1 $10 + constant I2C1_DR ( read-write )  \ Data register
I2C1 $14 + constant I2C1_SR1 (  )  \ Status register 1
I2C1 $18 + constant I2C1_SR2 ( read-only )  \ Status register 2
I2C1 $1C + constant I2C1_CCR ( read-write )  \ Clock control register
I2C1 $20 + constant I2C1_TRISE ( read-write )  \ TRISE register
: I2C1_CR1. cr ." I2C1_CR1.  RW   $" I2C1_CR1 @ dup hex.  bin1. ;
: I2C1_CR2. cr ." I2C1_CR2.  RW   $" I2C1_CR2 @ dup hex.  bin1. ;
: I2C1_OAR1. cr ." I2C1_OAR1.  RW   $" I2C1_OAR1 @ dup hex.  bin1. ;
: I2C1_OAR2. cr ." I2C1_OAR2.  RW   $" I2C1_OAR2 @ dup hex.  bin1. ;
: I2C1_DR. cr ." I2C1_DR.  RW   $" I2C1_DR @ dup hex.  bin1. ;
: I2C1_SR1. cr ." I2C1_SR1.   $" I2C1_SR1 @ dup hex.  bin1. ;
: I2C1_SR2. cr ." I2C1_SR2.  RO   $" I2C1_SR2 @ dup hex.  bin1. ;
: I2C1_CCR. cr ." I2C1_CCR.  RW   $" I2C1_CCR @ dup hex.  bin1. ;
: I2C1_TRISE. cr ." I2C1_TRISE.  RW   $" I2C1_TRISE @ dup hex.  bin1. ;
: I2C1.
I2C1_CR1.
I2C1_CR2.
I2C1_OAR1.
I2C1_OAR2.
I2C1_DR.
I2C1_SR1.
I2C1_SR2.
I2C1_CCR.
I2C1_TRISE.
;

$40013000 constant SPI1 ( Serial peripheral interface ) 
SPI1 $0 + constant SPI1_CR1 ( read-write )  \ control register 1
SPI1 $4 + constant SPI1_CR2 ( read-write )  \ control register 2
SPI1 $8 + constant SPI1_SR (  )  \ status register
SPI1 $C + constant SPI1_DR ( read-write )  \ data register
SPI1 $10 + constant SPI1_CRCPR ( read-write )  \ CRC polynomial register
SPI1 $14 + constant SPI1_RXCRCR ( read-only )  \ RX CRC register
SPI1 $18 + constant SPI1_TXCRCR ( read-only )  \ TX CRC register
SPI1 $1C + constant SPI1_I2SCFGR ( read-write )  \ I2S configuration register
SPI1 $20 + constant SPI1_I2SPR ( read-write )  \ I2S prescaler register
: SPI1_CR1. cr ." SPI1_CR1.  RW   $" SPI1_CR1 @ dup hex.  bin1. ;
: SPI1_CR2. cr ." SPI1_CR2.  RW   $" SPI1_CR2 @ dup hex.  bin1. ;
: SPI1_SR. cr ." SPI1_SR.   $" SPI1_SR @ dup hex.  bin1. ;
: SPI1_DR. cr ." SPI1_DR.  RW   $" SPI1_DR @ dup hex.  bin1. ;
: SPI1_CRCPR. cr ." SPI1_CRCPR.  RW   $" SPI1_CRCPR @ dup hex.  bin1. ;
: SPI1_RXCRCR. cr ." SPI1_RXCRCR.  RO   $" SPI1_RXCRCR @ dup hex.  bin1. ;
: SPI1_TXCRCR. cr ." SPI1_TXCRCR.  RO   $" SPI1_TXCRCR @ dup hex.  bin1. ;
: SPI1_I2SCFGR. cr ." SPI1_I2SCFGR.  RW   $" SPI1_I2SCFGR @ dup hex.  bin1. ;
: SPI1_I2SPR. cr ." SPI1_I2SPR.  RW   $" SPI1_I2SPR @ dup hex.  bin1. ;
: SPI1.
SPI1_CR1.
SPI1_CR2.
SPI1_SR.
SPI1_DR.
SPI1_CRCPR.
SPI1_RXCRCR.
SPI1_TXCRCR.
SPI1_I2SCFGR.
SPI1_I2SPR.
;

$40012400 constant ADC1 ( Analog to digital converter ) 
ADC1 $0 + constant ADC1_SR ( read-write )  \ status register
ADC1 $4 + constant ADC1_CR1 ( read-write )  \ control register 1
ADC1 $8 + constant ADC1_CR2 ( read-write )  \ control register 2
ADC1 $C + constant ADC1_SMPR1 ( read-write )  \ sample time register 1
ADC1 $10 + constant ADC1_SMPR2 ( read-write )  \ sample time register 2
ADC1 $14 + constant ADC1_JOFR1 ( read-write )  \ injected channel data offset register  x
ADC1 $18 + constant ADC1_JOFR2 ( read-write )  \ injected channel data offset register  x
ADC1 $1C + constant ADC1_JOFR3 ( read-write )  \ injected channel data offset register  x
ADC1 $20 + constant ADC1_JOFR4 ( read-write )  \ injected channel data offset register  x
ADC1 $24 + constant ADC1_HTR ( read-write )  \ watchdog higher threshold  register
ADC1 $28 + constant ADC1_LTR ( read-write )  \ watchdog lower threshold  register
ADC1 $2C + constant ADC1_SQR1 ( read-write )  \ regular sequence register 1
ADC1 $30 + constant ADC1_SQR2 ( read-write )  \ regular sequence register 2
ADC1 $34 + constant ADC1_SQR3 ( read-write )  \ regular sequence register 3
ADC1 $38 + constant ADC1_JSQR ( read-write )  \ injected sequence register
ADC1 $3C + constant ADC1_JDR1 ( read-only )  \ injected data register x
ADC1 $40 + constant ADC1_JDR2 ( read-only )  \ injected data register x
ADC1 $44 + constant ADC1_JDR3 ( read-only )  \ injected data register x
ADC1 $48 + constant ADC1_JDR4 ( read-only )  \ injected data register x
ADC1 $4C + constant ADC1_DR ( read-only )  \ regular data register
: ADC1_SR. cr ." ADC1_SR.  RW   $" ADC1_SR @ dup hex.  bin1. ;
: ADC1_CR1. cr ." ADC1_CR1.  RW   $" ADC1_CR1 @ dup hex.  bin1. ;
: ADC1_CR2. cr ." ADC1_CR2.  RW   $" ADC1_CR2 @ dup hex.  bin1. ;
: ADC1_SMPR1. cr ." ADC1_SMPR1.  RW   $" ADC1_SMPR1 @ dup hex.  bin1. ;
: ADC1_SMPR2. cr ." ADC1_SMPR2.  RW   $" ADC1_SMPR2 @ dup hex.  bin1. ;
: ADC1_JOFR1. cr ." ADC1_JOFR1.  RW   $" ADC1_JOFR1 @ dup hex.  bin1. ;
: ADC1_JOFR2. cr ." ADC1_JOFR2.  RW   $" ADC1_JOFR2 @ dup hex.  bin1. ;
: ADC1_JOFR3. cr ." ADC1_JOFR3.  RW   $" ADC1_JOFR3 @ dup hex.  bin1. ;
: ADC1_JOFR4. cr ." ADC1_JOFR4.  RW   $" ADC1_JOFR4 @ dup hex.  bin1. ;
: ADC1_HTR. cr ." ADC1_HTR.  RW   $" ADC1_HTR @ dup hex.  bin1. ;
: ADC1_LTR. cr ." ADC1_LTR.  RW   $" ADC1_LTR @ dup hex.  bin1. ;
: ADC1_SQR1. cr ." ADC1_SQR1.  RW   $" ADC1_SQR1 @ dup hex.  bin1. ;
: ADC1_SQR2. cr ." ADC1_SQR2.  RW   $" ADC1_SQR2 @ dup hex.  bin1. ;
: ADC1_SQR3. cr ." ADC1_SQR3.  RW   $" ADC1_SQR3 @ dup hex.  bin1. ;
: ADC1_JSQR. cr ." ADC1_JSQR.  RW   $" ADC1_JSQR @ dup hex.  bin1. ;
: ADC1_JDR1. cr ." ADC1_JDR1.  RO   $" ADC1_JDR1 @ dup hex.  bin1. ;
: ADC1_JDR2. cr ." ADC1_JDR2.  RO   $" ADC1_JDR2 @ dup hex.  bin1. ;
: ADC1_JDR3. cr ." ADC1_JDR3.  RO   $" ADC1_JDR3 @ dup hex.  bin1. ;
: ADC1_JDR4. cr ." ADC1_JDR4.  RO   $" ADC1_JDR4 @ dup hex.  bin1. ;
: ADC1_DR. cr ." ADC1_DR.  RO   $" ADC1_DR @ dup hex.  bin1. ;
: ADC1.
ADC1_SR.
ADC1_CR1.
ADC1_CR2.
ADC1_SMPR1.
ADC1_SMPR2.
ADC1_JOFR1.
ADC1_JOFR2.
ADC1_JOFR3.
ADC1_JOFR4.
ADC1_HTR.
ADC1_LTR.
ADC1_SQR1.
ADC1_SQR2.
ADC1_SQR3.
ADC1_JSQR.
ADC1_JDR1.
ADC1_JDR2.
ADC1_JDR3.
ADC1_JDR4.
ADC1_DR.
;

$E0042000 constant DBG ( Debug support ) 
DBG $0 + constant DBG_IDCODE ( read-only )  \ DBGMCU_IDCODE
DBG $4 + constant DBG_CR ( read-write )  \ DBGMCU_CR
: DBG_IDCODE. cr ." DBG_IDCODE.  RO   $" DBG_IDCODE @ dup hex.  bin1. ;
: DBG_CR. cr ." DBG_CR.  RW   $" DBG_CR @ dup hex.  bin1. ;
: DBG.
DBG_IDCODE.
DBG_CR.
;

$E000E000 constant NVIC ( Nested Vectored Interrupt  Controller ) 
NVIC $4 + constant NVIC_ICTR ( read-only )  \ Interrupt Controller Type  Register
NVIC $F00 + constant NVIC_STIR ( write-only )  \ Software Triggered Interrupt  Register
NVIC $100 + constant NVIC_ISER0 ( read-write )  \ Interrupt Set-Enable Register
NVIC $104 + constant NVIC_ISER1 ( read-write )  \ Interrupt Set-Enable Register
NVIC $180 + constant NVIC_ICER0 ( read-write )  \ Interrupt Clear-Enable  Register
NVIC $184 + constant NVIC_ICER1 ( read-write )  \ Interrupt Clear-Enable  Register
NVIC $200 + constant NVIC_ISPR0 ( read-write )  \ Interrupt Set-Pending Register
NVIC $204 + constant NVIC_ISPR1 ( read-write )  \ Interrupt Set-Pending Register
NVIC $280 + constant NVIC_ICPR0 ( read-write )  \ Interrupt Clear-Pending  Register
NVIC $284 + constant NVIC_ICPR1 ( read-write )  \ Interrupt Clear-Pending  Register
NVIC $300 + constant NVIC_IABR0 ( read-only )  \ Interrupt Active Bit Register
NVIC $304 + constant NVIC_IABR1 ( read-only )  \ Interrupt Active Bit Register
NVIC $400 + constant NVIC_IPR0 ( read-write )  \ Interrupt Priority Register
NVIC $404 + constant NVIC_IPR1 ( read-write )  \ Interrupt Priority Register
NVIC $408 + constant NVIC_IPR2 ( read-write )  \ Interrupt Priority Register
NVIC $40C + constant NVIC_IPR3 ( read-write )  \ Interrupt Priority Register
NVIC $410 + constant NVIC_IPR4 ( read-write )  \ Interrupt Priority Register
NVIC $414 + constant NVIC_IPR5 ( read-write )  \ Interrupt Priority Register
NVIC $418 + constant NVIC_IPR6 ( read-write )  \ Interrupt Priority Register
NVIC $41C + constant NVIC_IPR7 ( read-write )  \ Interrupt Priority Register
NVIC $420 + constant NVIC_IPR8 ( read-write )  \ Interrupt Priority Register
NVIC $424 + constant NVIC_IPR9 ( read-write )  \ Interrupt Priority Register
NVIC $428 + constant NVIC_IPR10 ( read-write )  \ Interrupt Priority Register
NVIC $42C + constant NVIC_IPR11 ( read-write )  \ Interrupt Priority Register
NVIC $430 + constant NVIC_IPR12 ( read-write )  \ Interrupt Priority Register
NVIC $434 + constant NVIC_IPR13 ( read-write )  \ Interrupt Priority Register
NVIC $438 + constant NVIC_IPR14 ( read-write )  \ Interrupt Priority Register
: NVIC_ICTR. cr ." NVIC_ICTR.  RO   $" NVIC_ICTR @ dup hex.  bin1. ;
: NVIC_STIR. cr ." NVIC_STIR " WRITEONLY ; 
: NVIC_ISER0. cr ." NVIC_ISER0.  RW   $" NVIC_ISER0 @ dup hex.  bin1. ;
: NVIC_ISER1. cr ." NVIC_ISER1.  RW   $" NVIC_ISER1 @ dup hex.  bin1. ;
: NVIC_ICER0. cr ." NVIC_ICER0.  RW   $" NVIC_ICER0 @ dup hex.  bin1. ;
: NVIC_ICER1. cr ." NVIC_ICER1.  RW   $" NVIC_ICER1 @ dup hex.  bin1. ;
: NVIC_ISPR0. cr ." NVIC_ISPR0.  RW   $" NVIC_ISPR0 @ dup hex.  bin1. ;
: NVIC_ISPR1. cr ." NVIC_ISPR1.  RW   $" NVIC_ISPR1 @ dup hex.  bin1. ;
: NVIC_ICPR0. cr ." NVIC_ICPR0.  RW   $" NVIC_ICPR0 @ dup hex.  bin1. ;
: NVIC_ICPR1. cr ." NVIC_ICPR1.  RW   $" NVIC_ICPR1 @ dup hex.  bin1. ;
: NVIC_IABR0. cr ." NVIC_IABR0.  RO   $" NVIC_IABR0 @ dup hex.  bin1. ;
: NVIC_IABR1. cr ." NVIC_IABR1.  RO   $" NVIC_IABR1 @ dup hex.  bin1. ;
: NVIC_IPR0. cr ." NVIC_IPR0.  RW   $" NVIC_IPR0 @ dup hex.  bin1. ;
: NVIC_IPR1. cr ." NVIC_IPR1.  RW   $" NVIC_IPR1 @ dup hex.  bin1. ;
: NVIC_IPR2. cr ." NVIC_IPR2.  RW   $" NVIC_IPR2 @ dup hex.  bin1. ;
: NVIC_IPR3. cr ." NVIC_IPR3.  RW   $" NVIC_IPR3 @ dup hex.  bin1. ;
: NVIC_IPR4. cr ." NVIC_IPR4.  RW   $" NVIC_IPR4 @ dup hex.  bin1. ;
: NVIC_IPR5. cr ." NVIC_IPR5.  RW   $" NVIC_IPR5 @ dup hex.  bin1. ;
: NVIC_IPR6. cr ." NVIC_IPR6.  RW   $" NVIC_IPR6 @ dup hex.  bin1. ;
: NVIC_IPR7. cr ." NVIC_IPR7.  RW   $" NVIC_IPR7 @ dup hex.  bin1. ;
: NVIC_IPR8. cr ." NVIC_IPR8.  RW   $" NVIC_IPR8 @ dup hex.  bin1. ;
: NVIC_IPR9. cr ." NVIC_IPR9.  RW   $" NVIC_IPR9 @ dup hex.  bin1. ;
: NVIC_IPR10. cr ." NVIC_IPR10.  RW   $" NVIC_IPR10 @ dup hex.  bin1. ;
: NVIC_IPR11. cr ." NVIC_IPR11.  RW   $" NVIC_IPR11 @ dup hex.  bin1. ;
: NVIC_IPR12. cr ." NVIC_IPR12.  RW   $" NVIC_IPR12 @ dup hex.  bin1. ;
: NVIC_IPR13. cr ." NVIC_IPR13.  RW   $" NVIC_IPR13 @ dup hex.  bin1. ;
: NVIC_IPR14. cr ." NVIC_IPR14.  RW   $" NVIC_IPR14 @ dup hex.  bin1. ;
: NVIC.
NVIC_ICTR.
NVIC_STIR.
NVIC_ISER0.
NVIC_ISER1.
NVIC_ICER0.
NVIC_ICER1.
NVIC_ISPR0.
NVIC_ISPR1.
NVIC_ICPR0.
NVIC_ICPR1.
NVIC_IABR0.
NVIC_IABR1.
NVIC_IPR0.
NVIC_IPR1.
NVIC_IPR2.
NVIC_IPR3.
NVIC_IPR4.
NVIC_IPR5.
NVIC_IPR6.
NVIC_IPR7.
NVIC_IPR8.
NVIC_IPR9.
NVIC_IPR10.
NVIC_IPR11.
NVIC_IPR12.
NVIC_IPR13.
NVIC_IPR14.
;


compiletoram
\ File: STM32F103C8T6.gpio.mode.fs 			   
\ Created: Mon  8 Feb 2021 14:09:48 AEDT							   
\ Author 2021 by t.j.porter <terry@tjporter.com.au>	   
\ Purpose: New format for STM32F1 GPIO modes			   
\ MCU: STM32F1xxx								   
\ Board: BluePill							   
\ Core: 								   
\ Required:							   
\ Recommended:							   
\ Based on:							   
\ Literature:							   
\ License: MIT, please see COPYING

compiletoflash

\ GPIO Configs, %1100  is reserved
\ STM32F1xx GPIO MODE constants
\ %0000 constant i.a	      \ input, analog
\ %0001 constant o.pp.10      \ output, push-pull, 10 mhz 
\ %0010 constant o.pp.2	      \ output, push-pull,  2 mhz 
\ %0011 constant o.pp.50      \ output, push-pull, 50 mhz
\ %0100 constant i.float      \ input, floating
\ %0101 constant o.od.10      \ output, open-drain, 10 mhz
\ %0110 constant o.od.2	      \ output, open-drain,  2 mhz
\ %0111 constant o.od.50      \ output, open-drain, 50 mhz
\ %1000 constant i.pullx      \ input, pullx
\ %1001 constant o.af.pp.10   \ output, alt func, push-pull, 10 mhz
\ %1010 constant o.af.pp.2    \ output, alt func, push-pull,  2 mhz
\ %1011 constant o.af.pp.50   \ output, alt func, push-pull, 50 mhz
\ %1101 constant o.af.od.10   \ output, alt func, open-drain, 10 mhz
\ %1110 constant o.af.od.2    \ output, alt func, open-drain,  2 mhz
\ %1111 constant o.af.od.50   \ output, alt func, open-drain, 50 mhz


\ GPIO Configs
\ These condense into 7 choices
%0000 constant input.analog	 \ input, analog
%0001 constant output.pp	 \ output, push-pull, 10 mhz
%0100 constant input.floating	 \ input, floating
%0101 constant output.od	 \ output, open-drain, 10 mhz
%1000 constant input.pullx	 \ pulldown ODR = 0 pullup ODR = 1 
%1001 constant output.af.pp	 \ output, alt func, push-pull, 10 mhz
%1101 constant output.af.od	 \ output, alt func, open-drain, 10 mhz

: gpio? ( -- ) ." Mode Syntax " cr     \ gpio syntax memory jogger Word
   ." input.analog " cr
   ." output.pp 10mhz " cr
   ." input.floating " cr
   ." output.od 10mhz " cr
   ." input.pullx  pulldown ODR = 0, pullup ODR = 1 " cr
   ." output.af.pp 10mhz " cr
   ." output.af.od 10mhz " cr cr
 ;


\ GPIOA_CRL (read-write) Reset:0x44444444
\  : GPIOA_CRL_MODE0<< ( %bbbb -- x ) 0  lshift ; 
\  : GPIOA_CRL_MODE1<< ( %bbbb -- x ) 4  lshift ; 
\  : GPIOA_CRL_MODE2<< ( %bbbb -- x ) 8  lshift ; 
\  : GPIOA_CRL_MODE3<< ( %bbbb -- x ) 12 lshift ; 
\  : GPIOA_CRL_MODE4<< ( %bbbb -- x ) 16 lshift ; 
\  : GPIOA_CRL_MODE5<< ( %bbbb -- x ) 20 lshift ; 
\  : GPIOA_CRL_MODE6<< ( %bbbb -- x ) 24 lshift ; 
\  : GPIOA_CRL_MODE7<< ( %bbbb -- x ) 28 lshift ; 
\  : GPIOA_CRL_MODE7<< ( %bbbb -- x ) 30 lshift ; 
 
\ GPIOA_CRH (read-write) Reset:0x44444444
\  : GPIOA_CRH_MODE8<<  ( %bbbb -- x ) 0  lshift ; 
\  : GPIOA_CRH_MODE9<<  ( %bbbb -- x ) 4  lshift ; 
\  : GPIOA_CRH_MODE10<< ( %bbbb -- x ) 8  lshift ; 
\  : GPIOA_CRH_MODE11<< ( %bbbb -- x ) 12 lshift ; 
\  : GPIOA_CRH_MODE12<< ( %bbbb -- x ) 16 lshift ; 
\  : GPIOA_CRH_MODE13<< ( %bbbb -- x ) 20 lshift ; 
\  : GPIOA_CRH_MODE14<< ( %bbbb -- x ) 24 lshift ; 
\  : GPIOA_CRH_MODE15<< ( %bbbb -- x ) 28 lshift ; 

\ GPIOB_CRL (read-write) Reset:0x44444444
\  : GPIOB_CRL_MODE0<< ( %bbbb -- x ) 0  lshift ; 
\  : GPIOB_CRL_MODE1<< ( %bbbb -- x ) 4  lshift ; 
\  : GPIOB_CRL_MODE2<< ( %bbbb -- x ) 8  lshift ; 
\  : GPIOB_CRL_MODE3<< ( %bbbb -- x ) 12 lshift ; 
\  : GPIOB_CRL_MODE4<< ( %bbbb -- x ) 16 lshift ; 
\  : GPIOB_CRL_MODE5<< ( %bbbb -- x ) 20 lshift ; 
\  : GPIOB_CRL_MODE6<< ( %bbbb -- x ) 24 lshift ; 
\  : GPIOB_CRL_MODE7<< ( %bbbb -- x ) 28 lshift ; 
\  : GPIOB_CRL_MODE7<< ( %bbbb -- x ) 30 lshift ; 
 
\ GPIOB_CRH (read-write) Reset:0x44444444
\  : GPIOB_CRH_MODE8<<  ( %bbbb -- x ) 0  lshift ; 
\  : GPIOB_CRH_MODE9<<  ( %bbbb -- x ) 4  lshift ; 
\  : GPIOB_CRH_MODE10<< ( %bbbb -- x ) 8  lshift ; 
\  : GPIOB_CRH_MODE11<< ( %bbbb -- x ) 12 lshift ; 
\  : GPIOB_CRH_MODE12<< ( %bbbb -- x ) 16 lshift ; 
\  : GPIOB_CRH_MODE13<< ( %bbbb -- x ) 20 lshift ; 
\  : GPIOB_CRH_MODE14<< ( %bbbb -- x ) 24 lshift ; 
\  : GPIOB_CRH_MODE15<< ( %bbbb -- x ) 28 lshift ;

\ GPIOC_CRL (read-write) Reset:0x44444444
\  : GPIOC_CRL_MODE0<< ( %bbbb -- x ) 0  lshift ; 
\  : GPIOC_CRL_MODE1<< ( %bbbb -- x ) 4  lshift ; 
\  : GPIOC_CRL_MODE2<< ( %bbbb -- x ) 8  lshift ; 
\  : GPIOC_CRL_MODE3<< ( %bbbb -- x ) 12 lshift ; 
\  : GPIOC_CRL_MODE4<< ( %bbbb -- x ) 16 lshift ; 
\  : GPIOC_CRL_MODE5<< ( %bbbb -- x ) 20 lshift ; 
\  : GPIOC_CRL_MODE6<< ( %bbbb -- x ) 24 lshift ; 
\  : GPIOC_CRL_MODE7<< ( %bbbb -- x ) 28 lshift ; 
\  : GPIOC_CRL_MODE7<< ( %bbbb -- x ) 30 lshift ; 
 
\ GPIOC_CRH (read-write) Reset:0x44444444
\  : GPIOC_CRH_MODE8<<  ( %bbbb -- x ) 0  lshift ; 
\  : GPIOC_CRH_MODE9<<  ( %bbbb -- x ) 4  lshift ; 
\  : GPIOC_CRH_MODE10<< ( %bbbb -- x ) 8  lshift ; 
\  : GPIOC_CRH_MODE11<< ( %bbbb -- x ) 12 lshift ; 
\  : GPIOC_CRH_MODE12<< ( %bbbb -- x ) 16 lshift ; 
\  : GPIOC_CRH_MODE13<< ( %bbbb -- x ) 20 lshift ; 
\  : GPIOC_CRH_MODE14<< ( %bbbb -- x ) 24 lshift ; 
\  : GPIOC_CRH_MODE15<< ( %bbbb -- x ) 28 lshift ;

compiletoram
\ Program Name: f103-scb-constants.fs
\ Copyright 2020  t.porter <terry@tjporter.com.au>, licensed under the GPL
\ For Mecrisp-Stellaris by Matthias Koch
\ Chip: STM32F103
\ All register names must be CMSIS-SVD compliant
\ Note: gpio a,b,c,d,e, and uart1 are enabled by Mecrisp-Stellaris core as default.
\
\ This Program : System control block (SCB) 
\ Note the SCB is not a part of the STM32F CMSIS-SVD
\ See: ST PM0056 Programming manual, page 149
\ 0xE000ED00-0xE000ED3F
\ ------------------------------------------------------------------------------------------------------  
compiletoflash 


\ SCB constants
$E000ED00 CONSTANT SCB_CPUID    \ RO $412FC231 CPUID Base Register    
$E000ED04 CONSTANT SCB_ICSR     \ $00000000 Interrupt Control and State Register
$E000ED08 CONSTANT SCB_VTOR     \ $00000000 Vector Table Offset Register  
$E000ED0C CONSTANT SCB_AIRCR    \ $00000000 Application Interrupt and Reset Control Register  
$E000ED10 CONSTANT SCB_SCR      \ $00000000 System Control Register 
$E000ED14 CONSTANT SCB_CCR      \ $00000200 Configuration and Control Register
$E000ED18 CONSTANT SCB_SHPR1    \ $00000000 System Handler Priority Register 1  
$E000ED1C CONSTANT SCB_SHPR2    \ $00000000 System Handler Priority Register 2 
$E000ED20 CONSTANT SCB_SHPR3    \ $00000000 System Handler Priority Register 3  
$E000ED24 CONSTANT SCB_SHCSR    \ $00000000 System Handler Control and State Register
$E000ED28 CONSTANT SCB_CFSR     \ $00000000 Configurable Fault Status Registers
$E000ED2C CONSTANT SCB_HFSR     \ $00000000 HardFault Status Register
\ $E000ED30 CONSTANT SCB_DFSR     \ $00000000 Debug Fault Status Register
$E000ED34 CONSTANT SCB_MMFAR     \ $00000000 MemManage Fault Address Register
$E000ED38 CONSTANT SCB_BFAR     \ BusFault Address Register
\ $E000ED3C CONSTANT SCB_AFSR     \ $00000000 Auxiliary Fault Status Register
\ $E000ED40 CONSTANT SCB_ID_PFR0  \ RO $00000030 Processor Feature Register 0
\ $E000ED44 CONSTANT SCB_ID_PFR1  \ RO $00000200 Processor Feature Register 1
\ $E000ED48 CONSTANT SCB_ID_DFR0  \ RO $00100000 Debug Features Register 0c
\ $E000ED4C CONSTANT SCB_ID_AFR0  \ RO $00000000 Auxiliary Features Register 0
\ $E000ED50 CONSTANT SCB_ID_MMFR0 \ RO $00100030 Memory Model Feature Register 0
\ $E000ED54 CONSTANT SCB_ID_MMFR1 \ RO $00000000 Memory Model Feature Register 1
\ $E000ED58 CONSTANT SCB_ID_MMFR2 \ RO $01000000 Memory Model Feature Register 2
\ $E000ED5C CONSTANT SCB_ID_MMFR3 \ RO $00000000 Memory Model Feature Register 3
\ $E000ED60 CONSTANT SCB_ID_ISAR0 \ RO $01100110 Instruction Set Attributes Register 0
\ $E000ED64 CONSTANT SCB_ID_ISAR1 \ RO $02111000 Instruction Set Attributes Register 1
\ $E000ED68 CONSTANT SCB_ID_ISAR2 \ RO $21112231 Instruction Set Attributes Register 2
\ $E000ED6C CONSTANT SCB_ID_ISAR3 \ RO $01111110 Instruction Set Attributes Register 3
\ $E000ED70 CONSTANT SCB_ID_ISAR4 \ RO $01310132 Instruction Set Attributes Register 4
\ $E000ED88 CONSTANT SCB_CPACR    \ RW $00000000 Coprocessor Access Control Register
\ $E000EF00 CONSTANT SCB_STIR     \ WO $00000000 Software Triggered Interrupt Register








compiletoram
\ Program Name: f103-systick-constants.fs
\ Date: 17 March 2020
\ Copyright 2020 by t.j.porter <terry@tjporter.com.au>, licensed under the GPLV2
\ For Mecrisp-Stellaris by Matthias Koch.
\ https://sourceforge.net/projects/mecrisp/
\ Chip: STM32F103
\ Clock: 72 Mhz
\ All register names are CMSIS-SVD compliant
\ Note: gpio a,b,c,d,e, and uart1 are enabled by Mecrisp-Stellaris Core.
\ Standalone: no preloaded support files required
\
\ This Program : Systick Constants
\ 0xE000E010-0xE000E01F System timer PM0056 Table 49 on page 154
\ ---------------------------------------------------------------------------\
\ compiletoram
 compiletoflash

\ Cortex-M0 STK constants  24 bit range = $00000001-$00FFFFFF
$E000E010   CONSTANT STK_CSR     \ RW  SysTick control and status register (STK_CSR) on page 86
$E000E014   CONSTANT STK_RVR     \ RW  SysTick reload value register (STK_RVR) on page 87
$E000E018   CONSTANT STK_CVR     \ RW  SysTick current value register (STK_CVR) on page 87
$E000E01C   CONSTANT STK_CALIB   \ RO  SysTick calibration value register (STK_CALIB) on page 88


\ STM32F103 naming so source for M0 can be used
STK_CSR	    CONSTANT STK_CTRL   \ RW SysTick control and status register
STK_RVR	    CONSTANT STK_LOAD   \ RW SysTick reload value register
STK_CVR	    CONSTANT STK_VAL    \ RW SysTick current value register
\ STK_CALIB   CONSTANT STK_CALIB  \ RO SysTick calibration value register


compiletoram



compiletoflash

\ A convenient memory dump helper

\  : u.4 ( u -- ) 0 <# # # # # #> type ;
\  : u.2 ( u -- ) 0 <# # # #> type ;

: dump16 ( addr -- ) \ Print 16 bytes memory
  base @ >r hex
  $F bic
  dup hex. ." :  "

  dup 16 + over do
    i c@ u.2 space \ Print data with 2 digits
    i $F and 7 = if 2 spaces then
  loop

  ."  | "

  dup 16 + swap do
        i c@ 32 u>= i c@ 127 u< and if i c@ emit else [char] . emit then
        i $F and 7 = if 2 spaces then
      loop

  ."  |" cr
  r> base !
;

: dump ( addr len -- ) \ Print a memory region
  cr
  over 15 and if 16 + then \ One more line if not aligned on 16
  begin
    swap ( len addr )
    dup dump16
    16 + ( len addr+16 )
    swap 16 - ( addr+16 len-16 )
    dup 0<
  until
  2drop
;
\ ------------------------
\ Words4 a 4 columnar list
\ of words by tp
\ ------------------------

\ 148 bytes

compiletoflash

: words4 ( -- ) cr  \ A columnar Word list printer. Width = 20 characters, handles overlength Words neatly
   0                                \ column counter
   dictionarystart
      begin
         dup 6 + dup
         ctype                      \ dup before 6 is for dictionarynext input
         count nip                  \ get number of characters in the word and drop the address of the word
             20 swap - dup 0 > if   \ if Word is less than 20 chars
                   spaces swap      \ pad with spaces to equal 20 chars
                   else drop cr     \ issue immediate carriage return and drop negative number
                   nip -1           \ and reset to column -1
                   then
                      dup 3 = if 3 - cr \ if at 4th column, zero column counter
                      else 1 +
                      then
         swap
         dictionarynext             \   ( a-addr - - a-addr flag )
      until
   2drop
;

compiletoram
\ USB driver for STM32F103 by Jean-Claude Wippler,
\ based on the Coreforth USB driver by Eckhart Köppen
\ file:///usr/home/tp/projects/stm32f0-doc/sphinx/_build/html/usb-stm32f103.html
\ modified by tp to work with my system
\ configured for Shenzhen LC Technology board with STM32F103C8T6 which is the same as the Bluepill with USB-DP on PA12

\ The board specific code is in +usb and needs to be changed for other
\ ways to signal a new connection by pulling D+ low briefly.

\ Other configs are available here:
\ /home/tp/projects/programming-languages/forth/mecrisp-stellaris/library/embello-1608-forth/suf
\ ### Boards
\ * **generic** 
\ * **hotcbo** 
\ * **hytiny** 
\ * **maplemini** 
\ * **olimexino** 
\ * **olip103** 
\ * **port103z** 

compiletoflash

\ -----------------------------------------------------------------------------
\  Chip serial number
\ -----------------------------------------------------------------------------

: chipid ( -- u1 u2 u3 3 )  \ unique chip ID as N values on the stack
  $1FFFF7E8 @ $1FFFF7EC @ $1FFFF7F0 @ 3 ;
: hwid ( -- u )  \ a "fairly unique" hardware ID as single 32-bit int
  chipid 1 do xor loop ;

\ -----------------------------------------------------------------------------
\   Flash tools
\ -----------------------------------------------------------------------------

\ emulate c, which is not available in hardware on some chips.
\ copied from Mecrisp's common/charcomma.txt
0 variable c,collection

: c, ( c -- )  \ emulate c, with h,
  c,collection @ ?dup if $FF and swap 8 lshift or h,
                         0 c,collection !
                      else $100 or c,collection ! then ;

: calign ( -- )  \ must be called to flush after odd number of c, calls
  c,collection @ if 0 c, then ;


: flash-kb ( -- u )  \ return size of flash memory in KB
  $1FFFF7E0 h@ ;
: flash-pagesize ( addr - u )  \ return size of flash page at given address
  drop flash-kb 128 <= if 1024 else 2048 then ;

\ -----------------------------------------------------------------------------
\  Ring buffers
\ -----------------------------------------------------------------------------

\ ring buffers, for serial ports, etc - size must be 4..256 and power of 2
\ TODO setup is a bit messy right now, should put buffer: word inside init

\ each ring needs 4 extra bytes for internal housekeeping:
\   addr+0 = ring mask, i.e. N-1
\   addr+1 = put index: 0..255 (needs to be masked before use)
\   addr+2 = get index: 0..255 (needs to be masked before use)
\   addr+3 = spare
\   addr+4..addr+4+N-1 = actual ring buffer, N bytes
\ example:
\   16 4 + buffer: buf  buf 16 init-ring

: init-ring ( addr size -- )  \ initialise a ring buffer
  1- swap !  \ assumes little-endian so mask ends up in ring+0
;

: c++@ ( addr -- b addr+1 ) dup c@ swap 1+ ;  \ fetch and autoinc byte ptr

: ring-step ( ring 1/2 -- addr )  \ common code for saving and fetching
  over + ( ring ring-g/p ) dup c@ >r ( ring ring-g/p R: g/p )
  dup c@ 1+ swap c!  \ increment byte under ptr
  dup c@ r> and swap 4 + + ;

: ring# ( ring -- u )  \ return current number of bytes in the ring buffer
\ TODO could be turned into a single @ word access and made interrupt-safe
  c++@ c++@ c++@ drop - and ;
: ring? ( ring -- f )  \ true if the ring can accept more data
  dup ring# swap c@ < ;
: >ring ( b ring -- )  \ save byte to end of ring buffer
  1 ring-step c! ;
: ring> ( ring -- b )  \ fetch byte from start of ring buffer
  2 ring-step c@ ;

\ -----------------------------------------------------------------------------
\  USB Descriptors
\ -----------------------------------------------------------------------------

create usb:dev
  18 c,  \ bLength
  $01 c, \ USB_DEVICE_DESCRIPTOR_TYPE
  $00 c,
  $02 c, \ bcdUSB = 2.00
  $02 c, \ bDeviceClass: CDC
  $00 c, \ bDeviceSubClass
  $00 c, \ bDeviceProtocol
  $40 c, \ bMaxPacketSize0
  $83 c,
  $04 c, \ idVendor = 0x0483
  $40 c,
  $57 c, \ idProduct = 0x7540
  $00 c,
  $02 c, \ bcdDevice = 2.00
  1 c,     \ Index of string descriptor describing manufacturer
  2 c,     \ Index of string descriptor describing product
  3 c,     \ Index of string descriptor describing the device's serial number
  $01 c, \ bNumConfigurations
calign

create usb:conf  \ total length = 67 bytes
\ USB Configuration Descriptor
  9 c,   \ bLength: Configuration Descriptor size
  $02 c, \ USB_CONFIGURATION_DESCRIPTOR_TYPE
  67 c,  \ VIRTUAL_COM_PORT_SIZ_CONFIG_DESC
  0 c,
  2 c,   \ bNumInterfaces: 2 interface
  1 c,   \ bConfigurationValue
  0 c,   \ iConfiguration
  $C0 c, \ bmAttributes: self powered
  $32 c, \ MaxPower 0 mA
\ Interface Descriptor
  9 c,   \ bLength: Interface Descriptor size
  $04 c, \ USB_INTERFACE_DESCRIPTOR_TYPE
  $00 c, \ bInterfaceNumber: Number of Interface
  $00 c, \ bAlternateSetting: Alternate setting
  $01 c, \ bNumEndpoints: One endpoints used
  $02 c, \ bInterfaceClass: Communication Interface Class
  $02 c, \ bInterfaceSubClass: Abstract Control Model
  $01 c, \ bInterfaceProtocol: Common AT commands
  $00 c, \ iInterface:
\ Header Functional Descriptor
  5 c,   \ bLength: Endpoint Descriptor size
  $24 c, \ bDescriptorType: CS_INTERFACE
  $00 c, \ bDescriptorSubtype: Header Func Desc
  $10 c, \ bcdCDC: spec release number
  $01 c,
\ Call Management Functional Descriptor
  5 c,   \ bFunctionLength
  $24 c, \ bDescriptorType: CS_INTERFACE
  $01 c, \ bDescriptorSubtype: Call Management Func Desc
  $00 c, \ bmCapabilities: D0+D1
  $01 c, \ bDataInterface: 1
\ ACM Functional Descriptor
  4 c,   \ bFunctionLength
  $24 c, \ bDescriptorType: CS_INTERFACE
  $02 c, \ bDescriptorSubtype: Abstract Control Management desc
  $02 c, \ bmCapabilities
\ Union Functional Descriptor
  5 c,   \ bFunctionLength
  $24 c, \ bDescriptorType: CS_INTERFACE
  $06 c, \ bDescriptorSubtype: Union func desc
  $00 c, \ bMasterInterface: Communication class interface
  $01 c, \ bSlaveInterface0: Data Class Interface
\ Endpoint 2 Descriptor
  7 c,   \ bLength: Endpoint Descriptor size
  $05 c, \ USB_ENDPOINT_DESCRIPTOR_TYPE
  $82 c, \ bEndpointAddress: (IN2)
  $03 c, \ bmAttributes: Interrupt
  8 c,   \ VIRTUAL_COM_PORT_INT_SIZE
  0 c,
  $FF c, \ bInterval:
\ Data class interface descriptor
  9 c,   \ bLength: Endpoint Descriptor size
  $04 c, \ USB_INTERFACE_DESCRIPTOR_TYPE
  $01 c, \ bInterfaceNumber: Number of Interface
  $00 c, \ bAlternateSetting: Alternate setting
  $02 c, \ bNumEndpoints: Two endpoints used
  $0A c, \ bInterfaceClass: CDC
  $00 c, \ bInterfaceSubClass:
  $00 c, \ bInterfaceProtocol:
  $00 c, \ iInterface:
\ Endpoint 3 Descriptor
  7 c,   \ bLength: Endpoint Descriptor size
  $05 c, \ USB_ENDPOINT_DESCRIPTOR_TYPE
  $03 c, \ bEndpointAddress: (OUT3)
  $02 c, \ bmAttributes: Bulk
  64 c,  \ VIRTUAL_COM_PORT_DATA_SIZE
  0 c,
  $00 c, \ bInterval: ignore for Bulk transfer
\ Endpoint 1 Descriptor
  7 c,   \ bLength: Endpoint Descriptor size
  $05 c, \ USB_ENDPOINT_DESCRIPTOR_TYPE
  $81 c, \ bEndpointAddress: (IN1)
  $02 c, \ bmAttributes: Bulk
  64 c,  \ VIRTUAL_COM_PORT_DATA_SIZE
  0 c,
  $00 c, \ bInterval
calign

create usb:langid
  4 c, 3 c,  \ USB_STRING_DESCRIPTOR_TYPE,
  $0409 h, \ LangID = U.S. English

create usb:vendor
  40 c, 3 c,  \ USB_STRING_DESCRIPTOR_TYPE,
  char M h, char e h, char c h, char r h, char i h, char s h, char p h,
  bl     h, char ( h, char S h, char T h, char M h, char 3 h, char 2 h,
  char F h, char 1 h, char 0 h, char x h, char ) h,

create usb:product
  36 c, 3 c,  \ USB_STRING_DESCRIPTOR_TYPE,
  char F h, char o h, char r h, char t h, char h h, bl     h, char S h,
  char e h, char r h, char i h, char a h, char l h, bl     h, char P h,
  char o h, char r h, char t h,

create usb:line
  hex 00 c, C2 c, 01 c, 00 c, 01 c, 00 c, 08 c, 00 c, decimal

\ -----------------------------------------------------------------------------
\  USB module initialisation values
\ -----------------------------------------------------------------------------

create usb:init
hex
  0080 h,  \ ADDR0_TX   control - rx: 64b @ +040/080, tx: 64b @ +080/100
  0000 h,  \ COUNT0_TX
  0040 h,  \ ADDR0_RX
  8400 h,  \ COUNT0_RX
  00C0 h,  \ ADDR1_TX   bulk - tx: 64b @ +0C0/180
  0000 h,  \ COUNT1_TX
  0000 h,  \ ADDR1_RX
  0000 h,  \ COUNT1_RX
  0140 h,  \ ADDR2_TX   interrupt - tx: 8b @ +140/280
  0000 h,  \ COUNT2_TX
  0000 h,  \ ADDR2_RX
  0000 h,  \ COUNT2_RX
  0000 h,  \ ADDR3_TX   bulk - rx: 64b @ +100/200
  0000 h,  \ COUNT3_TX
  0100 h,  \ ADDR3_RX
  8400 h,  \ COUNT3_RX
decimal

$40005C00 constant USB 
USB $00 + constant USB_EP0R
USB $40 + constant USB_CNTR
USB $44 + constant USB_ISTR
USB $48 + constant USB-FNR
USB $4C + constant USB_DADDR
USB $50 + constant USB_BTABLE
$40006000 constant USBMEM

\ -----------------------------------------------------------------------------
\  USB peripheral module handling
\ -----------------------------------------------------------------------------

: usb-pma ( pos -- addr ) dup 1 and negate swap 2* + USBMEM + ;
: usb-pma@ ( pos -- u ) usb-pma h@ ;
: usb-pma! ( u pos -- ) usb-pma h! ;

: ep-addr ( ep -- addr ) cells USB_EP0R + ;
: ep-reg ( ep n -- addr ) 2* swap 8 * + usb-pma ;

: rxstat! ( ep u -- )  \ set stat_rx without toggling/setting any other fields
  swap ep-addr >r
  12 lshift  r@ h@ tuck  xor
\  R^rrseekT^ttnnnn
\  5432109876543210
  %0011000000000000 and swap
  %0000111100001111 and
  %1000000010000000 or
  or r> h! ;

: txstat! ( ep u -- )  \ set stat_tx without toggling/setting any other fields
  swap ep-addr >r
  4 lshift  r@ h@ tuck  xor
\  R^rrseekT^ttnnnn
\  5432109876543210
  %0000000000110000 and swap
  %0000111100001111 and
  %1000000010000000 or
  or r> h! ;

: ep-reset-rx# ( ep -- ) $8400 over 3 ep-reg h! 3 rxstat! ;
: rxclear ( ep -- ) ep-addr dup h@ $7FFF and $8F8F and swap h! ;
: txclear ( ep -- ) ep-addr dup h@ $FF7F and $8F8F and swap h! ;

0 0 2variable usb-pend
18 buffer: usb-serial

: set-serial ( -- addr )  \ fill serial number in as UTF-16 descriptor
  base @ hex
  hwid 0 <# 8 0 do # loop #> ( base addr 8 )
  0 do dup c@ i 1+ 2* usb-serial + h! 1+ loop
  drop base !
  usb-serial $0312 over h! ;

: send-data ( addr n -- ) usb-pend 2! ;
: send-next ( -- )
  usb-pend 2@ 64 min $46 usb-pma@ min
  >r ( addr R: num )
  r@ even 0 ?do
    dup i + h@ $80 i + usb-pma!
  2 +loop drop
  r@ $02 usb-pma! 0 3 txstat!
  usb-pend 2@ r> dup negate d+ usb-pend 2! ;

: send-desc ( -- )
  $42 usb-pma@ case
    $0100 of usb:dev     18 endof
    $0200 of usb:conf    67 endof
    $0300 of usb:langid  4  endof
    $0301 of usb:vendor  40 endof
    $0302 of usb:product 36 endof
    $0303 of set-serial  18 endof
    true ?of 0           0  endof
  endcase send-data ;

: usb-reset ( -- )
  256 0 do  0 i 2* usb-pma! loop  0 USB_BTABLE h!
  usb:init  64 0 do
    dup h@  i USBMEM + h!
    2+
  4 +loop  drop
  $3210 0 ep-addr h!
  $0021 1 ep-addr h!
  $0622 2 ep-addr h!
  $3003 3 ep-addr h!
  $80 USB_DADDR h! ;

\ -----------------------------------------------------------------------------
\  USB packet handling
\ -----------------------------------------------------------------------------

create zero 0 ,

128 4 + buffer: usb-in-ring   \ RX ring buffer, ample for mecrisp input lines
 64 4 + buffer: usb-out-ring  \ TX ring buffer, for outbound bytes

: ep-setup ( ep -- )  \ setup packets, sent from host to config this device
  dup rxclear
  $41 usb-pma c@ case
    $00 of zero 2 send-data endof
    $06 of send-desc endof
    ( default ) 0 0 send-data
  endcase
  ep-reset-rx# send-next ;

0 variable tx.pend
0 variable usb.ticks

: usb-pma-c! ( b pos -- )  \ careful, can't write high bytes separately
  dup 1 and if
    1- dup usb-pma@ rot 8 lshift or swap
  then usb-pma! ;

: usb-fill ( -- )  \ fill the USB outbound buffer from the TX ring buffer
  usb-out-ring ring# ?dup if
    dup tx.pend !
    dup 0 do usb-out-ring ring> $C0 i + usb-pma-c!  loop
    1 1 ep-reg h! 1 3 txstat!
  then ;

: ep-out ( ep -- )  \ outgoing packets, sent from host to this device
\ dup 2 rxstat!  \ set RX state to NAK
  dup if  \ only pick up data for endpoint 3
    usb-in-ring ring# 60 > if drop exit then  \ reject if no room in ring
    dup 3 ep-reg h@ $7F and 0 ?do
      i $100 + usb-pma c@ usb-in-ring >ring
    loop
  then
  dup rxclear
  ep-reset-rx# ;

: ep-in ( ep -- )  \ incoming polls, sent from this device to host
  dup if
    0 usb.ticks !  0 tx.pend !  usb-fill
  else
    $41 usb-pma c@ $05 = if $42 usb-pma@ $80 or USB_DADDR h! then
    send-next
  then
  txclear ;

: usb-ctr ( istr -- )
  dup $07 and swap $10 and if 
    dup ep-addr h@ $800 and if ep-setup else ep-out then
  else ep-in then ;

: usb-flush
  usb-in-ring 128 init-ring
  usb-out-ring 64 init-ring ;

: usb-poll
  \ clear ring buffers if pending output is not getting sent to host
  tx.pend @ if
    1 usb.ticks +!
    usb.ticks @ 10000 u> if usb-flush then
  then
  \ main USB driver polling
  USB_ISTR h@
  dup $8000 and if dup usb-ctr                            then
  dup $0400 and if usb-reset            $FBFF USB_ISTR h! then
  dup $0800 and if %1100 USB_CNTR hbis! $F7FF USB_ISTR h! then
      $1000 and if %1000 USB_CNTR hbic! $EFFF USB_ISTR h! then ;

: usb-key? ( -- f )  pause usb-poll usb-in-ring ring# 0<> ;
: usb-key ( -- c )  begin usb-key? until  usb-in-ring ring> ;
: usb-emit? ( -- f )  usb-poll usb-out-ring ring? ;
: usb-emit ( c -- )  begin usb-emit? until  usb-out-ring >ring
                     tx.pend @ 0= if usb-fill then ;

: usb-io ( -- )  \ start up USB and switch console I/O to it
  23 bit $4002101C bis!  \ USB ENABLE
  $0001 USB_CNTR h! ( 10 us ) $0000 USB_CNTR h!  \ FRES
  usb-flush
  ['] usb-key? hook-key? !
  ['] usb-key hook-key !
  1000000 0 do usb-poll loop
  ['] usb-emit? hook-emit? !
  ['] usb-emit hook-emit !
  \ ['] usb-poll hook-pause !
;

\ -----------------------------------------------------------------------------
\  USB connect and disconnect, board specific !
\ -----------------------------------------------------------------------------

: init.usb ( -- )  \ Init USB hardware and switch to USB terminal
   72mhz \ This is required for USB use 
   \ moved to seperate " usbdp " Word by tp
   \ original jeelabs code
   \ Board-specific way to briefly pull USB-DP down via PA12 for 1ms
   \   $00050000 $40010804 ( PORTA_CRH ) bis!   \ PA12 Open-Drain Output, ( dont affect serial ports ).
   \   12 bit $4001080C ( PORTA_ODR ) bic!	\ PA12 LOW
   \   1000 0 do loop				\ approx 1ms delay
   \   12 bit $4001080C ( PORTA_ODR ) bis!	\ PA12 HIGH
  usb-io
;

: deinit.usb ( -- )	   \ Deinit USB hardware, switch back to swdcom terminal
  23 bit $4002101C bic!	   \ Usb peripheral disable RCC_APB1ENR_USBEN
  \ 1 12 lshift $4001080C ( PORTA_ODR )  bic!  \ original jeelabs code:  PC12 = 0
  ['] swd-key? hook-key? !
  ['] swd-key hook-key !
  ['] swd-emit? hook-emit? !
  ['] swd-emit hook-emit !
  \ ['] nop hook-pause !
;

: +usb ( -- ) init.usb ;
: -usb ( -- ) deinit.usb ;

\ -----------------------------------------------------------------------------

\ : init ( -- ) +usb ;	   \ or -usb


\ Program Name: memstat.fs
\ Date: Sun 12 Jan 2020 18:55:01 AEDT
\ Copyright 2020 by t.j.porter <terry@tjporter.com.au>, licensed under the GPLV2
\ For Mecrisp-Stellaris and Mecrisp-Quintus by Matthias Koch.
\ https://sourceforge.net/projects/mecrisp/
\ Standalone: no preloaded support files required
\
\ This Program : Displays memory statistics
\
\ ---------------------------------------------------------------------------\
\     Usage:    " ramsize-kb flashmod flash-size-register-address memstats "
\
\     'ramsize-kb' = Get the MCU ram size from the datasheet as it's not 
\     available from the mcu directly like the flash size.
\
\     'flashmod' = flash size modifier
\	 '1' = normal use, flash exactly as reported
\
\	 '2' = doubles the reported flash size. Only for a STM32F103C8 which
\	 reports 64kB of Flash but actually has DOUBLE (128kB) that size.
\	 OR if you suspect your chip MAY have double the flash advertized. Note:
\	 will crash this program with a Exception if it doesn't!
\
\     'flash-size-register-address' = "Flash size data register address". Check
\     your STM reference manual "Device electronic signature" section for the
\     correct address.
\
\ --------------------------- MCU Type Examples -----------------------------\
\  
\ ram-size  flashmod	ram-size    MCU Type
\ -kb			-register   
\			-address
\ --------  ---------   ---------   --------
\  8	    1		$1FFFF7CC   STM32F0xx
\  20	    1		$1FFFF7E0   STM32F10xx
\  20	    2		$1FFFF7E0   STM32F103C8 (2x indicated Flash)
\  20	    1		$1FFFF7E0   CKS32F103C8T6 (Chinese STM32F103CB clone)
\  32	    1		$1FFFF7E0   GD32VF103 RISC-V32, Mecrisp-Quintus
\  20	    1		$1FF8007C   STM32L0x3
\  64	    1		$1FFF7A22   STM32F407,415,427,437,429,439
\ 
\ ----------------------------- Screenshot ----------------------------------\

\ ---------------------------------------------------------------------------\
 \ compiletoram
 compiletoflash

 : flashfree ( -- u )
   compiletoram?
   compiletoflash		     
   unused
   swap			    
      if compiletoram
      then			    
 ;
 
 : ramfree ( u -- u ) 
   compiletoram? not      		    
   compiletoram	   
   unused
   swap			   	   		   
      if compiletoflash	   
      then
 ;

 : flashfree. ( u addr -- )	    \ 2 $1FFFF7E0 flashfree.
   @ $FFFF and 1024 * * dup dup
   ."  Flash Total:" .
   ."  Used:" flashfree - dup .
   ."  Free:" - .
   cr ;

 : ramfree. ( u -- )		    \ 20 ramfree.
   1024 * dup dup
   ."  Ram Total:" .
   ."  Used:" ramfree - dup . 
   ."  Free:" - .
   cr ;
 
 : memstats ( u u addr -- ) cr	    \ 20 2 $1FFFF7E0 memstats
   ." Memory stats in bytes: " cr   
   flashfree.
   ramfree.
 ; 
     
 compiletoram
 
 \ Possible usage examples
 \ : free ( -- ) 32 1 $1FFFF7E0 memstats ;  \ GD32VF103 
 \ : free ( -- ) 20 2 $1FFFF7E0 memstats ;  \ STM32F103C8
 \ : free ( -- )  8 1 $1FFFF7CC memstats ;  \ STM32F0xx 

 \ free


\ Partial ARM Cortex M3/M4 Disassembler, Copyright (C) 2013  Matthias Koch
\ This is free software under GNU General Public License v3.
\ Knows all M0 and some M3/M4 machine instructions, 
\ resolves call entry points, literal pools and handles inline strings.
\ Usage: Specify your target address in disasm-$ and give disasm-step some calls.

compiletoflash

 0 variable   word.start      \ added tp 
 0 variable   word.end	      \ added tp 

\ ---------------------------------------
\  Memory pointer and instruction fetch
\ ---------------------------------------

0 variable disasm-$   \ Current position for disassembling

: disasm-fetch        \ ( -- Data ) Fetches opcodes and operands, increments disasm-$
    disasm-$ @ h@     \             Holt Opcode oder Operand, incrementiert disasm-$
  2 disasm-$ +!   ;

\ --------------------------------------------------
\  Try to find address as code start in Dictionary 
\ --------------------------------------------------

: disasm-string ( -- ) \ Takes care of an inline string
  disasm-$ @ dup ctype skipstring disasm-$ !
;

: name. ( Address -- ) \ If the address is Code-Start of a dictionary word, it gets named.
  1 bic \ Thumb has LSB of address set.

  >r
  dictionarystart
  begin
    dup   6 + dup skipstring r@ = if ."   --> " ctype else drop then
    dictionarynext
  until
  drop
  r> 

  case \ Check for inline strings ! They are introduced by calls to ." or s" internals.
    ['] ." $1E + of ."   -->  .' " disasm-string ." '" endof \ It is ." runtime ?
    ['] s"  $4 + of ."   -->  s' " disasm-string ." '" endof \ It is .s runtime ?
    ['] c"  $4 + of ."   -->  c' " disasm-string ." '" endof \ It is .c runtime ?
  endcase
;

\ -------------------
\  Beautiful output
\ -------------------

: register. ( u -- )
  case 
    13 of ."  sp" endof
    14 of ."  lr" endof
    15 of ."  pc" endof
    dup ."  r" decimal u.ns hex 
  endcase ;


\ ----------------------------------------
\  Disassembler logic and opcode cutters
\ ----------------------------------------

: opcode? ( Opcode Bits Mask -- Opcode ? ) \ (Opcode and Mask) = Bits
  rot ( Bits Mask Opcode )
  tuck ( Bits Opcode Mask Opcode )
  and ( Bits Opcode Opcode* )
  rot ( Opcode Opcode* Bits )
  =
;

: reg.    ( Opcode Position -- Opcode ) over swap rshift  $7 and register. ;
: reg16.  ( Opcode Position -- Opcode ) over swap rshift  $F and register. ;
: reg16split. ( Opcode -- Opcode ) dup $0007 and over 4 rshift $0008 and or register. ;
: registerlist. ( Opcode -- Opcode ) 8 0 do dup 1 i lshift and if i register. space then loop ;

: imm3. ( Opcode Position -- Opcode ) over swap rshift  $7  and const. ;
: imm5. ( Opcode Position -- Opcode ) over swap rshift  $1F and const. ;
: imm8. ( Opcode Position -- Opcode ) over swap rshift  $FF and const. ;

: imm3<<1. ( Opcode Position -- Opcode ) over swap rshift  $7  and shl const. ;
: imm5<<1. ( Opcode Position -- Opcode ) over swap rshift  $1F and shl const. ;
: imm8<<1. ( Opcode Position -- Opcode ) over swap rshift  $FF and shl const. ;

: imm3<<2. ( Opcode Position -- Opcode ) over swap rshift  $7  and shl shl const. ;
: imm5<<2. ( Opcode Position -- Opcode ) over swap rshift  $1F and shl shl const. ;
: imm7<<2. ( Opcode Position -- Opcode ) over swap rshift  $7F and shl shl const. ;
: imm8<<2. ( Opcode Position -- Opcode ) over swap rshift  $FF and shl shl const. ;

: condition. ( Condition -- )
  case
    $0 of ." eq" endof  \ Z set
    $1 of ." ne" endof  \ Z clear
    $2 of ." cs" endof  \ C set
    $3 of ." cc" endof  \ C clear
                       
    $4 of ." mi" endof  \ N set
    $5 of ." pl" endof  \ N clear
    $6 of ." vs" endof  \ V set
    $7 of ." vc" endof  \ V clear
                       
    $8 of ." hi" endof  \ C set Z clear
    $9 of ." ls" endof  \ C clear or Z set
    $A of ." ge" endof  \ N == V
    $B of ." lt" endof  \ N != V
                       
    $C of ." gt" endof  \ Z==0 and N == V
    $D of ." le" endof  \ Z==1 or N != V
  endcase
;

: rotateleft  ( x u -- x ) 0 ?do rol loop ;
: rotateright ( x u -- x ) 0 ?do ror loop ;

: imm12. ( Opcode -- Opcode )
  dup $FF and                 \ Bits 0-7
  over  4 rshift $700 and or  \ Bits 8-10
  over 15 rshift $800 and or  \ Bit  11
  ( Opcode imm12 )
  dup 8 rshift
  case
    0 of $FF and                                  const. endof \ Plain 8 Bit Constant
    1 of $FF and                 dup 16 lshift or const. endof \ 0x00XY00XY
    2 of $FF and        8 lshift dup 16 lshift or const. endof \ 0xXY00XY00
    3 of $FF and dup 8 lshift or dup 16 lshift or const. endof \ 0xXYXYXYXY

    \ Shifted 8-Bit Constant
    swap
      \ Otherwise, the 32-bit constant is rotated left until the most significant bit is bit[7]. The size of the left
      \ rotation is encoded in bits[11:7], overwriting bit[7]. imm12 is bits[11:0] of the result.
      dup 7 rshift swap $7F and $80 or swap rotateright const.
  endcase
;

\ --------------------------------------
\  Name resolving for blx r0 sequences
\ --------------------------------------

0 variable destination-r0

\ ----------------------------------
\  Single instruction disassembler
\ ----------------------------------

: disasm-thumb-2 ( Opcode16 -- Opcode16 )
  dup 16 lshift disasm-fetch or ( Opcode16 Opcode32 )

  $F000D000 $F800D000 opcode? if  \ BL
                                ( Opcode )
                                ." _bl  "
                                dup $7FF and ( Opcode DestinationL )
                                over ( Opcode DestinationL Opcode )
                                16 rshift $7FF and ( Opcode DestinationL DestinationH )
                                dup $400 and if $FFFFF800 or then ( Opcode DestinationL DestinationHsigned )
                                11 lshift or ( Opcode Destination )
                                shl 
                                disasm-$ @ +
                                dup addr. name. \ Try to resolve destination
                              then

  \ MOVW / MOVT
  \ 1111 0x10 t100 xxxx 0xxx dddd xxxx xxxx
  \ F    2    4    0    0    0    0    0
  \ F    B    7    0    8    0    0    0

  $F2400000 $FB708000 opcode? if \ MOVW / MOVT
                                ( Opcode )
                                dup $00800000 and if ." movt"
                                                  else ." movw"
                                                  then

                                8 reg16. \ Destination register

                                \ Extract 16 Bit constant from opcode:
                                dup        $FF and              ( Opcode Constant* )
                                over     $7000 and  4 rshift or ( Opcode Constant** )
                                over $04000000 and 15 rshift or ( Opcode Constant*** )
                                over $000F0000 and  4 rshift or ( Opcode Constant )
                                dup ."  #" u.4
                                ( Opcode Constant )
                                over $00800000 and if 16 lshift destination-r0 @ or destination-r0 !
                                                   else                             destination-r0 !
                                                   then
                              then

  \ 
  \ 1111 0i0x xxxs nnnn 0iii dddd iiii iiii
  \ F    0    0    0    0    0    0    0
  \ F    A    0    0    8    0    0    0

  $F0000000 $FA008000 opcode? not if else \ Data processing, modified 12-bit immediate
                                dup 21 rshift $F and
                                case
                                  %0000 of ." and" endof
                                  %0001 of ." bic" endof
                                  %0010 of ." orr" endof
                                  %0011 of ." orn" endof
                                  %0100 of ." eor" endof
                                  %1000 of ." add" endof
                                  %1010 of ." adc" endof
                                  %1011 of ." sbc" endof
                                  %1101 of ." sub" endof
                                  %1110 of ." rsb" endof
                                  ." ?"
                                endcase
                                dup 1 20 lshift and if ." s" then \ Set Flags ?
                                8 reg16. 16 reg16. \ Destionation and Source registers
                                imm12.
                              then

  case \ Decode remaining "singular" opcodes used in Mecrisp-Stellaris:

    $EA5F0676 of ." rors r6 r6 #1" endof

    $F8470D04 of ." str r0 [ r7 #-4 ]!" endof
    $F8471D04 of ." str r1 [ r7 #-4 ]!" endof
    $F8472D04 of ." str r2 [ r7 #-4 ]!" endof
    $F8473D04 of ." str r3 [ r7 #-4 ]!" endof
    $F8476D04 of ." str r6 [ r7 #-4 ]!" endof

    $F8576026 of ." ldr r6 [ r7 r6 lsl #2 ]" endof
    $F85D6C08 of ." ldr r6 [ sp #-8 ]" endof

    $FAB6F686 of ." clz r6 r6" endof

    $FB90F6F6 of ." sdiv r6 r0 r6" endof
    $FBB0F6F6 of ." udiv r6 r0 r6" endof
    $FBA00606 of ." umull r0 r6 r0 r6" endof
    $FBA00806 of ." smull r0 r6 r0 r6" endof

  endcase \ Case drops Opcode32
  ( Opcode16 )
;

: disasm ( -- ) \ Disassembles one machine instruction and advances disasm-$

disasm-fetch \ Instruction opcode on stack the whole time.

$4140 $FFC0 opcode? if ." adcs"  0 reg. 3 reg. then          \ ADC
$1C00 $FE00 opcode? if ." adds" 0 reg. 3 reg. 6 imm3. then   \ ADD(1) small immediate two registers
$3000 $F800 opcode? if ." adds" 8 reg. 0 imm8. then          \ ADD(2) big immediate one register
$1800 $FE00 opcode? if ." adds" 0 reg. 3 reg. 6 reg. then    \ ADD(3) three registers
$4400 $FF00 opcode? if ." add"  reg16split. 3 reg16. then    \ ADD(4) two registers one or both high no flags
$A000 $F800 opcode? if ." add"  8 reg. ."  pc " 0 imm8<<2. then  \ ADD(5) rd = pc plus immediate
$A800 $F800 opcode? if ." add"  8 reg. ."  sp " 0 imm8<<2. then  \ ADD(6) rd = sp plus immediate
$B000 $FF80 opcode? if ." add sp" 0 imm7<<2. then            \ ADD(7) sp plus immediate

$4000 $FFC0 opcode? if ." ands" 0 reg. 3 reg. then           \ AND
$1000 $F800 opcode? if ." asrs" 0 reg. 3 reg. 6 imm5. then   \ ASR(1) two register immediate
$4100 $FFC0 opcode? if ." asrs" 0 reg. 3 reg. then           \ ASR(2) two register
$D000 $F000 opcode? not if else dup $0F00 and 8 rshift       \ B(1) conditional branch
                       case
                         $00 of ." beq" endof  \ Z set
                         $01 of ." bne" endof  \ Z clear
                         $02 of ." bcs" endof  \ C set
                         $03 of ." bcc" endof  \ C clear
                       
                         $04 of ." bmi" endof  \ N set
                         $05 of ." bpl" endof  \ N clear
                         $06 of ." bvs" endof  \ V set
                         $07 of ." bvc" endof  \ V clear
                       
                         $08 of ." bhi" endof  \ C set Z clear
                         $09 of ." bls" endof  \ C clear or Z set
                         $0A of ." bge" endof  \ N == V
                         $0B of ." blt" endof  \ N != V
                       
                         $0C of ." bgt" endof  \ Z==0 and N == V
                         $0D of ." ble" endof  \ Z==1 or N != V
                         \ $0E: Undefined Instruction
                         \ $0F: SWI                       
                       endcase
                       space
                       dup $FF and dup $80 and if $FFFFFF00 or then
                       shl disasm-$ @ 1 bic + 2 + addr. 
                    then

$E000 $F800 opcode? if ." b"                                 \ B(2) unconditional branch
                      dup $7FF and shl
                      dup $800 and if $FFFFF000 or then
                      disasm-$ @ + 2+                     
                      space addr.
                    then

$4380 $FFC0 opcode? if ." bics" 0 reg. 3 reg. then           \ BIC
$BE00 $FF00 opcode? if ." bkpt" 0 imm8. then                 \ BKPT

\ BL/BLX handled as Thumb-2 instruction on M3/M4.

$4780 $FF87 opcode? if ." blx"  3 reg16. then                \ BLX(2)
$4700 $FF87 opcode? if ." bx"   3 reg16. then                \ BX
$42C0 $FFC0 opcode? if ." cmns" 0 reg. 3 reg. then           \ CMN
$2800 $F800 opcode? if ." cmp"  8 reg. 0 imm8. then          \ CMP(1) compare immediate
$4280 $FFC0 opcode? if ." cmp"  0 reg. 3 reg. then           \ CMP(2) compare register
$4500 $FF00 opcode? if ." cmp"  reg16split. 3 reg16. then    \ CMP(3) compare high register
$B660 $FFE8 opcode? if ." cps"  0 imm5. then                 \ CPS
$4040 $FFC0 opcode? if ." eors" 0 reg. 3 reg. then           \ EOR

$C800 $F800 opcode? if ." ldmia" 8 reg. ."  {" registerlist. ." }" then     \ LDMIA

$6800 $F800 opcode? if ." ldr" 0 reg. ."  [" 3 reg. 6 imm5<<2. ."  ]" then  \ LDR(1) two register immediate
$5800 $FE00 opcode? if ." ldr" 0 reg. ."  [" 3 reg. 6 reg. ."  ]" then      \ LDR(2) three register
$4800 $F800 opcode? if ." ldr" 8 reg. ."  [ pc" 0 imm8<<2. ."  ]  Literal " \ LDR(3) literal pool
                       dup $FF and shl shl ( Opcode Offset ) \ Offset for PC
                       disasm-$ @ 2+ 3 bic + ( Opcode Address )
                       dup addr. ." : " @ addr. then

$9800 $F800 opcode? if ." ldr"  8 reg. ."  [ sp" 0 imm8<<2. ."  ]" then     \ LDR(4)

$7800 $F800 opcode? if ." ldrb" 0 reg. ."  [" 3 reg. 6 imm5. ."  ]" then    \ LDRB(1) two register immediate
$5C00 $FE00 opcode? if ." ldrb" 0 reg. ."  [" 3 reg. 6 reg.  ."  ]" then    \ LDRB(2) three register

$8800 $F800 opcode? if ." ldrh" 0 reg. ."  [" 3 reg. 6 imm5<<1. ."  ]" then \ LDRH(1) two register immediate
$5A00 $FE00 opcode? if ." ldrh" 0 reg. ."  [" 3 reg. 6 reg.  ."  ]" then    \ LDRH(2) three register

$5600 $FE00 opcode? if ." ldrsb" 0 reg. ."  [" 3 reg. 6 reg. ."  ]" then    \ LDRSB
$5E00 $FE00 opcode? if ." ldrsh" 0 reg. ."  [" 3 reg. 6 reg. ."  ]" then    \ LDRSH

$0000 $F800 opcode? if ." lsls" 0 reg. 3 reg. 6 imm5. then   \ LSL(1)
$4080 $FFC0 opcode? if ." lsls" 0 reg. 3 reg. then           \ LSL(2) two register
$0800 $F800 opcode? if ." lsrs" 0 reg. 3 reg. 6 imm5. then   \ LSR(1) two register immediate
$40C0 $FFC0 opcode? if ." lsrs" 0 reg. 3 reg. then           \ LSR(2) two register
$2000 $F800 opcode? if ." movs" 8 reg. 0 imm8. then          \ MOV(1) immediate
$4600 $FF00 opcode? if ." mov" reg16split. 3 reg16. then     \ MOV(3)

$4340 $FFC0 opcode? if ." muls" 0 reg. 3 reg. then           \ MUL
$43C0 $FFC0 opcode? if ." mvns" 0 reg. 3 reg. then           \ MVN
$4240 $FFC0 opcode? if ." negs" 0 reg. 3 reg. then           \ NEG
$4300 $FFC0 opcode? if ." orrs" 0 reg. 3 reg. then           \ ORR

$BC00 $FE00 opcode? if ." pop {"  registerlist. dup $0100 and if ."  pc " then ." }" then \ POP
$B400 $FE00 opcode? if ." push {" registerlist. dup $0100 and if ."  lr " then ." }" then \ PUSH

$BA00 $FFC0 opcode? if ." rev"   0 reg. 3 reg. then         \ REV
$BA40 $FFC0 opcode? if ." rev16" 0 reg. 3 reg. then         \ REV16
$BAC0 $FFC0 opcode? if ." revsh" 0 reg. 3 reg. then         \ REVSH
$41C0 $FFC0 opcode? if ." rors"  0 reg. 3 reg. then         \ ROR
$4180 $FFC0 opcode? if ." sbcs"  0 reg. 3 reg. then         \ SBC
$B650 $FFF7 opcode? if ." setend" then                      \ SETEND

$C000 $F800 opcode? if ." stmia" 8 reg. ."  {" registerlist. ." }" then     \ STMIA

$6000 $F800 opcode? if ." str" 0 reg. ."  [" 3 reg. 6 imm5<<2. ."  ]" then  \ STR(1) two register immediate
$5000 $FE00 opcode? if ." str" 0 reg. ."  [" 3 reg. 6 reg. ."  ]" then      \ STR(2) three register
$9000 $F800 opcode? if ." str" 8 reg. ."  [ sp + " 0 imm8<<2. ."  ]" then   \ STR(3)

$7000 $F800 opcode? if ." strb" 0 reg. ."  [" 3 reg. 6 imm5. ."  ]" then    \ STRB(1) two register immediate
$5400 $FE00 opcode? if ." strb" 0 reg. ."  [" 3 reg. 6 reg.  ."  ]" then    \ STRB(2) three register

$8000 $F800 opcode? if ." strh" 0 reg. ."  [" 3 reg. 6 imm5<<1. ."  ]" then \ STRH(1) two register immediate
$5200 $FE00 opcode? if ." strh" 0 reg. ."  [" 3 reg. 6 reg.  ."  ]" then    \ STRH(2) three register

$1E00 $FE00 opcode? if ." subs" 0 reg. 3 reg. 6 imm3. then   \ SUB(1)
$3800 $F800 opcode? if ." subs" 8 reg. 0 imm8. then          \ SUB(2)
$1A00 $FE00 opcode? if ." subs" 0 reg. 3 reg. 6 reg. then    \ SUB(3)
$B080 $FF80 opcode? if ." sub sp" 0 imm7<<2. then            \ SUB(4)

$DF00 $FF00 opcode? if ." swi"  0 imm8. then                 \ SWI
$B240 $FFC0 opcode? if ." sxtb" 0 reg. 3 reg. then           \ SXTB
$B200 $FFC0 opcode? if ." sxth" 0 reg. 3 reg. then           \ SXTH
$4200 $FFC0 opcode? if ." tst"  0 reg. 3 reg. then           \ TST
$B2C0 $FFC0 opcode? if ." uxtb" 0 reg. 3 reg. then           \ UXTB
$B280 $FFC0 opcode? if ." uxth" 0 reg. 3 reg. then           \ UXTH


\ 16 Bit Thumb-2 instruction ?

$BF00 $FF00 opcode? not if else                              \ IT...
                      dup $000F and
                      case
                        $8 of ." it" endof

                        over $10 and if else $8 xor then
                        $C of ." itt" endof
                        $4 of ." ite" endof

                        over $10 and if else $4 xor then
                        $E of ." ittt" endof
                        $6 of ." itet" endof
                        $A of ." itte" endof
                        $2 of ." itee" endof

                        over $10 and if else $2 xor then
                        $F of ." itttt" endof
                        $7 of ." itett" endof
                        $B of ." ittet" endof
                        $3 of ." iteet" endof
                        $D of ." ittte" endof
                        $5 of ." itete" endof
                        $9 of ." ittee" endof
                        $1 of ." iteee" endof
                      endcase
                      space
                      dup $00F0 and 4 rshift condition.
                    then

\ 32 Bit Thumb-2 instruction ?

$E800 $F800 opcode? if disasm-thumb-2 then
$F000 $F000 opcode? if disasm-thumb-2 then


\ If nothing of the above hits: Invalid Instruction... They are not checked for.

\ Try name resolving for blx r0 sequences:

$2000 $FF00 opcode? if dup $FF and destination-r0  ! then \ movs r0, #...
$3000 $FF00 opcode? if dup $FF and destination-r0 +! then \ adds r0, #...
$0000 $F83F opcode? if destination-r0 @                   \ lsls r0, r0, #...
                         over $07C0 and 6 rshift lshift
                       destination-r0 ! then
dup $4780 =         if destination-r0 @ name. then        \ blx r0

drop \ Forget opcode
; \ disasm

\ ------------------------------
\  Single instruction printing
\ ------------------------------

: memstamp \ ( Addr -- ) Shows a memory location nicely
    dup u.8 ." : " h@ u.4 ."   " ;

: disasm-step ( -- )
    disasm-$ @                 \ Note current position
    dup memstamp disasm cr     \ Disassemble one instruction

    begin \ Write out all disassembled memory locations
      2+ dup disasm-$ @ <>
    while
      dup memstamp cr
    repeat
    drop
;

\ ------------------------------
\  Disassembler for definitions
\ ------------------------------

: seec ( -- ) \ Continues to see
  base @ hex cr

  begin
    disasm-$ @ h@           $4770 =  \ Flag: Loop terminates with bx lr
    disasm-$ @ h@ $FF00 and $BD00 =  \ Flag: Loop terminates with pop { ... pc }
    or
    disasm-step
  until
  disasm-$ @  word.end !		     \ added tp
  base !
;

: see ( -- ) \ Takes name of definition and shows its contents from beginning to first ret
  ' disasm-$ !
  disasm-$ @  word.start !		     \ added tp 
  seec
  ." Bytes: "  word.end @ word.start @ - .   \ added tp
;
\ prerequisite: memstats.fs 
compiletoflash
: free ( -- ) 20 2 $1FFFF7E0 memstats ; \ STM32F103C8
compiletoram

\ Program Name: systick.fs
\ Date: Wed 8 Jan 2020 13:13:57 AEDT
\ Copyright 2020 by t.j.porter <terry@tjporter.com.au>,  licensed under the GPLV3
\ For Mecrisp-Stellaris by Matthias Koch.
\ https://sourceforge.net/projects/mecrisp/
\ Standalone: no preloaded support files required
\ This systick design is based on this article:
\ https://embedded.fm/blog/2016/9/26/scheduling-code-on-bare-metal?rq=systick
\
\ This Program: Interrupt driven STM32Fxxx Systick Timing Library
\
\ Note the (STK) is not a part of STM32F CMSIS-SVD
\ See: ST PM0215 Programming manual, page 85-91
\
\ ---------------------------------------------------------------------------\
 compiletoflash
 \ compiletoram
 
\  $E000E010   constant stk_csr     \ RW  SysTick control and status  
\  $E000E014   constant stk_rvr     \ RW  SysTick reload value 
\  $E000E018   constant stk_cvr     \ RW  SysTick current value 
\  $E000E01C   constant stk_calib   \ RO  SysTick calibration value 

 0 variable ticktime	\ 32 bits or -> $ffffffff u. = 4294967295 ms, 4294967 seconds,
			\ 71582 minutes, 19.88 Hrs
 
 : tickint ( -- )       \ tickint: sysTick exception request enable
   %010 stk_csr bis!    \ 1 = Counting down to zero asserts the SysTick exception request.
 ;
 
 : systick-handler ( -- )
   1 ticktime +!
 ;
 
 : init.systick	( 0.1 ms cal value -- )	  \ init systick
   stk_rvr !				  \ systick calib for 0.11ms 
   %101 stk_csr bis!			  \ systick enable
   ['] systick-handler irq-systick !	  \ 'hooks' the systick-handler word (above) to the systick interrupt
   tickint
 ;
  
 : ticktime. ( -- )	\ print now time
   ticktime @ hex.
 ;

 : zero-ticktime ( -- )	\ zero now time
   0 ticktime !
 ;

 : ms.delay ( u -- )	\ accurate  0.1 millisecond blocking delay, range is 1ms to 19.88 Hrs (32 bytes)
    zero-ticktime
    10 *		\ convert to ms
      begin
	 ticktime @ over u>=
      until
    drop
 ;

\ 7200 init.systick   \ Add to any existing init word to run at boot from Flash.
 compiletoram
\ Taken from mecrisp-stellaris-2.5.2/stm32f103-ra/usb-f1.txt

compiletoflash

: cornerstone ( Name ) ( -- )
  <builds begin here $3FF and while 0 h, repeat
  does>   begin dup  $3FF and while 2+   repeat
          eraseflashfrom
;

cornerstone --utils--

compiletoram
\ ------------------------------------------------------------------------------ \
\ configs.fs
\ purpose: general peripheral configuration Words


\ --------------------------------Essential First Start------------------------- \
\ compiletoram
 compiletoflash

\ VERSION   
1 constant version-major
631 constant version-minor
: version ( -- c )
   ." Bluepill Diagnostics V" version-major u.ns  ." ." version-minor u.ns
;



72mhz  \ for *much* faster uploading

: calltrace-handler ( -- ) \ Assume that the 2nd block of Flash isnt there and the test raised a exception.  
  ." Failed memory test. Press board RESET button to restart microprocessor " cr
  begin again	  \ Trap execution, stop the endless error message.
;

: init.calltrace ( -- )
  ['] calltrace-handler irq-fault !
;

\ ---------------------------------Configs-------------------------------------- \

: RCC_APB2ENR_IOPAEN ( -- x addr ) 2 bit  ; \ RCC_APB2ENR_IOPAEN, I/O port A clock enable
: RCC_APB2ENR_IOPBEN ( -- x addr ) 3 bit  ; \ RCC_APB2ENR_IOPBEN, I/O port B clock enable
: RCC_APB2ENR_IOPCEN ( -- x addr ) 4 bit  ; \ I/O port C clock enable
 
: JUMPER-ON? ( --  1|0 ) 0 bit GPIOA_IDR bit@ ; \  GPIOA_IDR_IDR0?  option jumper (V3<->PA0)
: GPIOA_CRL_MODE0<< ( %bbbb -- x ) 0  lshift ;
: GPIOC_CRH_MODE13<< ( %bbbb -- x ) 20 lshift ;	\ GPIOC-13 mode
: GPIOC_BSRR_BS13 ( -- ) 13 bit GPIOC_BSRR ! ;	\ Set bit 13
: GPIOC_BSRR_BR13 ( -- ) 29 bit GPIOC_BSRR ! ;	\ Reset bit 13

 \ -------------- original old style, need to be updated sometime ------------ \
 \ PA9 Open Drain
 : GPIOB_CRH_MODE9 ( %bb -- x addr ) 4 lshift GPIOB_CRH ;   
 : GPIOB_CRH_CNF9 ( %bb -- x addr ) 6 lshift GPIOB_CRH ;    
 \ 7  6  5  4
 \ CNF9  MODE9
 \ 0  1  1  0 

 : GPIOB_BSRR_BS9 ( -- ) 9 bit GPIOB_BSRR ! ;	\ GPIOB_BSRR_BS9, Set bit 9
 : GPIOB_BSRR_BR9 ( -- ) 25 bit GPIOB_BSRR ! ;	\ GPIOB_BSRR_BR9, Reset bit 9
 : PB9-LOW   GPIOB_BSRR_BR9 ;			\ Open Drain is hi-z
 : PB9-HIGH  GPIOB_BSRR_BS9 ;			\ Open Drain is short to 0v

 \ PA12 Open Drain
 : GPIOA_CRH_MODE12 ( %bb -- x addr ) 16 lshift GPIOA_CRH ; 
 : GPIOA_CRH_CNF12 ( %bb -- x addr ) 18 lshift GPIOA_CRH ;  
 \ 19 18 17 16
 \ CNF12 MODE12
 \ 0  1  1  0

 : GPIOA_BSRR_BS12 ( -- ) 12 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BS12, Set bit 12
 : GPIOA_BSRR_BR12 ( -- ) 28 bit GPIOA_BSRR ! ; \ GPIOA_BSRR_BR12, Reset bit 12
 : PA12-HIGH  GPIOA_BSRR_BR12 ; \ Open Drain !
 : PA12-LOW   GPIOA_BSRR_BS12 ; \ Open Drain !
 
\ ---------------------------Misc Programs-------------------------------------- \

: blink ( -- pc13 )
   $F GPIOC_CRH_MODE13<< GPIOC_CRH bic!		\ clear all bits
   output.od GPIOC_CRH_MODE13<<	 GPIOC_CRH bis! \ set PC13 to open drain
		  
   begin
      GPIOC_BSRR_BR13	\ PC13 led on
      1000 ms.delay 	\ accurate  1 millisecond blocking delay
      GPIOC_BSRR_BS13	\ PC13 led off
      1000 ms.delay
   key? until		\ keep blinking until a keyboard key is pressed
;

\ B13 and B14 used with option jumper to blink LED for pass or fail ?
\ fast blinks for pass and slow blinks for fail ?
\ also must include 2nd flash block test !
\ two blinks to indicate starting test then led stays lit until results are determined ?
\ ask lestoppe ?
\ ------------------------------------------------------------------------------ \
\ usb.fs
\ purpose: Usb DP low pulse for various boards

: pa12-init ( -- )	      \ Blue Pill PA12 normally HIGH = Open Drain OFF !
   %10 GPIOA_CRH_MODE12	bis!  \ output.2mhz
   pa12-high
;

: pa12-disable ( -- )
  pa12-low 
;

: pa12-pulse ( -- )  \ Blue Pill PA12 normally HIGH, pulse LOW for 10 ms
  pa12-low
  10 ms.delay	     \ intervals are 0.1ms in this case
  pa12-low
;

: pb9-init ( -- )	   \ maple-mini normally LOW
  %10 GPIOB_CRH_MODE9 bis! \ output.2mhz
  pb9-low
;

: pb9-disable ( -- )
  pb9-low
;

: pb9-pulse ( -- )  \ maple-mini normally LOW, pulse HIGH for 1ms
  pb9-high
  10 ms.delay	     \ = 1ms (intervals are 0.1ms)
  pb9-low
;

: usddp-init ( -- )
  pa12-init
  pb9-init
  pb9-low
;

: usbdp-pulse ( -- )
  pa12-pulse
;

: usbdp-disable ( -- )
  pa12-disable 
  pb9-disable
  deinit.usb
;

\ ------------------------------------------------------------------------------ \
\ memtest.fs
\ purpose: all memory test words

0 variable 2nd64kb-verified-flag       \ 0 = untested or failed, 1 = passed test and has valid 2nd 64kb Flash
0 variable test-flag		       \ total memory locations that passed, should be 32768
0 variable pass-flag		       \ increment by one when a test is passed
0 variable flash=65536-declared-flag

: qty-flash-declared? ( -- bytes )	 
   $1FFFF7E0 @ $FFFF and 1024 *
;

: 2nd64kb-verified-flag-test ( -- )  
   test-flag @ 32768 - 0 = if 1 2nd64kb-verified-flag !
      else 0 2nd64kb-verified-flag !	\ 0 = untested or failed    
   then
   0 test-flag !
   pass-flag @ 1 + pass-flag !
;

: FF? ( -- )	  \ Blank check, scan $10000 to $1FFFF (65536 bytes)
   0 test-flag !				\ reset test-flag
   65535 0 do 
      $10000  i + c@ $FF = if  test-flag @ 1 + test-flag ! 
	    else $10000 i + hex. ." $FF?: " $10000 i + c@ ." $" h.2 cr
	    0 2nd64kb-verified-flag !	    \ 0 = untested or failed
	    then
   2 +loop
   2nd64kb-verified-flag-test
; 

: AA? ( --  )	  \ $AA check, scan $10000 to $1FFFF
   0 test-flag !				\ reset test-flag
   65535 0 do 
      $10000  i + c@ $AA = if  test-flag @ 1 + test-flag !
	    else $10000 i + hex. ." $AA?: " $10000 i + c@ ." $" h.2 cr
	    0 2nd64kb-verified-flag !	    \ 0 = untested or failed
	    then
   2 +loop
   2nd64kb-verified-flag-test 
; 

: 55? ( --  )	  \ $55 check, scan $10000 to $1FFFF
   0 test-flag !				\ reset test-flag
   65535 0 do 
      $10000  i + c@ $55 = if  test-flag @ 1 + test-flag !
	    else $10000 i + hex. ." $55?: " $10000 i + c@ ." $" h.2 cr
	    0 2nd64kb-verified-flag !	    \ 0 = untested or failed
	    then
   2 +loop
   2nd64kb-verified-flag-test
; 
 
: fillAA ( -- )	\ Fill $10000 to $1FFFF with $AA, 
   65535 0 do 
      %1010101010101010 $10000 i + hflash!
      \ $10000 i + hex. ." : " $10000 i + c@ h.2 cr  \ diags only
   2 +loop
   \  ." Flash with 1010101010101010 (0xAA) " cr
   ." ."				     \ visual progress dot
; 
   
: fill55 ( -- )	\ Fill $10000 to $1FFFF with $55
   65535 0 do 
      %0101010101010101 $10000 i + hflash!
   2 +loop
   \  ." Flash with 0101010101010101 (0x55) " cr
   ." ."				     \ visual progress dot
   0 2nd64kb-verified-flag !  \ reset previous pass test 
;

: erase ( -- )			       \ Erase $10000 to $1FFFF
   65535 0 do 
      $10000 i + flashpageerase
      1 ms.delay		       \ or flashpageerase won't work
      \ $10000 i + hex . decimal cr
   1024 +loop			       \ flashpageerase = Erase one 1k flash page only, no reset
   \ ." Erasing " cr
   ." ."			       \ visual progress dot
;

: 2nd64kb? ( -- )   \ Test the second 64kB flash block.    2nd64kb-verified-flag @ . 
   0 2nd64kb-verified-flag !  \ 0 = untested or failed, 1 = passed test and has valid 2nd 64kb Flash
      ." ."    \ first visual progress dot   
      erase    \ erase everything
      FF?      \ $FF check, test #1
      fillAA   \ fill all locations with %1010101010101010  ($AA)
      AA?      \ $AA check, test #2
      erase    \ erase before next test
      FF?      \ $FF check, test #3
      fill55   \ fill all locations with %0101010101010101  ($55)
      55?      \ $55 check, test #4
      erase    \ leave flash in erased state
      FF?      \ $FF check, test #5
      pass-flag @ 5 = if  1 2nd64kb-verified-flag !
	 else 0 2nd64kb-verified-flag !
	 then
      0 pass-flag !
;
 
: hidden64kB? ( -- )  
    2nd64kb-verified-flag @ if ." Hidden second 64kB Flash block VERIFIED, total of 128kB Flash in this MCU "
	       else ." Potential hidden second 64kB Flash block: untested or failed. "
	       then cr
;
 
: cause-exception ( -- )
   1000000 @ .
;

: wait ( -- )
   ." Please wait, testing Flash " 
; 
 
: flash-declared? ( -- )
  qty-flash-declared?
  65536 =
  IF
    1 flash=65536-declared-flag !
  ELSE
    0  flash=65536-declared-flag !
  THEN
;

: print-flash-declared ( -- )
  qty-flash-declared? . ." flash is declared in the Flash size register at 0x1FFFF7E0 " cr
;
\ ------------------------------------------------------------------------------ \
\ cpuid.fs
\ purpose: all mcu identification words

0 variable DBGMCU_IDCODE-UNREADABLE-FLAG

: 3addr ( -- )			       \ Device ID register addresses Bytes: 30 ok.
   $1FFFF7E8 @ $1FFFF7EC @ $1FFFF7F0 @
;

: duid ( addr1 addr2 addr3 -- u )      \ Derived device ID.  Device ID Bytes: 28 ok.
  3 1 do xor loop ;

: serial ( -- ) 3addr duid ." Unique Serial Number = 0x" hex. cr ;

: is-ascii? ( u -- true = printable | no = . )  \ Bytes: 58 ok.
  >r
  r@ 32 u>= r@ 127 u<
  and if
     r> emit
     else
     [char] . emit rdrop
  then ;

: ascii. ( -- )
  dup $ff000000 and 24 rshift is-ascii?  \ split Bytes: 60 ok.
  dup $00ff0000 and 16 rshift is-ascii? 
  dup $0000ff00 and  8 rshift is-ascii?
  $000000ff and is-ascii?
;
 
: id ( u -- )				  \ Bytes: 96
  dup ." $" hex. ." |"			  \ legend
  dup $ff000000 and 24 rshift is-ascii?	  \ split
  dup $00ff0000 and 16 rshift is-ascii? 
  dup $0000ff00 and  8 rshift is-ascii?
  $000000ff and is-ascii?
  ." | "
;

: scb_cpuid-bits31-0 ( -- )  \ scb_cpuid = $E000ED00
  scb_cpuid @ dup
  ." $" hex. ." = "
  $411FC231 = if ." STM32F1 series" else ." NOT STM32F1 series"
  then 
;

: scb_cpuid-bits31:24 ( -- )
  scb_cpuid @ $ff000000 and 24 rshift
;

: scb_cpuid-bits23:20 ( -- )
  scb_cpuid @ $00f00000 and 20 rshift
;

: scb_cpuid-bits19:16 ( -- )
  scb_cpuid @ $000f0000 and 16 rshift
;

: scb_cpuid-bits15:4 ( -- )
  scb_cpuid @ $0000fff0 and 4 rshift
;

: scb_cpuid-bits3:0 ( -- )
  scb_cpuid @ $0000000f and 
; 

: scb-cpuid ( -- )
   ." SCB-CPUID: " cr
   ." ---------- " cr
   ." <BITS-31:24>" scb_cpuid-bits31:24 ." $" h.2 ." </BITS-31:24>" cr
   ." <BITS-23:20>" scb_cpuid-bits23:20 ." $"  h.1 ."  </BITS-23:20>" cr
   ." <BITS-19:16>" scb_cpuid-bits19:16 ." $"  h.1 ."  </BITS-19:16>" cr
   ." <BITS-15:4>"  scb_cpuid-bits15:4 ." $"  h.3 ."  </BITS-15:4>" cr
   ." <BITS-3:0>"   scb_cpuid-bits3:0 ." $"  h.1 ."  </BITS-3:0>" cr
;

: uuid ( -- )	  \  unique-device-id
 ." UNIQUE DEVICE ID: " cr
 ." ----------------- " cr
 ." BITS-95:64 | " $1FFFF7F0 @ dup ." 0x" hex. ." | " ascii. cr
 ." BITS-63:32 | " $1FFFF7EC @ dup ." 0x" hex. ." | " ascii. cr
 ." BITS-31:0  | " $1FFFF7E8 @ dup ." 0x" hex. ." | " ascii. cr
 cr
;


: print-dbgmcu_idcode ( -- )
   $E0042000 @ ." DBGMCU_IDCODE [@ 0xE0042000] = 0x" hex. cr
;

: dbgmcu_idcode? ( -- ) \ 1 if DBGMCU_IDCODE NOT READABLE - pass
   $E0042000 @  0 =
   IF 
     1  DBGMCU_IDCODE-UNREADABLE-FLAG !
   ELSE
     0  DBGMCU_IDCODE-UNREADABLE-FLAG !
   THEN
;

$E00FFFD0 constant jdec-cont
$E00FFFE0 constant jdec-id
0 variable jdec-verified-flag

: jdec_ident_code ( -- hex )   \ jdec Identity Code
  jdec-id cell+ c@ $f0 and 4 rshift
  jdec-id 2 cells + c@ $7 and  
  4 lshift or 
;

: jdec_cont_code ( -- c ) jdec-cont c@ ; \ jdec Continuation Code

: jdec-verified-flag? ( -- )
   jdec_ident_code $20 =
   swap
   jdec_cont_code  $00 =
   and
   IF	 1 jdec-verified-flag !
   ELSE  0 jdec-verified-flag !
   THEN
;

: jdec-fallthru ." JDEC manufacturer id: UNKNOWN, consult readme 'JDEC Codes' table" cr ;

: jedec_id. ( addr -- x )	    \ jdec print 
   jdec_cont_code dup ." Jdec Continuation Code: 0x" hex.2 cr
   jdec_ident_code dup  ." Jdec Identity Code: 0x" hex.2 cr
   8 lshift +							  \ merge ident/cont into one number for case
   case
      $2000 of ." JDEC manufacturer id: STMicroelectronics "   endof \ ident/cont
      $3b04 of ." JDEC manufacturer id: CKS or APM "	       endof
      $C807 of ." GigaDevice Semiconductor "		       endof
      $5107 of ." GigaDevice Semiconductor (Beijing)"	       endof
      		       
      jdec-fallthru swap
   endcase
;

\ flash=65536-test		 = 1 if flash=65536 - pass
\ DBGMCU_IDCODE-UNREADABLE-FLAG	 = 1 if DBGMCU_IDCODE NOT READABLE - pass
\ 2nd64kb-verified-flag		 = 1 if 2nd64kb-verified - pass
\ jdec-verified-flag		 = 1 if STMicroelectronics - pass

: test-status? ( -- )
   flash=65536-declared-flag @ 0 = IF ." FAIL - Declared flash not 65536 "
      ELSE ." PASS - Declared flash = 65536 Bytes " THEN cr
   DBGMCU_IDCODE-UNREADABLE-FLAG @ 0 = IF ." FAIL - DBGMCU_IDCODE is readable with no SWD/Jtag connected "
      ELSE ." PASS - DBGMCU_IDCODE is NOT readable without SWD/Jtag connected " THEN cr
   2nd64kb-verified-flag @ 0 = IF ." FAIL - Second 64KB flash block not verified or not tested "
      ELSE ." PASS - Second 64KB flash block verified "  THEN cr
   jdec-verified-flag @ 0 = IF ." FAIL - JDEC manufacturer id NOT STMicroelectronics " 
      ELSE ." PASS - JDEC manufacturer id IS STMicroelectronics " THEN cr
; 

: F103C8T6-Auth? ( -- )
   dbgmcu_idcode?
   flash-declared?
   jdec-verified-flag?
   flash=65536-declared-flag @  
   DBGMCU_IDCODE-UNREADABLE-FLAG @ 
   2nd64kb-verified-flag @
   jdec-verified-flag @
   and and and
   IF    ." STM32F103C8 authentication PASSED all these tests:" cr 
   ELSE  ." STM32F103C8 authentication FAILED one or more tests: " cr
   THEN
         ." ---------------------------------------------------- " cr
   test-status? 
;
\ ------------------------------------------------------------------------------ \
\ menu.fs
\ purpose: menues and help texts

: 0dump $00000  65535 dump ;	 \ $0 to $FFFF, 1st 64kB Flash block
: 1dump $10000  65535 dump ;	 \ $10000 to $1FFFF, 2nd 64kB Flash block
: fflag-fail! $fff0 $1FFF0 hflash! ;
: fflag-pass! $ff00 $1FFF0 hflash! ;	 
: ex3   $20000  dump16 ;	 \ $20000  -> Exception #3 
: flash-$55@$1FFF0 %0101010101010101 $1FFF0 hflash! ;  \ insert 55 @$1FFD0 near end of 128kb block
: read-@$1FFF0 $1FFF0 c@ h.2 cr ;


: credits ( -- ) cr cr
   ." Bluepill Diagnostics V1.6 written by Terry Porter <terry@tjporter.com.au> " cr
   ." https://mecrisp-stellaris-folkdoc.sourceforge.io/bluepill-diagnostics-v1.6.html " cr
   ." Mecrisp-Stellaris Forth Homepage: http://mecrisp.sourceforge.net/ " cr
   ." Mecrisp-Stellaris created by Matthias Koch  " cr
;

: license ( -- ) cr cr
   ." This project is licensed under the terms of the MIT license " cr 
;

: faq ( -- ) cr cr
   ." * How many times can the 't' test be safely run ? << Thousands of times " cr
   ." * The Flash Data View is too fast  << Use your terminal loging facility & capture it " cr
   ." * Will this test harm my chip ? << No " cr
   ." * How can I view the current chip memory status ? << Quit the menu and enter 'free' " cr
   ." * How was the Test Kit made ? << Using the Forth Programming Language " cr
   ." * How do I see other programs on the chip ?  << Quit the menu and enter 'words4' " cr
   ." * Can I write other programs on this chip  << Yes, it's a complete Forth system " cr
   ." * Learn more about Forth << Mecrisp Stellaris Unofficial UserDoc: https://mecrisp-stellaris-folkdoc.sourceforge.io " cr
;

: usb-faq ( -- ) cr cr
   ." BluePill and generic boards: USBDP on GPIO-A12, normally HIGH pulsed LOW for 10mS at reboot " cr
   ." Maplemini: USBDP on GPIO-B9, normally LOW, pulsed HIGH for 10mS at reboot " cr
;

: fallthru ." Not a menu item: press the 'm' key for the menu" cr 0 ;

: extra-menu-print ( -- ) cr cr
  ." ---------- " cr 
  ." Extra Menu " cr
  ." ---------- " cr
  ." f - view First  64kb flash memory block: 0x00000 - 0x10000 " cr
  ." s - view Second 64kb flash memory block: 0x10000 - 0x1FFFF " cr
  ." i - unique device Id " cr
  ." n - unique derived serial Number " cr
  ." a - fAQ " cr
  ." u - Usb faq " cr
  ." c - Credits " cr
  ." l - License " cr
  ." v - Version " cr
  ." q - Quit back to main menu " cr
  ." m - Extra menu " cr
  cr cr
;

: menu-a ( -- )
   qty-flash-declared?
   case 
      65536  of ." h - test for Hidden second 64kb flash block: 0x10000 - 0x1FFFF" endof
      131072 of ." h - test second Half of the 128KB flash declared for this chip" endof
	        ." unexpected result "
   endcase
   2nd64kb-verified-flag @ if ." :  PASSED " then cr     
;

: menu-print ( -- ) cr cr
 ." --------- " cr
 ." Main Menu " cr
 ." --------- " cr 
 menu-a	 \ flash test menu
 ." f - how much Flash is declared in the Flash Size Register ? " cr
 ." d - Print DBGMCU_IDCODE " cr
 ." a - STM32F103C8T6 Authenticity test, don't use with SWD/JTAG. Requires test h once to complete" cr
 ." j - Jdec manufacturer id " cr
 ." e - Extra menu " cr
 ." q - Quit menu, enter the Forth command line " cr
 ." m - Main menu " cr
 cr cr
;

: extra-menu ( -- )  cr \ Extra Menu
  extra-menu-print
  begin key
     case
	 [char] a of faq      extra-menu-print  0 endof
	 [char] c of credits  extra-menu-print  0 endof
	 [char] f of 0dump    extra-menu-print  0 endof
	 [char] s of 1dump    extra-menu-print  0 endof
	 [char] l of license  extra-menu-print  0 endof
	 [char] i of uuid     extra-menu-print  0 endof
	 [char] n of serial   extra-menu-print  0 endof
	 [char] u of usb-faq  extra-menu-print  0 endof
	 [char] m of	      extra-menu-print  0 endof
	 [char] v of version  extra-menu-print  0 endof
	 [char] q of				1 endof
	 fallthru swap		 \ default fall thru	  
     endcase
  until
  menu-print
;

: menu ( -- ) cr			 \ Main Menu
   menu-print
   begin key
      case
	 [char] d of print-dbgmcu_idcode     menu-print  0 endof
	 [char] f of print-flash-declared    menu-print  0 endof
	 [char] a of F103C8T6-Auth?	     menu-print  0 endof
	 [char] j of jedec_id.		     menu-print  0 endof
	 [char] e of extra-menu				 0 endof
	 [char] h of wait 2nd64kb?	     menu-print  0 endof
	 [char] m of			     menu-print  0 endof
	 [char] q of					 1 endof
	 fallthru swap	\ default fall thru
      endcase  
   until 
   cr cr
   ." enter 'menu' to restart menu " cr
;

: m menu ( -- ) ;

\ Program Name: id.fs
\ Copyright 2021 by t.j.porter <terry@tjporter.com.au>, MIT licensed.
\ For Mecrisp-Stellaris by Matthias Koch.
\ https://sourceforge.net/projects/mecrisp/
\ Chip: STM32F103C8 or clones.
\ All register names are CMSIS-SVD compliant
\ Note: gpio a,b,c,d,e, and uart1 are enabled by Mecrisp-Stellaris Core.
\ Standalone: no preloaded support files required
\
\ This Program : Determines if STM32F103C8T6 is present, prints all the ID registers of Blue Pill MCU
\
\ *** NOTE *** 64KB Image MUST be flashed with /usr/local/share/openocd/scripts/target/stm32f1x.cfg or
\ 2nd flash block test will FAIL with "Wrong address or data for writing flash !!" !!
\
\ Clock is set to 72MHz in id-includes.fs for faster uploading
\ -------------------------------------------------------------------------------------------------- \


: option-jumper? ( -- )	 \ Two pin option jumper selects whether the terminal will use SWD or USB at power up.
   $F GPIOA_CRL_MODE0<<	 GPIOA_CRL bic!   \ clear all bits
   INPUT.PULLX GPIOA_CRL_MODE0<<	  \ set input pullup/pull down mode. Is pulldown when ODR bit = 0 (reboot default)
                  GPIOA_CRL bis!
   JUMPER-ON? not IF init.usb menu	  \ (3V<->PA0) JUMPER-ON? then PA0 = HI = SWDCOM, else USB after reboot.
      THEN				  \ else USB and menu after reboot.
;


: init ( -- )	
   72mhz
   7200 init.systick	\ tick = 1 ms needed for usb pulse ?
   init.calltrace
   RCC_APB2ENR_IOPAEN RCC_APB2ENR_IOPBEN RCC_APB2ENR_IOPCEN + + RCC_APB2ENR bis! \ enable GPIO's A,B & C
   usddp-init
   usbdp-pulse
   option-jumper?
   cr cr
;

init quit
compiletoram
   
 


