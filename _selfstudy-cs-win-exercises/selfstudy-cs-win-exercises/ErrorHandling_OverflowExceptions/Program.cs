using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling_OverflowExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = int.MaxValue + int.Parse("1");

            // Stop on an OverflowException
            checked
            {
                int value2 = int.MaxValue + int.Parse("1");
            }
        }
    }
}
