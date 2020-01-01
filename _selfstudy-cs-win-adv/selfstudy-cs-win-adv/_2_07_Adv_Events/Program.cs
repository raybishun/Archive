/// <summary>
/// Event based programming
/// </summary>
namespace _2_07_Adv_Events 
{
    class Program
    {
        static void Main(string[] args)
        {
            var tower = new ClockTower();
            var ray = new Person("Ray", tower);

            tower.ChimeFivePM();
            tower.ChimeSixAM();
        }
    }
}
