using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod05_Classes_L1_Inheritance
{
    class Customer : Person
    {
        public CustomerStatusEnum Status { get; set; }

        public override string Details()
        {
            return $"Customer: {Id}\n{Name}\n{Status}\n{Email}";
        }
    }
}
