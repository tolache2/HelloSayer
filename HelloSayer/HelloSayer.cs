﻿using System;

namespace HelloSayer
{
    public class HelloSayer
    {
        public static void SayHello(string name, int linesCount)
        {
            Console.WriteLine("HelloSayer version 18");
            for (int i = 1; i <= linesCount; i++)
            {
                Console.WriteLine("Hello {0}! This is line #{1}.", name, i);
            }
        }
    }
}