using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AddressBook
{
    public partial class AllContacts : Form
    {
        public AllContacts()
        {
            InitializeComponent();
        }

        private void AllContacts_Load(object sender, EventArgs e)
        {
           // all contacts are loaded to a datagrid view
           //here we can view all information from all contacts as well as the total number of contacts
            try
            {
                string sPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                XmlDocument xml = new XmlDocument();
                xml.Load(sPath + "\\Address Book\\data.xml");

                DataSet dataSet = new DataSet();
                dataSet.ReadXml(sPath + "\\Address Book\\data.xml");
                dataGridView1.DataSource = dataSet.Tables[0];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                txtTotalContacts.Text = dataGridView1.Rows.Count.ToString();
            }
            //if we have not entered any contacts, the datagrid view can't load so we get this message
            catch
            {
                MessageBox.Show("Enter a contact first!", "No contacts found!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }

        }

        //Button that closes this form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
