using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod05_Classes_L1_Inheritance
{
    class Person : IComparable<Person>
    {
        protected static int nextId = 1;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }

        public Person()
        {
            Id = nextId++;
            Notes = "this is a sample note";
        }

        public virtual string Details()
        {
            return $"{Id}\n{Name}\n{Email}\n{Notes.TileCase()}";
        }

        public override string ToString()
        {
            return $"{Id}\n{Name}\n{Email}";
        }

        // IComparable will facilitate sort persons.Sort() method in the Utilities class
        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
