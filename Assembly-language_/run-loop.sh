#!/bin/sh
nasm -f elf loop.nasm
gcc -m32 -o loop loop.o
./loop
