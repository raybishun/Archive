using System;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Ch04_Using_DotNet_Std_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //ManipulatingText();
            //SplittingStrings();
            //GetPartOfAString();
            //RegExDemo();
            //Lists();
            WorkingWithDictionaries();
                

            Console.ReadLine();
        }

        private static void WorkingWithDictionaries()
        {
            var keywords = new Dictionary<string, string>();
            keywords.Add("int", "32-bit integer data type");
            keywords.Add("long", "64-bit integer data type");
            keywords.Add("float", "Single precision floating poin tnumber");

            Console.WriteLine("Keywords & their definitions");

            foreach (KeyValuePair<string, string> item in keywords)
            {
                Console.WriteLine($"{item.Key}: {item.Value} ");
            }

            Console.WriteLine($"The definition of log is {keywords["long"]}");
        }

        private static void Lists()
        {
            var cities = new List<string>
            {
                "London",
                "Paris",
                "Milan"
            };

            cities.Insert(1, "New York");

            Console.WriteLine($"Last city in the list is: {cities[cities.Count -1]}");

            cities.RemoveAt(3);

            cities.Remove("Paris");

            Console.WriteLine($"{cities.Count}");

            foreach (var city in cities)
            {
                Console.WriteLine($"{city}");
            }
        }

        private static void RegExDemo()
        {
            Console.Write("enter your age: ");
            string input = Console.ReadLine();
            // Regex ageChecker = new Regex(@"\d"); // d = digit, and in this example means, must include a digit
            Regex ageChecker = new Regex(@"^\d+$"); // ^ = start, $ = end, + is one or more
            if (ageChecker.IsMatch(input))
            {
                Console.WriteLine("Thank you!");
            }
            else
            {
                Console.WriteLine($"{input} is not a valid age.");
            }
        }

        private static void GetPartOfAString()
        {
            string fullName = "Peter Parker";
            int indexOfTheSpace = fullName.IndexOf(' ');
            string firstName = fullName.Substring(0, indexOfTheSpace);
            string lastName = fullName.Substring(indexOfTheSpace +1);
            Console.WriteLine($"{lastName}, {firstName}");
        }

        private static void SplittingStrings()
        {
            string cities = "Paris,Berlin,Madrid,New York";
            string[] citiesArray = cities.Split(',');

            foreach (string city in citiesArray)
            {
                Console.WriteLine(city);
            }
        }

        static void ManipulatingText()
        {
            string city = "London";
            Console.WriteLine(city.Length);
            Console.WriteLine($"3rd char is: {city[2]}");
        }
    }
}
