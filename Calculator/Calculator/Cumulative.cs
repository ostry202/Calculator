using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Cumulative
    {
        public static bool ValidateAll(string a, string y, string b)
        {
            if (InputValidation.EmptyOperation(a, y, b))
            {
                Console.WriteLine("Operation is empty!");
                return true;
            }
            else if (InputValidation.EmptyFirstNumber(a, y, b))
            {
                Console.WriteLine("First value is empty!");
                return true;
            }
            else if (InputValidation.EmptyMathSymbol(a, y, b))
            {
                Console.WriteLine("Mathematical symbol is empty!");
                return true;
            }
            else if (InputValidation.EmptySecondNumber(a, y, b))
            {
                Console.WriteLine("Second value is empty!");
                return true;
            }
            else if (InputValidation.LackOfNumbers(a, b))
            {
                Console.WriteLine("There are no numbers!");
                return true;
            }
            else if (InputValidation.FirstValueNotNumber(a))
            {
                Console.WriteLine("First value is not a number");
                return true;
            }
            else if (InputValidation.SecondValueNotNumber(b))
            {
                Console.WriteLine("Second value is not a number");
                return true;
            }
            else if (InputValidation.WrongMathSymbol(y))
            {
                Console.WriteLine("Wrong Mathematical Symbol!");
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Bigger (double q, double w)
        {
            if (OutputValidation.IsBigger(q, w))
            {
                Console.WriteLine("First number is bigger than Second number");
                return true;
            }
            else if (OutputValidation.IsLower(q, w))
            {
                Console.WriteLine("Second number is bigger than First number");
                return true;
            }
            else if (OutputValidation.IsEqual(q, w))
            {
                Console.WriteLine("First number is equal to Second number");
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool GreaterThan0 (double q, double w)
        {
            if (OutputValidation.BiggerThan0(q,w))
            {
                Console.WriteLine("Both numbers are greater than 0");
                return true;
            }
            else if (OutputValidation.SecondThan0(q,w))
            {
                Console.WriteLine("Only Second number is greater than 0");
                return true;
            }
            else if (OutputValidation.FirstThan0(q,w))
            {
                Console.WriteLine("Only First number is greater than 0");
                return true;
            }
            else if (OutputValidation.NegativeValue(q,w))
            {
                Console.WriteLine("Both numbers has negative value!!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
