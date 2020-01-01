using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod05_Classes_L1_Inheritance
{
    class Prospect : Person
    {
        public string PostalCode { get; set; }

        public override string Details()
        {
            return $"Prospect: {base.Details()}\n{PostalCode}";
        }
    }
}
