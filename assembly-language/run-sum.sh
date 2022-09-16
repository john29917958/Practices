nasm -f elf sum.nasm
gcc -m32 -o sum sum.o
# ld -m elf_i386 -s -o sum sum.o
./sum
