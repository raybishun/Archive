using System;  

/// <summary>
/// Delegates allows you to treat methods as a 'first class object', 
/// i.e. pass them into and out of methods
/// </summary>
namespace _2_05_Adv_Delegates
{
    delegate void NoParamDelegate();
    delegate void ParamDelegate(string s);

    delegate void Operation(int number);

    class Program
    {
        static void Main(string[] args)
        {
            // Delegates101();
            Delegates102();
        }

        static void Delegates101()
        {
            // MyDelegate myDelegate = new MyDelegate(SayHello);
            // myDelegate.Invoke();

            NoParamDelegate noParamDelegate = SayHello;
            noParamDelegate();

            SayHello(noParamDelegate);

            ParamDelegate paramDelegate = SayHello;
            paramDelegate("Ray");

            ParamDelegate paramDelegate2 = ReturnADelegate();
            SayHello(paramDelegate2);
        }

        static void Delegates102()
        {
            Operation op = Double;
            //ExecuteOperation(2, op);

            //op = Triple;
            //ExecuteOperation(2, op);

            op += Triple;
            op += Quad;

            ExecuteOperation(2, op);
        }

        static void SayHello()
        {
            Console.WriteLine("Hello, World!");
        }

        static void SayHello(NoParamDelegate del)
        {
            del();
        }

        static void SayHello(ParamDelegate del)
        {
            del("Ray2");
        }

        static void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }

        static ParamDelegate ReturnADelegate()
        {
            return new ParamDelegate(SayHello);
        }

        static void Double(int num)
        {
            Console.WriteLine($"{num} * 2 = {num * 2}");
        }

        static void Triple(int num)
        {
            Console.WriteLine($"{num} * 3 = {num * 3}");
        }

        static void Quad(int num)
        {
            Console.WriteLine($"{num} * 4 = {num * 4}");
        }

        static void ExecuteOperation(int num, Operation operation)
        {
            operation(num);
        }
    }
}
