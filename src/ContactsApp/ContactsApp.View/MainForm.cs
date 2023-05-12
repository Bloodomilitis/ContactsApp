using ContactsApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
        private Project _project;

        /// <summary>
        /// Менеджер проекта.
        /// </summary>
        private ProjectSerializer _projectSerializer;

        /// <summary>
        /// Список отображаемых контактов.
        /// </summary>
        private List<Contact> _currentContacts;

        /// <summary>
        /// генератор случайных чисел.
        /// </summary>
        private static readonly Random randomInstance = new Random();
        /// <summary>
        /// генератор случайного числа в указанном диапазоне.
        /// </summary>
        public static int GenerateRandomNumber(int min, int max)
        {
            lock (randomInstance) // synchronize
            {
                return randomInstance.Next(min, max);
            }
        }
        /// <summary>
        /// генератор случайного слова указанной длины.
        /// </summary>
        private string RandomWord(int length)
        {
            Random rnd = new Random();
            string word = String.Empty;
            for (int i = 0; i < length; i++)
                word += (char) GenerateRandomNumber(97, 122);
            return word;
        }
        /// <summary>
        /// Служебный генератор случайного числа указанной длины.
        /// </summary>
        private string RandomNumber(int length)
        {
            string number = String.Empty;
            for (int i = 0; i < length; i++)
                number += GenerateRandomNumber(0, 9);
            return number;
        }
        /// <summary>
        /// генератор случайной даты от 1 января 1900 года по сегодняшний день.
        /// </summary>
        DateTime RandomDate()
        {

            DateTime date = new DateTime(GenerateRandomNumber(1900, DateTime.Now.Year), GenerateRandomNumber(1, 12), GenerateRandomNumber(1, 28));
            return date;
        }

        /// <summary>
        /// генератор контакта со случайными параметрами.
        /// </summary>
        private void AddRandomContact()
        {

            _project.AddContact(new Contact(
                RandomWord(GenerateRandomNumber(6, 12)) + " " + RandomWord(GenerateRandomNumber(4, 8)),
                RandomWord(GenerateRandomNumber(6, 12)) + "@mail.ru",
                RandomNumber(10),
                DateTime.Now.Date,
                ""));
        }

        /// <summary>
        /// Проверка на именинников и вывод соответствующей панели.
        /// </summary>
        private void CelebrantsCheck()
        {
            var contacts = _project.Celebrants();
            if (contacts.Count == 0)
            {
                MessagePanel.Visible = false;
                return;
            }

            var surnames =
                contacts.Select(contact => contact.FullName.Split().First()).ToList();
            surnames = surnames.Take(Math.Min(surnames.Count, 5)).ToList();
            var fullText = string.Join(", ", surnames);
            CelebrantsLabel.Text = fullText;
            MessagePanel.Visible = true;
        }

        /// <summary>
        /// Обновление списка контактов.
        /// </summary>
        private void UpdateListBox()
        {
            ContactsList.Items.Clear();
            if (FindBox.Text != "")
            {
                _currentContacts = _project.SearchContactsByPattern(FindBox.Text);
                foreach (Contact contact in _currentContacts)
                {
                    ContactsList.Items.Add(contact.FullName);
                }

            }
            else
            {
                _currentContacts = _project.Contacts;
                foreach (Contact contact in _currentContacts)
                {
                    ContactsList.Items.Add(contact.FullName);
                }
            }
        }

        /// <summary>
        /// Вывод информации выбранного контакта в полях правой части формы.
        /// </summary>
        private void UpdateSelectedContact(int index)
        {
            var currentContact = _currentContacts[index];
            FullNameBox.Text = currentContact.FullName;
            MailTextBox.Text = currentContact.Email;
            PhoneNumberBox.Text = currentContact.Phone;
            DateBox.Text = currentContact.DateOfBirth.ToShortDateString();
            VKBox.Text = currentContact.IdVK;
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
            _project.Sort();
            _projectSerializer.SaveToFile(_project);
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
            /*var Contact = new ContactForm(new Contact(RandomWord(GenerateRandomNumber(6, 12)) + " " + RandomWord(GenerateRandomNumber(4, 8)),
                RandomWord(GenerateRandomNumber(6, 12)) + "@mail.ru",
                RandomNumber(10),
                RandomDate(),
                "")); //Создаем форму
            */
            var Contact = new ContactForm();
            Contact.ShowDialog(); //Отображаем форму для редактирования

            if (Contact.DialogResult == DialogResult.OK)
            {
                _project.AddContact(Contact.Contact); //Забираем измененные данные
                _project.Sort();
                UpdateListBox();
                _projectSerializer.SaveToFile(_project);
            }
        }

        /// <summary>
        /// Вызов ContactForm и изменение выбранного контакта.
        /// </summary>
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            if (ContactsList.SelectedIndex != -1)
            {
                var Contact = new ContactForm((Contact)_project.Contacts[_project.Contacts.IndexOf(_currentContacts[ContactsList.SelectedIndex])].Clone()); //Создаем форму
                Contact.ShowDialog(); //Отображаем форму для редактирования

                if (Contact.DialogResult == DialogResult.OK)
                {
                    _project.Contacts.RemoveAt(_project.Contacts.IndexOf(_currentContacts[ContactsList.SelectedIndex]));
                    _project.AddContact(Contact.Contact); //Забираем измененные данные
                    _project.Sort();
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
            RemoveContact(_project.Contacts.IndexOf(_currentContacts[ContactsList.SelectedIndex]));
            _project.Sort();
            UpdateListBox();
            ClearSelectedContact();
            _projectSerializer.SaveToFile(_project);
        }
        private void RemoveContact(int index)
        {
            if (index != -1)
            {

            }
            var result = MessageBox.Show("Do you really want to remove " + ContactsList.SelectedItem,
                                                        "Remove contact?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _project.Contacts.RemoveAt(index);
                UpdateListBox();
            }
        }

        /// <summary>
        /// Вывод уведомления на закрытие формы и закрытие при подтверждении.
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Do you really want to close app?", "Closing app", MessageBoxButtons.YesNo);
            e.Cancel = result != DialogResult.Yes;
        }
    }
}
