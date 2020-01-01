using System;

namespace _2_07_Adv_Events
{
    class Person
    {
        private string _name;
        private ClockTower _tower;

        public Person(string name, ClockTower tower)
        {
            _name = name;
            _tower = tower;

            _tower.Chime += (object sender, ClockTowerEventArgs args) =>
            {
                Console.WriteLine($"{_name} heard the clock chime at {args.Time}.");
                switch (args.Time)
                {
                    case 6:
                        Console.WriteLine($"{_name} is waking up.\n");
                        break;
                    case 17:
                        Console.WriteLine($"{_name} is going home.\n");
                        break;
                }
            };
        }
    }
}
