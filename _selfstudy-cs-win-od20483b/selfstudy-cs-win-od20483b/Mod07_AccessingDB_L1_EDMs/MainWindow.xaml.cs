using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mod07_AccessingDB_L1_EDMs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CustomerManagementEntities context = new CustomerManagementEntities();

        public MainWindow()
        {
            InitializeComponent();

            // Note context.Customers uses 'lazy loading' (only load when needed)
            // However, to force the retrieval of all the records in customers - use the ToList() method
            customerList.ItemsSource = context.Customers.ToList();
        }

        private void customerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Customer current = customerList.SelectedItem as Customer;
            details.Text = (current != null ? current.ToString() : "");
        }

        private void btnGetData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnReadModify_Click(object sender, RoutedEventArgs e)
        {
            // Find a record in the table
            Customer bob = context.Customers.First( c => c.Name == "Bob" );
            bob.Status = CustomerStatusEnum.Platium;

            // Create a new customer
            context.Customers.Add(
                new Customer { Name = "Test", Status = CustomerStatusEnum.Platium, Email = "t@t.com" });
            context.SaveChanges();

            customerList.ItemsSource = context.Customers.ToList();
        }

        private void btnQueryData_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            // Option1
            //var customers = (from c in context.Customers
            //                 where c.dbStatus == 1
            //                 orderby c.Name
            //                 select c);

            //customerList.ItemsSource = customers.ToList();

            // Option2 (using an extension method)
            customerList.ItemsSource = context.Customers.Where(c => c.dbStatus == 1).OrderBy(c=>c.Name).ToList();

            var stats = from c in context.Customers
                         group c by c.dbStatus into s
                         select new { Status = (CustomerStatusEnum)s.Key, CustCount = s.Count() }; // creating an anonymouse type

            foreach (var stat in stats)
            {
                sb.AppendFormat($"{stat.Status} - {stat.CustCount}\n");
            }

            details.Text = sb.ToString();
        }
    }
}
