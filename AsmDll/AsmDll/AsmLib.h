#pragma once
#ifdef ASMLIB_EXPORTS
#define ASMLIB_API __declspec(dllexport)
#else
#define ASMLIB_API __declspec(dllexport)
#endif

extern "C" ASMLIB_API void incrementRGB(int* pixels, double* R, double* G, double* B, int pixels_size);