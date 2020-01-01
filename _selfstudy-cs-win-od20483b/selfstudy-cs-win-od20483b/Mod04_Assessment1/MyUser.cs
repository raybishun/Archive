using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod04_Assessment1
{
    class MyUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        private static int nextId = 1;
        public MyUser()
        {
            Id = nextId++;
        }

        public MyUser(string name, string email) : this()
        {
            Name = name;
            Email = email;
        }

        internal static List<MyUser> GetUsers()
        {
            List<MyUser> myUsers = new List<MyUser>();
            myUsers.Add(new MyUser("ray", "ray@acme.com"));
            myUsers.Add(new MyUser("julie", "julie@acme.com"));
            myUsers.Add(new MyUser("jennifer", "jennifer@acme.com"));
            return myUsers;
        }

        public override string ToString()
        {
            return $"{Id}\n{Name}\n{Email}";
        }
    }
}
