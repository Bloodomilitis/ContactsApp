using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ContactsApp.Model

{
    /// <summary>
    /// Описывает проект.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Возвращает или задает список всех контактов.
        /// </summary>
        public List<Contact> Contacts { get; set; }

        /// <summary>
        /// Сортировка списка контактов по полному имени
        /// </summary>
        public void Sort()
        {
            Contacts.Sort((left, right) => left.FullName.CompareTo(right.FullName));
        }

        /// <summary>
        /// Добавление в список нового контакта и автоматическая сортировка
        /// </summary>
        public void AddContact(Contact NewContact)
        {
            Contacts.Add(NewContact);
        }

        /// <summary>
        /// Удаляет объект <see cref="Contact"> 
        /// </summary>
        public void DeleteContact(int DeletedContactId)
        {
            Contacts.RemoveAt(DeletedContactId);
        }

        /// <summary>
        /// Возвращает список объектов <see cref="Contact">, одно из полей которых содержит подаваемый паттерн.
        /// </summary>
        public List<Contact> SearchContactsByPattern(string pattern)
        {
            Regex regex = new Regex(@"\w*" + pattern + @"\w*", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            return Contacts.FindAll(e => regex.IsMatch(e.FullName));
        }

        /// <summary>
        /// Возвращает список объектов <see cref="Contact">, чей день и месяц рождения равны сегодняшнему.
        /// </summary>
        public List<Contact> Celebrants()
        {
            List<Contact> Celebrants = Contacts.Where(contact => contact.DateOfBirth.Day == DateTime.Now.Day && contact.DateOfBirth.Month == DateTime.Now.Month).ToList();
            Celebrants.Sort((left, right) => left.FullName.CompareTo(right.FullName));
            return Celebrants;
        }

        /// <summary>
        /// Создает пустой экземпляр <see cref="Project">.
        /// </summary>
        public Project()
        {
            Contacts = new List<Contact>();
        }

        /// <summary>
        /// Создает экземпляр <see cref="Project"> с указанным списком контактов.
        /// </summary>
        [JsonConstructor]
        public Project(List<Contact> contacts)
        {
            this.Contacts = contacts;
        }
    }
}
