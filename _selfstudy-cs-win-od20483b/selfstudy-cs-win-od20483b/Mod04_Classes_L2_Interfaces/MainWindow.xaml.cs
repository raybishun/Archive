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

namespace Mod04_Classes_L2_Interfaces
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



                //Customer cust = current as Customer;

                //if (cust != null)
                //{
                //    details.Text = cust.ToString();
                //}
                //else
                //{
                //    Prospect prosp = current as Prospect;

                //    if (prosp != null)
                //    {
                //        details.Text = prosp.ToString();
                //    }
                //}
            }
        }

        private void btnCtors_Click(object sender, RoutedEventArgs e)
        {
            //Customer c2 = new Customer("Sue", CustomerStatusEnum.Platinum, "sue@sue.com");
            //Customer c3 = new Customer() { Name = "Linda", Email = "linda@cust.com" };
            //customerList.Items.Add(new Customer("Bob"));
            //customerList.Items.Add(c2);
            //customerList.Items.Add(c3);
            //customerList.Items.Add(Utilities.GetCustomers(4));
        }

        private void btnStaticMembers_Click(object sender, RoutedEventArgs e)
        {
            foreach (object cust in Utilities.GetCustomers())
            {
                customerList.Items.Add(cust.ToString());
            }
        }

        private void btnGenericList_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
