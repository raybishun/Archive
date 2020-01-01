using System;

namespace _2_04_Adv_Reflection
{
    [MyClass]
    class Sample2
    {
        public string MyPublicProperty { get; set; }
        public int myPublicInt;

        private int myPrivateInt;

        [MyMethod]
        public void MyMethod()
        {
            Console.WriteLine("Hello, World!");
        }

        public void MethodNotDecoratedWithAnAttribute() { }

        private void MyPrivateMethod() { }
    }
}
