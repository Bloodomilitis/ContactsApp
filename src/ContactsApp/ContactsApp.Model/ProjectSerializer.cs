using Newtonsoft.Json;
using System;
using System.IO;
using static System.Environment;

namespace ContactsApp.Model
{
    /// <summary>
    /// Описывает менеджер проекта
    /// </summary>
    public class ProjectSerializer
    {
        /// <summary>
        /// Путь к файлу
        /// </summary>
        public string Filename { get; set; }
        
        /// <summary>
        /// Сохранение указанного проекта в файл
        /// </summary>
        public void SaveToFile(Project project)
        {
            var Filename = Environment.GetFolderPath(SpecialFolder.ApplicationData) + "/ContactsApp/Kalashnikov/NoteApp/userdata.json";
            JsonSerializer serializer = new JsonSerializer();
            try
            {
                using (StreamWriter sw = new StreamWriter(Filename))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, project);
                }
            }
            catch
            {
                if (!Directory.Exists(Environment.GetFolderPath(SpecialFolder.ApplicationData) + "/ContactsApp/Kalashnikov/NoteApp"))
                {
                    Directory.CreateDirectory(Environment.GetFolderPath(SpecialFolder.ApplicationData) + "/ContactsApp/Kalashnikov/NoteApp");
                }
                File.Create(Filename);
                using (StreamWriter sw = new StreamWriter(Filename))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, project);
                }
            }

        }

        /// <summary>
        /// Возвращает десериализованный проект из файла
        /// </summary>
        public Project LoadFromFile()
        {
            Filename = Environment.GetFolderPath(SpecialFolder.ApplicationData) + "/ContactsApp/Kalashnikov/NoteApp/userdata.json";
            JsonSerializer serializer = new JsonSerializer();
            try
            {
                //Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                string json = File.ReadAllText(Filename);
                if (json != "")
                {
                    Project project = JsonConvert.DeserializeObject<Project>(json);
                    return project;
                }
                else
                {
                    return new Project();
                }

            }
            catch
            {
                return new Project();
            }
        }
    }
}
