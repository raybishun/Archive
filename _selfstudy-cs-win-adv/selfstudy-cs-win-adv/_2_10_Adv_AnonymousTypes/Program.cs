using System;
using System.Collections.Generic;
using System.Linq; 

/// <summary>
/// Use case: Only show members of an object that you care about...
/// How: use the 'new' keyword, i.e. in the LINQ query below
/// Only 'properties' are supported
/// And the properties are read-only (immutable)
/// Also, unable to pass anonymous types as parameters
/// </summary>
namespace _2_10_Adv_AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            AnonymousTypesDemo();
        }

        static void AnonymousTypesDemo()
        {
            var people = new List<Person>
            {
                new Person { FirstName = "John", LastName = "Doe", Age = 20},
                new Person { FirstName = "Jane", LastName = "Doe", Age = 30},
                new Person { FirstName = "Bill", LastName = "Johnson", Age = 15},
                new Person { FirstName = "Sally", LastName = "Johnson", Age = 17},
                new Person { FirstName = "Rupert", LastName = "LastName", Age = 55},
            };

            var result = from p in people
                         where p.LastName == "Doe"
                         select new { FName = p.FirstName, LName = p.LastName };

            foreach (var p in result)
            {
                Console.WriteLine($"{p.LName}, {p.LName}");
            }
        }
    }
}
