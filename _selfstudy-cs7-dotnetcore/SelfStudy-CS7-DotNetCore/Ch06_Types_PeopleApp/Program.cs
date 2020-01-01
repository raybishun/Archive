using System;
using Ch06_Types_Libraries;
using static System.Console;

namespace Ch06_Types_PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //EnumDemo();
            //StaticDemo();
            //CtorDemo();
            //TubleDemo();
            PassingToMethods();


            ReadLine();
        }

        static void PassingToMethods()
        {
            Person p1 = new Person();

            int a = 10;
            int b = 20;
            int c = 0;

            Console.WriteLine($"BEFORE\t{a}\t{b}\t{c}");

            p1.PassingParameters(a, ref b, out c);

            Console.WriteLine($"\nAFTER\t{a}\t{b}\t{c}");
        }

        static void TubleDemo()
        {
            var p1 = new Person();

            var fruitNamed = p1.GetNamedFruit();
            Console.WriteLine($"{fruitNamed.Name} {fruitNamed.Number}");

            // Deconstructing tuples
            (string fruitName, int fruitNumber) = p1.GetFruitCS7();
            Console.WriteLine($"{fruitName}, {fruitNumber}");
        }

        static void CtorDemo()
        {
            var p3 = new Person();
            var p4 = new Person("John");
        }

        static void StaticDemo()
        {
            BankAccount.InterestRate = 0.012M;

            var bal = new BankAccount();
            bal.AccountName = "Mrs. Jones";
            bal.Balance = 2400;
            WriteLine($"{bal.AccountName} earned {bal.Balance * BankAccount.InterestRate:C} interest");

            var ba2 = new BankAccount();
            ba2.AccountName = "Ms. Gerrier";
            ba2.Balance = 98;
            WriteLine($"{ba2.AccountName} earned {ba2.Balance * BankAccount.InterestRate:C} interest");

        }

        static void EnumDemo()
        {
            var p1 = new Person();
            p1.Name = "Bob Smith";
            p1.DateOfBirth = new DateTime(1965, 12, 22);
            p1.FavouriteAnchientWonder = WondersOfTheAncientWorld.StatueOfZesusAtOlympia;
            WriteLine($"{p1.Name} was born on {p1.DateOfBirth:dddd, d MMMM yyyy}");
            WriteLine($"{p1.Name}'s is  {p1.FavouriteAnchientWonder}");

            p1.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon |
                WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
            // p1.BucketList = (WondersOfTheAncientWorld)18;
            Console.WriteLine($"{p1.Name}'s bucket list is {p1.BucketList}");

            p1.Children.Add(new Person());
            p1.Children.Add(new Person());
            Console.WriteLine($"{p1.Name} has {p1.Children.Count} children");
            Console.WriteLine($"{p1.HomePlanet}");


            Console.WriteLine($"{p1.Name} is a {Person.Species}");


            var p2 = new Person
            {
                Name = "Alice Jones",
                DateOfBirth = new DateTime(1998, 3, 17)
            };
            WriteLine($"{p2.Name} was born on {p2.DateOfBirth:d MMM yy}");
        }
    }
}
