using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod04_Classes_L2_Interfaces
{
    class Utilities
    {
        public static ArrayList GetCustomers()
        {
            // Note, ArrayList are not type safe
            ArrayList customers = new ArrayList();

            // Customers
            customers.Add(new Customer("bob", "bob@test.com", "123"));
            customers.Add(new Customer("sue", "@test.com", "456"));
            customers.Add(new Customer("ashley", "ashley@test.com", "789"));
            customers.Add(new Customer("ben", "ben@test.com", "ABC"));
            customers.Add(new Customer("linda", "linda@test.com", "DEF"));

            // Prospects
            customers.Add(new Prospect("susan", "p1", "bob@Prospect.com"));
            customers.Add(new Prospect("evan", "p2", "evan@Prospect.com"));
            customers.Add(new Prospect("donna", "p3", "ashley@Prospect.com"));

            return customers;
        }
    }
}
