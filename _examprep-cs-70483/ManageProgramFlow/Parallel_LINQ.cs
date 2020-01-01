using System;
using System.Linq;

namespace ManageProgramFlow
{
    class Parallel_LINQ
    {
        class Person
        {
            public static int Index { get; set; }

            public int Id { get; set; }
            public string Name { get; set; }
            public string City { get; set; }

            public Person()
            {
                Id = Index;
                Index++;
            }
        }

        public static void DoWork()
        {
            Person[] people = new Person[] 
            {
                new Person { Name = "Alan", City = "Hull" },
                new Person { Name = "Beryl", City = "Seattle" },
                new Person { Name = "Charles", City = "London" },
                new Person { Name = "David", City = "Seattle" },
                new Person { Name = "Eddy", City = "Paris" },
                new Person { Name = "Fred", City = "Berlin" },
                new Person { Name = "Cordon", City = "Hull" },
                new Person { Name = "Henry", City = "Seattle" },
                new Person { Name = "Isaac", City = "Seattle" },
                new Person { Name = "James", City = "London" }
            };

            // ================================================================
            // Informing Parallelization
            // ================================================================
            Console.WriteLine("\nAsParallel()");
            var resultAsParallel = from person in people.AsParallel()
                         where person.City == "Seattle"
                         select person;

            foreach (var person in resultAsParallel)
            {
                Console.WriteLine($"{person.Id}. {person.Name}");
            }

            // WithDegreeOfParallelism()
            Console.WriteLine("\nWithDegreeOfParallelism()");
            var resultInformingParallelization = from person in people.AsParallel().
                          WithDegreeOfParallelism(4). // maximum of 4 processors
                          WithExecutionMode(ParallelExecutionMode.ForceParallelism)
                          where person.City == "Seattle"
                          select person;

            foreach (var person in resultInformingParallelization)
            {
                Console.WriteLine($"{person.Id}. {person.Name}");
            }

            // AsOrdered(), still runs parallel, but there's a hit due to 
            // maintaining the order
            Console.WriteLine("\nAsOrdered()");
            var resultAsOrdered = from person in people.AsParallel().
                                  AsOrdered()
                                  where person.City == "Seattle"
                                  select person;

            foreach (var person in resultAsOrdered)
            {
                Console.WriteLine($"{person.Id}. {person.Name}");
            }

            // AsSequentional(), identify & force parts of a query that must be
            // sequentially executed
            Console.WriteLine("\nAsSequential()");
            var resultAsSequential = (from person in people.AsParallel()
                                      where person.City == "Seattle"
                                      orderby (person.Name)
                                      select new
                                      {
                                          Name2 = person.Name
                                      }).AsSequential().Take(4);

            foreach (var person in resultAsSequential)
            {
                Console.WriteLine($"{person.Name2}");
            }

            // ForAll
            Console.WriteLine(("\nForAll()"));
            var resultForAll = from person in people.AsParallel()
                               where person.City == "Seattle"
                               select person;
            resultForAll.ForAll(person => Console.WriteLine(person.Name));


            // Exceptions in LINQ
            Console.WriteLine("\nHandling LINQ Exceptions");
            try
            {   
                var resultException = from person in people.AsParallel()
                                      where person.City == "Seattle"
                                      select person;

                resultException.ForAll(person => Console.WriteLine((person.Name)));
            }
            catch (AggregateException e)
            {
                Console.WriteLine($"{e.InnerExceptions.Count} exceptions.");
            }
           

            Console.WriteLine("Finished processing, Press any key...");
        }

        public static bool CheckCity(string name)
        {
            if (name == "")
            {
                throw new ArgumentException(name);
            }

            return name == "Seattle";
        }
    }
}
