using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ContactsApp.View
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        private void ChoosePhotoButton_MouseMove(object sender, MouseEventArgs e)
        {
            ChoosePhotoButton.Image = Properties.Resources.add_photo_32x32;
        }

        private void ChoosePhotoButton_MouseLeave(object sender, EventArgs e)
        {
            ChoosePhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PhoneNumberBox_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[^\d]");

            string phoneNum = regex.Replace(PhoneNumberBox.Text, "");
            if (phoneNum.Length > 0)
            {
                if (phoneNum.Length > 10)
                {
                    phoneNum = phoneNum.Substring(0, 9);
                }
                phoneNum = Convert.ToInt64(phoneNum).ToString().PadRight(10, '0'); ;
                PhoneNumberBox.Text = Convert.ToInt64(phoneNum).ToString("+7 (###) ###-##-##");
            }
        }

        private void FullNameTextBox_Enter(object sender, EventArgs e)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            FullNameTextBox.Text = ti.ToTitleCase(FullNameTextBox.Text);
            if (FullNameTextBox.Text.Length > 100)
            {
                FullNameTextBox.Text = FullNameTextBox.Text.Substring(0, 100);
            }
        }

        private void MailTextBox_Enter(object sender, EventArgs e)
        {
            if (MailTextBox.Text.Length > 100)
            {
                MailTextBox.Text = MailTextBox.Text.Substring(0, 100);
            }
        }

        private void VKBox_Enter(object sender, EventArgs e)
        {
            if (VKBox.Text.Length > 50)
            {
                VKBox.Text = MailTextBox.Text.Substring(0, 50);
            }
        }
    }
}
