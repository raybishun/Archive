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

namespace SimpleAsyncDemoApp2
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

        private async void Submit_Click(object sender, RoutedEventArgs e)
        {
            // ResultsTextBox.Clear();
            await DoWorkAsync();
            
        }

        private async Task<string> DoWorkAsync()
        {
            WebClient wc = new WebClient();

            string[] urls = {"http://www.msn.com", "http://www.redhat.com", "http://www.google.com", "http://www.microsoft.com",
                "http://www.yahoo.com", "http://finance.yahoo.com", "http://finance.google.com", "http://www.bmwusa.edu", "http://www.mbusa.com"};

            try
            {
                foreach (string url in urls)
                {
                    var results = await wc.DownloadDataTaskAsync(url);
                    ResultsTextBox.Text += $"{url}\t{results.Length.ToString("N0")}\n";
                }

                return "Done";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
