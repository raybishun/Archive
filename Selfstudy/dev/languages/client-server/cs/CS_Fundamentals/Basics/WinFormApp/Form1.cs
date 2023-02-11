using System;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcSum_Click(object sender, EventArgs e)
        {
            try
            {
                double sum = Convert.ToDouble(OperandOne.Text) + Convert.ToDouble(OperandTwo.Text);
                MessageBox.Show($"The sum is: {sum}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("1. FormLoad()");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("2. FormShown()");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            // Every click...
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("3. FormClosing()", 
                "FormClosing()", MessageBoxButtons.YesNoCancel);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("4. FormClosed()");
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            // Didn't work
            MessageBox.Show("Enter()");
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            // MessageBox.Show("MouseEnter()");
        }
    }
}
