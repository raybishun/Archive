using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopQuiz_MethodChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            DomNumber myNumber = new DomNumber(1);

            myNumber.Add(5).Add(10).Print();
            
            Console.ReadLine();
        }
    }

    class DomNumber
    {
        public int Number { get; set; }

        public DomNumber(int initialNum)
        {
            Number = initialNum;
        }

        public DomNumber Add(int toAdd)
        {
            Number += toAdd;

            return this;
        }

        public void Print()
        {
            Console.WriteLine(Number);
        }
    }
}
