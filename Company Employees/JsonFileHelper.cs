
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Company_Employees
{
    public class JsonFileHelper
    {
        private string _filePath;

        public JsonFileHelper(string filePath)
        {
            _filePath = filePath;
        }
        public void SerializeToFile(List<Employee> employees)
        {
            var serializer = new JsonSerializer();
            using (var streamWriter = new StreamWriter(_filePath))
            using (JsonWriter writer = new JsonTextWriter(streamWriter)) 
            {
                    serializer.Serialize(writer, employees);
                    streamWriter.Close();
            }
        }
        public List<Employee> DeserializeFromFile()
        {
            if (!File.Exists(_filePath))
                return new List<Employee>();

            var serializer = new JsonSerializer();

            using (var streamReader = new StreamReader(_filePath))
            using (JsonReader reader = new JsonTextReader(streamReader))
            {
                List<Employee> employees = (List<Employee>)serializer.Deserialize(reader, typeof(List<Employee>));
                streamReader.Close();
                return employees;
            }

        }
    }

    /*public class JsonFileHelper<T> where T : new()
    {
        private string _filePath;

        public JsonFileHelper(string filePath)
        {
            _filePath = filePath;
        }
        public void SerializeToFile(T employees)
        {
            var serializer = new JsonSerializer();
            using (var streamWriter = new StreamWriter(_filePath))
            using (JsonWriter writer = new JsonTextWriter(streamWriter)) 
            {
                    serializer.Serialize(writer, employees);
                    streamWriter.Close();
            }
        }
        public T DeserializeFromFile()
        {
            if (!File.Exists(_filePath))
                return new T();

            var serializer = new JsonSerializer();

            using (var streamReader = new StreamReader(_filePath))
            using (JsonReader reader = new JsonTextReader(streamReader))
            {
                var employees = (T)serializer.Deserialize(reader);
                streamReader.Close();
                return employees;
            }

        }
    }*/
}
