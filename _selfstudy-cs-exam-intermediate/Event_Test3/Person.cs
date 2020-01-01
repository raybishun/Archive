using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Test3
{
    class Person
    {
        public string Name { get; set; }
        public PersonalScheduler Scheduler { get; set; }

        public Person(string name, PersonalScheduler personalScheduler)
        {
            Name = name;
            Scheduler = personalScheduler;

            // Subscriber
            personalScheduler.Activity += (object sender, PersonalSchedulerEventArgs e) => 
            {
                switch (e.AnEvent)
                {
                    case "Meeting":
                        Console.WriteLine("What's the conf#?");
                        break;
                    case "Lunch":
                        Console.WriteLine("Order please...");
                        break;
                    default:
                        break;
                }
            };

        }
    }
}
