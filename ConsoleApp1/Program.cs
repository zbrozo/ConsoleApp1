﻿using System;

namespace ConsoleApp1
{
    using System.Threading;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            //Thread t = new Thread(func);
            //t.Start();

			// komentarz7
            Task.Run(func);

            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            //Console.ReadKey();
        }

        static async void Go()
        {
			// komentarz6
            await func();
        }

        static int func()
        {
			// komentarz2
            for (int i = 1; i < 9999; ++i)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }

            return 0;
        }

    }
}
