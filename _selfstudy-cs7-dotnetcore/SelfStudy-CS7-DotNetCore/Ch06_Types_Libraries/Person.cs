using System;
using System.Collections.Generic;

namespace Ch06_Types_Libraries
{
    public class Person
    {
        // fields
        int Id = 0;
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavouriteAnchientWonder;
        public WondersOfTheAncientWorld BucketList;

        public const string Species = "Homo Sapien";

        public readonly string HomePlanet = "Earth";

        public readonly DateTime Instantiated;

        public List<Person> Children = new List<Person>();


        public Person()
        {
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName)
        {
            Name = initialName;
            Instantiated = DateTime.Now;
        }

        // the old C#4 and .net 4.0 system.tuple typ0e
        public Tuple<string, int> GetFruitCS4()
        {
            return Tuple.Create("Apples", 5);
        }

        // the new C#7 syntax and new System.ValueTuple type
        public (string, int) GetFruitCS7()
        {
            return ("Apples", 5);
        }

        public (string Name, int Number) GetNamedFruit()
        {
            return (Name: "Apples", Number: 5);
        }

        public void PassingParameters(int x, ref int y, out int z)
        {
            // out parameters cannot have a default
            // AND must be initialized inside the method
            z = 99;

            // increament each parameter
            x++;
            y++;
            z++;
        }
    }
}
