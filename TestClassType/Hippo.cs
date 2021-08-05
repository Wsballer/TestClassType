using System;
using System.Collections.Generic;
using System.Text;

namespace TestClassType
{
    class Hippo : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Grunt.");
        }

        public void Swim()
        {
            Console.WriteLine("Splash! I'm going for a swim!");
        }
    }
}
