using System.Windows;

namespace Mod01_ReviewCsSyntax_L3_Arrays
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
            // PopulateTextBox();
            MultiDimensionalArrays();
        }

        private void PopulateTextBox()
        {
            txtResults.Clear();

            char[] chars = new char[3] { 'R', 'a', 'y' };

            foreach (var letter in chars)
            {
                txtResults.Text += $"{letter}";
            }
        }

        private void MultiDimensionalArrays()
        {
            string[,] users = new string[2, 2];
            users[0, 0] = "Ray";
            users[0, 1] = "NY";

            users[1, 0] = "Julie";
            users[1, 1] = "NJ";

            //for (int row = 0; row < users.GetLength(0); row++)
            //{
            //    string name = users[row, 0];
            //    string state = users[row, 1];
            //    MessageBox.Show($"{name}, {state}");
            //}

            for (int r = 0; r < users.GetLength(0); r++)
            {
                for (int c = 0; c < users.GetLength(1); c++)
                {
                    string name = users[r, c];
                    string state = users[r, ++c];
                    MessageBox.Show($"{name}, {state}");
                }

            }
        }
    }
}
