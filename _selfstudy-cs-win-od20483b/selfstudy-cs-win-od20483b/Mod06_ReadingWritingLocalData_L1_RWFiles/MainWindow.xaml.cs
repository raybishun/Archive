using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

namespace Mod06_ReadingWritingLocalData_L1_RWFiles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string textFile = @"c:\temp\text.txt";
        private string linesFile = @"c:\temp\lines.txt";

        ObservableCollection<string> items = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();

            display.ItemsSource = items;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            items.Add(text.Text);
            text.Text = "";
            text.Focus();
        }

        private void verifyPath(string fileName)
        {
            string dirPath = System.IO.Path.GetDirectoryName(fileName);
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            verifyPath(textFile);
            File.WriteAllText(textFile, text.Text);
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            verifyPath(textFile);
            if (File.Exists(textFile))
            {
                text.Text = File.ReadAllText(textFile);
            }
        }

        private void btnSaveAll_Click(object sender, RoutedEventArgs e)
        {
            verifyPath(textFile);
            File.WriteAllLines(linesFile, items);
        }

        private void btnLoadAll_Click(object sender, RoutedEventArgs e)
        {
            items.Clear();
            string[] itemsFromFile = File.ReadAllLines(linesFile);
            foreach (string item in itemsFromFile)
            {
                items.Add(item);
            }
        }
    }
}
