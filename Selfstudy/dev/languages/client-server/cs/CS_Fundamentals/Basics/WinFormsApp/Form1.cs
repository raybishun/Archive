using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StringBuilder sb = new();
            sb.AppendFormat($"CloseReason: {e.CloseReason}");
            sb.AppendLine();
            sb.AppendFormat($"Cancel: {e.Cancel}");
            sb.AppendLine();

            MessageBox.Show(sb.ToString(), "FormClosing Event");
        }
    }
}
