// See https://aka.ms/new-console-template for more information

using Oefening1;
using System;
using static Oefening1.Dier;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dier dier = new Dier();

            Koe koe1 = new Koe();
            Slang slang1 = new Slang();
            Varken varken = new Varken();

            dier = koe1;
            dier.Zegt();

            dier = slang1;
            dier.Zegt();

            dier = varken;
            dier.Zegt();
            
            Console.WriteLine();
        }

    }
}
