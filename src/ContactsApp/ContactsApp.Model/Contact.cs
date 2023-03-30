using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ContactsApp.Model
{
    internal class Contact : ICloneable
    {
        private string _FullName;
        public string fullName
        {
            get { return _FullName; }
            set
            {
                if (value.Length != 0 && value.Length <= 100)
                {

                    _FullName = value;
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
        
        private string _Mail;
        public string mail
        {
            get { return _Mail; }
            set {
                if (value.Length != 0 && value.Length <= 100)
                {

                    _Mail = value;
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
        
        private string _Phone;
        public string phone
        {
            get { return _Phone; }
            set {
                if (value.Length != 0)
                {

                    _Phone = value;
                }
                else
                {
                    throw new ArgumentException("Phone is empty!");
                }
            }
        }
        
        private DateTime _Birthday;   
        public DateTime birthday
        {
            get { return _Birthday; }
            set
            {
                if (value.Year >= 1900 && value.Date < DateTime.Now)
                {
                    _Birthday = value;
                }
                else
                {
                    throw new ArgumentException("Wrong date of Birthday!");
                }
            }
        }
       
        private string _IdVK;
        public string idVK
        {
            get { return _IdVK; }
            set {
                if (value.Length <= 50)
                {

                    _IdVK = value;
                }
                else
                {
                    throw new ArgumentException("VK id is too big (maximum 50 symbols)!");
                }
            }
        }
        
        public Contact(string name, string mail, string phone, DateTime birthday, string idvk)
        {
            this.fullName = name;
            this.mail = mail;
            this.phone = phone;
            this.birthday = birthday;
            this.idVK = idvk;
        }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}