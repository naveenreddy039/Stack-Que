﻿using System;
using System.Collections.Generic;

namespace Stack1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("70");
            stack.Push("30");
            stack.Push("56");

            foreach (string item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------");
            stack.Pop();
        }
    }
}
