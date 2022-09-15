; NASM x86
section .text
    global _start

; takes two numbers and stores the sum of the two numbers in the eax register.
sum:
    push ebp
    mov ebp, esp

    xor eax, eax ; set the eax register to 0
    mov eax, [ebp+8]
    add eax, [ebp+12]
    
    pop ebp

    ret

assert_are_equal:
    mov edx, message_is_equal_length
    mov ecx, message_is_equal
    mov ebx, 1
    mov eax, 4
    int 0x80
    
    mov eax, 1
    int 0x80

assert_are_not_equal:
    mov edx, message_is_not_equal_length
    mov ecx, message_is_not_equal
    mov ebx, 1
    mov eax, 4
    int 0x80
    
    mov eax, 1
    int 0x80

_start:
    mov edx, message_length
    mov ecx, message
    mov ebx, 1 ; file descriptor (stdout)
    mov eax, 4 ; system call number (sys_write)
    int 0x80 ; call kernel

    push 1 ; the first argument
    push 2 ; the second argument
    call sum ; call sum function to add the two numbers
    cmp eax, 3 ; assert if the result is 3
    je assert_are_equal ; assert true
    jne assert_are_not_equal ; assert false

    mov eax, 1 ; system call number (sys_exit)
    int 0x80 ; call kernel

section .data
    message_is_equal db 'the result is correct', 0xa
    message_is_equal_length equ $ - message_is_equal
    message_is_not_equal db 'the result is incorrect', 0xa
    message_is_not_equal_length equ $ - message_is_not_equal

    message db 'start sum program', 0xa
    message_length equ $ - message
