using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PixelsLibCs;

namespace Histogram.Model
{
    internal class SimpleTaskCS : SimpleTask
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pixels"></param>
        public SimpleTaskCS(int[] pixels) : base(pixels) { }
        



        /// <summary>
        /// 
        /// </summary>
        public override ResultHolder doTask()
        {
            int[] R = new int[256];
            int[] G = new int[256];
            int[] B = new int[256];
            int[] fourPixels = new int[4];
            int j = 0;

            for (int i = 0; i < pixels.Length; i++)
            {
                fourPixels[j] = pixels[i];

                if (++j == 4 || i == pixels.Length)
                {
                    HistogramCs.incrementRGB(R, G, B, fourPixels);
                    pixels[i - 3] = fourPixels[0];
                    pixels[i - 2] = fourPixels[1];
                    pixels[i - 1] = fourPixels[2];
                    pixels[i] = fourPixels[3];
                    j = 0;
                }
            }



            return new ResultHolder(R, G, B);
      
        }
    }
}
