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

        // extern "C" void 

        [DllImport(@"D:\Documents\GitHub\HistogramCreator\HistogramCreator\HistogramCreator\x64\Debug\AsmDll.dll")]

        private static extern void incrementRGB(int[] pixels, double[] R, double[] G, double[] B, int pixels_size);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public override ResultHolder doTask()
        {
            double[] R = new double[256];
            double[] G = new double[256];
            double[] B = new double[256];
            incrementRGB(pixels, R, G, B, pixels.Length);
            return new ResultHolder(R, G, B);
            //extern "C" void _stdcall do_Task();
            //throw new NotImplementedException();
        }
    }
}
