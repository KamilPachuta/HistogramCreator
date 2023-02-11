namespace PixelsLibCs
{
    public class HistogramCs
    {
        public static void incrementRGB(int[] R, int[] G, int[] B, int[] pixels)
        {
            for (int i = 0; i < 4; i++)
            {
                R[(pixels[i] >> 16) & 0xff]++;
                G[(pixels[i] >> 8) & 0xff]++;
                B[pixels[i] & 0xff]++;
            }
        }

    }

}