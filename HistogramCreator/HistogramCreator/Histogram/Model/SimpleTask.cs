using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram.Model
{
    abstract class SimpleTask
    {
        
        protected readonly int[] pixels;
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pixels"></param>
        protected SimpleTask(int[] pixels)
        {
            this.pixels = pixels;
        }

        /// <summary>
        /// 
        /// </summary>
        public abstract ResultHolder doTask();

    }
}
