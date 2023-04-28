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
        /// Почтовый ящик контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Телефонный номер контакта.
        /// </summary>
        private string _phone;

        /// <summary>
        /// Дата рождения контакта.
        /// </summary>
        private DateTime _dateOfBirth;
        /// <summary>
        /// Номер ИД в ВК контакта.
        /// </summary>
        private string _idVK;
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
        /// Возвращает или задает почтовый ящик контакта.
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                if (value.Length != 0 && value.Length <= 100)
                {

                    _email = value;
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
        /// Возвращает или задает дату рождения контакта.
        /// </summary>
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set
            {
                if (value.Year >= 1900 && value.Date < DateTime.Now)
                {
                    _dateOfBirth = value;
                }
                else
                {
                    throw new ArgumentException("Wrong date of Birthday!");
                }
            }
        }
        
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
        public Contact(string fullName, string email, string phone, DateTime dateOfBirth, string idVK)
        {
            this.FullName = fullName;
            this.Email = email;
            this.Phone = phone;
            this.DateOfBirth = dateOfBirth;
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
        public bool IsOnlyLetters(string value)
        {
            foreach (char c in value)
            {
                if (c >= '0' && c <= '9')
                    return false;
            }
            return true;

        }
    }
}