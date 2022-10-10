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
        public void KoeSound()
        {
            SoundPlayer sound = new(@"C:\Users\User\OneDrive\Documents\School\.NET Advanced\DotNetAdvanced_Opdracht2\Oefening2\cow-sound.wav");
            sound.Play();
        }

        public override string Zegt()
        {
            return "boe";
        }
    }




    internal class Slang : Dier
    {
        public void SlangSound()
        {
            SoundPlayer sound = new(@"C:\Users\User\OneDrive\Documents\School\.NET Advanced\DotNetAdvanced_Opdracht2\Oefening2\snake-sound.wav");
            sound.Play();
        }

        public override string Zegt()
        {
            return "ssj";
        }
    }



    internal class Varken : Dier
    {
        public void VarkenSound()
        {
            SoundPlayer sound = new(@"C:\Users\User\OneDrive\Documents\School\.NET Advanced\DotNetAdvanced_Opdracht2\Oefening2\pig-sound.wav");
            sound.Play();
        }

        public override string Zegt()
        {
            return "groink groink";
        }
    }
}
