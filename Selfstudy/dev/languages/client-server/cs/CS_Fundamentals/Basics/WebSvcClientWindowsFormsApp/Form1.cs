using Newtonsoft.Json;
using System;
using System.Data;
using System.Windows.Forms;

namespace WebSvcClientWindowsFormsApp
{
    public partial class Form1 : Form
    {
        localhost.WebService1 proxy = new localhost.WebService1();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string countriesJson = proxy.GetCountries();
            DataTable countriesDt = JsonConvert.DeserializeObject<DataTable>(countriesJson);
            dataGridView1.DataSource = countriesDt;
        }
    }
}
