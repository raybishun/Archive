namespace Mod04_Classes_L1_RefValueTypes
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CustomerStatusEnum Status { get; set; }
        public string Email { get; set; }

        private static int nextId = 1;
        public Customer()
        {
            Id = nextId++;
        }

        public Customer(string name, CustomerStatusEnum status, string email)
            :this() // this ctor will call the base ctor
        {
            Name = name;
            Status = status;
            Email = email;
        }


        public override string ToString()
        {
            return $"{Id},{Name},{Status},{Email}";
        }
    }

    public enum CustomerStatusEnum
    {
        Silver,
        Gold,
        Platinum
    }
}