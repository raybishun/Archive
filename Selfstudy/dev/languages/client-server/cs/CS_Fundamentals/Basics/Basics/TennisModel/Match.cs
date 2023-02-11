using System;

namespace Basics.TennisModel
{
    class Match
    {
        public Match()
        {
            Location = "Unknown";
        }

        public string Location { get; set; }
        public DateTime? MatchDate { get; set; }
    }
}
