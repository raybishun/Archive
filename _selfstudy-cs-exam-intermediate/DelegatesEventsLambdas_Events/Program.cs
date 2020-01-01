using System;

namespace DelegatesEventsLambdas_Events
{
    public delegate void MyEventHandler(string value);

    class Program
    {
        static void Main(string[] args)
        {
            // used a named function as a event handler
            EventPublisher obj = new EventPublisher();
            // obj.ValueChanged += Obj_ValueChanged;

            // Or use an anonymous delegate as an event handler
            obj.ValueChanged += delegate (string value)
            {
                Console.WriteLine($"The value changed to: {value}");
            };


            string str;

            do {
                Console.WriteLine("Enter a value: ");
                str = Console.ReadLine();
                if (!str.Equals("exit"))
                {
                    obj.TheValue = str;
                }
            } while (!str.Equals("exit"));
            Console.WriteLine("Goodbye!");


            Console.ReadLine();
        }

        //static void Obj_ValueChanged(string value)
        //{
        //    Console.WriteLine($"The value changed to: {value}");
        //}
    }
}
