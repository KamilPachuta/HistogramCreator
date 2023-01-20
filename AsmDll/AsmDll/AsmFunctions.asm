.data
    pixels_ptr dq 0
    R_ptr dq 0
    G_ptr dq 0
    B_ptr dq 0
    pixels_size dq 0

.code
incrementAsm proc
    mov ebx, dword ptr[rbp + 48] ; zapisanie wielkosci tablicy
    mov r11, rbx ;? nie ebx?
    
    movdqu xmm1, oword ptr[rdx] ; zapisz adres do R?
    ;movdqu xmm0, oword ptr [xmm1]
    ;movss pixel, [xmm1]
    ;movdqu		oword ptr[rcx], xmm1		
    ; przetworzony piksel wpisujemy w odpowiednie miejsce w tablicy pikseli
    ret
incrementAsm endp
end
