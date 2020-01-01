using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod07_AccessingDB_L1_EDMs
{
    public partial class Customer
    {
        public CustomerStatusEnum Status
        {
            get
            {
                return (CustomerStatusEnum)dbStatus;
            }
            set
            {
                dbStatus = (int)value;
            }
        }

        public override string ToString()
        {
            return $"{Id}\n{Name}\n{Status}\n{Email}";
        }
    }
}
