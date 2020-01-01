using System;
using System.Windows;

namespace Mod02_Methods_Monitoring_L3_ThrowingEx
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

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            string name = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            var nullRefEx = new NullReferenceException($"{name} the <some parameter> is null.");

            try
            {
                // MessageBox.Show(nullRefEx.ToString());
            }
            catch (NullReferenceException ex)
            {
                txtOutput.Text = ex.ToString();
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {

            }
        }
    }
}
