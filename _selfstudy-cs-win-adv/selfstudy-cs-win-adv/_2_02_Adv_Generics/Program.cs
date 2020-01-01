using System; 

namespace _2_02_Adv_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var result1 = new Result<int, string> { Success = true, Data = 5, Data2 = "Five" };
            Console.WriteLine($"{result1.Success}, {result1.Data}, {result1.Data2}\n");

            var result2 = new Result<string, bool> { Success = false, Data = "Hello", Data2 = true };
            Console.WriteLine($"{result2.Success}, {result2.Data}, {result2.Data2}\n");

            var helper = new ResultPrinter();
            helper.Print(result1);
            helper.Print(result2);
        }
    }
}
