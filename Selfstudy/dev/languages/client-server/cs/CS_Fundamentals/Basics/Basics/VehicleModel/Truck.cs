namespace Basics.VehicleModel
{
    class Truck : Vehicle
    {
        protected string Brake() // NOTE: Could use 'new' keyword if want to hide
        {
            return "Truck is breaking...";
        }

        public string GetTruckBreak()
        {
            return this.Brake();

            // return base.Brake();    // "Vehicle is breaking...";
        }
    }
}
