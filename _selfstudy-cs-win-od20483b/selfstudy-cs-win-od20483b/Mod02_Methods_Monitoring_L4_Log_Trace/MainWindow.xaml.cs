using System.Windows;
using System.Windows.Controls;


// Instrumentation (aka application monitoring)
// 1. logging & tracing
// 2. application profiling
    // Analyze
    // Launch Performance Wizard...
// 3. perfmon counters




namespace Mod02_Methods_Monitoring_L4_Log_Trace
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Utilities utils = new Utilities();
            // customerList.ItemsSource = utils.GetCustomers();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void CustomerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Customer current = customerList.SelectedItem as Customer;
            DisplayCustomer(current);
        }

        private void DisplayCustomer(Customer customer)
        {
            details.Text = string.Format($"{customer.Name}\n{customer.Status}\n{customer.Email}");
        }

        private void OverloadedButton_Click(object sender, RoutedEventArgs e)
        {
            Utilities util = new Utilities();
            Customer c1 = util.NewCustomer(10, "Customer 1");
            Customer c2 = util.NewCustomer(11, "Customer 2", CustomerStatusEnum.Silver, "another@email.com");
            customerList.Items.Add(c1);
            customerList.Items.Add(c2);
        }

        private void OptionalParametersButton_Click(object sender, RoutedEventArgs e)
        {
            Utilities util = new Utilities();
            Customer c1 = util.NewCustomer(10, "Customer 3");
            Customer c2 = util.NewCustomer(11, "Customer 4", CustomerStatusEnum.Silver);
            customerList.Items.Add(c1);
            customerList.Items.Add(c2);
        }

        private void NamedParametersButton_Click(object sender, RoutedEventArgs e)
        {
            Utilities util = new Utilities();
            Customer c1 = util.NewCustomer(id: 20, name: "Named 1", status: CustomerStatusEnum.Platinum);
            Customer c2 = util.NewCustomer(id: 21, name: "N2", email: "prettycool@cool.com");
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
        }
    }
}
