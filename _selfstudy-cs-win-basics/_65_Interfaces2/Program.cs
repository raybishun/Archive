using System;

namespace _65_Interfaces2
{
    class Program
    {
        // You cannot create an instance of an abstract classs or interfac
        // Said differently, cannot 'new up' an Interface

        static void Main(string[] args)
        {
            Mark m = new Mark();
            m.DoWork();

            // But how can we access the ISecond.DoWork() method?

            // Here we are essentially using the 'class' as a way to access the ISecond.DoWork() method
            ISecond s = new Mark();
            s.DoWork();


            IFirst f = new Mark();
            f.DoWork();

            // A casting option
            Console.WriteLine();
            ((ISecond)m).DoWork();


            Console.ReadLine();
        }
    }

    interface IFirst
    {
        void DoWork();
    }

    interface ISecond
    {
        int DoWork();
    }

    class Mark : IFirst, ISecond
    {
        public void DoWork()
        {
            Console.WriteLine("DoWork() from iFirst...");
        }

        int ISecond.DoWork()
        {
            Console.WriteLine("DoWork() from ISecond...");
            return 1;
        }

        public void Test()
        {

        }
    }
}
