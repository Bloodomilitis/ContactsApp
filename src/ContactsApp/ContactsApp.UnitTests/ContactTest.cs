using ContactsApp.Model;
using NUnit.Framework;
using System;



namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class ContactTest
    {
        [Test(Description = "Позитивный тест геттера FullName")]
        public void TestFullNameGet_CorrectValue()
        {
            var expected = "Смирнов";
            var contact = new Contact();
            contact.FullName = expected;
            var actual = contact.FullName;
            Assert.AreEqual(expected, actual, "Геттер FullName возвращает неправильное ФИО");
        }

        [TestCase("", "Должно возникать исключение, если фамилия - пустая строка",
            TestName = "Присвоение пустой строки в качестве ФИО")]
        [TestCase("Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов", "Должно возникать исключение, если ФИО длиннее 100 символов",
        TestName = "Присвоение неправильного ФИО больше 100 символов")]
        [TestCase("Смирнов1", "Должно возникать исключение, если ФИО содержит небуквенные символы",
            TestName = "Присвоение неправильного ФИО, которое содержит небуквенные символы")]
        public void TestSurnameSet_ArgumentException(string wrongFullName, string message)
        {
            var contact = new Contact();
            Assert.Throws<ArgumentException>(
                () => { contact.FullName = wrongFullName; },
                message);
        }

        [Test(Description = "Позитивный тест геттера Email")]
        public void TestEmailGet_CorrectValue()
        {
            var expected = "Smirnov@mail.ru";
            var contact = new Contact();
            contact.Email = expected;
            var actual = contact.Email;
            Assert.AreEqual(expected, actual, "Геттер Email возвращает неправильную почту");
        }

        [TestCase("", "Должно возникать исключение, если электронная почта - пустая строка",
            TestName = "Присвоение пустой строки в качестве электронной почты")]

        [TestCase("Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов",
            "Должно возникать исключение, если электронная почта длиннее 100 символов",
            TestName = "Присвоение неправильной электронной почты больше 100 символов")]
        public void TestEmailSet_ArgumentException(string wrongEmail, string message)
        {
            var contact = new Contact();
            Assert.Throws<ArgumentException>(
                () => { contact.Email = wrongEmail; },
                message);
        }


        [Test(Description = "Позитивный тест геттера Phone")]
        public void TestPhoneGet_CorrectValue()
        {
            var expected = "+7(565) 260-88-08";
            var contact = new Contact();
            contact.Phone = expected;
            var actual = contact.Phone;
            Assert.AreEqual(expected, actual, "Геттер Email возвращает неправильный номер телефона");
        }

        [TestCase("", "Должно возникать исключение, если номер телефона - пустая строка",
            TestName = "Присвоение пустой строки в качестве номера телефона")]
        public void TestPhoneSet_ArgumentException(string wrongPhone, string message)
        {
            var contact = new Contact();
            Assert.Throws<ArgumentException>(
                () => { contact.Phone = wrongPhone; },
                message);
        }

        [Test(Description = "Позитивный тест геттера DateOfBirth")]
        public void TestDateOfBirthGet_CorrectValue()
        {
            var expected = new DateTime(1999, 11, 12);
            var contact = new Contact();
            contact.DateOfBirth = expected;
            var actual = contact.DateOfBirth;
            Assert.AreEqual(expected, actual, "Геттер Email возвращает неправильный номер телефона");
        }

        [TestCase("01/20/1888", "Должно возникать исключение, если год даты менее 1900",
            TestName = "Присвоение даты ранее 1900 года")]
        [TestCase("01/20/2222", "Должно возникать исключение, если дата позже сегодняшней",
            TestName = "Присвоение ненаступившей даты ")]
        public void TestateOfBirthSet_ArgumentException(DateTime wrongDateOfBirth, string message)
        {
            var contact = new Contact();
            Assert.Throws<ArgumentException>(
                () => { contact.DateOfBirth = wrongDateOfBirth; },
                message);
        }

        [Test(Description = "Позитивный тест геттера IdVK")]
        public void TestIdVKGet_CorrectValue()
        {
            var expected = "Omilitis";
            var contact = new Contact();
            contact.IdVK = expected;
            var actual = contact.IdVK;
            Assert.AreEqual(expected, actual, "Геттер Email возвращает неправильный номер телефона");
        }

        [TestCase("asdkjpoijwegoianerpgioaewlrkjnhupoaern;jfgpuearfhgbupqawerg", "Должно возникать исключение, если ид вк длиннее 50 символов",
            TestName = "Присвоение неправильного ИД ВК больше 50 символов")]
        public void TestIdVKSet_ArgumentException(string wrongIdVK, string message)
        {
            var contact = new Contact();
            Assert.Throws<ArgumentException>(
                () => { contact.IdVK = wrongIdVK; },
                message);
        }

        [Test(Description = "Проверка клонирования контакта")]
        public void CloneTest()
        {
            var contact = new Contact("Kirill", "2002_kirill@mail.ru", "+79021659485", DateTime.Now, "");
            var clone = (Contact)contact.Clone();
            Assert.AreEqual(contact.FullName, clone.FullName, "Клонирование неправильно устанавливает в клоне полное имя");
            Assert.AreEqual(contact.Email, clone.Email, "Клонирование неправильно устанавливает в клоне электронную почту");
            Assert.AreEqual(contact.Phone, clone.Phone, "Клонирование неправильно устанавливает в клоне номер телефона");
            Assert.AreEqual(contact.DateOfBirth, clone.DateOfBirth, "Клонирование неправильно устанавливает в клоне дату рождения");
            Assert.AreEqual(contact.IdVK, clone.IdVK, "Клонирование неправильно устанавливает в клоне ИД ВК");
        }
    }
}
