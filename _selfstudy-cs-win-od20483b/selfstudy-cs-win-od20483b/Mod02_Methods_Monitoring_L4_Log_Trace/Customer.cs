namespace Mod02_Methods_Monitoring_L4_Log_Trace
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public CustomerStatusEnum Status { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{ID},{Name},{Status},{Email}";
        }
    }

    public enum CustomerStatusEnum
    {
        Silver,
        Gold,
        Platinum
    }
}