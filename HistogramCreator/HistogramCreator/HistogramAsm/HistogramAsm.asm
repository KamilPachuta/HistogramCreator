
.code
MyProc1 proc
movdqu xmm0, [rcx]      ; Wpisuje 4 Pixele do xmm0





						; Wyciagniecie koloru R

xor r13, r13            ; zerowanie r13
add r13, 16711680       ; maska na R
movd xmm1, r13          ; Wpisz maske na R do xmm1
pshufd xmm1, xmm1, 0    ; Wypelnij xmm1 ta maska

vpand xmm2, xmm0, xmm1  ; Zapisuje zamaskowane pixele na R w xmm2
psrld xmm2, 16          ; Przesuniecie bitowe o 16 w prawo



						; Inkrementacje:

pextrb r11, xmm2, 0     ; Wyciagniecie wartosci r z pixel[0] do r11
imul r11, 4             ; w r11 jest przesuniecie adresu tablicy
mov r12, [RDX+r11]      ; Wpisz do r12 wartosc do inkrementacji
add r12, 1              ; Inkrementacja
mov [RDX+r11], r12      ; Zapisz wartosc

pextrb r11, xmm2, 4     ; Wyciagniecie wartosci r z pixel[0] do r11
imul r11, 4             ; w r11 jest przesuniecie adresu tablicy
mov r12, [RDX+r11]      ; Wpisz do r12 wartosc do inkrementacji
add r12, 1              ; Inkrementacja
mov [RDX+r11], r12      ; Zapisz wartosc

pextrb r11, xmm2, 8     ; Wyciagniecie wartosci r z pixel[0] do r11
imul r11, 4             ; w r11 jest przesuniecie adresu tablicy
mov r12, [RDX+r11]      ; Wpisz do r12 wartosc do inkrementacji
add r12, 1              ; Inkrementacja
mov [RDX+r11], r12      ; Zapisz wartosc

pextrb r11, xmm2, 12     ; Wyciagniecie wartosci r z pixel[0] do r11
imul r11, 4             ; w r11 jest przesuniecie adresu tablicy
mov r12, [RDX+r11]      ; Wpisz do r12 wartosc do inkrementacji
add r12, 1              ; Inkrementacja
mov [RDX+r11], r12      ; Zapisz wartosc





						; Wyciagniecie koloru G

xor r13, r13            ; zerowanie r13
add r13, 65280          ; maska na G
movd xmm1, r13          ; Wpisz maske na R do xmm1
pshufd xmm1, xmm1, 0    ; Wypelnij xmm1 ta maska

vpand xmm2, xmm0, xmm1  ; Zapisuje zamaskowane pixele na G w xmm2
psrld xmm2, 8          ; Przesuniecie bitowe o 8 w prawo



						; Inkrementacje:

pextrb r11, xmm2, 0     ; Wyciagniecie wartosci g z pixel[0] do r11
imul r11, 4             ; w r11 jest przesuniecie adresu tablicy
mov r12, [r8+r11]       ; Wpisz do r12 wartosc do inkrementacji
add r12, 1              ; Inkrementacja
mov [r8+r11], r12       ; Zapisz wartosc

pextrb r11, xmm2, 4     ; Wyciagniecie wartosci g z pixel[0] do r11
imul r11, 4             ; w r11 jest przesuniecie adresu tablicy
mov r12, [r8+r11]       ; Wpisz do r12 wartosc do inkrementacji
add r12, 1              ; Inkrementacja
mov [r8+r11], r12       ; Zapisz wartosc

pextrb r11, xmm2, 8     ; Wyciagniecie wartosci g z pixel[0] do r11
imul r11, 4             ; w r11 jest przesuniecie adresu tablicy
mov r12, [r8+r11]       ; Wpisz do r12 wartosc do inkrementacji
add r12, 1              ; Inkrementacja
mov [r8+r11], r12       ; Zapisz wartosc

pextrb r11, xmm2, 12     ; Wyciagniecie wartosci g z pixel[0] do r11
imul r11, 4             ; w r11 jest przesuniecie adresu tablicy
mov r12, [r8+r11]       ; Wpisz do r12 wartosc do inkrementacji
add r12, 1              ; Inkrementacja
mov [r8+r11], r12       ; Zapisz wartosc





						; Wyciagniecie koloru B

xor r13, r13            ; zerowanie r13
add r13, 255            ; maska na B
movd xmm1, r13          ; Wpisz maske na R do xmm1
pshufd xmm1, xmm1, 0    ; Wypelnij xmm1 ta maska

vpand xmm2, xmm0, xmm1  ; Zapisuje zamaskowane pixele na B w xmm2



						; Inkrementacje:

pextrb r11, xmm2, 0     ; Wyciagniecie wartosci b z pixel[0] do r11
imul r11, 4             ; w r11 jest przesuniecie adresu tablicy
mov r12, [r9+r11]       ; Wpisz do r12 wartosc do inkrementacji
add r12, 1              ; Inkrementacja
mov [r9+r11], r12       ; Zapisz wartosc

pextrb r11, xmm2, 4     ; Wyciagniecie wartosci b z pixel[0] do r11
imul r11, 4             ; w r11 jest przesuniecie adresu tablicy
mov r12, [r9+r11]       ; Wpisz do r12 wartosc do inkrementacji
add r12, 1              ; Inkrementacja
mov [r9+r11], r12       ; Zapisz wartosc

pextrb r11, xmm2, 8     ; Wyciagniecie wartosci b z pixel[0] do r11
imul r11, 4             ; w r11 jest przesuniecie adresu tablicy
mov r12, [r9+r11]       ; Wpisz do r12 wartosc do inkrementacji
add r12, 1              ; Inkrementacja
mov [r9+r11], r12       ; Zapisz wartosc

pextrb r11, xmm2, 12    ; Wyciagniecie wartosci b z pixel[0] do r11
imul r11, 4             ; w r11 jest przesuniecie adresu tablicy
mov r12, [r9+r11]       ; Wpisz do r12 wartosc do inkrementacji
add r12, 1              ; Inkrementacja
mov [r9+r11], r12       ; Zapisz wartosc



ret
MyProc1 endp
end
