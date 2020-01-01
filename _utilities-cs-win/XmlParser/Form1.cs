using System;
using System.Windows.Forms;
using System.Xml;

/// <summary>
/// *************
/// Prerequisites
/// *************
/// Set the EmployeeData.xml to:
///    Copy to Output Directory: Copy always
/// </summary>
namespace XmlParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LoadEmployees();
        }

        private void LoadEmployees()
        {
            XmlDocument doc = new XmlDocument();

            try
            {
                doc.Load("EmployeeData.xml");

                foreach (XmlNode node in doc.DocumentElement)
                {
                    string name = node.Attributes[0].Value;
                    int age = int.Parse(node["Age"].InnerText);
                    bool isMale = bool.Parse(node["IsMale"].InnerText);

                    myListBox.Items.Add(new Employee(name, age, isMale));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (myListBox.SelectedIndex != -1)
            {
                propertyGrid.SelectedObject = myListBox.SelectedItem;
            }
        }
    }
}
