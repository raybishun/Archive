using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod05_Classes_L1_Inheritance
{
    static class Utilities
    {
        public static List<Person> GetCustomers()
        {
            // Note, ArrayList are not type safe
            List<Person> persons = new List<Person>
            {
                // Customers
                new Customer { Name = "bob", Status = CustomerStatusEnum.Gold, Email = "bob@test.com" },
                new Customer { Name = "sue", Status = CustomerStatusEnum.Gold, Email = "sue@test.com" },
                new Customer { Name = "ashley", Status = CustomerStatusEnum.Gold, Email = "ashley@test.com" },
                new Customer { Name = "ben", Status = CustomerStatusEnum.Gold, Email = "ben@test.com" },
                new Customer { Name = "linda", Status = CustomerStatusEnum.Gold, Email = "linda@test.com" },

                // Prospects
                new Prospect { Name = "susan", PostalCode = "12345", Email = "susan@test.com" },
                new Prospect { Name = "evan", PostalCode = "ABCDEF", Email = "evan@test.com" },
                new Prospect { Name = "donna", PostalCode = "?????", Email = "donna@test.com" }
        };

            // Requires IComparable to be implemented, and it is in the Utilities class
            // If IComparable was not implemented persons.Sort() would not know how to sort
            persons.Sort();

            return persons;
        }



        // *** Extension Methods ***
        // Note: You can oly create extension methods from static classes
        public static string TileCase(this string input)
        {
            string[] words = input.Split(' ');

            for (int lcv = 0; lcv < words.Length; lcv++)
            {
                words[lcv] = 
                    words[lcv].Substring(0, 1).ToUpper() + 
                    words[lcv].Substring(1).ToLower();
            }

            return string.Join(" ", words);
        }
    }
}
