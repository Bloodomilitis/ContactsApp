using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RemoveContactButton_MouseMove(object sender, MouseEventArgs e)
        {
            //#FАF5F5
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
            ContactForm newForm = new ContactForm();
            newForm.Show();
        }

        private void EditContactButton_Click(object sender, EventArgs e)
        {
            ContactForm newForm = new ContactForm();
            newForm.Show();
        }
    }
}
