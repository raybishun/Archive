using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            auto[1] = "Mercedes";
            auto[2] = "Dodge";
            auto[4] = "Chevrolet";
            auto[5] = "Honda";

            Console.WriteLine($"car 1: {auto[1]}");
            Console.WriteLine($"car 2: {auto[2]}");
            Console.WriteLine($"car 4: {auto[44]}");

            Console.ReadLine();
        }
    }


    class Auto
    {
        // Seems that you can only have 1 indexer per class
        // based on the use of the 'this' keyword

        string[] car = new string[40];
        public string this[int carNum]
        {
            get
            {
                if (carNum >= 0 && carNum <= car.Length)
                {
                    return car[carNum];
                }

                return "Out of index range...";
            }

            set
            {
                if (carNum >= 0 && carNum <= car.Length)
                {
                    car[carNum] = value;
                }
            }
        }
    }
}
