using ScottPlot;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram.Model
{
    internal class MainModel
    {
        Bitmap loadedBitmap;
        bool usersLibChoice;
        int numberOfThreads;
        int[] pixels;
        int numberOfPixels;
        int bitmapWidth;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="choice"></param>
        /// <param name="nThreads"></param>
        internal MainModel(Bitmap bitmap, bool choice, int nThreads)
        {
            loadedBitmap = bitmap;
            usersLibChoice = choice;
            numberOfThreads = nThreads;
            bitmapWidth = loadedBitmap.Width;
            numberOfPixels = (bitmapWidth * loadedBitmap.Height)/4;
            numberOfPixels *= 4;
            changeBitmapToInts();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public (double[] R, double[] G, double[] B, double totalMilliseconds) getDataFromBitmap()
        {
            ThreadsSplitter threadsSplitter = new(pixels, numberOfPixels, numberOfThreads, usersLibChoice);
            (ResultHolder result, double time) = threadsSplitter.assignTaskAndGetData();
            (double[] R, double[] G, double[] B) = changeResultToTables(result);
            return (R, G, B, time);
        }

        /// <summary>
        /// 
        /// </summary>
        private void changeBitmapToInts()
        {
            
            pixels = new int[numberOfPixels];
            for(int i = 0; i < numberOfPixels; i++)
            {
                int y = i / loadedBitmap.Width;
                int x = i % loadedBitmap.Width;
                pixels[i] = loadedBitmap.GetPixel(x, y).ToArgb();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        private (double[] R, double[] G, double[] B) changeResultToTables(ResultHolder result)
        {
            
            double[] r = new double[256];
            double[] g = new double[256];
            double[] b = new double[256];

            for(int i = 0; i < 256; i++)
            {
                r[i] = result.R[i];
                g[i] = result.G[i];
                b[i] = result.B[i];

            }
            return (r, g, b);
        }




    }
}
