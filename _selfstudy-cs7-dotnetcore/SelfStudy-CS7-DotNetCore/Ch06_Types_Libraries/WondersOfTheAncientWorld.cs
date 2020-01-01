using System;
using System.Collections.Generic;
using System.Text;

namespace Ch06_Types_Libraries
{
    public enum WondersOfTheAncientWorld_Old
    {
        GreatPyramidOfGiza,
        HangingGardensOfBabylon,
        StatueOfZesusAtOlympia,
        TempleOfArtemisAtEphesus,
        MausoleumAtHalicarnassus,
        CollossusOfRhodes,
        LighthourseOfAlexandria
    }

    [System.Flags]
    public enum WondersOfTheAncientWorld : byte
    {
        None = 0,
        GreatPyramidOfGiza = 1,
        HangingGardensOfBabylon = 1 << 1,
        StatueOfZesusAtOlympia = 1 << 2,
        TempleOfArtemisAtEphesus = 1 << 3,
        MausoleumAtHalicarnassus = 1 << 4,
        CollossusOfRhodes = 1 << 5,
        LighthourseOfAlexandria = 1 << 6
    }
}
