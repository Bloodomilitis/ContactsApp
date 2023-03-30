using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        private static readonly Random randomInstance = new Random();
        public static int GenerateRandomNumber(int min, int max)
        {
            lock (randomInstance) // synchronize
            {
                return randomInstance.Next(min, max);
            }
        }
        private Project _project;
        public MainForm()
        {
            InitializeComponent();
        }


        private void RemoveContactButton_MouseMove(object sender, MouseEventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32;
        }

        private void RemoveContactButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32_gray;
        }

        private void EditContactButton_MouseMove(object sender, MouseEventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32;
        }

        private void EditContactButton_MouseLeave(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32_gray;
        }

        private void AddContactButton_MouseMove(object sender, MouseEventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32;
        }

        private void AddContactButton_MouseLeave(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32_gray;
        }

        private void CloseMessageButton_Click(object sender, EventArgs e)
        {
            MessagePanel.Visible = false;
        }

        private void MainForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            AboutForm newForm = new AboutForm();
            newForm.Show();
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            AddContact();
            /*ContactForm newForm = new ContactForm(new Contact(RandomWord(GenerateRandomNumber(6, 12)) + " " + RandomWord(GenerateRandomNumber(4, 8)),
                RandomWord(GenerateRandomNumber(6, 12)) + "@mail.ru",
                RandomNumber(8),
                RandomDate(),
                ""));
            newForm.Show();*/
        }

        private void EditContactButton_Click(object sender, EventArgs e)
        {
            if (ContactsList.SelectedIndex!=-1)
            {
                ContactForm newForm = new ContactForm(_project.contacts[ContactsList.SelectedIndex]);
                newForm.Show();
            }
        }

        private string RandomWord(int length)
        {
            Random rnd = new Random();
            Char[] pwdChars = new Char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string word = String.Empty;
            for (int i = 0; i < length; i++)
                word += pwdChars[GenerateRandomNumber(0, 25)];
            return word;
        }
        private string RandomNumber(int length)
        {
            Char[] pwdChars = new Char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            string number = String.Empty;
            for (int i = 0; i < length; i++)
                number += pwdChars[GenerateRandomNumber(0, 9)];
            return number;
        }
        DateTime RandomDate()
        {
            
            DateTime date = new DateTime(GenerateRandomNumber(1900, DateTime.Now.Year), GenerateRandomNumber(1, 12), GenerateRandomNumber(1, 28));
            return date;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            _project= new Project();
            UpdateListBox();
        }
        private void UpdateListBox()
        {
            ContactsList.Items.Clear();
            foreach(Contact contact in _project.contacts)
            {
                ContactsList.Items.Add(contact.fullName);
            }
        }
        private void AddContact()
        { 
            _project.AddContact(new Contact(RandomWord(GenerateRandomNumber(6, 12)) + " " + RandomWord(GenerateRandomNumber(4, 8)),
                RandomWord(GenerateRandomNumber(6, 12)) + "@mail.ru",
                RandomNumber(10),
                RandomDate(),
                ""));
            UpdateListBox();
        }
        private void RemoveContact(int index)
        {
            if (index != -1)
            {
                if (MessageBox.Show("Do you really want to remove " + ContactsList.SelectedItem, "Remove contact?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    _project.contacts.RemoveAt(index);
                    UpdateListBox();
                }
            }
        }

        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsList.SelectedIndex);
            UpdateListBox();
        }

        private void ContactsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsList.SelectedIndex != -1)
            {
                UpdateSelectedContact(ContactsList.SelectedIndex);
            }
            else
            {
                ClearSelectedContact();
            }
        }
        private void UpdateSelectedContact(int index)
        {
            FullNameBox.Text= _project.contacts[index].fullName;
            MailTextBox.Text = _project.contacts[index].mail;
            PhoneNumberBox.Text = _project.contacts[index].phone;
            DateBox.Text = _project.contacts[index].birthday.ToShortDateString();
            VKBox.Text = _project.contacts[index].idVK;
        }
        private void ClearSelectedContact()
        {
            FullNameBox.Text = "";
            MailTextBox.Text = "";
            PhoneNumberBox.Text = "";
            DateBox.Text = "";
            VKBox.Text = "";
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            FullNameLabel.Text = e.KeyCode.ToString();
            if (e.KeyCode == Keys.Delete && ContactsList.SelectedIndex != -1)
            {
                RemoveContact(ContactsList.SelectedIndex);
                e.Handled = true;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ;
            if (MessageBox.Show("Do you really want to close app?", "Closing app", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
