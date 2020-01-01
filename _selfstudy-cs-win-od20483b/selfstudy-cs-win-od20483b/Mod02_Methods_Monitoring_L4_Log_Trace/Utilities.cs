using System.Collections.Generic;
using System.Diagnostics;

namespace Mod02_Methods_Monitoring_L4_Log_Trace
{
    class Utilities
    {
        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer() { Name = "Bob", Status = CustomerStatusEnum.Gold, Email = "Bob@cust.com" },
                new Customer() { Name = "Sue", Status = CustomerStatusEnum.Gold, Email = "Sue@cust.com" },
                new Customer() { Name = "Ashley", Status = CustomerStatusEnum.Gold, Email = "Ashley@cust.com" },
                new Customer() { Name = "Linda", Status = CustomerStatusEnum.Gold, Email = "Linda@cust.com" },
                new Customer() { Name = "Ben", Status = CustomerStatusEnum.Silver, Email = "Ben@cust.com" }
            };

            return customers;
        }

        public Customer NewCustomer(int id, string name, CustomerStatusEnum status = CustomerStatusEnum.Platinum, string email = null)
        {
            Customer customer = new Customer
            {
                ID = id,
                Name = name,
                Status = status,
                Email = (email == null ? $"{name}@cust.com" : email)
                // Email = (email ?? $"{name}@cust.com")
            };

            // Works for Debug (F5) mode only
            Debug.Print($"debug.print --> New Customer{id}");


            Debug.Write("Works only when project is set to compile in \'DEBUG\' mode");


            // - Is extensible
            // - Uses local app.config file 
            // - Can be used to write out to a file
            // For both Debug & Release modes
            Trace.WriteLine($"trace.writeline --> New Customer{id}");

            // - Is extensible
            // - Uses local app.config file 
            // - Can be used to write out to a file
            // For both Debug & Release modes
            Trace.TraceWarning($"trace.tracewarning --> New Customer{id}");

            // Application Profiling
            // - this is built-in/and used within VS
            // Analyze/Performance Profiling/...

            CreateCounter();
            IncrementCounter();


            int intA = 10;
            int retValue = SetValue(ref intA);
            // MessageBox.Show(intA.ToString());

            return customer;
        }

        private int SetValue(ref int intB)
        {
            int intC = 10;
            intB++;
            intC += intB;
            return intC;
        }

        public bool NewValidatedCustomer(int id, string name, out Customer c, CustomerStatusEnum status = CustomerStatusEnum.Platinum, string email = null)
        {
            if (id != -1)
            {
                c = new Customer
                {
                    ID = id,
                    Name = name,
                    Status = status,
                    Email = (email == null ? $"{name}@cust.com" : email)
                    // Email = (email ?? $"{name}@cust.com")
                };

                return true;
            }
            else
            {
                c = null;
                return false;
            }
        }

        public void CreateCounter()
        {
            if (!PerformanceCounterCategory.Exists("A Demo Counter"))
            {
                CounterCreationDataCollection counters = new CounterCreationDataCollection();

                CounterCreationData totalOrders = new CounterCreationData();
                totalOrders.CounterName = "Customers";
                totalOrders.CounterHelp = "Total number of customers created";
                totalOrders.CounterType = PerformanceCounterType.NumberOfItems32;
                counters.Add(totalOrders);

                // You launch VS in Admin Mode
                PerformanceCounterCategory.Create(
                    "A Demo Counter", 
                    "A custom category for demonstration...", 
                    PerformanceCounterCategoryType.SingleInstance, 
                    counters);
            }
        }

        public void IncrementCounter()
        {
            PerformanceCounter counterOrders = new PerformanceCounter("A Demo Counter", "Customers", false);
            counterOrders.Increment();
        }
    }
}
