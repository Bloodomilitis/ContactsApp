using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ContactsApp.Model

{
    /// <summary>
    /// Описывает проект.
    /// </summary>
   public class Project
    {
        /// <summary>
        /// список всех контактов.
        /// </summary>
        private List<Contact> _Contacts;

        /// <summary>
        /// Возвращает или задает список всех контактов.
        /// </summary>
        public List<Contact> contacts
        {
            get { return _Contacts; }
            set { _Contacts = value; }
        }

        /// <summary>
        /// Сортировка списка контактов по полному имени
        /// </summary>
        public void Sort()
        {
            contacts.Sort((left, right) => left.fullName.CompareTo(right.fullName));
            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }
        /// <summary>
        /// Добавление в список нового контакта и автоматическая сортировка
        /// </summary>
        public void AddContact(Contact NewContact)
        {
            contacts.Add(NewContact);
            Sort();
        }
        /// <summary>
        /// Удаляет объект <see cref="Contact"> 
        /// </summary>
        public void DeleteContact(int DeletedContactId)
        {
            contacts.RemoveAt(DeletedContactId);
            Sort();
        }
        /// <summary>
        /// Возвращает список объектов <see cref="Contact">, одно из полей которых содержит подаваемый паттерн.
        /// </summary>
        public List<Contact> SearchContacts(string pattern)
        {
            Regex regex = new Regex(@"\w*" + pattern + @"\w*", RegexOptions.Compiled | RegexOptions.IgnoreCase);   
            return contacts.FindAll(e => regex.IsMatch(e.fullName));
        }
        /// <summary>
        /// Возвращает список объектов <see cref="Contact">, чей день и месяц рождения равны сегодняшнему.
        /// </summary>
        public List<Contact> Celebrants()
        {
            List<Contact> Celebrants = contacts.Where(contact => contact.birthday.Day == DateTime.Now.Day && contact.birthday.Month == DateTime.Now.Month).ToList();
            Celebrants.Sort((left, right) => left.fullName.CompareTo(right.fullName));
            return Celebrants;
        }
        /// <summary>
        /// Создает экземпляр <see cref="Project">.
        /// </summary>
        public Project() { 
            contacts = new List<Contact>();
        }
        
    }
}
