namespace Basics.ComputerModel
{
    class Desktop : Computer
    {
        public Desktop()
        {

        }

        public Desktop(string storage)
        {
            Storage = storage;
        }

        public override int GetSerialNumber()
        {
            return SerialNumber;
        }

        public override string GetStorage()
        {
            return Storage;
        }
    }
}
