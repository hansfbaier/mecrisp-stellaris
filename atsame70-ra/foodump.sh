#!/bin/sh
pyocd commander <<EOF 
rw 0x480000 0x5000
EOF

