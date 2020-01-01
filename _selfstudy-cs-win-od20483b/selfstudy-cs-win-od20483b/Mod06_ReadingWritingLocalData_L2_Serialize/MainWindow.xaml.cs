using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
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

namespace Mod06_ReadingWritingLocalData_L2_Serialize
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string binFile = @"c:\temp\people.bin";
        private const string xmlFile = @"c:\temp\people.xml";

        List<Person> humans = Utilities.GetPeople();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();

            //foreach (var human in humans)
            //{
            //    listBox.Items.Add(human.Name);
            //}

            listBox.ItemsSource = Utilities.GetPeople();
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var result = (from human in humans
            //              where human.Name == listBox.SelectedItem.ToString()
            //              select human).First();

            //details.Text = result.ToString();


            Person current = listBox.SelectedItem as Person;

            if (current != null)
            {
                details.Text = current.ToString();
            }
        }


        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            People people = listBox.ItemsSource as People;
            if (people == null)
            {
                return;
            }

            // var formatter = new BinaryFormatter();
            //var stream = File.Create(binFile);
            var formatter = new SoapFormatter();
            var stream = File.Create(xmlFile);

            formatter.Serialize(stream, people);
            stream.Close();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            //var formatter = new BinaryFormatter();
            //var stream = File.OpenRead(binFile);
            var formatter = new SoapFormatter();
            var stream = File.OpenRead(xmlFile);

            People people = formatter.Deserialize(stream) as People;
            stream.Close();
            listBox.ItemsSource = people;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            listBox.ItemsSource = null;
            listBox.Items.Clear();
        }
    }
}
