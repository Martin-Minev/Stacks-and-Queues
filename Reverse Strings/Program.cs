using System;
using System.Linq;
using System.Collections.Generic;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> reversed = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                reversed.Push(input[i]);
            }
            while (reversed.Count > 0)
            {
                Console.Write(reversed.Pop());
            }


            //Queue<string> books = new Queue<string>();

            //books.Enqueue("Pinokio");
            //books.Enqueue("V i M");
            //books.Enqueue("alch");

            //Console.WriteLine(books.Dequeue());
            //Console.WriteLine(books.Dequeue());
            //Console.WriteLine(books.Dequeue());

            //books.Enqueue("F na tier");
            //Console.WriteLine(books.Dequeue());

            // Console.WriteLine(books.Pop());
        }
    }
}
