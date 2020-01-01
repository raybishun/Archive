using System;
using System.Collections.Generic;
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

namespace Mod06_ReadingWritingLocalData_L3_Streams
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

        private const string binFile = "stream.bin";
        private const string textfile = "stream.txt";

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            WriteData();
            ReadData();
        }

        private void WriteData()
        {
            string s = "This is a string";
            int i = 5;
            DateTime dt = DateTime.Now;

            var stream = new FileStream(binFile, FileMode.Create, FileAccess.Write);
            var wr = new BinaryWriter(stream);

            wr.Write(s);
            wr.Write(i);
            wr.Write(dt.ToBinary());
            stream.Close();
        }

        private void ReadData()
        {
            string s ;
            int i;
            DateTime dt;

            var stream = new FileStream(binFile, FileMode.Open, FileAccess.Read);
            var rdr = new BinaryReader(stream);
            s = rdr.ReadString();
            i = rdr.ReadInt32();
            dt = DateTime.FromBinary(rdr.ReadInt64()); // a long int
            MessageBox.Show($"{s}\n{i}\n{dt}");
        }
    }
}
