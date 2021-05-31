using System;
using System.Collections.Generic;
using System.Linq;

namespace lambdas
{
    class Program
    {
        static Random random = new Random();
        static double GetRandomDouble(int max) => max * random.NextDouble();
        static void PrintValue(double d) => Console.WriteLine($"The value is {d:0.0000}");
        /*static double GetRandomDouble(int max)
        {
            return max * random.NextDouble();
        }
        static void PrintValue(double d)
        {
            Console.WriteLine($"The value is {d:0.0000}");
        }*/
        static void Main(string[] args)
        {
            var value = Program.GetRandomDouble(100);
            Program.PrintValue(value);
            var array = new[] { 1, 2, 3, 4 };
            // var result = from i in array select i * 2;
            var result = array.Select(i => i * 2);
            foreach (var i in result) Console.WriteLine(i);
        }
    }
}
