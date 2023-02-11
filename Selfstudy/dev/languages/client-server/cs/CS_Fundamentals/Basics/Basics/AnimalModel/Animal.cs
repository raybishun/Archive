using System;

namespace Basics.AnimalModel
{
    class Animal
    {
        public string Name { get; set; }

        public virtual void MakeNoise() 
        {
            Console.WriteLine("I'm just an Amimal...");
        }
    }
}
