using Newtonsoft.Json;
using System;

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
        /// Возвращает или задает полное имя контакта.
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set
            {
                if (value.Length != 0 && value.Length <= 100 && IsOnlyLetters(value))
                {

                    _fullName = value;
                }
                else if (!IsOnlyLetters(value))
                {
                    throw new ArgumentException("Full Name contain number(s)!");
                }
                else if (value.Length > 100)
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
        public string Mail
        {
            get { return _mail; }
            set
            {
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
        public string Phone
        {
            get { return _phone; }
            set
            {
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
        public DateTime Birthday
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
        public string IdVK
        {
            get { return _idVK; }
            set
            {
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
        [JsonConstructor]
        public Contact(string fullName, string mail, string phone, DateTime birthday, string idVK)
        {
            this.FullName = fullName;
            this.Mail = mail;
            this.Phone = phone;
            this.Birthday = birthday;
            this.IdVK = idVK;
        }
        
        /// <summary>
        /// Клонирует данный экземпляр <see cref="Contact">.
        /// </summary>
        public object Clone()
        {
            return MemberwiseClone();
        }
        /// <summary>
        /// Проверка на наличие чисел в строке
        /// </summary>
        public bool IsOnlyLetters(string str)
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