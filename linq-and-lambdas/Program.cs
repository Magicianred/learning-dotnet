using System;

namespace linq_and_lambdas
{
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> numbers = new List<int>();
            for (int i = 1; i <= 99; i++)
            {
                numbers.Add(i);
            }
             METHOD CHAINING:
               Almost all of the LINQ methods return an IEnumerable<T>, you can take the result of a LINQ
               method and call another LINQ method directly on them with using a variable to keep track of the results.
            */
            //IEnumerable<int> firstAndLastFive = numbers.Take(5).Concat(numbers.TakeLast(5));
            /*foreach(int i in firstAndLastFive)
            {
                Console.Write($"{i} ");
                
            }*/
            /*
            Console.WriteLine(Enumerable.Range(1,5).Sum());
            Console.WriteLine(Enumerable.Range(1,6).Average());
            Console.WriteLine(new int[] {3, 7, 9, 1, 10, 2, -3}.Min());
            Console.WriteLine(new int[] {8, 6, 7, 5, 3, 0, 9}.Max());
            Console.WriteLine(Enumerable.Range(10,3721).Count());
            Console.WriteLine(Enumerable.Range(5,100).Last());
            Console.WriteLine(new List<int>() {3, 8, 7, 6, 9, 6, 2}.Skip(4).Sum());
            Console.WriteLine(Enumerable.Range(10,731).Reverse().Last()); */

            // LINQ Queries

            int[] values = new int[] {0, 12, 44, 36, 92, 54, 13, 8};
            IEnumerable<int> result = from v in values where v < 37 orderby -v select v;
            // 
            foreach(int i in result)
            {
                Console.Write($"{i} ");
            }

        }
    }
}
