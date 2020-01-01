using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Mod04_Classes_L1_RefValueTypes;


namespace Mod04_Classes_L1_RefValueTypesUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Customer cust = Utilities.GetCustomer(id: 5);
            cust.Status = CustomerStatusEnum.Silver;
            string expected = "bob";
            Assert.AreEqual(expected, cust.Name, "Name test failed!");
        }
    }
}
