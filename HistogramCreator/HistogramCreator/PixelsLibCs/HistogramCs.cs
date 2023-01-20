namespace PixelsLibCs
{
    public class HistogramCs
    {
        public static void incrementRGB(double[] R, double[] G, double[] B, int[] pixels, int i)
        {
            R[(pixels[i] >> 16) & 0xff]++;
            G[(pixels[i] >> 8) & 0xff]++;
            B[pixels[i] & 0xff]++;
        }

    }

}