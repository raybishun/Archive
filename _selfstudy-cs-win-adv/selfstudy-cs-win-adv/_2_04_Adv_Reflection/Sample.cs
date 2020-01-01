using System;

namespace _2_04_Adv_Reflection
{
    class Sample
    {
        public string MyPublicProperty { get; set; }
        public int myPublicInt;

        private int myPrivateInt;

        public void MyMethod()
        {
            Console.WriteLine("Hello, World!");
        }

        private void MyPrivateMethod() { }
    }
}
