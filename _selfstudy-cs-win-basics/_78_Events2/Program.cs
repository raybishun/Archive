using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _78_Events2
{
    class Program
    {
        static void Main(string[] args)
        {
            EventPublisher ep = new EventPublisher();
            EventSubscriber es = new EventSubscriber();
            ep.MyEvent += es.HandleTheEvent;
            ep.CheckBalance(251);


            Console.ReadLine();
        }
    }

    class EventPublisher
    {
        //public delegate void del(string x);

        //public event del MyEvent;

        public EventHandler<EventArgsClass> MyEvent;

        public void CheckBalance(int x)
        {
            if (x > 250)
            {
                // MyEvent(this, EventArgs.Empty);

                EventArgsClass eac = new EventArgsClass("Balance exceeds $250.00");
                MyEvent(this, eac);
            }
        }
    }

    class EventSubscriber
    {
        public void HandleTheEvent(object sender, EventArgsClass e)
        {
            Console.WriteLine($"{sender} {e.Message}");
        }
    }

    public class EventArgsClass : EventArgs
    {
        public EventArgsClass(string str)
        {
            message = str;
        }

        private string message;
        public string Message
        {
            get
            {
                return message;
            }

        }
    }
}
