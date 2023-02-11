using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Xml;
using System.Data;

namespace WinFormAppForSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            
        }
        private void RunSQL_Click(object sender, System.EventArgs e)
        {
            ConnectToSql();
        }

        private void ConnectToSql()
        {
            SqlConnectionStringBuilder sqlConSb = new SqlConnectionStringBuilder();
            sqlConSb.DataSource = @"X1EXTREME\SQLEXPRESS";
            sqlConSb.InitialCatalog = "SwDevFun";
            sqlConSb.IntegratedSecurity = true;

            SqlConnection sqlConn = new SqlConnection(sqlConSb.ConnectionString);
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM [SwDevFun].[dbo].[tblEmployee]", sqlConn);

            try
            {
                sqlConn.Open();
                // MessageBox.Show(sqlConn.State.ToString());

                using (SqlDataReader sqlReader = sqlCmd.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        MessageBox.Show($"{sqlReader.GetString(0)} {sqlReader.GetString(1)}");
                    }
                }
              
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReadFlatFile_Click(object sender, System.EventArgs e)
        {
            using (StreamReader sr = new StreamReader(@".\flatfile.txt"))
            {
                string line = "";
                
                while ((line = sr.ReadLine()) != null)
                {
                    MessageBox.Show(line);
                }
            }
        }

        private void ReadXML_Click(object sender, System.EventArgs e)
        {
            using (StreamReader sr = new StreamReader(@".\xmlfile.xml"))
            {
                XmlReaderSettings xmlSettings = new XmlReaderSettings();
                XmlReader xmlReader = XmlReader.Create(sr, xmlSettings);

                while (xmlReader.Read())
                {
                    switch (xmlReader.NodeType)
                    {
                        case XmlNodeType.Element:
                            MessageBox.Show(xmlReader.Name);
                            break;
                        case XmlNodeType.Text:
                            MessageBox.Show(xmlReader.Value);
                            break;
                        case XmlNodeType.EndElement:
                            MessageBox.Show($"End of {xmlReader.Name}");
                            break;
                    }
                }
            }
        }

        private void InMemDataSets_Click(object sender, System.EventArgs e)
        {
            using (DataSet ds = new DataSet())
            {
                ds.ReadXml(@".\xmlfile.xml");

                foreach (DataTable table in ds.Tables)
                {
                    MessageBox.Show($"Table: {table.TableName}");

                    foreach (DataRow row in table.Rows)
                    {
                        foreach (DataColumn column in table.Columns)
                        {
                            MessageBox.Show($"{column.ColumnName}: {row[column]}");
                        }
                    }
                }
            }
        }
    }
}
