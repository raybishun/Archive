using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            DoStackGeneric_LIFO();
        }

        static void DoStack_LIFO()
        {
            Stack myStack = new();
            myStack.Push(2);
            myStack.Push(4);
            myStack.Push(6);
            myStack.Push(8);

            Console.WriteLine($"Removed: {myStack.Pop()}");
            myStack.Push(3);
            Console.WriteLine($"Removed: {myStack.Pop()}");
            myStack.Push(4);
            myStack.Push(6);
            myStack.Push(7);
            Console.WriteLine($"Removed: {myStack.Pop()}");
            Console.WriteLine($"Removed: {myStack.Pop()}");
            Console.WriteLine($"Removed: {myStack.Pop()}");

            //foreach (var item in myStack)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine($"Top of Stack: {myStack.Peek()}"); // 6
        }

        static void DoStackGeneric_LIFO()
        {
            Stack<int> myStack = new();
            myStack.Push(2);
            myStack.Push(4);
            myStack.Push(6);
            myStack.Push(8);

            Console.WriteLine($"Removed: {myStack.Pop()}");
            myStack.Push(3);
            Console.WriteLine($"Removed: {myStack.Pop()}");
            myStack.Push(4);
            myStack.Push(6);
            myStack.Push(7);
            Console.WriteLine($"Removed: {myStack.Pop()}");
            Console.WriteLine($"Removed: {myStack.Pop()}");
            Console.WriteLine($"Removed: {myStack.Pop()}");

            //foreach (var item in myStack)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine($"Top of Stack: {myStack.Peek()}"); // 6
        }
    }
}