using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Properties_Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            try
            {
                p.Age = 19;
                p.Weight = 140;
                Console.WriteLine($"{p.Age}\n{p.Weight}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error: {ex.Message}");
            }


        Console.ReadLine();
        }
    }

    public class Person
    {
        public int age;

        private int weight;

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }




        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0 && value < 65)
                {
                    age = value;
                }
                else
                {
                    throw new Exception("Age cannot be over 64...");
                }
            }
        }
    }
}
