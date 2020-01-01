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

namespace Mod05_Classes_L1_Inheritance
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
            if (customerList.SelectedItem != null)
            {
                Person current = customerList.SelectedItem as Person;

                if (current != null)
                {
                    details.Text = current.Details();
                }
            }
            else
            {
                // customerList.SelectedItem is null
                return;
            }
        }

        private void btnInheritance_Click(object sender, RoutedEventArgs e)
        {
            customerList.ItemsSource = Utilities.GetCustomers();
        }

        private void btnExtension_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // Test the LoyaltyCardNotFoundException class

                // Perorm the operation that could cause an exception

                throw new LoyaltyCardNotFoundException();
            }
            catch (LoyaltyCardNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
