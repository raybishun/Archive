using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Mod04_Classes_L2_Interfaces
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ZipCode { get; set; }
        
        private static int nextId = 1;
        public Customer()
        {
            Id = nextId++;
        }

        public Customer(string name, string email, string zipcode)
            : this()
        {
            Name = name;
            Email = email;
            ZipCode = zipcode;
        }

        public override string ToString()
        {
            return string.Format($"{Id}, {Name}, {Email}, {ZipCode}");
        }
    }
}
