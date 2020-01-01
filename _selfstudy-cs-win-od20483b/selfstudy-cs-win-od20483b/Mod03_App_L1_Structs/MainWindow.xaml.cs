using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Mod03_App_L1_Structs
{
    // *** NOTE: The attributes of a listbox expect a 'property' ***
    
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int nextId = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void listboxCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (customerList.SelectedItem == null)
            {
                return;
            }

            Customer current = (Customer)customerList.SelectedItem;
            // details.Text = current.ToString();


            var util = new Utilities();
            var customers = util.GetCustomersUsingHashTable();
            // Customer cust = (Customer)customers[current.Name];

            details.Text = current.ToString();
        }

        private void btnAddStruct_Click(object sender, RoutedEventArgs e)
        {
            //Customer cust = new Customer();
            //cust.Id = nextId++;
            //cust.Name = customerName.Text;
            //cust.Status = CustomerStatusEnum.Gold;
            //cust.Email = $"{cust.Name}@cust.com";
            //customerList.Items.Add(cust);

            customerList.Items.Add(new Customer(nextId++, customerName.Text + "@cust.com", customerName.Text, CustomerStatusEnum.Gold));
        }

        private void btnUseCollection_Click(object sender, RoutedEventArgs e)
        {
            var util = new Utilities();

            // Using ArrayList
            
            // var customers = util.GetCustomersUsingArrayList();
            //foreach (var cust in customers)
            //{
            //    customerList.Items.Add(cust);
            //}

            // Using HashTable
            foreach (var cust in util.GetCustomersUsingHashTable().Values)
            {
                customerList.Items.Add(cust);
            }
        }

        private void btnQueryCollectionUsingLinq_Click(object sender, RoutedEventArgs e)
        {
            customerList.Items.Clear();

            var utils = new Utilities();

            var customers = utils.GetCustomersUsingArrayList();

            var gold = from Customer c in customers
                       where c.Status == CustomerStatusEnum.Gold
                       orderby c.Name
                       select c;

            //foreach (var customer in gold)
            //{
            //    customerList.Items.Add(customer);
            //}

            Customer c1 = gold.FirstOrDefault(); // extension method
            customerList.Items.Add(c1);

            // Accessing the struct (or class) using indexer
            string student = c1[2];
            MessageBox.Show(student);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            details.Text = $"Started with {customer.Name}";
        }
        
        Customer customer = new Customer(2, "Bob", "bob@cust.com", CustomerStatusEnum.Gold);
        
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            customer.NameChanged += Customer_NameChanged;

            customer.Name = customerName.Text;
        }

        private void Customer_NameChanged(object sender, System.EventArgs e)
        {
            details.Text = ($"Name changed to {customer.Name}");
        }
    }
}
