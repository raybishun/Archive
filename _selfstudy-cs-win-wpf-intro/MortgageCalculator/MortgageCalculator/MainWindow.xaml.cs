using System;
using System.Collections.Generic;
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

namespace MortgageCalculator
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

        // Silly example

        public double AmountBorrowed { get; set; }
        public double InterestRate { get; set; }
        public int MortgagePeriod { get; set; }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            AmountBorrowed = (double)Int32.Parse(txtAmt.Text);

            // get interest rate
            decimal result;
            if (decimal.TryParse(txtInterest.Text, out result))
            {
                InterestRate = (double)result;
            }
            
            // get mortgage rate
            MortgagePeriod = Int32.Parse(txtPeriod.Text);

            // get mortgage period
            lblMonthlyPayments.Content = CalcMortgage(AmountBorrowed, InterestRate, MortgagePeriod);
        }

        private object CalcMortgage(double amountBorrowed, double interestRate, int mortgagePeriod)
        {
            double p = amountBorrowed;
            double r = ConvertToMonthlyInterest(interestRate);
            double n = YearsToMonths(MortgagePeriod);

            var c = (decimal)(((r * p) * Math.Pow((1 + r), n)) / (Math.Pow((1 + r), n) - 1));

            return ($"${Math.Round(c, MidpointRounding.AwayFromZero)}");
            
        }

        private double YearsToMonths(int years)
        {
            return (12 * years);
        }

        private double ConvertToMonthlyInterest(double percent)
        {
            return (percent / 12) / 100;
        }
    }
}
