using System;
using System.Collections.Generic;

namespace Basics.ResultsModel
{
    class Results
    {
        public static void Display()
        {
            // Display Top Two
            Console.WriteLine("--- Top Two! ---");
            foreach (var ranking in Rankings(true))
            {
                DisplayName(ranking);
            }

            // Display All
            Console.WriteLine("--- All ---");
            foreach (var ranking in Rankings(false))
            {
                DisplayName(ranking);
            }
        }

        private static void DisplayName(string ranking)
        {
            Console.WriteLine(ranking);
        }

        private static IEnumerable<string> Rankings(bool top2Only)
        {
            // Top Two
            yield return "John";
            yield return "Nancy";

            if (top2Only)
            {
                yield break; // Exit
            }
            else
            {
                // Include/return the remainding folks...
                yield return "Chris";
                yield return "Parker";
                yield return "Stark";
            }
        }
    }
}
