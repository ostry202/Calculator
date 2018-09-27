using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("First number: ");
            var a = Console.ReadLine();
            Console.WriteLine("Operation (+,-,/,*) :");
            var y = Console.ReadLine();
            Console.WriteLine("Second number: ");
            var b = Console.ReadLine();
            Console.WriteLine(Environment.NewLine + "*****************************************************"  + Environment.NewLine);
            //var result = (x > z) ? "X is bgger than Z" : "Z is bigger than X";
            // var result1 = x.ToString().CompareTo(z.ToString());

            if (!(Cumulative.ValidateAll(a, y, b)))
            {

                var q = double.Parse(a);
                var w = double.Parse(b);

                DataContainer data = new DataContainer(q, w);

                switch (y)
                {
                    case "+":
                        Console.WriteLine($"Result of adding: {MathematicalOperations.Plus(q, w)}");
                        break;
                    case "-":
                        Console.WriteLine($"Result of substraction: {MathematicalOperations.Minus(q, w)}");
                        break;
                    case "*":
                        Console.WriteLine($"Result of multiplication: {MathematicalOperations.Multiplication(q, w)}");
                        break;
                    case "/":
                        if (!(InputValidation.DivideZero(data.Q, data.W)))
                        {
                            Console.WriteLine($"Result of divide: {MathematicalOperations.Divide(q, w)}");
                        }
                        break;
                    case "%":
                        Console.WriteLine($"Result of modulo {MathematicalOperations.Modulo(q, w)}");
                        break;
                }

                Cumulative.GreaterThan0(q, w);
                Cumulative.Bigger(q, w);
            }
        }
    }
}
