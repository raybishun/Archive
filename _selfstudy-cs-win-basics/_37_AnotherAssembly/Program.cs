namespace _37_AnotherAssembly
{
    class Program
    {
        static void Main(string[] args)
        {
            var classC = new ClassC();
            classC.AnyWhere = 7;
            classC.SameAssembly = 9;
            classC.Derived_Or_SameAssembly = 10;
        }
    }

    public class ClassC
    {
        private int Local { get; set; }
        public int AnyWhere { get; set; }
        protected int Derived { get; set; }
        internal int SameAssembly { get; set; }

        // Adds flexibility to protected, that is
        // can be used by a derived class, as well as in the same assembly
        protected internal int Derived_Or_SameAssembly { get; set; }
    }
}
