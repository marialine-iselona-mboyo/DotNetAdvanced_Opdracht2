using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    internal abstract class Dier
    {
        public abstract string Zegt();
        

    }




    internal class Koe : Dier
    {

        public override string Zegt() 
        {
            return "boe";
            //Console.WriteLine("boe");
        }

        public void koeSoundd()
        {
            SoundPlayer sound = new SoundPlayer(@"C:\Users\User\OneDrive\Documents\School\.NET Advanced\DotNetAdvanced_Opdracht2\Oefening2\cow-sound.wav");
            sound.Play();
        }
    }




    internal class Slang : Dier
    {

        public override string Zegt()
        {
            return "ssj";
            //Console.WriteLine("ssj");
        }

        public void slangSoundd()
        {
            SoundPlayer sound = new SoundPlayer(@"C:\Users\User\OneDrive\Documents\School\.NET Advanced\DotNetAdvanced_Opdracht2\Oefening2\snake-sound.wav");
            sound.Play();
        }
    }



    internal class Varken : Dier
    {

        public override string Zegt()
        {
            return "groink groink";
            //Console.WriteLine("groink groink");
        }

        public void varkenSoundd()
        {
            SoundPlayer sound = new SoundPlayer(@"C:\Users\User\OneDrive\Documents\School\.NET Advanced\DotNetAdvanced_Opdracht2\Oefening2\pig-sound.wav");
            sound.Play();
        }
    }
}
