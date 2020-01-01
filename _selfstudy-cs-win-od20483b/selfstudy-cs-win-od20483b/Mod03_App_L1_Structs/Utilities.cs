using System.Collections;

// Collections
// -------------
// Lists - linear 
// Dictionary - key/value pairs
// Queue - FIFO
// Stack - LIFO

// Note ArrayList are not type safe

namespace Mod03_App_L1_Structs
{
    class Utilities
    {
        public ArrayList GetCustomersUsingArrayList()
        {
            // Note ArrayList are not type safe
            ArrayList customers = new ArrayList();
            customers.Add(new Customer(1, "bob@test.com", "bob", CustomerStatusEnum.Platinum));
            customers.Add(new Customer(2, "sue@test.com", "sue", CustomerStatusEnum.Gold));
            customers.Add(new Customer(3, "ashley@test.com", "ashley", CustomerStatusEnum.Gold));
            customers.Add(new Customer(4, "ben@test.com", "ben", CustomerStatusEnum.Gold));
            customers.Add(new Customer(5, "linda@test.com", "linda", CustomerStatusEnum.Platinum));
            return customers;
        }

        public Hashtable GetCustomersUsingHashTable()
        {
            // Hashtable are a form of a dictionary
            // Hashtable require 2 objects, a key objects, and a value object
            Hashtable customers = new Hashtable();
            customers.Add("Bob", new Customer(1, "bob@test.com", "bob", CustomerStatusEnum.Platinum));
            customers.Add("Sue", new Customer(2, "sue@test.com", "sue", CustomerStatusEnum.Gold));
            customers.Add("Ashley", new Customer(3, "ashley@test.com", "ashley", CustomerStatusEnum.Gold));
            customers.Add("Ben", new Customer(4, "ben@test.com", "ben", CustomerStatusEnum.Gold));
            customers.Add("Linda", new Customer(5, "linda@test.com", "linda", CustomerStatusEnum.Platinum));
            return customers;
        }
    }
}
