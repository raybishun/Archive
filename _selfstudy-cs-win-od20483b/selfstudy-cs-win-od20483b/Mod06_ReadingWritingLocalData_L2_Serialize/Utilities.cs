using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod06_ReadingWritingLocalData_L2_Serialize
{
    class Utilities
    {
        internal static List<Person> GetPeople()
        {
            List<Person> people = new List<Person>()
            {
                // Customers
                new Customer {Name = "evan", Email = "evan@acme.com"},
                new Customer {Name = "ben", Email = "ben@acme.com"},
                new Customer {Name = "ashley", Email = "ashley@acme.com"},
                new Customer {Name = "donna", Email = "donna@acme.com"},
                new Customer {Name = "bob", Email = "bob@acme.com"},

                // Prospects
                new Prospect {Name = "susan", Email = "susan@acme.com"},
                new Prospect {Name = "sue", Email = "sue@acme.com"},
                new Prospect {Name = "linda", Email = "linda@acme.com"},
            };

            people.Sort();

            return people;
        }
    }
}
