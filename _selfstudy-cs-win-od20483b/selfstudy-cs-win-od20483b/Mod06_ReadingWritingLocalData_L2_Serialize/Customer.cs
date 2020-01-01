using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod06_ReadingWritingLocalData_L2_Serialize
{
    [Serializable]
    class Customer : Person
    {
        public CustomerStatusEnum Status { get; set; }

        public override string ToString()
        {
            return string.Format($"Customer: {Id}\n{Name}\n{Email}\n{Notes}");
        }
    }
}
