using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    public class Dier
    {
        public virtual void Zegt()
        {
            Console.WriteLine("hello");
        }
    }

    public class Koe : Dier
    {
        public override void Zegt()
        {
            Console.WriteLine("boe");
        }
    }

    public class Slang : Dier
    {
        public override void Zegt()
        {
            Console.WriteLine("ssj");
        }
    }

    public class Varken : Dier
    {
        public override void Zegt()
        {
            Console.WriteLine("groink");
        }
    }
}
