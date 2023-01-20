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
            double[] R = new double[256];
            double[] G = new double[256];
            double[] B = new double[256];
            for (int i = 0; i < pixels.Length; i++)
            {
                HistogramCs.incrementRGB(R, G, B, pixels, i); // Wywołanie metody statycznej z dll C#
            }
            
            return new ResultHolder(R, G, B);
        }
    }
}
