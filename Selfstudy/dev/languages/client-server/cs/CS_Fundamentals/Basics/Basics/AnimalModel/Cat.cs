using System;

namespace Basics.AnimalModel
{
    class Cat : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Meow, meow...");
        }

        public void Purr()
        {
            Console.WriteLine("Cat purring...");
        }
    }
}
