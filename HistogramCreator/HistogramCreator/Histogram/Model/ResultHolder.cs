using Accessibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram.Model
{
    
    internal class ResultHolder
    {
        private int[] _R = new int[256];
        private int[] _G = new int[256];
        private int[] _B = new int[256];

        internal ResultHolder(int[] R, int[] G, int[] B) 
        {
            _R = R;
            _G = G;
            _B = B;
        }

        public int[] R
        {
            get { return _R; }
        }

        public int[] G 
        { 
            get { return _G; } 
        }

        public int[] B 
        { 
            get { return _B; } 
        }

        public void addToResult(ResultHolder x)
        {
            for (int i = 0; i < 256; i++)
            {
                this.R[i] += x.R[i];
                this.G[i] += x.G[i];
                this.B[i] += x.B[i];
            }
        }

        public static ResultHolder operator +(ResultHolder x, ResultHolder y) 
        {
            int[] r = new int[256];
            int[] g = new int[256];
            int[] b = new int[256];
            for (int i = 0; i < 256; i++) 
            {
                r[i] = x.R[i] + y.R[i];
                g[i] = x.G[i] + y.G[i];
                b[i] = x.B[i] + y.B[i];

            }
            return new ResultHolder(r,g,b);
        }
    }

}
