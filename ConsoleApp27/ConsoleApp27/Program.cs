﻿using System;

namespace ConsoleApp27
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Class1 variant5 = new Class1();

          
            Console.Write("Введите число:");

            Console.Write("");
          variant5.i = int.Parse(Console.ReadLine());

            switch (variant5.i)
            {

                case 12: Console.WriteLine("Зима"); break;
                case 1: Console.WriteLine("Зима"); break;
                case 2: Console.WriteLine("Зима"); break;
                case 3: Console.WriteLine("Весна"); break;
                case 4: Console.WriteLine("Весна"); break;
                case 5: Console.WriteLine("Весна"); break;
                case 6: Console.WriteLine("Лето"); break;
                case 7: Console.WriteLine("Лето"); break;
                case 8: Console.WriteLine("Лето"); break;
                case 9: Console.WriteLine("Осень"); break;
                case 10: Console.WriteLine("Осень"); break;
                case 11: Console.WriteLine("Осень"); break;

            }
        }

    }
}