.data
    pixels_ptr dq 0
    R_ptr dq 0
    G_ptr dq 0
    B_ptr dq 0
    pixels_size dq 0

.code
incrementAsm proc
    ;movd R_ptr, qword ptr[rbp+16]
    ;pop pixels_size
    ;movdqu xmm1, oword ptr[r8] ; zapisz adres do R?
    mov rbx, qword ptr[rbp+8] ; zapisanie wielkosci tablicy
    mov r11, rbx ;
    ;add [r14], 5
    ;[r14] bylo tam R
    ;r8 -wskaznik na G
    ;r9 - wskaznik na B
    ;rdx -> R
    ; w obowiazujacnym adressie na samym dole byla wartosc pixelssize
    ;movdqu xmm0, oword ptr [xmm1]
    ;movss pixel, [xmm1]
    ;movdqu		oword ptr[rcx], xmm1		
    ; przetworzony piksel wpisujemy w odpowiednie miejsce w tablicy pikseli
    ret
incrementAsm endp
end
