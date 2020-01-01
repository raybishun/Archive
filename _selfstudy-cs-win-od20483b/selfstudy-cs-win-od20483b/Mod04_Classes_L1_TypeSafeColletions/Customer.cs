using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod04_Classes_L1_TypeSafeColletions
{
    enum CustomerStatusEnum
    {
        Gold,
        Silver,
        Platinum
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CustomerStatusEnum Status { get; set; }
        public string Email { get; set; }

        public Customer()
        {

        }

        public Customer(int id, string name, CustomerStatusEnum status = CustomerStatusEnum.Silver, string email = null)
        {
            Id = id;
            Name = name;
            Status = status;
            Email = (email == null ? $"{name}@cust.com" : email);
        }

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
            Status = CustomerStatusEnum.Gold;
            Email = $"{name}@cust.com";
        }

        public string Details()
        {
            return string.Format($"{Id}\n{Name}\n{Status}\n{Email}");
        }
    }
}
