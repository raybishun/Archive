using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace WebClientApp
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

        private async void GoButton_Click(object sender, RoutedEventArgs e)
        {
            ResultsTextBox.Clear();

            string[] urls = 
            {
                "http://www.msn.com",
                "http://www.yahoo.com",
                "http://www.google.com",
                "http://www.cnn.com",
                "http://www.stackoverflow.com",
                "http://www.codeproject.com",
                "http://www.tradestation.com",
                "http://www.ninjatrader.com",
                "http://www.microsoft.com",
                "http://www.redhat.com"
            };

            foreach (var url in urls)
            {
                ResultsTextBox.Text += $"{await DoWorkAsync(url)}\n";
            }
        }

        static async Task<string> DoWorkAsync(string url)
        {
            WebClient wc = new WebClient();
            
            string downloaded_result = await wc.DownloadStringTaskAsync(url);

            return $"{url}, {downloaded_result.Length}";
        }
    }
}
