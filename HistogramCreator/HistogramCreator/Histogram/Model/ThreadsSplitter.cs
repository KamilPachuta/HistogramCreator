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
        //int numberOfThreads;
        bool usersLibChoice;
        ResultHolder result;

        internal ThreadsSplitter(int[] pixels, int numberOfPixels, int numberOfThreads, bool usersLibChoice)
        {
            this.pixels = pixels;
            this.numberOfPixels = numberOfPixels;
            //this.numberOfThreads = numberOfThreads;
            this.usersLibChoice = usersLibChoice;
            ThreadPool.SetMaxThreads(numberOfThreads, numberOfThreads);
            ThreadPool.SetMinThreads(numberOfThreads, numberOfThreads);
        }

        internal (ResultHolder, double totalMilliseconds) assignTaskAndGetData()
        {
            result = new ResultHolder(new int[256], new int[256], new int[256]);
            int numberOfTasks = 100; 
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
  

            var tasks = new Task<ResultHolder>[numberOfTasks];

            DateTime begin = DateTime.Now;

            for (int i = 0; i < numberOfTasks; i++)
            {
                int[] pixelsSmallTab = somePixels[i];

                if (usersLibChoice)
                    tasks[i] = Task.Factory.StartNew(() => doTaskCS(pixelsSmallTab));
                else
                    tasks[i] = Task.Factory.StartNew(() => doTaskAsm(pixelsSmallTab));
            }



            Task.WaitAll(tasks);

            TimeSpan time = DateTime.Now - begin;

            for (int i = 0; i < numberOfTasks; i++)
                result += tasks[i].Result;

            return (result, time.TotalMilliseconds);
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
