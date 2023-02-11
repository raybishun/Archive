using System;

namespace Basics.ComputerModel
{
    abstract public class Computer
    {
        public Computer()
        {

        }

        public float Version = 1.618f;

        public string Make { get; set; }
        public string Model { get; set; }
        public int SerialNumber { get; set; }
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }

        protected string GetMake() 
        {
            return Make;
        }

        public abstract int GetSerialNumber();

        public virtual string GetStorage()
        {
            return "Default storage...";
        }
    }
}
