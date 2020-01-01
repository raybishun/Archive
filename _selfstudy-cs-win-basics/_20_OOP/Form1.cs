using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_OOP
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee e1 = new Employee
            {
                FirstName = "Peter",
                LastName = "Parker",
                Seniority = 5
            };

            Employee e2 = new Employee { FirstName = "Alice", LastName = "Jones" };
            

            string p = e1.Promote();
            string q = e2.Promote();
            MessageBox.Show($"{p}\n{q}");
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Seniority { get; set; }

        public string Promote()
        {
            return "Employee has been promoted...";
        }

        public string AnnualReview()
        {
            return "Annual review completed...";
        }
    }
}
