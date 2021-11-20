using System;
using System.Collections.Generic;

namespace Queue2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("56");
            queue.Enqueue("30");
            queue.Enqueue("70");

            foreach (string item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");
            queue.Dequeue();

            foreach (string item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");
            Console.WriteLine(queue.Peek());
        }
    }
}
