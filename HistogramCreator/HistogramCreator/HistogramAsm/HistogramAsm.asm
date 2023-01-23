.code
MyProc1 proc
mov r14, rcx ; wpisz pixel do r14
xor r13, r13 ; zerowanie r13
add r13, 16711680 ; maska na R
and r14, r13 ; w r 14 wynik and z maska na R
shr r14, 16 ; przesuniecie bitowe na R
imul r14, 4 ; w r14 jest przesuniecie adresu tablicy
mov r12, [RDX+r14]
add r12, 1
mov [RDX+r14], r12


mov r14, rcx ; wpisz pixel do r14
xor r13, r13 ; zerowanie r13
add r13, 65280 ; maska na G
and r14, r13 ; w r 14 wynik and z maska na G
shr r14, 8 ; przesuniecie bitowe na G
imul r14, 4 ; w r14 jest przesuniecie adresu tablicy
mov r12, [r8+r14]
add r12, 1
mov [r8+r14], r12


mov r14, rcx ; wpisz pixel do r14
xor r13, r13 ; zerowanie r13
add r13, 255 ; maska na B
and r14, r13 ; w r 14 wynik and z maska na B
;shr r14, 8 ; przesuniecie bitowe na G
imul r14, 4 ; w r14 jest przesuniecie adresu tablicy
mov r12, [r9+r14]
add r12, 1
mov [r9+r14], r12



ret
MyProc1 endp
end