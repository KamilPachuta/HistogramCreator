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
        private double[] _R = new double[256];
        private double[] _G = new double[256];
        private double[] _B = new double[256];

        internal ResultHolder(double[] R, double[] G, double[] B) 
        {
            _R = R;
            _G = G;
            _B = B;
        }

        public double[] R
        {
            get { return _R; }
        }

        public double[] G 
        { 
            get { return _G; } 
        }

        public double[] B 
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
            double[] r = new double[256];
            double[] g = new double[256];
            double[] b = new double[256];
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
