using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_winforms_web_browser
{
    public partial class MyWebBrowserForm : Form
    {
        public MyWebBrowserForm()
        {
            InitializeComponent();

            tbURL.Text = "http://www.microsoft.com";

            myBrowser.Navigate(tbURL.Text.Trim());
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            myBrowser.Navigate(tbURL.Text.Trim());
        }
    }
}
