using ScottPlot.Palettes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//using ..\PixelsLibAsm\PixelsLibAsm.vcxproj;

namespace Histogram.Model
{
    internal class SimpleTaskAsm : SimpleTask
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pixels"></param>
        public SimpleTaskAsm(int[] pixels) : base(pixels) { }

        [DllImport(@"D:\Documents\GitHub\HistogramCreator\HistogramCreator\HistogramCreator\x64\Debug\HistogramAsm.dll")]

        private static extern void MyProc1(int[] pixel, int[] R, int[] G, int[] B);
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

            for (int i = 0; i<pixels.Length;i++)
            {
                fourPixels[j] = pixels[i];

                if (++j == 4 || i == pixels.Length)
                {
                    MyProc1(fourPixels, R, G, B);
                    pixels[i - 3] = fourPixels[0];
                    pixels[i - 2] = fourPixels[1];
                    pixels[i - 1] = fourPixels[2];
                    pixels[i] = fourPixels[3];
                    j = 0;
                }
            }

            double[] dR = new double[256];
            double[] dG = new double[256];
            double[] dB = new double[256];

            for(int i = 0; i<256; i++)
            {
                dR[i] = R[i];
                dG[i] = G[i];
                dB[i] = B[i];
            }

            return new ResultHolder(dR, dG, dB);
        }
    }
}
