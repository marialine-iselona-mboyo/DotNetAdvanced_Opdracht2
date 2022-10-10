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

        public static void KoeSoundd()
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

        public static void SlangSoundd()
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

        public static void VarkenSound()
        {
            SoundPlayer sound = new SoundPlayer(@"C:\Users\User\OneDrive\Documents\School\.NET Advanced\DotNetAdvanced_Opdracht2\Oefening2\pig-sound.wav");
            sound.Play();
        }
    }
}
