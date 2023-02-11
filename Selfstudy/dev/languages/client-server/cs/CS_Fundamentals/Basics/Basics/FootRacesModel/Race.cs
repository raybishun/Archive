using System;

namespace Basics.FootRacesModel
{
    class Race
    {
        public int Seconds;

        public virtual void Display()
        {
            Console.WriteLine(Seconds);
        }
    }
}
