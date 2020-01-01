using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selfstudy_cs_exam_intermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            // ImplicitTyping_AnonymousTypes_LINQ();
            // Boxing_UnBoxing();
            // Null_Coalescing_Operator();
            // Conditional_Operator();
            // Modulus_Operator();
            // BasicLINQ();
            // BasicLINQ2();
            // BasicLINQ3();
            // Basic_LINQ_Function();
            // Basic_LINQ_New_Option();
            // Basic_LINQ_With_Alias();
            // Basic_LINQ_When_Executed();
            // Shadow_Copy();
            Closures();


            Console.ReadLine();
        }

        static void ImplicitTyping_AnonymousTypes_LINQ()
        {
            int x;  // Explicit type

            // Implicitly-typed variabled must be initialized
            // And can only be used as a local variable
            var y = 51;

            // Implicit type usage
            var anonymousType = new { Fruit = "Apple" };


            string[] names = { "Ray", "Julie", "Parker" };
            var queryResult = from n in names
                              where n == "Ray"
                              select n;

            foreach (var name in queryResult)
            {
                Console.WriteLine(name);
            }
        }

        static void Boxing_UnBoxing()
        {
            int i = 25;

            // Boxing = converting a value type into a reference type
            // Boxing is an expensive operation
            object o = i;

            // UnBoxing = converting a reference type into a value type
            // UnBoxing requires use of explicit casting
            var j = (int)o;

        }

        static void Null_Coalescing_Operator()
        {
            int? i = null; // the '?' means 'i' is a 'nullable type' (said differently, 'i' can be null)

            int j = (i ?? -1); // 'i' (left side) is returned if not-null (an int in this case), else, if null (the right side is returned)
            Console.WriteLine(j);
        }

        static void Conditional_Operator()
        {
            string status = "NOK";

            string result = (status == "OK") ? "clear" : "error";
            Console.WriteLine(result);
        }

        static void Modulus_Operator()
        {
            var data = Enumerable.Range(1, 10);

            for (int i = 0; i < 11; i++)
            {
                if (i % 2 == 0)
                {
                    // print the even number
                    Console.WriteLine(i);
                }
            }
        }

        static void BasicLINQ()
        {
            // LINQ can be used with any object that implements IEnumerable and IQueryable

            var data = Enumerable.Range(1, 100);

            // LINQ via method syntax
            var option1 = data.Where((i) => i % 2 == 0).Select(i => i.ToString());

            // LINQ via query syntax
            var option2 = from d in data
                          where d % 2 == 0
                          select d.ToString();

            foreach (var item in option2)
            {
                Console.WriteLine(item);
            }

        }

        static void BasicLINQ2()
        {
            var values = new[] { "A", "B", "B", "C", "B", "B", "A", "B" };
            var distinct = values.Distinct();
            foreach (var item in distinct)
            {
                Console.WriteLine(item);
            }

            var first = values.First();
            Console.WriteLine($"\n{first}");

            var firstOrDefault = values.FirstOrDefault();
            Console.WriteLine(firstOrDefault);

            var twoValues = values.Skip(2).Take(2);
            foreach (var item in twoValues)
            {
                Console.WriteLine($"twoValues: {item}");
            }
        }

        static void BasicLINQ3()
        {
            var myArray = new[] { 1, 2, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = from i in myArray where i % 2 == 0 where i > 5 select i;
            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }
        }

        #region Basic_LINQ_Function
        static void Basic_LINQ_Function()
        {
            var myArray = new[] { 1, 2, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = from i in myArray where IsEvenAndGreaterThan5(i) select i;
            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }
        }

        static bool IsEvenAndGreaterThan5(int i)
        {
            return (i % 2 == 0 && i > 5);    
        }
        #endregion

        static void Basic_LINQ_New_Option()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { FirstName = "Peter", LastName = "Parker" });
            people.Add(new Person { FirstName = "Bruce", LastName = "Wayne" });
            people.Add(new Person { FirstName = "Steve", LastName = "Rogers" });

            // If we need to select more than one value - use 'new { }'
            var humans = from p in people
                         where p.FirstName == "Bruce"
                         select new { p.FirstName, p.LastName };

            foreach (var human in humans)
            {
                Console.WriteLine(human.FirstName);
            }
        }

        static void Basic_LINQ_With_Alias()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { FirstName = "Peter", LastName = "Parker" });
            people.Add(new Person { FirstName = "Bruce", LastName = "Wayne" });
            people.Add(new Person { FirstName = "Steve", LastName = "Rogers" });

            // LINQ via query syntax
            var humans = from p in people
                         where p.FirstName == "Peter"
                         select new { First = p.FirstName, Last = p.LastName };

            foreach (var human in humans)
            {
                Console.WriteLine(human.First);
            }
            
            // LINQ via method syntax
            //var humans = people.Select(p => new { p.FirstName, p.LastName }).Where(p => p.FirstName == "Bruce").Select(p => p.FirstName);
            //Console.WriteLine(humans.FirstOrDefault());
        }

        static void Basic_LINQ_When_Executed()
        {
            // Question: When does a LINQ query actually get executed?
            // Answer: Only when the element is 

            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = from i in myArray
                              where i % 2 == 0
                              select i;

            foreach (int i in evenNumbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            myArray[1] = 12;

            foreach (int i in evenNumbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            var evenNumbersCount = (from i in myArray where i % 2 == 0 select i).Count();
            foreach (int i in evenNumbers)
            {
                Console.WriteLine(i);
            }
        }

        static void Shadow_Copy()
        {
            // The Shadow copy problem...

            //Person[] original = new Person[1];
            //original[0] = new Person() { FirstName = "John" };
            //Person[] clone = (Person[])original.Clone();
            //clone[0].FirstName = "Mary";

            //// Both original[0] & clone[0] = "Mary"
            //Console.WriteLine(original[0].FirstName);
            //Console.WriteLine(clone[0].FirstName);

            Person[] original = new Person[1];
            original[0] = new Person() { FirstName = "John" };
            Person[] clone = (Person[])original.Clone();
            clone[0] = new Person() { FirstName = "Bob" };
            Console.WriteLine(original[0].FirstName);
            Console.WriteLine(clone[0].FirstName);
        }

        static void Closures()
        {
            // Figure this out

            //var funcs = new List<Func>();
            //for (int i = 0; i < 3; ++i)
            //{
            //    int tmp = i;
            //    funcs.Add(() => tmp);
            //}

            //foreach (var f in funcs)
            //{
            //    Console.WriteLine(f());
            //}
        }

        static void Compiler_Directives() { }
    }
}
