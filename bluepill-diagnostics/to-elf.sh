arm-none-eabi-objcopy -I binary -O elf32-littlearm --change-section-address=.data=0x8000000 -B arm -S bluepill-diagnostics-v1.631.bin bluepill-diagnostics-v1.631.elf
