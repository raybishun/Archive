using System;

namespace _2_08_Adv_ExtensionMethods
{
    public static class MyExtensionMethods
    {
        public static void SayHello(this VendorOwnedClass employee)
        {
            Console.WriteLine($"Hello {employee.Name}.");
        }

        public static void SayHello(this VendorOwnedClass employee, VendorOwnedClass employee2)
        {
            Console.WriteLine($"{employee.Name} says hello to {employee2.Name}.");
        }
    }
}
