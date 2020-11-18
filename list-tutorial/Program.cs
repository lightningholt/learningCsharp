using System;
using System.Collections.Generic; //this is a very important call

namespace list_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //WorkingWithStrings();
            var fibonacciNumber = new List<int> { 1, 1 };

            var previous = fibonacciNumber[fibonacciNumber.Count - 1];
            var previous2 = fibonacciNumber[fibonacciNumber.Count - 2];

            fibonacciNumber.Add(previous + previous2);

            for (int index = fibonacciNumber.Count; index < 20; index++)
            {
                previous = fibonacciNumber[index - 1];
                previous2 = fibonacciNumber[index - 2];

                fibonacciNumber.Add(previous + previous2);
            }

            

            foreach (var item in fibonacciNumber)
                Console.WriteLine(item);
        }
        static void WorkingWithStrings()
        {
            var names = new List<string> { "Caleb", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine();
            names.Add("Marija");
            names.Add("Bill");
            names.Remove("Ana");

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"I've added {names[2]} and {names[3]}");

            Console.WriteLine($"The list has {names.Count} people in it.");
            Console.WriteLine();

            var index = names.IndexOf("Felipe");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            index = names.IndexOf("Not Found");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            Console.WriteLine();

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}
