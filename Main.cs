using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace AddressBook
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //This is the main form of an address book application where the user will be able to store and view contacts.

        // A list class where I will store all the saved contacts as objects of class "Contact".
        List<Contact> Contacts = new List<Contact>(); 

        private void Main_Load(object sender, EventArgs e) // What happens when the form loads
        {
            //I will save all the contacts' data at an xml file located at Windows My Documents folder
            
            //Check if the directory and the file I want already exist.
            //If not I create them
            string sPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (Directory.Exists(sPath + "\\Address Book") == false)
            {
                Directory.CreateDirectory(sPath + "\\Address Book");
            }
            if (File.Exists(sPath + "\\Address Book\\data.xml") == false)
            {
                // xml file initizalization
                XmlTextWriter xmltw = new XmlTextWriter(sPath + "\\Address Book\\data.xml", Encoding.UTF8);
                xmltw.WriteStartElement("Contacts");
                xmltw.WriteEndElement();
                xmltw.Close();
            }

            //Previously saved contacts are stored at a data.xml file
            //Load all my previously saved contacts from my data.xml to the form's lists ass well as the List Class Contacts which includes all contacts
            XmlDocument xml = new XmlDocument();
            xml.Load(sPath + "\\Address Book\\data.xml");

            //I create a contact class object named
            //For every xml node inside each Contacts/Contact node I assign the equivalent contact object's variable that value
            foreach (XmlNode xmlnode in xml.SelectNodes("Contacts/Contact"))
            {
                Contact c = new Contact();
                c.sFirstName = xmlnode.SelectSingleNode("First_Name").InnerText;
                c.sLastName = xmlnode.SelectSingleNode("Last_Name").InnerText;
                c.sPhone = xmlnode.SelectSingleNode("Phone").InnerText;
                c.sEmail = xmlnode.SelectSingleNode("Email").InnerText;
                c.sAddress = xmlnode.SelectSingleNode("Address").InnerText;
                c.sNotes = xmlnode.SelectSingleNode("Notes").InnerText;
                Contacts.Add(c);

                //Create a ListView to show all the contacts loaded from my data.xml file when the main form loads
                string[] arr = new string[5];
                ListViewItem itm;

                //add items to ListView
                arr[0] = c.sLastName;
                arr[1] = c.sFirstName;
                arr[2] = c.sPhone;
                arr[3] = c.sEmail;
                itm = new ListViewItem(arr);
                lstContacts.Items.Add(itm);

            }
        }


        private void btnSave_Click(object sender, EventArgs e) // What happens when the Save button is clicked
        {
            //Confirmation Message. The button only works if user selects "Yes".
            DialogResult drReply = MessageBox.Show("Are you sure?", "Confirmation",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (drReply == DialogResult.Yes)
            {
                //Empty Text Boxes Validation
                if (txtFirstName.Text == String.Empty && txtLastName.Text == String.Empty)
                {
                    MessageBox.Show("Please enter a first or a last name!", "Missing Fields!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPhone.Text == String.Empty)
                {
                    MessageBox.Show("Please enter a phone number!", "Missing Fields!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Phone number format validation
                else if (isValidPhone(txtPhone.Text) == false) //a method is called to check if the format of the phone number entered is valid
                {
                    MessageBox.Show("Please enter a valid phone number!", "Invalid phone number!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhone.Clear();
                }
                // Email validation
                // A method is called to check if the format of the email entered is valid
                else if (txtEmail.Text != "" && txtEmail.Text != "someone@example.com" && isValidEmail(txtEmail.Text) == false)
                {
                    MessageBox.Show("Invalid email format", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Clear();
                }
                else
                {
                    if (txtEmail.Text == "someone@example.com")
                    {
                        txtEmail.Clear();
                        txtEmail.ForeColor = Color.Black;
                    }

                    //If validation is successfull, I create a Contact class object and I store inputs from text boxes as class variables

                    Contact c = new Contact();
                    c.sFirstName = txtFirstName.Text;
                    c.sLastName = txtLastName.Text;
                    c.sPhone = txtPhone.Text;
                    c.sEmail = txtEmail.Text;
                    c.sAddress = txtAddress.Text;
                    c.sNotes = txtNotes.Text;

                    //Then I add this class object to List Class Contacts
                    Contacts.Add(c);

                    string[] arr = new string[5];
                    ListViewItem itm;
                    //add items to ListView
                    arr[0] = c.sLastName;
                    arr[1] = c.sFirstName;
                    arr[2] = c.sPhone;
                    arr[3] = c.sEmail;
                    itm = new ListViewItem(arr);
                    lstContacts.Items.Add(itm);

                    clear(); //this method clears any text in the form
                    savecontacts(); //this method saves all the changes we made to our contacts to data.xml file


                }

            }
        }

        //This is what happens when we press the "apply changes" button
        //The "apply changes" button is enabled when we click the edit button over a selected contact from our list view.
        //We click it after finishing editing to apply the changes.
        private void btnApply_Click(object sender, EventArgs e)
        {
            //Empty Text Boxes Validation
            if (txtFirstName.Text == String.Empty && txtLastName.Text == String.Empty)
            {
                MessageBox.Show("Please enter a first or a last name!", "Missing Fields!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPhone.Text == String.Empty)
            {
                MessageBox.Show("Please enter a phone number!", "Missing Fields!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Phone number validation
            else if (isValidPhone(txtPhone.Text) == false)
            {
                MessageBox.Show("Please enter a valid phone number!", "Invalid phone number!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Clear();
            }
            // Email validation
            else if (txtEmail.Text != "" && txtEmail.Text != "someone@example.com" && isValidEmail(txtEmail.Text) == false)
            {
                MessageBox.Show("Invalid email format", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Clear();
            }
            else
            {
                if (txtEmail.Text == "someone@example.com")
                {
                    txtEmail.Clear();
                }

                //If validation is successful, the selected contact's details that are loaded to our form's text boxes for editing are saved.
                //Changes are applied at the forms' lists as well as the data.xml file were all our data are stored.

                Contacts[lstContacts.SelectedItems[0].Index].sFirstName = txtFirstName.Text;
                Contacts[lstContacts.SelectedItems[0].Index].sLastName = txtLastName.Text;
                Contacts[lstContacts.SelectedItems[0].Index].sPhone = txtPhone.Text;
                Contacts[lstContacts.SelectedItems[0].Index].sEmail = txtEmail.Text;
                Contacts[lstContacts.SelectedItems[0].Index].sAddress = txtAddress.Text;
                Contacts[lstContacts.SelectedItems[0].Index].sNotes = txtNotes.Text;

                ListViewItem item = lstContacts.SelectedItems[0];
                item.SubItems[0].Text = txtLastName.Text;
                item.SubItems[1].Text = txtFirstName.Text;
                item.SubItems[2].Text = txtPhone.Text;
                item.SubItems[3].Text = txtEmail.Text;

                clear();

                txtEmail.ForeColor = Color.Black;
                btnApply.Enabled = false;
                btnSave.Enabled = true;
                groupBox1.Enabled = true;

                txtEmail.Text = "someone@example.com";
                txtEmail.ForeColor = Color.Gray;

                savecontacts();




            }
        }



        //This is what happens when we click the exit button
        //A messagebox appears asking if we want to exit program. If we click yes, the application exits.
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult drReply = MessageBox.Show("Exit program?", "Confirmation",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drReply == DialogResult.Yes)
            {
                Application.Exit();
            }


        }
        //When we click View -> All Contacts from the main form menu strip, this is what happens.
        private void allContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //The AllContacts form is opened.
            AllContacts AllCon = new AllContacts();
            AllCon.ShowDialog();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            clear(); 
        }




        //a method that clears all text from the form.
        void clear()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            if (txtEmail.Text != "someone@example.com")
            {
                txtEmail.Clear();
            }
            txtAddress.Clear();
            txtNotes.Clear();
        }

        //a method that saves all changes to our data.xml file
        //when we enter a new contact, it is immediately shown at aour list view
        //But in order to save these contacts to our data.xml so that we can store and load them in future, this method needs to be called
        void savecontacts()
        {
            XmlDocument xml = new XmlDocument();
            string sPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            xml.Load(sPath + "\\Address Book\\data.xml");
            XmlNode xmlnode = xml.SelectSingleNode("Contacts");
            xmlnode.RemoveAll();


            //for each obect of the class contact that has been recorded to our list class Contacts
            //an extra Contacts/Contact node is recorded at our data.xml file

            foreach (Contact c in Contacts)
            {
                XmlNode xmltop = xml.CreateElement("Contact");
                XmlNode xmlfirstname = xml.CreateElement("First_Name");
                XmlNode xmllastname = xml.CreateElement("Last_Name");
                XmlNode xmlphone = xml.CreateElement("Phone");
                XmlNode xmlemail = xml.CreateElement("Email");
                XmlNode xmladdress = xml.CreateElement("Address");
                XmlNode xmlnotes = xml.CreateElement("Notes");

                xmlfirstname.InnerText = c.sFirstName;
                xmllastname.InnerText = c.sLastName;
                xmlphone.InnerText = c.sPhone;
                xmlemail.InnerText = c.sEmail;
                xmladdress.InnerText = c.sAddress;
                xmlnotes.InnerText = c.sNotes;
                xmltop.AppendChild(xmlfirstname);
                xmltop.AppendChild(xmllastname);
                xmltop.AppendChild(xmlphone);
                xmltop.AppendChild(xmlemail);
                xmltop.AppendChild(xmladdress);
                xmltop.AppendChild(xmlnotes);
                xml.DocumentElement.AppendChild(xmltop);
            }
            xml.Save(sPath + "\\Address Book\\data.xml");
        }

        //This method is called to delete a contact
        void delete()
        {

            DialogResult drReply = MessageBox.Show("Are you sure you want to delete this contact?", "Confirmation",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (drReply == DialogResult.Yes)
            {
                try
                {
                    //contact is removed from List class
                    Contacts.RemoveAt(lstContacts.SelectedItems[0].Index);
                    //contact is removed from data.xml
                    lstContacts.Items.Remove(lstContacts.SelectedItems[0]);
                }
                catch
                {
                    //if no contact is selected from list view, the method won't work so we get this error message
                    MessageBox.Show("No contact selected", "Cant't Delete!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        //a message that appears when the app is closed
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
                        MessageBox.Show("Thanks for using Address Book App!", "Your contacts are safe!",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //an about form that is shown when we click the Help -> About button from the main form menu strip.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 abox = new AboutBox1();
            abox.ShowDialog();
        }

        //a method that deletes ALL contacts in case we want to start from scratch.
        private void deleteAllContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult drReply = MessageBox.Show("Are you sure you want to delete all contacts?", "Confirmation",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (drReply == DialogResult.Yes)
            {
                Contacts.Clear(); //Contacts List class is cleared
                lstContacts.Items.Clear(); //Main form list view is cleared
                savecontacts(); //Changes are saved to our data.xml file as well
            }



        }
        //when we click at email textbox, placeholder text should be cleared.
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.ForeColor != Color.Black)
            {
                txtEmail.Clear();
                txtEmail.ForeColor = Color.Black;
            }
        }

        //Phone validation method using RegEx class
        public static bool isValidPhone(string inputMobileNumber)
        {
            string strRegex = @"(^[0-9]{3,15}$)|(^[0-9]{3,6}\s+[0-9]{7,10}$)| ";

            // Class Regex Represents an immutable regular expression.
            //   Format                Pattern
            // xxxxxxxxxx(xxxxx)    ^[0 - 9]{3,15}$ which means a phone number can have from 3 to 15 numbers
            Regex re = new Regex(strRegex);

            // The IsMatch method is used to validate a string or to ensure that a string conforms to a particular pattern.
            if (re.IsMatch(inputMobileNumber))
                return (true);
            else
                return (false);
        }

        //Email validation method using RegEx class
        public static bool isValidEmail(string inputEmail)
        {

            // This Pattern is used to verify the email
            string strRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            Regex re = new Regex(strRegex, RegexOptions.IgnoreCase);

            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        //This is what happens when we click the File -> Open File Location button.
        //A windows explorer window opens at the directory where data.xml is saved.
        //This directory is the My Documents folder
        private void openAllContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Specifying a file path
            string sPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string path = sPath + "\\Address Book";

            Process.Start("explorer.exe", path);
        }

        //This is what happens when we press the edit button.
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            try
            {
                //all information from the selected list view contact are copied to the form text boxes so the user can edit them
                txtFirstName.Text = Contacts[lstContacts.SelectedItems[0].Index].sFirstName;
                txtLastName.Text = Contacts[lstContacts.SelectedItems[0].Index].sLastName;
                txtPhone.Text = Contacts[lstContacts.SelectedItems[0].Index].sPhone;
                txtEmail.Text = Contacts[lstContacts.SelectedItems[0].Index].sEmail;
                txtAddress.Text = Contacts[lstContacts.SelectedItems[0].Index].sAddress;
                txtNotes.Text = Contacts[lstContacts.SelectedItems[0].Index].sNotes;

                btnSave.Enabled = false; // disable save button so that the user won't insert a new contact by mistake when editing
                btnApply.Enabled = true;
                groupBox1.Enabled = false;


                txtEmail.ForeColor = Color.Black;
            }
            catch
            {
                MessageBox.Show("No contact selected", "Cant't Edit!",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //This is what happens when we click the Delete button
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            delete(); //by calling this method, selected contact is deleted both from the form lists and the xml file
            savecontacts(); //changes are saved
        }

        //Edit and Delete buttons are disabled when we open the app
        //When we select any contact from the main list view, these buttons are enabled so that we can edit or delete the selected contact
        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = lstContacts.SelectedItems.Count > 0;
            btnDelete.Enabled = lstContacts.SelectedItems.Count > 0;
            editToolStripMenuItem.Enabled = lstContacts.SelectedItems.Count > 0;
            deleteToolStripMenuItem.Enabled = lstContacts.SelectedItems.Count > 0;


        }

    }
    //all our contacts are objects of this Contact Class
    class Contact
    { 
        public string sFirstName { get; set; }
        public string sLastName { get; set; }
        public string sPhone { get; set; }
        public string sEmail { get; set; }
        public string sAddress { get; set; }
        public string sNotes { get; set; }
    }





}
