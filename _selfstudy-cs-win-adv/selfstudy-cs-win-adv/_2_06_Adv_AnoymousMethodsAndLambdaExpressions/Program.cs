using System; 

/// <summary>
/// Anonymous Methods = inline methods
/// Lambda Expressions = a shorthand fo anonymous methods
/// Custom Delegates = the delegates you create
/// Built-in Delegates = Action (returns void and accepts no parameters)
/// Built-in Generic Delegates = Action<T> (no return type, up to 16 parameters), 
///     and Func<T> (has a return value, and supports up to 16 parameters)
/// </summary>
namespace _2_06_Adv_AnoymousMethodsAndLambdaExpressions
{
    delegate void CustomDelegate(int num);
    delegate int CustomDelegate2(int num);

    class Program
    {
        static void Main(string[] args)
        {
            // AnonymousMethodsDemo();
            // LambdaExpressionsDemo();
            // ActionDemo();
            FuncDemo();
        }

        static void AnonymousMethodsDemo()
        {
            // Traditional
            CustomDelegate custDel = Double;
            custDel(2);

            // Use of Anonymous Method (inline method)
            CustomDelegate anonymousMethod = delegate (int num) { Console.WriteLine($"{num} * 3 = {num * 3}"); };
            anonymousMethod(10);

            // Use of Anonymous Method (inline method) with return type
            CustomDelegate2 anonymousMethod2 = delegate (int num)
            {
                return num * 2;
            };

            int value = anonymousMethod2(2);

            Console.WriteLine(value);
        }

        static void LambdaExpressionsDemo()
        {
            CustomDelegate lambdaExpression = (int num) => { Console.WriteLine($"{num} * 3 = {num * 3}"); };
            lambdaExpression(3);

            CustomDelegate lambdaExpression2 = num => { Console.WriteLine($"{num} * 3 = {num * 3}"); };
            lambdaExpression2(4);
        }

        static void ActionDemo()
        {
            Action<int> action = num => { Console.WriteLine($"{num} * 3 = {num * 3}"); };
            action(2);
        }

        static void FuncDemo()
        {
            // The 'last' parameter is the out parameter
            Func<int, int> Double = x => { return x * 2; };
            Console.WriteLine(Double(2));
        }

        static void Double(int num)
        {
            Console.WriteLine($"{num} * 2 = {num * 2}");
        }
    }
}
