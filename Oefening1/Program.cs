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
            var dier = new Dier();

            var koe1 = new Koe(500);
            var slang1 = new Slang(50);
            var varken1 = new Varken(250);

            dier = koe1;
            dier.Zegt();
            Console.WriteLine(koe1.ToString());

            dier = slang1;
            dier.Zegt();
            Console.WriteLine(slang1.ToString());

            dier = varken1;
            dier.Zegt();
            Console.WriteLine(varken1.ToString());
        }

    }
}
