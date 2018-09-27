using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Calculator
{
    class InputValidation
    {
        private static bool IsNUmber(string input)
        {
            if (Regex.IsMatch(input, @"[\d]"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool FirstValueNotNumber(string a)
        {
            if (!IsNUmber(a))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SecondValueNotNumber(string a)
        {
            if (!IsNUmber(a))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool LackOfNumbers(string a, string b)
        {
            if (!IsNUmber(a) && !IsNUmber(b))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool EmptyOperation(string a, string y, string b)
        {
            if (string.IsNullOrEmpty(a) && string.IsNullOrEmpty(y) && string.IsNullOrEmpty(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool EmptyFirstNumber(string a, string y, string b)
        {
            if (string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(y) && !string.IsNullOrEmpty(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool EmptyMathSymbol(string a, string y, string b)
        {
            if (string.IsNullOrEmpty(y) && !string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool EmptySecondNumber(string a, string y, string b)
        {
            if (string.IsNullOrEmpty(b) && !string.IsNullOrEmpty(y) && !string.IsNullOrEmpty(a))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool WrongMathSymbol(string y)
        {
            if (y != "/" && y != "*" && y != "+" && y != "-" && y != "%")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool DivideZero(double q, double w)
        {
            if (q == 0 || w == 0)
            {
                Console.WriteLine("You can't divide by 0!!!!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
