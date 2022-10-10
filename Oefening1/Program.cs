// See https://aka.ms/new-console-template for more information

using Oefening1;
using System;
using static Oefening1.Dier;

namespace MyApp 
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dier dier = new Dier(250);

            Koe koe1 = new Koe(500);
            Slang slang1 = new Slang(50);
            Varken varken1 = new Varken(250);

            dier = koe1;
            dier.Zegt();
            Console.WriteLine(koe1.ToString());

            dier = slang1;
            dier.Zegt();
            Console.WriteLine(slang1.ToString());

            dier = varken1;
            dier.Zegt();
            Console.WriteLine(varken1.ToString());

            //Console.WriteLine();


            Console.WriteLine(dier.ToString());
        }

    }
}
