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

namespace Mod02_Methods_Monitoring_L1_Methods
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Utilities utils = new Utilities();
            //customerList.ItemsSource = utils.GetCustomers();
        }

        private void CustomerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Customer current = customerList.SelectedItem as Customer;
            DisplayCustomer(current);
        }

        private void DisplayCustomer(Customer customer)
        {
            if (customer != null)
            {
                details.Text = string.Format($"{customer.Name}\n{customer.Status}\n{customer.Email}");
            }
            else
            {
                MessageBox.Show("NULL");
            }
        }

        private void OverloadedButton_Click(object sender, RoutedEventArgs e)
        {
            Utilities util = new Utilities();

            Customer c1 = util.NewCustomer(10, "Customer 1");
            Customer c2 = util.NewCustomer(11, "Customer 2", 3, "another@email.com");

            customerList.Items.Add(c1);
            customerList.Items.Add(c2);
        }

        private void OptionalParametersButton_Click(object sender, RoutedEventArgs e)
        {
            Utilities util = new Utilities();

            Customer c1 = util.NewCustomer(10, "Customer 3");
            Customer c2 = util.NewCustomer(11, "Customer 4", 3);

            customerList.Items.Add(c1);
            customerList.Items.Add(c2);
        }

        private void NamedParametersButton_Click(object sender, RoutedEventArgs e)
        {
            Utilities util = new Utilities();

            Customer c1 = util.NewCustomer(id:20, name:"Named 1", status:2);
            Customer c2 = util.NewCustomer(id:21, name:"N2", email:"prettycool@cool.com");

            customerList.Items.Add(c1);
            customerList.Items.Add(c2);
        }

        private void OutButton_Click(object sender, RoutedEventArgs e)
        {
            Customer c1, c2;

            Utilities util = new Utilities();

            if (util.NewValidatedCustomer(1, "Bob", out c1))
            {
                customerList.Items.Add(c1);
            }

            if (util.NewValidatedCustomer(-1, "Sue", out c2))
            {
                customerList.Items.Add(c2);
            }
            else
            {
                MessageBox.Show("Invalid customer");
            }

            if (util.NewValidatedCustomer(out Customer c3, 3, "Ray"))
            {
                customerList.Items.Add(c3);
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            customerList.Items.Clear();
        }
    }
}
