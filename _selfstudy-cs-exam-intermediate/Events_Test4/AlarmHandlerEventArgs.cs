using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Test4
{
    public class AlarmHandlerEventArgs : EventArgs
    {
        public string SomeActivity { get; set; }
    }
}
