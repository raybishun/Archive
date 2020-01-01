using System.Windows;
using System.Windows.Controls;

namespace Mod04_Classes_L1_TypeSafeColletions
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

        private void customerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (customerList.SelectedItem == null)
            {
                return;
            }
            else
            {
                Customer current = (Customer)customerList.SelectedItem;
                details.Text = current.Details();
            }
        }

        private void btnCtors_Click(object sender, RoutedEventArgs e)
        {
            customerList.Items.Clear();

            Customer c2 = new Customer(2, "Sue", CustomerStatusEnum.Platinum, "sue@sue.com");
            Customer c3 = new Customer() { Id = 3, Name = "Linda", Email = "linda@cust.com"};

            customerList.Items.Add(new Customer(1, "Bob"));
            customerList.Items.Add(c2);
            customerList.Items.Add(c3);
        }
    }
}
