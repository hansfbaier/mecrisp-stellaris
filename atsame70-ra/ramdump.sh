#!/bin/sh
pyocd commander <<EOF 
rw 0x20400000 0x40000
EOF

