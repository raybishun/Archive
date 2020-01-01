using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Test4
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            Person ray = new Person("ray", clock);

            // simulate an alarm event
            clock.WakeUp();
            clock.GoToGym();
            
            Console.ReadKey();
        }
    }
}
