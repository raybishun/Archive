using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Test4
{
    public delegate void AlarmHandler(object sender, AlarmHandlerEventArgs e);

    class Clock
    {
        public event AlarmHandler Alarm;

        // My alarms (events)
        public void WakeUp()
        {
            Alarm(this, new AlarmHandlerEventArgs { SomeActivity = "WakeUp" });
        }

        public void GoToGym()
        {
            Alarm(this, new AlarmHandlerEventArgs { SomeActivity = "GoToGym" });
        }

    }
}
