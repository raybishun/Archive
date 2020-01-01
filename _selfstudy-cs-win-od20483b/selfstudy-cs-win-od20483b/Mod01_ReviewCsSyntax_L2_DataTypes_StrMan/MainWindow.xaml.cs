using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;

namespace Mod01_ReviewCsSyntax_L2_DataTypes_StrMan
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
            // StringsAreImmutable();
            // StrBuilder();
            // RegEx();
            Test();
        }

        static void StringsAreImmutable()
        {
            string str = "one";
            str = "two";
            str += "\n\rthree";
            str += "\n\rfour";
            MessageBox.Show(str);
        }

        static void StrBuilder()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("one\n");
            sb.Append("\ttwo\n\r");
            sb.Append("\t\tthree");

            string formattedStr = string.Format($"Formatted String:\n{DateTime.Now}\n{sb}");

            MessageBox.Show(formattedStr);
        }

        static void RegEx()
        {
            string input = "Hell0 World";

            string pattern = "\\d"; // Find "\d" (digit)

            var regEx = Regex.Match(input, pattern, RegexOptions.None);

            if (regEx.Success)
            {
                // int i = input.IndexOf('0');

                int index = regEx.Index;

                MessageBox.Show($"Found {pattern} at index {index}.");
            }
        }

        static void Test()
        {
            string firstName = "John";
            string lastName = "Smith";
            string fullName = $"{firstName} {lastName}";
            MessageBox.Show(fullName);
        }
    }
}
