using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Test3
{
    public delegate void PersonalSchedulerHandler(
        object sender, PersonalSchedulerEventArgs e);

    class PersonalScheduler
    {
        public event PersonalSchedulerHandler Activity;

        public void Event1()
        {
            Activity(this, new PersonalSchedulerEventArgs() { AnEvent = "Meeting" });
        }

        public void Event2()
        {
            PersonalSchedulerEventArgs schEventArgs = new PersonalSchedulerEventArgs
            {
                AnEvent = "Lunch"
            };

            Activity(this, schEventArgs);
        }
    }
}
