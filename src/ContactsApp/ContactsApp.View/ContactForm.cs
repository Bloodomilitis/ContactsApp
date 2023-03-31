using ContactsApp.Model;
using System;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ContactsApp.View
{
    /// <summary>
    /// Описывает второстепенное окно приложения.
    /// </summary>
    public partial class ContactForm : Form
    {
        /// <summary>
        /// Активный контакт.
        /// </summary>
        private Contact _contact;
        
        /// <summary>
        /// Возвращает или задает контакт.
        /// </summary>
        public Contact Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                _contact = value;
                if (_contact != null)
                {
                    UpdateForm();
                }
            }
        }
        
        /// <summary>
        /// Сообщения об ошибках в каждом поле.
        /// </summary>
        private string _fullNameError, _emailError, _phoneError, _vkError;
       
        /// <summary>
        /// Создает  экземпляр <see cref="ContactForm">  с пустым контактом.
        /// </summary>
        public ContactForm()
        {
            InitializeComponent();
            DatePicker.MaxDate= DateTime.Now.Date;
            Contact = new Contact(" ", " ", " ", DatePicker.MinDate, " ");
            _fullNameError = "";
            _emailError = "";
            _phoneError = "";
            _vkError = "";
        }
        
        /// <summary>
        /// Создает  экземпляр <see cref="ContactForm">  с указанным контактом.
        /// </summary>
        public ContactForm(Contact contact)
        {
            InitializeComponent();
            DatePicker.MaxDate = DateTime.Now.Date;         
            Contact = contact;
            FormatNumber();
            _fullNameError = "";
            _emailError = "";
            _phoneError = "";
            _vkError = "";
        }
        
        /// <summary>
        /// Обновля поля ввода информацией из активного контакта.
        /// </summary>    
        private void UpdateForm()
        {
            FullNameTextBox.Text = _contact.FullName;
            MailTextBox.Text = _contact.Mail;
            PhoneNumberBox.Text = _contact.Phone;
            DatePicker.Value = _contact.Birthday;
            VKBox.Text = _contact.IdVK;
        }
        
        /// <summary>
        /// Изменение иконки кнопки добавления фото при наличии или отсутвии над ней курсора.
        /// </summary>
        private void ChoosePhotoButton_MouseMove(object sender, MouseEventArgs e)
        {
            ChoosePhotoButton.Image = Properties.Resources.add_photo_32x32;
        }
        private void ChoosePhotoButton_MouseLeave(object sender, EventArgs e)
        {
            ChoosePhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
        }
        
        /// <summary>
        /// Устанавливает DialogResult на значение No и закрывает форму
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }
        
        /// <summary>
        /// Вывод уведомления на закрытие формы и закрытие при подтверждении.
        /// </summary>
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (CheckFormsOnErrors())
            {
                UpdateContact();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        
        /// <summary>
        /// При выборе удаляет из поля телефона все нечисловые символы и телефонный код России.
        /// </summary>
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
        
        /// <summary>
        /// Автоматическое форматирование номера под шаблон "+7 (###) ###-##-##" при выходе из поля.
        /// </summary>
        private void PhoneNumberBox_Leave(object sender, EventArgs e)
        {
            FormatNumber();
            try
            {
                _contact.   Phone = PhoneNumberBox.Text;
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
        
        /// <summary>
        /// Проверка на правильность формата имени
        /// </summary>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.FullName = FullNameTextBox.Text;
                _fullNameError = "";
                FullNameTextBox.BackColor = Color.White;
            }
            catch (ArgumentException ex)
            {
                _fullNameError = ex.Message;
                FullNameTextBox.BackColor = Color.LightPink;
            }
        }
        
        /// <summary>
        /// Проверка на правильность формата телефона
        /// </summary>
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
        
        /// <summary>
        /// Проверка на правильность формата почты
        /// </summary>
        private void MailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Mail = MailTextBox.Text;
                _emailError = "";
                MailTextBox.BackColor = Color.White;
            }
            catch (ArgumentException ex)
            {
                _emailError = ex.Message;
                MailTextBox.BackColor = Color.LightPink;
            }
        }
        
        /// <summary>
        /// Проверка на правильность формата ИД ВК
        /// </summary>
        private void VKBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.IdVK = VKBox.Text;
                _vkError = "";
                VKBox.BackColor = Color.White;
            }
            catch (ArgumentException ex)
            {
                _vkError = ex.Message;
                VKBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Проверка на правильность формата имени
        /// </summary>
        private void FullNameTextBox_Leave(object sender, EventArgs e)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            FullNameTextBox.Text = ti.ToTitleCase(FullNameTextBox.Text);
        }
        
        /// <summary>
        /// Проверка на наличие сообщений об ошибке
        /// </summary>
        private bool CheckFormsOnErrors()
        {
            //_fullNameError, _emailError, _dateError, _phoneError, _vkError
            if (_fullNameError != "")
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
            if (_vkError != "")
            {
                MessageBox.Show(_vkError);
            }
            if (_fullNameError != "" || _emailError != "" || _phoneError != "" || _vkError != "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        /// <summary>
        /// Обновление полей активного контакта
        /// </summary>
        private void UpdateContact()
        {
            _contact.FullName = FullNameTextBox.Text;
            _contact.Mail = MailTextBox.Text;
            _contact.Phone = PhoneNumberBox.Text;
            _contact.Birthday = DatePicker.Value;
            _contact.IdVK = VKBox.Text;
        }
    }
}
