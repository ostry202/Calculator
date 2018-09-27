using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class DataContainer:MathematicalOperations
    {
        public double Q { get; set; }
        public double W { get; set; }

       public DataContainer(double q, double w)
        {
            Q = q;
            W = w;
        }
    }

}
