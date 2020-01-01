using System;

namespace Ecents_Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockTower tower = new ClockTower();
            Person john = new Person("John", tower);

            tower.ChimeWakeUp();
            tower.ChimeLeaveWork();
            



            Console.ReadLine();
        }
    }
}
