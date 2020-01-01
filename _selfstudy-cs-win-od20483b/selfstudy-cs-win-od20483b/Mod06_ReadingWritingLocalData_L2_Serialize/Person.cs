using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod06_ReadingWritingLocalData_L2_Serialize
{
    [Serializable]
    class Person : IComparable<Person>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }

        static int nextId = 1;
        public Person()
        {
            Id = nextId++;
            Notes = "this is a sample note...";
        }

        public override string ToString()
        {
            return string.Format($"Person: {Id}\n{Name}\n{Email}\n{Notes}");
        }

        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
