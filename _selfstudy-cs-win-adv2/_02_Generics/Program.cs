using System;

namespace _02_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // TheOldWay();
            DoWork();


            Console.ReadLine();
        }

        static void DoWork()
        {
            //var result = new Result<int, string> { Success = true, Data = 5, Data2 = "Completed" };
            //Console.WriteLine($"{result.Success}\t{result.Data}\t{result.Data2}");

            //var result2 = new Result<string, bool> { Success = false, Data = "Normal", Data2 = true };
            //Console.WriteLine($"{result2.Success}\t{result2.Data}\t{result2.Data}");

            //var result3 = new Result<int> { Success = true, Data = 5, Data2 = 4 };
            //var result4 = new Result<string> { Success = true, Data = "OK", Data2 = "YES" };


            var result = new Result<int> { Success = true, Data = 5 };
            var helper = new ResultPrinter();
            helper.Print(result);

            var result2 = new Result<string> { Success = true, Data = "Normal" };
            var helper2 = new ResultPrinter();
            helper2.Print(result2);

        }

        /// <summary>
        /// Generics solve/prevent you from doing this:
        /// </summary>
        static void TheOldWay()
        {
            var result = new ResultInt { Success = true, Data = 5 };
            Console.WriteLine($"{result.Success}\n{result.Data}");

            var result2 = new ResultString { Success = false, Data = "Normal" };
            Console.WriteLine($"{result2.Success}\n{result2.Data}");

        }
    }


    public class Result<T, U>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public U Data2 { get; set; }
    }

    public class Result<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public T Data2 { get; set; }
    }

    /// <summary>
    /// Using generics in a method
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ResultPrinter
    {
        public void Print<T>(Result<T> result)
        {
            Console.WriteLine($"{result.Success}, {result.Data}");
        }
    }


    






    /// <summary>
    /// Generics solve/prevent you from doing this:
    /// </summary>
    public class ResultInt
    {
        public bool Success { get; set; }
        public int Data { get; set; }
    }

    /// <summary>
    /// Generics solve/prevent you from doing this:
    /// </summary>
    public class ResultString
    {
        public bool Success { get; set; }
        public string Data { get; set; }
    }

    /// <summary>
    /// Generics solve/prevent you from doing this:
    /// </summary>
    public class ResultBool
    {
        public bool Success { get; set; }
        public bool Data { get; set; }
    }
}
