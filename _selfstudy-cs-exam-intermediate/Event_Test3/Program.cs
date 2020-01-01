using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalScheduler personalScheduler
                = new PersonalScheduler();

            Person ray = new Person("Ray", personalScheduler);


            // simulate occurance of events
            personalScheduler.Event1();
            personalScheduler.Event2();



            Console.ReadLine();
        }
    }
}
