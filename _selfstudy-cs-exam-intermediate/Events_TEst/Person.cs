using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Test
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
                Console.WriteLine($"{name} heard the alarm.");
                switch (args.Time)
                {
                    case 6:
                        Console.WriteLine("Get Up for work");
                        break;
                    case 17:
                        Console.WriteLine("The work day is done...");
                        break;
                    default:
                        break;
                }
            };
        }
    }
}
