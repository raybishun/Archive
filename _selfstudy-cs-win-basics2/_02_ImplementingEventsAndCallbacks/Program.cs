using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ImplementingEventsAndCallbacks
{
    class Program
    {
        delegate decimal SomeMathThing(int x, int y);

        static void Main(string[] args)
        {
            OlderUseOfDelegate();
            UsingBuildInDelegateForTypicalMethodSignatures_WithReturnType();
            UsingBuildInDelegateForTypicalMethodSignatures_WithoutReturnType();


            Console.ReadLine();
        }

        static void OlderUseOfDelegate()
        {
            SomeMathThing myMathThing = AddTwoNumbers;
            Console.WriteLine(myMathThing(3333,11));
        }

        static decimal AddTwoNumbers(int x, int y)
        {
            return x + y;
        }

        static void UsingBuildInDelegateForTypicalMethodSignatures_WithoutReturnType()
        {
            Action<int, string> someMethod = VoidMethodWithTwoParameters;
        }

        static void UsingBuildInDelegateForTypicalMethodSignatures_WithReturnType()
        {
            Func<int, int, decimal> myMathThing = AddTwoNumbers;
            Console.WriteLine(myMathThing(3333, 11));
        }

        static void VoidMethodWithTwoParameters(int age, string name)
        {
            Console.WriteLine($"{age}, {name}");
        }


    }
}
