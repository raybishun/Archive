using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod04_Classes_L2_Interfaces
{
    interface IDisplay
    {
        int Id { get; set; }
        string Details();
    }
}
