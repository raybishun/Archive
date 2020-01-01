using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Mod01_ReviewCsSyntax_L3_Interation
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Iterations();
        }

        private void Iterations()
        {
            txtResults.Clear();

            for (int i = 0; i < 10; i++)
            {
                if (i == 6)
                {
                    // break; // will exit loop
                    continue; // will skip
                }

                txtResults.Text += $"{i} ";
            }
        }
    }
}
