using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58_Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient p = new Patient();
            p.Examine();

            Adult a = new Adult();
            a.Examine();
                        
            Patient pa = new Adult();
            pa.Examine(); // What method() would be called here (if virtual/override were removed from the below methods) 

            Console.ReadLine();
        }
    }

    class Patient
    {
        public virtual void Examine()
        {
            Console.WriteLine("Patient examined...");
        }
    }

    class Adult : Patient
    {
        public override void Examine()
        {
            Console.WriteLine("Adult examined...");
        }
    }
}
