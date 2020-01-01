namespace Mod02_Methods_Monitoring_L1_Methods
{
    internal class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{ID},{Name},{Status},{Email}";
        }
    }
}