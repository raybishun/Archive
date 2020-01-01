using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod04_Classes_L1_RefValueTypes
{
    public static class Utilities
    {
        public static ArrayList GetCustomer()
        {
            // Note, ArrayList are not type safe
            ArrayList customers = new ArrayList();
            customers.Add(new Customer("bob", CustomerStatusEnum.Platinum, "bob@test.com"));
            customers.Add(new Customer("sue", CustomerStatusEnum.Gold, "@test.com"));
            customers.Add(new Customer("ashley", CustomerStatusEnum.Gold, "ashley@test.com"));
            customers.Add(new Customer("ben", CustomerStatusEnum.Gold, "ben@test.com"));
            customers.Add(new Customer("linda", CustomerStatusEnum.Platinum, "linda@test.com"));
            return customers;
        }

        public static Customer GetCustomer(int id)
        {
            return new Customer("bob", CustomerStatusEnum.Platinum, "bob@test.com");
        }
    }
}
