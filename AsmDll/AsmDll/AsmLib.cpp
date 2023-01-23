#include "pch.h"
#include "framework.h"
#include "AsmLib.h"

extern "C" void incrementAsm(__m128 pixels, __m128 R, __m128 G, __m128 B, int pixels_size);

extern "C" ASMLIB_API void incrementRGB(__m128 pixels, __m128 R, __m128 G, __m128 B, int pixels_size)
{
	incrementAsm(pixels, R, G, B,pixels_size);
	/*
	* for(int i = 0; i < pixels_size; i+4)
	* {
	*		incrementAsm([pixels[i],pixels[i+1],pixels[i+2],pixels[i+3]], R[],G[],B[])
	* }
	* 
	* 
	* [pixels[i],pixels[i+1],pixels[i+2],pixels[i+3]]
	* jak zamieœciæ 4 pixele w formie inta do xmm
	* 
	*/
}