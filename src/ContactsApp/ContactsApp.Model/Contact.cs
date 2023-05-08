using Newtonsoft.Json;
using System;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using System.Linq;

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
                if (!IsOnlyLetters(value))
                {
                    throw new ArgumentException("Full Name contain non-letter characters!");
                }
                else if (value.Length > 100)
                {
                    throw new ArgumentException("Full Name is too big (maximum 100 symbols, including spaces)!");
                }
                else if (value.Length == 0)
                {
                    throw new ArgumentException("Full Name is empty!");
                }
                else
                {
                    _fullName = value;
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
                if (value.Length > 100)
                {
                    throw new ArgumentException("E-mail is too big (maximum 100 symbols, including spaces)!");
                }
                else if( value.Length == 0)
                {
                    throw new ArgumentException("E-mail is empty!");
                }
                else
                {
                    _email = value;
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
                if (value.Length == 0 || String.Join("", Regex.Split(value, @"\D+").Where(s => s != "").ToArray()) == "7")
                {
                    throw new ArgumentException("Phone is empty!");
                    
                }
                else
                {
                    _phone = value;
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

        public Contact()
        {
        }

        /// <summary>
        /// Клонирует данный экземпляр <see cref="Contact">.
        /// </summary>
        public object Clone()
        {
            return MemberwiseClone();
        }
        /// <summary>
        /// Проверка на наличие небуквенных символов в строке
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