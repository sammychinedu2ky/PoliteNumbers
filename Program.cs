using System;
using System.Collections.Generic;
using System.Linq;
namespace swacblooms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your target value: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ConsecutiveGroups(input));

        }
        static int ConsecutiveGroups(int target)
        {
            int product = 2 * target;
            int count = 0;
            int n = 2;
            List<List<int>> ranges = new List<List<int>> { };

            while (true)
            {
                double numerator = product - n * n + n;
                double denominator = 2 * n;
                double a = numerator / denominator;
                if (a <= 0) break;
                if ((int)a == a)
                {
                    List<int> range = Enumerable.Range((int)a, n).ToList();
                    ranges.Add(range);
                    count++;
                }
                n++;
            }
            ranges.ForEach(i => Console.WriteLine($"{string.Join('+', i)} = {target}"));
            return count;
        }
    }
}
