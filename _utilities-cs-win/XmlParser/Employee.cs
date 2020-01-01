namespace XmlParser
{
    class Employee
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public bool IsMale { get; private set; }

        public Employee(string name, int age, bool isMale)
        {
            Name = name;
            Age = age;
            IsMale = isMale;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
