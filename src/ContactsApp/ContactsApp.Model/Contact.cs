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
        private string FullName;
        public string fullName
        {
            get { return FullName; }
            set
            {
                if (value.Length != 0 && value.Length <= 100)
                {

                    FullName = value;
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
        
        private string Mail;
        public string mail
        {
            get { return Mail; }
            set {
                if (value.Length != 0 && value.Length <= 100)
                {

                    Mail = value;
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
        
        private string Phone;
        public string phone
        {
            get { return Phone; }
            set {
                if (value.Length != 0)
                {

                    Phone = value;
                }
                else
                {
                    throw new ArgumentException("Phone is empty!");
                }
            }
        }
        
        private DateTime Birthday;   
        public DateTime birthday
        {
            get { return Birthday; }
            set
            {
                if (value.Year >= 1900 && value.Date < DateTime.Now)
                {
                    Birthday = value;
                }
                else
                {
                    throw new ArgumentException("Wrong date of Birthday!");
                }
            }
        }
       
        private string IdVK;
        public string idVK
        {
            get { return IdVK; }
            set {
                if (value.Length <= 50)
                {

                    IdVK = value;
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