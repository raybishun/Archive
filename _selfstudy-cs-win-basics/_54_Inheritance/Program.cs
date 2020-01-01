using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient p = new Patient();
            p.Examine("Jamison");

            Child c = new Child();
            c.Examine("Bob");
            c.Inoculate();

            UnderFive u5 = new UnderFive();
            u5.Inoculate();

            Console.ReadLine();
        }
    }

    public class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public long SSN { get; set; }

        public void Examine(string pName)
        {
            Console.WriteLine($"Examination of {pName} completed.");
        }

        public void Billing(long ssn)
        {
            Console.WriteLine("Billing completed...");
        }
    }

    public class Child : Patient
    {
        public void Inoculate()
        {
            Console.WriteLine("Child inoculated...");
        }
    }

    public class UnderFive : Child
    {
        public void UnderFiveMethod()
        {
            Console.WriteLine("Under5Method called...");
        }
    }
}
