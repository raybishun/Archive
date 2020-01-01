using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace WebClientAppAsync
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

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            ResultsTextBox.Clear();

            DoWorkAsync();
        }

        private async void DoWorkAsync()
        {
            string[] urls = { "http://www.google.com", "http://www.msn.com", "http://www.microsoft.com", "http://www.youtube.com", "http://www.apple.com", "http://www.cnbc.com",
                "http://www.excelsior.edu", "http://www.wgu.edu", "http://www.bmwusa.com", "http://www.mbusa.com" };

            foreach (var url in urls)
            {
                WebClient wc = new WebClient();

                // string downloadResults = wc.DownloadString(url);

                string downloadResults = await wc.DownloadStringTaskAsync(url);
                                
                ResultsTextBox.Text += $"{url}, {downloadResults.Length.ToString("N0")}\n";
            }

            ResultsTextBox.Text += "Done.";
        }
    }
}
