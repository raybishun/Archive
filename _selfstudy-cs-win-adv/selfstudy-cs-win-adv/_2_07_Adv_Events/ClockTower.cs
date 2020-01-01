namespace _2_07_Adv_Events
{
    // public delegate void ChimeEventHandler();
    // public delegate void ChimeEventHandler(object sender, EventArgs args);
    public delegate void ChimeEventHandler(object sender, ClockTowerEventArgs args);

    class ClockTower
    {
        public event ChimeEventHandler Chime;

        public void ChimeFivePM()
        {
            Chime(this, new ClockTowerEventArgs { Time = 17 });
        }

        public void ChimeSixAM()
        {
            Chime(this, new ClockTowerEventArgs { Time = 6 });
        }
    }
}
