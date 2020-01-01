using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod02_Methods_Monitoring_L1_Methods
{
    class Utilities
    {
        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer() { Name = "Bob", Status = 1, Email = "Bob@cust.com" },
                new Customer() { Name = "Sue", Status = 2, Email = "Sue@cust.com" },
                new Customer() { Name = "Ashley", Status = 3, Email = "Ashley@cust.com" },
                new Customer() { Name = "Linda", Status = 4, Email = "Linda@cust.com" },
                new Customer() { Name = "Ben", Status = 5, Email = "Ben@cust.com" }
            };

            return customers;
        }

        // As an alternative to method overloading, (where appropriate) you could simply use 'Optional Parameters'
        // as shown in method below
        public Customer NewCustomer(int id, string name)
        {
            return NewCustomer(id, name, 2, $"{name}@cust.com");
        }

        public Customer NewCustomer(int id, string name, int status = 2, string email = null)
        {
            Customer c = new Customer
            {
                ID = id,
                Name = name,
                Status = status,
                Email = (email == null ? $"{name}@cust.com" : email) // ternary operator (the ?)
                // Email = (email ?? $"{name}@cust.com")
            };
            return c;
        }
        
        public bool NewValidatedCustomer(out Customer c, int id, string name, int status = 2, string email = null)
        {
            if (id != -1)
            {
                c = new Customer
                {
                    ID = id,
                    Name = name,
                    Status = status,
                    Email = email ?? $"{name}@cust.com" // using coalesce expression
                };
                return true;
            }
            else
            {
                c = null;
                return false;
            }   
        }
        
        public bool NewValidatedCustomer(int id, string name, out Customer c, int status = 2, string email = null)
        {
            if (id != -1)
            {
                c = new Customer
                {
                    ID = id,
                    Name = name,
                    Status = status,
                    Email = (email == null ? $"{name}@cust.com" : email)
                    // Email = (email ?? $"{name}@cust.com")
                };

                return true;
            }
            else
            {
                c = null;
                return false;
            }
        }
    }
}
