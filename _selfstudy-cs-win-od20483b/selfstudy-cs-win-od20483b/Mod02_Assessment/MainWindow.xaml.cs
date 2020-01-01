using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows;

namespace Mod02_Assessment
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

        // q1
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Debug.Write("Works only when project is set to compile in \'DEBUG\' mode");
        }

        // q2
        private void SqlDemo()
        {
            SqlConnection connection = null;
            string connectionString = "...";

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
        }

        // q3
        private void GetAllCustomers(string customerName) { }
        private void GetAllCustomers(int customerId) { }

        // q4
        private void RefButton_Click(object sender, RoutedEventArgs e)
        {
            int intA = 10;

            int retValue = SetVariable(ref intA);

            MessageBox.Show(intA.ToString());
        }

        private int SetVariable(ref int intB)
        {
            int intC = 10;

            intB++;

            intC += intB;

            return intC;
        }

        // q5
        private void ThrowButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                throw new NotFiniteNumberException("NaN");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //catch (NotFiniteNumberException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        // q6
        private void OutButton_Click(object sender, RoutedEventArgs e)
        {
            decimal newSalary;
            MessageBox.Show(OutDemo("Ray", out newSalary, 50).ToString());
            MessageBox.Show(newSalary.ToString());
        }

        private bool OutDemo(string name, out decimal salary, int age)
        {
            // The out parameter 'salary' must be assigned to before control leave the current method
            salary = 410000;

            return true;
        }


    }
}
