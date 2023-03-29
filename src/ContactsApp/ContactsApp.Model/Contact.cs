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
        public string FullName { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public DateTime Birthday { get; set; }
        public string idVK { get; set; }
        public Contact(string name, string mail, string phone, DateTime birthday, string idvk)
        {
            FullName = name;
            Mail = mail;
            Phone = phone;
            Birthday = birthday;
            idVK = idvk;
        }
        public string PhoneFormat(string phone)
        {
            Regex r = new Regex(@"[\d+()-]"); // Соответствуют только цифры и знаки ‘+’, ‘(’ ‘)’ ‘-’.
            return "";
        }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}