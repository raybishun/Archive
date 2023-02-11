using System;
using System.IO;
using System.Collections.Generic;
using Basics.ButtonModel;
using Basics.ComputerModel;
using Basics.PlayerModel;
using Basics.FootRacesModel;
using Basics.TennisModel;
using Basics.VehicleModel;
using Basics.WindowModel;
using Basics.AnimalModel;
using Basics.Animal2Model;
using Basics.TennisMatchesModel;
using Basics.ResultsModel;
using Basics.RaceModel;
using Basics.InstrumentModel;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // DoInheritanceInstrument();
            // DoSpeedRacer();
            // DoIEnumerable();
            // DoThrowException();
            // DoTennisMatches();
            // DoGuid();
            // DoInterface();
            // DoUnBoxing();
            // DoBoxing();
            // DoTypeCasting();
            // DoDownCasting();
            // DoUpCasting();
            // DoSDLC_And_Testing();
            // DoQuickSort();
            // DoBubbleSort();
            // DoLinkedLists();
            // DoQueues();
            // DoStacks();
            // DoMultiDimensionalArrays();
            // Console.WriteLine(DoStackOverflow(5));
            // Console.WriteLine(DoRecursion2(5));
            // DoFactorial(0);
            // DoEvent();
            // DoOOP();
            // DoExceptionHandling();
            // DoDateTimeOffset();
            // Do_Is_vs_As();
            // DoBooleanLogicalOperators();
            // DoPlayer();
            // DoThrow();
            DoRecursion(2); // 211
            // DoTennisMatch();
            // DoBreakGlass();
            // DoFootRaces();
            // DoGetStdErr();
            // DoTruck();
            // DoDoWhile();
            // DoModulo();
            // DoForLoop();
            // DoInfiniteLoop();
            // Do_Postfix_vs_Prefix_Increment();
            // DecisionTables();
            // DoSwitch(25 % 3);
        }

        private static void DoInheritanceInstrument()
        {
            Futures es = new();
            es.Close = 3500.25;
            es.Volume = 1000000000;
        }

        private static void DoSpeedRacer()
        {
            RaceModel.Results motoGP = new();
            string yamahaR1 = motoGP.CurrentOlympicRecord.Race = "Yamaha YZF-R1";
            double yamahaR1Time = motoGP.CurrentOlympicRecord.Time = 1.618;
            motoGP.AddRace(yamahaR1, yamahaR1Time);
            Console.WriteLine($"{motoGP.CurrentOlympicRecord.Race} time was {motoGP.CurrentOlympicRecord.Time}.");

            RaceModel.Results indy500 = new();
            string bmwM5 = indy500.CurrentOlympicRecord.Race = "Indianapolis 500";
            double bmwM5Time = indy500.CurrentOlympicRecord.Time = .618;
            indy500.AddRace(bmwM5, bmwM5Time);
            Console.WriteLine($"{indy500.CurrentOlympicRecord.Race} time was {indy500.CurrentOlympicRecord.Time}.");
        }

        private static void DoIEnumerable()
        {
            Basics.ResultsModel.Results.Display();
        }

        private static void DoThrowException()
        {
            throw new NotImplementedException();
        }

        private static void DoTennisMatches()
        {
            TennisMatchesModel.Match match = new TennisMatchesModel.Match
            {
                Location = "NA",
                MatchDate = new DateTime(2022, 6, 18)
            };
            
            Console.WriteLine(match.Location);
        }

        private static void DoGuid()
        {
            Console.WriteLine(Guid.NewGuid());
        }

        private static void DoInterface()
        {
            IAnimal animal = new Animal2Model.Dog();
            Console.WriteLine(animal.Speak()); // Woof, woof...
            Console.WriteLine(InversionOfControl(animal));

            animal = new Animal2Model.Cat();
            Console.WriteLine(animal.Speak()); // Meow...
            Console.WriteLine(InversionOfControl(animal));

            animal = new Parrot();
            Console.WriteLine(animal.Speak()); // Squark!
            Console.WriteLine(InversionOfControl(animal));
        }

        private static string InversionOfControl(IAnimal animal)
        {
            return $"I don't need to know what animal, any can use me {animal.Speak()}";
        }
        
        private static void DoUnBoxing()
        {
            object o = 1;
            int num1 = (int)o;
        }

        private static void DoBoxing()
        {
            int num1 = 1;
            object o = num1;
        }

        private static void DoTypeCasting()
        {
            int num1 = 1;
            int num2 = 2;
            short sum = (short)(num1 + num2); 
            Console.WriteLine(sum);
            Console.WriteLine(sum.GetType()); // System.Int16
        }

        private static void DoDownCasting()
        {
            Animal animal = new AnimalModel.Dog();

            AnimalModel.Dog dog = (AnimalModel.Dog)animal;
            dog.MakeNoise(); // Woof, woof...
            dog.Growl(); // Grrrr...
        }

        private static void DoUpCasting()
        {
            Animal animal = new AnimalModel.Dog();
            
            // However, only Animal members are available
            animal.MakeNoise(); // Woof, woof...
        }

        private static void DoSDLC_And_Testing()
        {
            // SDLC
            // 1. Requirements
            // 2. Design
            // 3. Implementation / Development
            // 4. Verification / Testing
            // 5. Maintenance / Release / Deploying

            // Testing
            // - White Box Testing - Known knowledge of internal components...
            // - Black Box Testing - Unknown knowledge of internal components...
        }

        private static void DoQuickSort()
        {
            string[] s = new string[10];   
        }

        private static void DoBubbleSort()
        {
            
        }

        private static void DoLinkedLists()
        {
            LinkedList<string> linkedList = new();

            linkedList.AddFirst("a");
            linkedList.AddLast("b");
            linkedList.AddLast("c");
            linkedList.AddLast("d");

            linkedList.RemoveLast(); // Removes node at the end

            linkedList.AddBefore(linkedList.Find("c"), "bb");

            linkedList.AddAfter(linkedList.Find("c"), "cc");

            linkedList.Remove(linkedList.Find("bb"));
            
            Console.WriteLine(linkedList.Contains("bb")); // False

            foreach (var item in linkedList)
            {
                Console.WriteLine(item); // a, b, c, cc
            }

            linkedList.Clear();

            Console.WriteLine(linkedList.Count); // 0
        }

        private static void DoQueues()
        {
            Queue<string> fifo_queue = new();
            fifo_queue.Enqueue("a");
            fifo_queue.Enqueue("b");
            fifo_queue.Enqueue("c");
            fifo_queue.Enqueue("d");

            fifo_queue.Dequeue(); // remove object from the beginning for the queue, the 'a'

            foreach (var item in fifo_queue)
            {
                Console.WriteLine(item); // b, c, d
            }

            Console.WriteLine(fifo_queue.Peek()); // return object at the beginning of the queue, the 'b' 

            Console.WriteLine(fifo_queue.Contains("a")); // False

            fifo_queue.Clear();

            Console.WriteLine(fifo_queue.Count); // 0
        }

        private static void DoStacks()
        {
            Stack<string> lifo_stack = new();
            lifo_stack.Push("a");
            lifo_stack.Push("b");
            lifo_stack.Push("c");
            lifo_stack.Push("d");

            lifo_stack.Pop(); // remove object from top of stack, the 'd'

            foreach (var item in lifo_stack)
            {
                Console.WriteLine(item); // c, b, a
            }

            Console.WriteLine(lifo_stack.Peek()); // return object at top of stack, the 'c'

            Console.WriteLine(lifo_stack.Contains("a")); // True

            lifo_stack.Clear();

            Console.WriteLine(lifo_stack.Count); // 0

            Console.WriteLine("---");
            Stack<int> stack = new();
            stack.Push(2);
            stack.Push(4);
            stack.Push(6);
            stack.Push(8);
            stack.Pop();
            stack.Push(3);
            stack.Pop();
            stack.Push(4);
            stack.Push(6);
            stack.Push(7);
            stack.Pop();
            stack.Pop();
            stack.Pop();
            Console.WriteLine(stack.Peek());
        }

        private static void DoMultiDimensionalArrays()
        {
            int[,] mda = {  { 1, 3, 5, 7 }, 
                            { 2, 4, 6, 8 } };

            for (int r = 0; r < 2; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write($"{mda[r, c]} ");
                }
                
                Console.WriteLine();
            }
        }

        private static string DoStackOverflow(int num)
        {
            try
            {
                return DoStackOverflow(num--);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally 
            {
                Console.WriteLine("Finally...");
            }
        }

        private static int DoRecursion2(int getFactorialOf)
        {
            if (getFactorialOf == 0)
            {
                // The factorial of 0 is always 1.
                return 1;
            }

            return getFactorialOf * DoRecursion2(getFactorialOf - 1);
        }

        private static void DoFactorial(int getFactorialOf)
        {
            // 5 factorial, expressed as 5!
            // Computed as: 5 * 4 * 3 * 2 * 1 = 120
            // NOTE: The factorial of 0 is always 1.

            int factorial = 1;

            for (int i = 1; i <= getFactorialOf; i++)
            {
                factorial *= i;

                // Compare output diagonally
                Console.WriteLine($"{i} {factorial *= 1}");   
            }
        }

        private static void DoEvent()
        {
            Console.WriteLine("Press A to simulate a button click...");
            var key = Console.ReadLine();
            if (key == "a")
            {
                KeyPressed();
            }
        }

        private static void KeyPressed() {
            Button button = new Button();
            button.ClickEvent += (sender, eventArgs) => {
                Console.WriteLine($"{eventArgs.Name} clicked a letter!");
            };
            button.OnClick();
        }

        private static void DoOOP()
        {
            Computer hp = new Desktop
            {
                Version = 233,
                SerialNumber = 618,
                Storage = "SSD"
            };
            Console.WriteLine(hp.Version);
            Console.WriteLine(hp.SerialNumber);
            Console.WriteLine(hp.Storage);
            Console.WriteLine();

            Computer ibm = new Desktop("MVMe")
            {
                Version = 133,
                SerialNumber = 398
            };
            Console.WriteLine(ibm.Version);
            Console.WriteLine(ibm.SerialNumber);
            Console.WriteLine(ibm.Storage);
            Console.WriteLine();

            Console.WriteLine(hp is Desktop); // true
            Console.WriteLine(hp is Computer); // true
        }

        private static void DoExceptionHandling()
        {
            FileStream fs = null;

            try
            {
                fs = File.Open(@"C:\Temp\top_secret.txt", FileMode.Open);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"FileNotFoundException --> {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"All else --> {ex.Message}");
                // throw new Exception("FNF Error!");
            }
            finally
            {
                Console.WriteLine("In finally...");

                if (fs != null)
                {
                    fs.Close();
                }
                else
                {
                    Console.WriteLine(@"NullReferenceException: 'Object reference not set to an instance of an object. 'fs was null.");
                }
            }
        }

        /// <summary>
        /// Same as DateTime, plus time zone awarness, etc.
        /// </summary>
        private static void DoDateTimeOffset()
        {
            DateTimeOffset dto = new DateTimeOffset();  // 1/1/0001 12:00:00 AM +00:00
            Console.WriteLine(dto.AddDays(365));        // 1/1/0002 12:00:00 AM +00:00
        }

        private static void Do_Is_vs_As()
        {
            // 'Is a' vs 'Has a'
            
            object my_object = "Ray";
            
            // Check if types are the same
            Console.WriteLine(my_object is string); // True

            // Convert type to another type
            var my_new_object = my_object as string;
            Console.WriteLine(my_new_object.GetType()); // System.String
        }

        private static void DoBooleanLogicalOperators()
        {
            Console.WriteLine(Convert.ToInt32(false));  // 0
            Console.WriteLine(Convert.ToInt32(true));   // 1

            int a = 3, b = 4, c = 4, d = 5;
            Console.WriteLine(a > b && c < d); // False
            Console.WriteLine(a > b || c < d); // True
        }

        private static void DoPlayer()
        {
            Player player1 = new();
            player1.SetResult(5, null);
            Console.WriteLine(player1.Ranking); // 5

            player1.SetResult(10, "Foo");
            Console.WriteLine(player1.Ranking); // 10

            player1.SetResult(15, "Bar");
            Console.WriteLine(player1.Ranking); // 10

            player1.SetResult(25, "Ray");
            Console.WriteLine(player1.Ranking); // 10
            Console.WriteLine(player1.MatchName("foo")); // True
        }

        private static void DoThrow()
        {
            throw new NotImplementedException();
        }

        private static int DoRecursion(int j)
        {
            for (var i = j; i > 0; i = DoRecursion(i - 1))
            {
                Console.Write(i); // 211

            }
            return j;
        }

        private static void DoTennisMatch()
        {
            var match = new TennisModel.Match();
            Console.WriteLine(match.Location);

            match.Location = "New York";
            match.MatchDate = new DateTime(2022, 5, 29);
            
            Console.WriteLine(match.Location);
        }

        private static void DoBreakGlass()
        {
            Glass glass = new Glass();
            Console.WriteLine(glass.BreakGlass());
        }

        private static void DoFootRaces()
        {
            var race1 = new FootRace();
            var race2 = race1 as IDisplayResult;
            race1.Seconds = 99;

            race1.Display();    // 99 seconds
            race2.Display();    // 1.65 minutes
            race1.DisplayRaw(); // 99

            IDisplayResult race3 = race1 as IDisplayResult;
            race3.Display();     // 1.65 minutes
        }

        private static void DoGetStdErr()
        {
            // Gets the standard output error stream.
            var getStandardOutputError = Console.Error;    
        }

        private static void DoTruck()
        {
            Truck truck = new();
            Console.WriteLine(truck.GetTruckBreak());
        }

        private static void DoDoWhile()
        {
            do
            {

            } while (true);

            while (true)
            {

            }
        }

        private static void DoModulo()
        {
            Console.WriteLine(0 % 2); // 0
            Console.WriteLine(1 % 2); // 1

            int count = 0;
            for (int i = 0; i < 100; i++)
            {
                // Console.Write($"{i} "); // 0 ... 99
                if (i % 2 != 0)
                {
                    Console.Write($"{i} ");
                    count++;
                }
            }
            Console.WriteLine($"\n{count}");
        }

        private static void DoForLoop()
        {
            int iterations = 0;

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"{i}");
                    iterations++;
                }
            }

            Console.WriteLine($"Iterations: {iterations}\n");

            Console.WriteLine("--------------------");
            int ctr = 1;
            for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine($"{ctr++}. Hello, World!");
            }
            Console.WriteLine("--------------------");

            Console.WriteLine();
            ctr = 1;
            for (int i = 0; i <= 10;)
            {
                Console.WriteLine($"{ctr++}. Hello, World!");
                i += 2;
            }

            Console.WriteLine("--- Recursion ---");
            Console.WriteLine(Recursion(2)); // 2112
        }

        private static int Recursion(int j)
        {
            for (var i = j; i > 0; i = Recursion(i - 1))
            {
                Console.Write(i);
            }
            return j;
        }

        private static void DoInfiniteLoop()
        {
            for ( ; ; ) {
                Console.Write('.');
            }
        }
        private static void Do_Postfix_vs_Prefix_Increment()
        {
            int a, b;

            // Postfix
            a = 1;
            b = a++;
            Console.WriteLine(b); // 1

            // Prefix
            a = 1;
            b = ++a;
            Console.WriteLine(b); // 2
        }

        private static void DecisionTables()
        {
            int a = 3, b = 4;
            int c = 4, d = 5;
            Console.WriteLine(a > b && c < d); // False
        }

        private static void DoRepetition()
        { 
            
        }

        private static void DoSwitch(int value)
        {
            switch (value)
            {
                case 1:
                    //Console.WriteLine(1);
                    //break;
                case 2:
                    Console.WriteLine(2);
                    break;
                default:
                    Console.WriteLine(0);
                    break;
            }
        }

        private static void DoBasics()
        {
            float myFloat = 2.5f;
            double myDouble = 2.5d;
            decimal myDecimal = 2.5m;

            // Console.WriteLine(myFloat.GetType()); // single

            bool isOkay = true;

            DateTime myDateTime = new DateTime(2030, 1, 1, 13, 15, 00);
            // Console.WriteLine(myDateTime);

            char myChar = '\u0024'; // $
            // Console.WriteLine(myChar);

            // int pemdas = (4 - 2) * 2 / 2 + 3 - 1; // 4
            // int pemdas = (4 - 2) * 2 / 2 + 3 - 1; // 4
            // Console.WriteLine(pemdas);

            Console.WriteLine((5 % 3));

            if (true)
            {

            }
        }
    }
}