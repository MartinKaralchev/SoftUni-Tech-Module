﻿using System;

namespace _07._Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Before:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("After:");
            Console.WriteLine("a = " + b);
            Console.WriteLine("b = " + a);
        }
    }
}
