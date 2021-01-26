using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Queue<string> people = new Queue<string>();
            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Paid")
                {
                    foreach (var item in people)
                    {
                        Console.WriteLine(item);
                    }
                    people.Clear();
                }
                else
                {
                    people.Enqueue(input);
                }
            }
            Console.WriteLine($"{people.Count} people remaining.");
        }
    }
}
