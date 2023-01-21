using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram.Model
{
    internal class ThreadsSplitter
    {
        int[] pixels;
        int numberOfPixels;
        int numberOfThreads;
        bool usersLibChoice;
        ResultHolder result;
        //public delegate (double[] R, double[] G, double[] B) Func< out (double[] R, double[] G, double[] B)>();
        //private Func<int> delegat;

        internal ThreadsSplitter(int[] pixels, int numberOfPixels, int numberOfThreads, bool usersLibChoice)
        {
            this.pixels = pixels;
            this.numberOfPixels = numberOfPixels;
            this.numberOfThreads = numberOfThreads;
            this.usersLibChoice = usersLibChoice;
            ThreadPool.SetMaxThreads(1, 1);
            ThreadPool.SetMinThreads(1, 1);
        }

        internal ResultHolder assignTaskAndGetData()
        {
            result = new ResultHolder(new double[256], new double[256], new double[256]);
            int numberOfTasks = 16; // chyba przerobic na numberOfThreads i zrobi tyle taskow ile watkow.
            int numberOfData = (numberOfPixels / numberOfTasks) + 1;

            int[][] somePixels = new int[numberOfTasks][];

            for (int i = 0; i < numberOfTasks; i++)
            {
                if ((((i + 1) * numberOfData) - 1) < numberOfPixels)
                    somePixels[i] = new int[numberOfData];
                else
                    somePixels[i] = new int[numberOfData - ((i + 1) * numberOfData - numberOfPixels)];
            }

            somePixels[0][0] = pixels[0];
            for (int i = 1; i < numberOfPixels; i++)
            {
                somePixels[(i / numberOfData)][i % numberOfData] = pixels[i];
            }
            /*
             for (int i = 1; i < numberOfPixels; i++)
            {
                if (i % numberOfData == 0)
                {
                    if (i+numberOfData < numberOfPixels)
                        somePixels[i / numberOfData] = new int[numberOfData];
                    else
                        somePixels[i / numberOfData] = new int[numberOfPixels%(numberOfData*(numberOfTasks-1))];
                }
                somePixels[(i / numberOfData)][i % numberOfData] = pixels[i]; 
            }
             */

            var tasks = new Task<ResultHolder>[numberOfTasks];


            for (int i = 0; i < numberOfTasks; i++)
            {
                int[] pixelsSmallTab = somePixels[i];

                if (usersLibChoice)
                    tasks[i] = Task.Factory.StartNew(() => doTaskCS(pixelsSmallTab));
                else
                    tasks[i] = Task.Factory.StartNew(() => doTaskAsm(pixelsSmallTab));
            }



            Task.WaitAll(tasks);
            
            for(int i = 0; i < numberOfTasks; i++)
            {
                // if (tasks[i].Result != null)
                //  result.addToResult(tasks[i].Result);
                result += tasks[i].Result;
            }

            return result;

            //if (usersLibChoice) 
        }

        public ResultHolder doTaskCS(int[] pixels)
        {
            SimpleTask task = new SimpleTaskCS(pixels);
            return task.doTask();

        }

        public ResultHolder doTaskAsm(int[] pixels)
        {
            SimpleTask task = new SimpleTaskAsm(pixels);
            return task.doTask();

        }
    }
}
