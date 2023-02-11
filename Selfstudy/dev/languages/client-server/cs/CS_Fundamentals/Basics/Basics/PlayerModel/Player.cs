namespace Basics.PlayerModel
{
    class Player
    {
        private string _name;
        public const string Key = "player";
        
        public bool MatchName(string searchTerm) {
            return _name.ToLower() == searchTerm;
        }

        public void SetResult(int rank, string name) {
            if (_name != null)
            {
                return;
            }

            Ranking = rank;
            _name = name;
        }

        public int Ranking { get; private set; }
    }
}
