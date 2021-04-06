using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> evenQueue = new Queue<int>();

            foreach (var item in arr)
            {
                if (item % 2 == 0)
                {
                    evenQueue.Enqueue(item);
                }
            }

            Console.WriteLine(string.Join(", ", evenQueue));
        }
    }
}
