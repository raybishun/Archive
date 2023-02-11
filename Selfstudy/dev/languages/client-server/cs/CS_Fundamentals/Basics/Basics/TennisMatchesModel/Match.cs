using System;

namespace Basics.TennisMatchesModel
{
    class Match
    {
        public Match()
        {
            Location = "Unknown";
            Console.WriteLine(Location);
        }

        public string Location { get; set; }
        public DateTime? MatchDate { get; set; }
    }
}
