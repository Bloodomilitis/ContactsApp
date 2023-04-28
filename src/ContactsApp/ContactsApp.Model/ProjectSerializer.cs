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
        public string FolderPath { get; set; }
        
        /// <summary>
        /// Сохранение указанного проекта в файл
        /// </summary>
        public void SaveToFile(Project project)
        {
            FolderPath = Environment.GetFolderPath(SpecialFolder.ApplicationData) 
                                                    + "/Kalashnikov/ContactsApp";
            JsonSerializer serializer = new JsonSerializer();
            try
            {
                using (StreamWriter sw = new StreamWriter(FolderPath+"/userdata.json"))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, project);
                }
            }
            catch
            {
                if (!Directory.Exists(FolderPath))
                {
                    Directory.CreateDirectory(FolderPath);
                }
                File.Create(FolderPath + "/userdata.json");
                using (StreamWriter sw = new StreamWriter(FolderPath + "/userdata.json"))
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
            FolderPath = Environment.GetFolderPath(SpecialFolder.ApplicationData) 
                                                     + "/Kalashnikov/ContactsApp";
            JsonSerializer serializer = new JsonSerializer();
            try
            {
                //Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                string json = File.ReadAllText(FolderPath + "/userdata.json");
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
