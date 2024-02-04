; A program to add two numbers.
; This program is written in assembly language (NASM x86).
section .text
    global main
    extern printf

; Takes two numbers and stores the sum of the two numbers in the eax register.
sum:
    push ebp
    mov ebp, esp

    xor eax, eax ; Sets the eax register to 0
    mov eax, [ebp+8]
    add eax, [ebp+12]

    pop ebp

    ret

main:
    mov edx, message_length
    mov ecx, message
    mov ebx, 1 ; File descriptor (stdout)
    mov eax, 4 ; System call number (sys_write)
    int 0x80 ; Calls kernel    

    push 5 ; Pushes the first argument
    push 2 ; Pushes the second argument
    call sum ; Calls the sum function to add the two numbers

    mov [output], eax ; Saves the sum of the two numbers
    
    mov edx, result_message_length
    mov ecx, result_message
    mov ebx, 1
    mov eax, 4
    int 0x80

    ; Prints the sum of the two numbers
    push dword[output]
    push print_fmt
    call printf

    ; To exit the program
    mov eax, 1 ; System call number (sys_exit)
    int 0x80 ; Calls kernel

section .data
    message db 'program starts', 0xa
    message_length equ $ - message

    result_message db 'result is: ', 0xa
    result_message_length equ $ - result_message

    print_fmt db "%d" , 0xa, 0 ; %d: signed decimal integer.

section .bss
    output resd 1
