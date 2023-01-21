#include "pch.h"
#include "framework.h"
#include "AsmLib.h"

extern "C" void incrementAsm(__m128 pixels, __m128 R, __m128 G, __m128 B, int pixels_size);

extern "C" ASMLIB_API void incrementRGB(__m128 pixels, __m128 R, __m128 G, __m128 B, int pixels_size)
{
	incrementAsm(pixels, R, G, B,pixels_size);
}