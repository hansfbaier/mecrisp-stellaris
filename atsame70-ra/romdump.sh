#!/bin/sh
pyocd commander <<EOF 
rw 0x400000 0x50000
EOF

