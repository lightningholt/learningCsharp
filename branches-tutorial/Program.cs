using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void ExploreIf()
        {
            int a = 5;
            int b = 6;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }

            int c = 4;
            // && denotes AND operator
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number equals the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }

            // || denotes OR operator
            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number equals the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }
        }

        static void ExploreWhileAndDoLoops()
        {
            int counter = 0;
            // while loops check condition, then implement code.
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }


            int count = 0;
            // the do... while loops implement code, then check condition
            do
            {
                Console.WriteLine($"Hello World! The counter is {count}");
                count++;
            } while (count < 10);

            // The above two loops produce the same result
        }
        static void ExploreForLoops()
        {
            // For loop example
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }

            // Practice nesting for loops
            for (int row = 1; row < 11; row++)
            {
                Console.WriteLine($"The row is {row}");
            }

            for (char col = 'a'; col < 'k'; col++)
            {
                Console.WriteLine($"The column is {col}");
            }

            for (char col = 'a'; col < 'k'; col++)
            {
                for (int row = 1; row < 11; row++)
                {
                    Console.WriteLine($"The cell is {row}{col}");
                }
            }
        }
        static void Main(string[] args)
        {
            //ExploreIf();
            //ExploreWhileAndDoLoops();
            //ExploreForLoops();

            // challenge problem:

            int res = 0;
            for (int num = 1; num < 21; num++)
            {
                if (num % 3 == 0)
                {
                    res += num;
                }
            }
            Console.WriteLine(res); 
        }
    }
}
