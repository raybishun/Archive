using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demo_ArrayList();
            Demo_List();

            Console.ReadLine();
        }

        private static void Demo_List()
        {
            List<int> list = new List<int>();
            list.Add(3);
            list.Add(6);
            list.Add(9);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void Demo_ArrayList()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(3);
            arrayList.Add("apple");
            arrayList.Add(9);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
