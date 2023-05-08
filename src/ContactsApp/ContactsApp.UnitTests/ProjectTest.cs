using ContactsApp.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class ProjectTest
    {
        [Test(Description = "Позитивный тест геттера List<Contact>")]
        public void TestContactsGet_CorrectValue()
        {
            List<Contact> expected = new List<Contact>();
            var project = new Project();
            project.Contacts = expected;
            var actual = project.Contacts;
            Assert.AreEqual(expected, actual, "Геттер List<Contact> возвращает неправильный список контактов");
        }
        [Test(Description = "Позитивный тест добавления контакта в список")]
        public void TestAddContact()
        {
            var expected = new Contact("Kirill", "2002_kirill@mail.ru", "+79021659485", DateTime.Now, "");
            var project = new Project();
            project.AddContact(expected);
            var actual = project.Contacts.Last();
            Assert.AreEqual(expected, actual, "AddContact добавляет в список неправильный контакт");
        }
        [Test(Description = "Позитивный тест удаления контакта из списка")]
        public void TestDeleteContact()
        {
            var testContact = new Contact("Kirill", "2002_kirill@mail.ru", "+79021659485", DateTime.Now, "");
            var project = new Project();
            project.AddContact(testContact);
            var actual = project.Contacts.Last();
            Assert.AreEqual(testContact, actual, "AddContact добавляет в список неправильный контакт");
            project.DeleteContact(0);
            var expected = 0;
            Assert.AreEqual(expected, project.Contacts.Count, "DeleteContact не удаляет контакт из списка");
        }
        [Test(Description = "Позитивный тест сортировки списка контактов")]
        public void TestSort()
        {
            var firstContact = new Contact("AAA", "2002_kirill@mail.ru", "+79021659485", DateTime.Now, "");
            var secondContact = new Contact("BBB", "2002_kirill@mail.ru", "+79021659485", DateTime.Now, "");
            var thirdContact = new Contact("CCC", "2002_kirill@mail.ru", "+79021659485", DateTime.Now, "");
            var project = new Project();
            project.AddContact(thirdContact);
            project.AddContact(firstContact);
            project.AddContact(secondContact);
            project.Sort();
            Assert.AreEqual(firstContact, project.Contacts[0], "Sort неправильно сортирует список контактов");
            Assert.AreEqual(secondContact, project.Contacts[1], "Sort неправильно сортирует список контактов");
            Assert.AreEqual(thirdContact, project.Contacts[2], "Sort неправильно сортирует список контактов");
        }

        [Test(Description = "Позитивный тест поиска контактов по заданному паттерну")]
        public void TestSearchContactsByPattern()
        {
            var firstContact = new Contact("AAA", "2002_kirill@mail.ru", "+79021659485", DateTime.Now, "");
            var secondContact = new Contact("BBB", "2002_kirill@mail.ru", "+79021659485", DateTime.Now, "");
            var thirdContact = new Contact("CCC", "2002_kirill@mail.ru", "+79021659485", DateTime.Now, "");
            var project = new Project();
            project.AddContact(thirdContact);
            project.AddContact(firstContact);
            project.AddContact(secondContact);
            project.Sort();
            var expected = 1;
            var actual = project.SearchContactsByPattern("A").Count;

            Assert.AreEqual(expected, actual, "TestSearchContactsByPattern возвращает неправильный список контактов");
        }

        [Test(Description = "Позитивный тест поиска именинников")]
        public void TestCelebrants()
        {
            var firstContact = new Contact("AAA", "2002_kirill@mail.ru", "+79021659485", DateTime.Now, "");
            var secondContact = new Contact("BBB", "2002_kirill@mail.ru", "+79021659485", DateTime.Now, "");
            var thirdContact = new Contact("CCC", "2002_kirill@mail.ru", "+79021659485", DateTime.Now, "");
            var project = new Project();
            project.AddContact(thirdContact);
            project.AddContact(firstContact);
            project.AddContact(secondContact);
            project.Sort();
            var expected = 3;
            var actual = project.Celebrants().Count;

            Assert.AreEqual(expected, actual, "TestSearchContactsByPattern возвращает неправильный список контактов");
        }
    }
}
