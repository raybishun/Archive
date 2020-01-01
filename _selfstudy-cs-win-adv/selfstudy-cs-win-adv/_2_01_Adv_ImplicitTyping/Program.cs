using System;

/// <summary>
/// Let the compiler determine the type
/// Therefore, the variable MUST be initialized
/// Can only be used (locally) within methods
/// Note, var (implicit types) are still strongly-typed
/// </summary>
namespace _2_01_Adv_ImplicitTyping
{
    class Program
    {
        static void Main(string[] args)
        {
            var price = 100.25;

            Console.WriteLine(price.GetType());
        }
    }
}
