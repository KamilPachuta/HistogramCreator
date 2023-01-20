#include "pch.h"
#include "framework.h"
#include "AsmLib.h"

extern "C" void incrementAsm(int* pixels, double* R, double* G, double* B, int pixels_size);

extern "C" ASMLIB_API void incrementRGB(int* pixels, double* R, double* G, double* B, int pixels_size)
{
	incrementAsm(pixels, R, G, B,pixels_size);
}