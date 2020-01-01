using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Test4
{
    class Person
    {
        public string Name { get; set; }
        public Clock MyClock { get; set; }

        public Person(string name, Clock myClock)
        {
            Name = name;
            MyClock = myClock;

            MyClock.Alarm += (object sender, AlarmHandlerEventArgs e) => 
            {
                switch (e.SomeActivity)
                {
                    case "WakeUp":
                        Console.WriteLine("WakeUp!");
                        break;
                    case "GoToGym":
                        Console.WriteLine("GoToGym!");
                        break;
                }
            };
        }
    }
}
