.data
    pixels_ptr dq 0
    R_ptr dq 0
    G_ptr dq 0
    B_ptr dq 0
    pixels_size dq 0

.code
incrementAsm proc
MOVQDU XMM0, [RCX]
    MOVQDU XMM0, [RCX]



   
    ret
incrementAsm endp
end
