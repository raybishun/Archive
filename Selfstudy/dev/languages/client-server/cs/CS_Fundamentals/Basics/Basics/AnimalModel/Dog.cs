using System;

namespace Basics.AnimalModel
{
    class Dog : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Woof, woof...");
        }

        public void Growl() 
        {
            Console.WriteLine("Grrrr...");
        }
    }
}
