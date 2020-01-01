using System;
using System.Windows;

namespace Mod01_ReviewCsSyntax_L2_DataTypes_Casting
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
            // Basics();
            // Tomorrow();
            // Parse();
            TryParse();
        }

        private void Basics()
        {
            int i = 10;
            long j = i * 10;
            i = (int)j;

            int k = 10;
            k += 5;
            MessageBox.Show(k.ToString());
        }

        private void Tomorrow()
        {
            DateTime now = DateTime.Now;
            DateTime tomorrow = now.AddDays(1);
            MessageBox.Show(tomorrow.ToShortDateString());
        }

        private void Parse()
        {
            string strDate = "01/01/2015";      // a valid date
            strDate = "";                       // an invalid date
            DateTime dt = DateTime.Parse(strDate);
            MessageBox.Show(dt.ToString());
        }

        private void TryParse()
        {
            // string strDate = "11/11/2018";   // a valid date
            string strDate = "";                // an invalid date
            DateTime error;
            var result = DateTime.TryParse(strDate, out error) ? DateTime.Parse(strDate) : error;
            MessageBox.Show(result.ToString());
        }
    }
}
