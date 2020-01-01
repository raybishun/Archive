namespace _2_08_Adv_ExtensionMethods 
{
    class Program
    {
        static void Main(string[] args)
        {
            VendorOwnedClass ray = new VendorOwnedClass
            {
                Name = "Ray",
                Age = 25
            };

            VendorOwnedClass julie = new VendorOwnedClass
            {
                Name = "Julie",
                Age = 35
            };

            ray.SayHello();
            ray.SayHello(julie);
        }
    }
}
