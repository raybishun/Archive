using System;

namespace Ecents_Test2
{
    public class ClockTowerEventArgs : EventArgs
    {
        public int Activity { get; set; }
    }

    public delegate void ChimeEventHandler(object sender, ClockTowerEventArgs args);

    class ClockTower
    {
        public event ChimeEventHandler Chime;

        public void ChimeWakeUp()
        {
            Chime(this, new ClockTowerEventArgs { Activity = 6 });
        }

        public void ChimeLeaveWork()
        {
            Chime(this, new ClockTowerEventArgs { Activity = 17 });
        }
    }
}
