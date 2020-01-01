using _37_AnotherAssembly;

namespace _37_AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var classA = new ClassA();
            classA.AnyWhere = 2;
            classA.SameAssembly = 4;
            classA.Derived_Or_SameAssembly = 5;

            var classC = new ClassC();
            classC.AnyWhere = 7;
        }
    }

    class ClassA
    {
        private int Local { get; set; }

        public int AnyWhere { get; set; }

        protected int Derived { get; set; }

        internal int SameAssembly { get; set; }

        // Adds flexibility to protected, that is
        // can be used by a derived class, as well as in the same assembly
        protected internal int Derived_Or_SameAssembly { get; set;}
    }

    class ClassB : ClassA
    {
        public ClassB()
        {
            AnyWhere = 2;
            Derived = 3;
            SameAssembly = 4;
            Derived_Or_SameAssembly = 5;
        }
    }

    class ClassD : ClassC
    {
        public ClassD()
        {
            AnyWhere = 7;
            Derived = 8;
            Derived_Or_SameAssembly = 10;
        }
    }
}
