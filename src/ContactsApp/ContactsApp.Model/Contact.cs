using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ContactsApp.Model
{
    /// <summary>
    /// Описывает контакт.
    /// </summary>
    public class Contact : ICloneable
    {
        /// <summary>
        /// Полное имя контакта.
        /// </summary>
        private string _fullName;
        /// <summary>
        /// Возвращает или задае тполное имя контакта.
        /// </summary>
        public string fullName
        {
            get { return _fullName; }
            set
            {
                if (value.Length != 0 && value.Length <= 100 && OnlyLetters(value))
                {

                    _fullName = value;
                }
                else if (!OnlyLetters(value))
                {
                    throw new ArgumentException("Full Name contain number(s)!");
                }
                else if (value.Length >100)
                {
                    throw new ArgumentException("Full Name is too big (maximum 100 symbols, including spaces)!");
                }
                else
                {
                    throw new ArgumentException("Full Name is empty!");
                }
            }

        }
        /// <summary>
        /// Почтовый ящик контакта.
        /// </summary>
        private string _mail;
        /// <summary>
        /// Возвращает или задает почтовый ящик контакта.
        /// </summary>
        public string mail
        {
            get { return _mail; }
            set {
                if (value.Length != 0 && value.Length <= 100)
                {

                    _mail = value;
                }
                else if (value.Length > 100)
                {
                    throw new ArgumentException("E-mail is too big (maximum 100 symbols, including spaces)!");
                }
                else
                {
                    throw new ArgumentException("E-mail is empty!");
                }
            }
        }
        /// <summary>
        /// Телефонный номер контакта.
        /// </summary>
        private string _phone;
        /// <summary>
        /// Возвращает или задает телефонный номер контакта.
        /// </summary>
        public string phone
        {
            get { return _phone; }
            set {
                if (value.Length != 0)
                {

                    _phone = value;
                }
                else
                {
                    throw new ArgumentException("Phone is empty!");
                }
            }
        }
        /// <summary>
        /// Дата рождения контакта.
        /// </summary>
        private DateTime _birthday;
        /// <summary>
        /// Возвращает или задает дату рождения контакта.
        /// </summary>
        public DateTime birthday
        {
            get { return _birthday; }
            set
            {
                if (value.Year >= 1900 && value.Date < DateTime.Now)
                {
                    _birthday = value;
                }
                else
                {
                    throw new ArgumentException("Wrong date of Birthday!");
                }
            }
        }
        /// <summary>
        /// Номер ИД в ВК контакта.
        /// </summary>
        private string _idVK;
        /// <summary>
        /// Возвращает или задает номер ИД в ВК контакта.
        /// </summary>
        public string idVK
        {
            get { return _idVK; }
            set {
                if (value.Length <= 50)
                {

                    _idVK = value;
                }
                else
                {
                    throw new ArgumentException("VK id is too big (maximum 50 symbols)!");
                }
            }
        }
        /// <summary>
        /// Создает экземпляр <see cref="Contact">.
        /// </summary>
        public Contact(string name, string mail, string phone, DateTime birthday, string idvk)
        {
            this.fullName = name;
            this.mail = mail;
            this.phone = phone;
            this.birthday = birthday;
            this.idVK = idvk;
        }
        /// <summary>
        /// Клонирует данный экземпляр <see cref="Contact">.
        /// </summary>
        public object Clone()
        {
            return MemberwiseClone();
        }
        public bool OnlyLetters(string str)
        {
            foreach (char c in str)
            {
                if (c >= '0' && c <= '9')
                    return false;
            }
            return true;

        }
    }
}