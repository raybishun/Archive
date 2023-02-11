using System;

namespace Basics.FootRacesModel
{
    class FootRace : Race, IDisplayResult
    {
        public override void Display()
        {
            Console.WriteLine($"{Seconds} seconds.");
        }

        public void DisplayRaw()
        {
            base.Display();
        }

        void IDisplayResult.Display()
        {
            Console.WriteLine($"{Seconds / 60d} minutes.");
        }
    }
}
