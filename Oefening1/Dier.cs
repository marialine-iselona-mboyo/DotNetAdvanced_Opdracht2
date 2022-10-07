using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    public class Dier
    { 
        private int gewicht { get; set; }

        public Dier(int gewicht)
        {
            //this.isAlive = isAlive;
            this.gewicht = gewicht;

            Console.WriteLine();
        }



        public virtual void Zegt()
        {
            Console.WriteLine();
        }



        public string ToString()
        {
            return "Gewicht: " + gewicht;
        }
    }

    public class Koe : Dier
    {
        public Koe(int gewicht) : base(gewicht)
        {
        }

        public override void Zegt()
        {
            Console.WriteLine("boe");
        }
    }

    public class Slang : Dier
    {
        public Slang(int gewicht) : base(gewicht)
        {
        }

        public override void Zegt()
        {
            Console.WriteLine("ssj");
        }
    }

    public class Varken : Dier
    {
        public Varken(int gewicht) : base(gewicht)
        {
        }

        public override void Zegt()
        {
            Console.WriteLine("groink groink");
        }
    }
}
