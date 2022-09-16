; NASM x86. A program written in assembly language.
section .text
    global main
    extern printf

; takes two numbers and stores the sum of the two numbers in the eax register.
sum:
    push ebp
    mov ebp, esp

    xor eax, eax ; set the eax register to 0
    mov eax, [ebp+8]
    add eax, [ebp+12]

    pop ebp

    ret

main:
    mov edx, message_length
    mov ecx, message
    mov ebx, 1 ; file descriptor (stdout)
    mov eax, 4 ; system call number (sys_write)
    int 0x80 ; call kernel    

    push 5 ; pushes the first argument
    push 2 ; pushes the second argument
    call sum ; calls the sum function to add the two numbers

    mov [output], eax ; saves the sum of the two numbers
    
    mov edx, result_message_length
    mov ecx, result_message
    mov ebx, 1
    mov eax, 4
    int 0x80

    ; prints the sum of the two numbers
    push dword[output]
    push print_fmt
    call printf

    ; to exit the program
    mov eax, 1 ; system call number (sys_exit)
    int 0x80 ; calls kernel

section .data
    message db 'program starts', 0xa
    message_length equ $ - message

    result_message db 'result is: ', 0xa
    result_message_length equ $ - result_message

    print_fmt db "%d" , 0xa, 0 ; the format specifier for C printf function. %d: signed decimal integer.

section .bss
    output resd 1
