using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _76_Events
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
        public delegate void del(string x);

        public event del MyEvent;

        public void CheckBalance(int x)
        {
            if (x > 250)
            {
                MyEvent("balance exceeds $250.00");
            }
        }
    }

    class EventSubscriber
    {
        public void HandleTheEvent(string a)
        {
            Console.WriteLine(a);
        }
    }
}
