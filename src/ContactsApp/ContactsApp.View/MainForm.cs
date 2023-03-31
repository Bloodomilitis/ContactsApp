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
using Microsoft.Build.Evaluation;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace ContactsApp.View
{
    /// <summary>
    /// Описывает главное окно приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Проект, хранящий информацию о всех контактах.
        /// </summary>
        private Model.Project _project;
        /// <summary>
        /// Менеджер проекта.
        /// </summary>
        private Model.ProjectSerializer _projectSerializer;
        /// <summary>
        /// Список отображаемых контактов.
        /// </summary>
        private List<Contact> _currentContacts;
        /// <summary>
        /// Служебные генераторы случайных слов и чисел указанной длины, а также дат и контакта.
        /// </summary>
        private static readonly Random randomInstance = new Random();
        public static int GenerateRandomNumber(int min, int max)
        {
            lock (randomInstance) // synchronize
            {
                return randomInstance.Next(min, max);
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
            Char[] pwdChars = new Char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            string number = String.Empty;
            for (int i = 0; i < length; i++)
                number += pwdChars[GenerateRandomNumber(0, 9)];
            return number;
        }
        DateTime RandomDate()
        {

            DateTime date = new DateTime(GenerateRandomNumber(1900, DateTime.Now.Year - 1), GenerateRandomNumber(1, 12), GenerateRandomNumber(1, 28));
            return date;
        }
        private void AddRandomContact()
        {

            _project.AddContact(new Contact(RandomWord(GenerateRandomNumber(6, 12)) + " " + RandomWord(GenerateRandomNumber(4, 8)),
                RandomWord(GenerateRandomNumber(6, 12)) + "@mail.ru",
                RandomNumber(10),
                DateTime.Now.Date,
                ""));
            UpdateListBox();
        }

        /// <summary>
        /// Создает  экземпляр <see cref="MainForm"> и загружает в него данные из файла.
        /// </summary>
        public MainForm()
        {
            _projectSerializer = new ProjectSerializer();
            _project = _projectSerializer.LoadFromFile();
            InitializeComponent();            
        }
        /// <summary>
        /// Выполняет проверки после загрузки формы.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {

            if (_project.contacts.Count == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    AddRandomContact();
                }
                _projectSerializer.SaveToFile(_project);
            }
            UpdateListBox();
            CelebrantsCheck();
        }
        /// <summary>
        /// Изменение иконки кнопки удаления контакта при наличии или отсутвии над ней курсора.
        /// </summary>
        private void RemoveContactButton_MouseMove(object sender, MouseEventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32;
        }
        private void RemoveContactButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32_gray;
        }
        /// <summary>
        /// Изменение иконки кнопки изменения контакта при наличии или отсутвии над ней курсора.
        /// </summary>
        private void EditContactButton_MouseMove(object sender, MouseEventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32;
        }
        private void EditContactButton_MouseLeave(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32_gray;
        }
        /// <summary>
        /// Изменение иконки кнопки добавления контакта при наличии или отсутвии над ней курсора.
        /// </summary>
        private void AddContactButton_MouseMove(object sender, MouseEventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32;
        }
        private void AddContactButton_MouseLeave(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32_gray;
        }
        /// <summary>
        /// Закрывает панель уведомления об именинниках.
        /// </summary>
        private void CloseMessageButton_Click(object sender, EventArgs e)
        {
            MessagePanel.Visible = false;
        }
        /// <summary>
        /// Проверка на именинников и вывод соответствующей панели.
        /// </summary>
        private void CelebrantsCheck()
        {
            if (_project.Celebrants().Count > 0)
            {
                Celebrantsabel.Text = "";
                foreach (Contact celebrants in _project.Celebrants())
                {
                    if (Celebrantsabel.Text.Split().Length < 5)
                    {
                        Celebrantsabel.Text += celebrants.fullName.Split().First() + ", ";
                    }
                    else
                    {
                        Celebrantsabel.Text = Celebrantsabel.Text.Remove(Celebrantsabel.Text.Length - 2);
                        Celebrantsabel.Text += "...";
                        break;
                    }
                }
                MessagePanel.Visible = true;
            }
            else
            {
                MessagePanel.Visible = false;
            }
            UpdateListBox();
        }
        /// <summary>
        /// Обновление списка контактов.
        /// </summary>
        private void UpdateListBox()
        {
            ContactsList.Items.Clear();
            if (FindBox.Text != "")
            {
                _currentContacts = _project.SearchContacts(FindBox.Text);
                foreach (Contact contact in _currentContacts)
                {

                    ContactsList.Items.Add(contact.fullName);
                }

            }
            else
            {
                _currentContacts = _project.contacts;
                foreach (Contact contact in _currentContacts)
                {
                    ContactsList.Items.Add(contact.fullName);
                }
            }

        }
        /// <summary>
        /// Реакция на изменение индекса выбранного контакта в ContactList.
        /// </summary>
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
        /// <summary>
        /// Вывод информации выбранного контакта в полях правой части формы.
        /// </summary>
        private void UpdateSelectedContact(int index)
        {
            FullNameBox.Text = _project.contacts[_project.contacts.IndexOf(_currentContacts[index])].fullName;
            MailTextBox.Text = _project.contacts[_project.contacts.IndexOf(_currentContacts[index])].mail;
            PhoneNumberBox.Text = _project.contacts[_project.contacts.IndexOf(_currentContacts[index])].phone;
            DateBox.Text = _project.contacts[_project.contacts.IndexOf(_currentContacts[index])].birthday.ToShortDateString();
            VKBox.Text = _project.contacts[_project.contacts.IndexOf(_currentContacts[index])].idVK;
        }
        /// <summary>
        /// Очищение полей в правой части формы.
        /// </summary>
        private void ClearSelectedContact()
        {
            FullNameBox.Text = "";
            MailTextBox.Text = "";
            PhoneNumberBox.Text = "";
            DateBox.Text = "";
            VKBox.Text = "";
        }
        /// <summary>
        /// Реакция на изменение текста в FindBox.
        /// </summary>
        private void FindBox_TextChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }
        /// <summary>
        /// Вызов AboutForm при нажатии на F1.
        /// </summary>
        private void MainForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            AboutForm newForm = new AboutForm();
            newForm.Show();
        }
        /// <summary>
        /// Вызов ContactForm и добавление нового контакта.
        /// </summary>
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            var Contact = new ContactForm(new Contact(RandomWord(GenerateRandomNumber(6, 12)) + " " + RandomWord(GenerateRandomNumber(4, 8)),
                RandomWord(GenerateRandomNumber(6, 12)) + "@mail.ru",
                RandomNumber(10),
                RandomDate(),
                "")); //Создаем форму
            Contact.ShowDialog(); //Отображаем форму для редактирования

            if (Contact.DialogResult == DialogResult.OK)
            {
                _project.AddContact(Contact.Contact); //Забираем измененные данные
                UpdateListBox();
                _projectSerializer.SaveToFile(_project);
            }
        }
        /// <summary>
        /// Вызов ContactForm и изменение выбранного контакта.
        /// </summary>
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            if (ContactsList.SelectedIndex!=-1)
            {
                var Contact = new ContactForm((Contact)_project.contacts[_project.contacts.IndexOf(_currentContacts[ContactsList.SelectedIndex])].Clone()); //Создаем форму
                Contact.ShowDialog(); //Отображаем форму для редактирования

                if (Contact.DialogResult == DialogResult.OK)
                {
                    _project.contacts.RemoveAt(ContactsList.SelectedIndex);
                    _project.AddContact(Contact.Contact); //Забираем измененные данные
                    UpdateListBox();
                    _projectSerializer.SaveToFile(_project);
                }
            }
        }
        /// <summary>
        /// Удаление выбранного контакта.
        /// </summary>
        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            RemoveContact(_project.contacts.IndexOf(_currentContacts[ContactsList.SelectedIndex]));
            UpdateListBox();
            _projectSerializer.SaveToFile(_project);
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
        /// <summary>
        /// Вывод уведомления на закрытие формы и закрытие при подтверждении.
        /// </summary>
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
