using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var tower = new ClockTower();
            var john = new Person("John", tower);
            
            // force a chime event to occur
            tower.ChimeFivePM();
            // tower.ChimeSixAM();



            Console.ReadLine();
        }
    }
}
