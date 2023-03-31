using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Environment;

namespace ContactsApp.Model
{
    public class ProjectSerializer
    {

        public string Filename { get; set; }
        public void SaveToFile(Project project)
        {
            var Filename = Environment.GetFolderPath(SpecialFolder.ApplicationData) + "/ContactsApp/Kalashnikov/NoteApp/userdata.json";
            JsonSerializer serializer = new JsonSerializer();
            //Открываем поток для записи в файл с указанием пути
            try
            {
                using (StreamWriter sw = new StreamWriter(Filename))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    //Вызываем сериализацию и передаем объект, который хотим сериализовать
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
