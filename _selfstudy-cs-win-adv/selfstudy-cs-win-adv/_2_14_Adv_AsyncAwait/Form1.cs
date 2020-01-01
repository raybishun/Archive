using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_14_Adv_AsyncAwait
{
    public partial class Form1 : Form
    {
        string name = WindowsIdentity.GetCurrent().Name;

        public Form1()
        {
            InitializeComponent();
        }

        // ========================================================================================
        // Using TaskScheduler.FromCurrentSynchronizationContext with Task.Factory.StartNew()
        // ========================================================================================
        private void TaskButton_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => DoWork(name))
                .ContinueWith((prevTask) => (label1.Text = prevTask.Result), TaskScheduler
                .FromCurrentSynchronizationContext());

            label1.Text = "Task button clicked, waiting...";
        }

        private string DoWork(string name)
        {
            Thread.Sleep(2000);
            return $"Hello, {name}";
        }

        // ========================================================================================
        // Async & Await
        // ========================================================================================
        private async void AsyncAwaitButton_Click(object sender, EventArgs e)
        {
            label1.Text = "AsyncAwait button clicked, waiting...";

            label1.Text = await DoWorkAsync();
        }

        private Task<string> DoWorkAsync()
        {
            return Task.Factory.StartNew(() =>
            {
                Thread.Sleep(2000);
                return $"Hello, {name}";
            });
        }
    }
}
