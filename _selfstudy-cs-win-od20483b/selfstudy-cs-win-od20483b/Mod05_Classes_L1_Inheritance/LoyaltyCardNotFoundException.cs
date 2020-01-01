using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod05_Classes_L1_Inheritance
{
    class LoyaltyCardNotFoundException : Exception
    {
        public LoyaltyCardNotFoundException()
        {
            // This implicity calls the base class ctor
        }

        public LoyaltyCardNotFoundException(string message)
            : base(message)
        {

        }

        public LoyaltyCardNotFoundException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}
