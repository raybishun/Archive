using System;

namespace Ecents_Test2
{
    class Person
    {
        public string Name { get; set; }
        public ClockTower Tower { get; set; }

        public Person(string name, ClockTower tower)
        {
            Name = name;
            Tower = tower;

            tower.Chime += (object sender, ClockTowerEventArgs args) => 
            {
                switch (args.Activity)
                {
                    case 6:
                        Console.WriteLine("Wake Up!");
                        break;
                    case 17:
                        Console.WriteLine("Done for day!");
                        break;
                    default:
                        break;
                }
            };
        }
    }
}
