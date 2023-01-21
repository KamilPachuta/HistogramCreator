#pragma once
#ifdef ASMLIB_EXPORTS
#define ASMLIB_API __declspec(dllexport)
#else
#define ASMLIB_API __declspec(dllexport)
#endif

extern "C" ASMLIB_API void incrementRGB(__m128 pixels, __m128 R, __m128 G, __m128 B, int pixels_size);