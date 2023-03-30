using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    internal class Project
    {
        private List<Contact> _Contacts;

        public List<Contact> contacts
        {
            get { return _Contacts; }
            set { _Contacts = value; }
        }


        public void Sort()
        {
            contacts.Sort((left, right) => left.fullName.CompareTo(right.fullName));
            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }
        public void AddContact(Contact NewContact)
        {
            contacts.Add(NewContact);
            Sort();
        }
        public void DeleteContact(Contact DeletedContact)
        {
            contacts.Remove(DeletedContact);
            Sort();
        }
        public List<Contact> SearchContacts(string pattern)
        {
            Regex regex = new Regex(@"\w*" + pattern + @"\w*", RegexOptions.Compiled | RegexOptions.IgnoreCase);   
            return contacts.FindAll(e => regex.IsMatch(e.fullName) || regex.IsMatch(e.mail) || regex.IsMatch(e.phone) || regex.IsMatch(e.fullName));
        }
        public Project() { 
            contacts = new List<Contact>();
        }
    }
}
