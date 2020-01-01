namespace _2_03_Adv_Attributes
{
    [Sample(AppName = "The App", Version = 1)]
    class TestClass
    {
        [Sample]
        public int TestProperty { get; set; }

        public void TestMethod() { }
    }
}
