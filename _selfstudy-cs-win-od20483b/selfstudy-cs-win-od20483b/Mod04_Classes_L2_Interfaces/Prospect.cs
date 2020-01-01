using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod04_Classes_L2_Interfaces
{
    class Prospect
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PostalCode { get; set; }
        
        private static int nextId = -1;
        public Prospect()
        {
            Id = nextId--;
        }

        public Prospect(string name, string email, string postalCode)
            : this()
        {
            Name = name;
            Email = email;
            PostalCode = postalCode;
        }

        public override string ToString()
        {
            return string.Format($"{Id}\n{Name}\n{Email}\n{PostalCode}");
        }
    }
}
