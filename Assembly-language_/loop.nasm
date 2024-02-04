; A "for loop" program to print numbers from 5 to 9
; This program is written in assembly language (NASM x86)
section .text
    global main
    extern printf

main:
    mov eax, 5
    mov ebx, 10

for:
    cmp eax, ebx
    jge end_for

    push eax
    push message
    call printf
    add esp, 4
    pop eax

    add eax, 1
    jmp for

end_for:
    mov edx, message_exit_length
    mov ecx, message_exit
    mov ebx, 1
    mov eax, 4
    int 0x80

    mov eax, 1
    int 0x80

section .data
    message db "The i is: %d", 0xa, 0
    message_exit db 'program is exit', 0xa
    message_exit_length equ $ - message_exit
