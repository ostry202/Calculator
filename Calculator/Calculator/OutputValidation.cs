using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class OutputValidation
    {
        public static bool IsBigger(double q, double w)
        {
            if (q > w)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsLower(double q, double w)
        {
            if (q < w)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsEqual(double q, double w)
        {
            if (q == w)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool BiggerThan0(double q, double w)
        {
            if (q > 0 && w > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SecondThan0(double q, double w)
        {
            if (!(q > 0) && w > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool FirstThan0(double q, double w)
        {
            if (!(w > 0) && q > 0)
            {
                return true;
            }
            {
                return false;
            }
        }
        public static bool NegativeValue(double q, double w)
        {
            if (!(q > 0) && !(w > 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
