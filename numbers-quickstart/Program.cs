using System;

namespace NumbersInCSharp
{
    class Program
    {
        static void WorkingWithIntegers()
        {
            int a = 18;
            int b = 6;

            // addition
            int c = a + b;
            Console.WriteLine(c);

            // subtraction
            c = a - b;
            Console.WriteLine(c);

            // multiplication
            c = a * b;
            Console.WriteLine(c);

            // division
            c = a / b;
            Console.WriteLine(c);
        }

        static void OrderPrecedence()
        {
            int a = 5;
            int b = 4;
            int c = 2;

            // No parenthesis 
            int d = a + b * c;
            Console.WriteLine(d);

            // add parenthesis
            d = (a + b) * c;
            Console.WriteLine(d);

            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);


            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e + f) / g;
            Console.WriteLine(h);
        }
        static void TestLimits()
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;

            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow [{max} + 3] is {what}");
        }

        static void WorkWithDoubles()
        {
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);

            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e + f) / g;
            Console.WriteLine(h);

            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"the range of double values is {min} to {max}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);
        }

        static void WorkWithDecimals()
        {
            decimal max = decimal.MaxValue;
            decimal min = decimal.MinValue;
            Console.WriteLine($"the range of decimal values is {min} to {max}");

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M; // note the M suffix designates 1.0 as type decimal (rather than a double which is the default)
            decimal d = 3.0M;
            Console.WriteLine(c / d);
        }

        static void Main(string[] args)
        {
            //WorkingWithIntegers();
            //OrderPrecedence();
            //TestLimits();
            //WorkWithDoubles();
            //WorkWithDecimals();

            double radius = 2.5;
            double area = Math.PI * radius * radius;
            Console.WriteLine(area);

        }
    }
}
