using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ContactsApp.Model;
using static System.Net.Mime.MediaTypeNames;

namespace ContactsApp.View
{
    public partial class ContactForm : Form
    {
        private Contact _contact;
        private string _fullNameError, _emailError, _dateError, _phoneError, _vkError;
        public ContactForm()
        {
            InitializeComponent();

        }
        public ContactForm(Contact contact)
        {
            InitializeComponent();
            _contact = contact;
            UpdateForm();
            FormatNumber();
            _fullNameError = "";
            _emailError = "";
            _dateError = "";
            _phoneError = "";
            _vkError = "";
        }

        private void UpdateForm()
        {
            FullNameTextBox.Text = _contact.fullName;
            MailTextBox.Text = _contact.mail;
            PhoneNumberBox.Text = _contact.phone;
            DatePicker.Value = _contact.birthday;
            VKBox.Text = _contact.idVK;
        }

        private void ChoosePhotoButton_MouseMove(object sender, MouseEventArgs e)
        {
            ChoosePhotoButton.Image = Properties.Resources.add_photo_32x32;
        }

        private void ChoosePhotoButton_MouseLeave(object sender, EventArgs e)
        {
            ChoosePhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PhoneNumberBox_Leave(object sender, EventArgs e)
        {
            FormatNumber();
            try
            {
                _contact.phone = PhoneNumberBox.Text;
            }
            catch (ArgumentException ex)
            {
                _phoneError = ex.Message;
                PhoneNumberBox.BackColor = Color.LightPink;
            }
        }
        private void FormatNumber()
        {
            Regex regex = new Regex(@"[^\d]");
            string phoneNum = PhoneNumberBox.Text;
            if (phoneNum.StartsWith("+7"))
            {
                phoneNum = phoneNum.Remove(0, 2);
            }
            phoneNum = regex.Replace(phoneNum, "");
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
        private void PhoneNumberBox_Enter(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[^\d]");
            string phoneNum = PhoneNumberBox.Text;
            if (phoneNum.StartsWith("+7"))
            {
                phoneNum = phoneNum.Remove(0, 2);
            }
            PhoneNumberBox.Text = regex.Replace(phoneNum, "");
        }

        private void VKBox_Enter(object sender, EventArgs e)
        {
            if (VKBox.Text.Length > 50)
            {
                VKBox.Text = MailTextBox.Text.Substring(0, 50);
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if(CheckFormsOnErrors())
            {
                UpdateContact();
                Close();
            }
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.fullName = FullNameTextBox.Text;
                _fullNameError = "";
                FullNameTextBox.BackColor = Color.White;
            }
            catch (ArgumentException ex)
            {
                _fullNameError = ex.Message;
                FullNameTextBox.BackColor = Color.LightPink;
            }
        }

        private void PhoneNumberBox_TextChanged(object sender, EventArgs e)
        {
            if (PhoneNumberBox.Text.Length > 0)
            {
                _phoneError = "";
                PhoneNumberBox.BackColor = Color.White;
            }
            else
            {
                _phoneError = "Phone is empty!";
                PhoneNumberBox.BackColor = Color.LightPink;
            }
        }

        private void MailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.mail = MailTextBox.Text;
                _emailError = "";
                MailTextBox.BackColor = Color.White;
            }
            catch (ArgumentException ex)
            {
                _emailError = ex.Message;
                MailTextBox.BackColor = Color.LightPink;
            }
        }

        private void VKBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.idVK = VKBox.Text;
                _vkError = "";
                VKBox.BackColor = Color.White;
            }
            catch (ArgumentException ex)
            {
                _vkError = ex.Message;
                VKBox.BackColor = Color.LightPink;
            }
        }

        private void BirthdayPicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.birthday = DatePicker.Value;
                _dateError = "";
                DateLabel.BackColor = Color.White;
            }
            catch (ArgumentException ex)
            {
                _dateError = ex.Message;
                DateLabel.BackColor = Color.LightPink;
            }
        }

        private void BirthdayPicker_DropDown(object sender, EventArgs e)
        {
            DatePicker.ValueChanged -= BirthdayPicker_ValueChanged;
        }

        private void BirthdayPicker_CloseUp(object sender, EventArgs e)
        {
            DatePicker.ValueChanged += BirthdayPicker_ValueChanged;
            BirthdayPicker_ValueChanged(sender, e);
        }

        private bool CheckFormsOnErrors()
        {
            //_fullNameError, _emailError, _dateError, _phoneError, _vkError
            if(_fullNameError!="")
            {
                MessageBox.Show(_fullNameError);
            }
            if (_emailError != "")
            {
                MessageBox.Show(_emailError);
            }
            if (_phoneError != "")
            {
                MessageBox.Show(_phoneError);
            }
            if (_dateError != "")
            {
                MessageBox.Show(_dateError);
            }
            if (_vkError != "")
            {
                MessageBox.Show(_vkError);               
            }
            if(_fullNameError != ""|| _emailError != "" || _dateError != "" || _phoneError != "" || _vkError != "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void UpdateContact()
        {
            _contact.fullName = FullNameTextBox.Text;
            _contact.mail = MailTextBox.Text;
            _contact.phone = PhoneNumberBox.Text;
            _contact.birthday = DatePicker.Value;
            _contact.idVK = VKBox.Text;
        }
    }
}
