using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_Casting_Converting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Placing_Int_Into_Double();
            // ExplicitCasting();
            // ConvertTo();
            Quiz();

            Console.ReadLine();
        }

        static void Placing_Int_Into_Double()
        {
            int intMax = int.MaxValue;

            Console.WriteLine(intMax.ToString("N0"));

            long int64 = intMax;

            Console.WriteLine(int64.ToString("N0"));
        }


        static void ExplicitCasting()
        {
            int i = 100;
            double d = 200.5;

            i = (int)d;
            Console.WriteLine(i);
        }


        static void ConvertTo()
        {
            int x = 7;
            double y = 12.6;

            // Rounds Down
            x = (int)y;
            Console.WriteLine(x);

            //=================================================================
            int xx = 7;
            double yy = 12.6;
            
            // Rounds Up
            xx = Convert.ToInt32(yy);
            Console.WriteLine(xx);

            //=================================================================
            string str = "123";
            int r;
            r = Convert.ToInt32(str);
            Console.WriteLine(r);
        }


        static void Quiz()
        {
            int i = 5;

            switch (i)
            {
                case 3:
                    Console.WriteLine("3");
                    break;
                case 6:
                    Console.WriteLine("6");
                    break;
                default:
                    Console.WriteLine("end");
                    break;
            }
            
            int[] numbers = new int[] { 1, 2, 3 };

            Array array;

            List<int> list = new List<int>();

            foreach (int num in numbers)
            {
                // Console.WriteLine(num);
                if (num == 2)
                {
                    break;
                }
            }
            
            bool x = true;
            bool y = false;
            // Console.WriteLine(x--);
            // Console.WriteLine(--x);

            // Console.WriteLine(++x);

            Console.WriteLine(x & y);
        }

    }
}
