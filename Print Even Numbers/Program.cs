using System;
using System.Collections.Generic;
using System.Linq;

namespace Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int[] nums = input
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> evens = new Queue<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    evens.Enqueue(nums[i]);
                }
            }
            Console.WriteLine(string.Join(", ", evens));
        }
    }
}
