using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_TPL_AsyncAwait_WinFrmApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // One option
            //Task.Factory.StartNew(() => BigLongImportantMethod("Ray"))
            //    .ContinueWith(prevTask => label1.Text = prevTask.Result, TaskScheduler.FromCurrentSynchronizationContext());

            CallBigImportantMethod();
            label1.Text = "Waiting...";
        }

        private async void CallBigImportantMethod()
        {
            label1.Text = await BigLongImportantMethodAsync("Ray");
        }

        private Task<string> BigLongImportantMethodAsync(string name)
        {
            // Option 1
            // return Task.Factory.StartNew(()=> BigLongImportantMethod(name));
            
            // Option 2
            // return Task.Run(()=> BigLongImportantMethod(name));

            // Option 3
            Task<string> t = Task.Run(() => BigLongImportantMethod(name));
            return t;
        }

        private string BigLongImportantMethod(string name)
        {
            Thread.Sleep(2000);
            return $"{name}";
        }
    }
}
