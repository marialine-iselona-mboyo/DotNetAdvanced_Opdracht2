using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    public class Dier
    {
        private object uitspraak;

        public int gewicht { get; set; }
        private string Uitspraak { get; }
        private string Geluid { get; }

        public Dier(int gewicht)
        {
            this.gewicht = gewicht;

            Console.WriteLine();
        }

        public Dier(int gewicht, object uitspraak) : this(gewicht)
        {
            this.uitspraak = uitspraak;
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

        public Koe(int gewicht, object Uitspraak) : base(gewicht, Uitspraak)
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

        public Slang(int gewicht, object Uitspraak) : base(gewicht, Uitspraak)
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

        public Varken(int gewicht, object Uitspraak) : base(gewicht, Uitspraak)
        {
        }

        public override void Zegt()
        {
            Console.WriteLine("groink groink");
        }
    }
}
