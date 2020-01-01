using System;
using System.Collections.Generic;
using System.Linq; 

/// <summary>
/// LINQ can be used on any collection that implements the IEnumerable Interface
/// </summary>
namespace _2_09_Adv_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinqDemo();
            //LinqDemoWithGrouping();
            //UsingLinqToQueryACollectionOfObjects();
            UsingLinqToQueryACollectionOfObjectsWithGrouping();
        }

        static void LinqDemo()
        {
            var sample = "I enjoy writing uber-software in C#";

            var result = from c in sample.ToLower()
                         where c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
                         orderby c descending
                         select c;

            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
        }

        static void LinqDemoWithGrouping()
        {
            var sample = "I enjoy writing uber-software in C#";

            var result = from c in sample.ToLower()
                         where c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
                         orderby c
                         group c by c; // GROUP must be the LAST statement

            foreach (var item in result)
            {
                Console.WriteLine($"Key: {item.Key} - Count: {item.Count()} ");
            }
        }

        static void UsingLinqToQueryACollectionOfObjects()
        {
            var people = new List<Person>
            {
                new Person {FirstName = "John", LastName = "Doe", Age = 25},
                new Person {FirstName = "Jane", LastName = "Doe", Age = 26},
                new Person {FirstName = "John", LastName = "Williams", Age = 40},
                new Person {FirstName = "Symantha", LastName = "Williams", Age = 35},
                new Person {FirstName = "Bob", LastName = "Walters", Age = 12}
            };

            var result = from p in people
                         where p.Age < 30 && p.LastName == "Doe"
                         orderby p.LastName
                         select p;

            foreach (var item in result)
            {
                Console.WriteLine($"{item.LastName}, {item.FirstName}");
            }
        }

        static void UsingLinqToQueryACollectionOfObjectsWithGrouping()
        {
            var people = new List<Person>
            {
                new Person {FirstName = "John", LastName = "Doe", Age = 25},
                new Person {FirstName = "Jane", LastName = "Doe", Age = 26},
                new Person {FirstName = "John", LastName = "Williams", Age = 40},
                new Person {FirstName = "Symantha", LastName = "Williams", Age = 35},
                new Person {FirstName = "Bob", LastName = "Walters", Age = 12}
            };

            var result = from p in people
                         orderby p.LastName
                         group p by p.LastName;

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} - {item.Count()}");
                foreach (var p in item)
                {
                    Console.WriteLine($"\t{p.LastName}, {p.FirstName}");
                }

                Console.WriteLine("------------------------------");
            }
        }
    }
}
