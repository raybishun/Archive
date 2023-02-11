namespace Basics.RaceModel
{
    public class Results
    {
        public Results()
        {
            CurrentOlympicRecord = new RaceSpeedRecord();
        }

        public RaceSpeedRecord CurrentOlympicRecord;

        public void AddRace(string raceName, double time)
        {
            var current = CurrentOlympicRecord;

            while (current.Time > time)
            {
                current = current.Slower;
            }

            var race = new RaceSpeedRecord
            {
                Faster = current.Faster,
                Slower = current.Slower,
                Race = raceName,
                Time = time
            };

            //current.Faster.Slower = race;
            //current.Slower.Faster = race;
        }
    }
}
