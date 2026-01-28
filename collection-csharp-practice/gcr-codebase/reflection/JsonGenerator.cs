using System.Reflection;
using System.Text;


namespace Collections.collection_csharp_practice.gcr_codebase.reflection
{
    public class Person
    {
        public int Id;
        public string Name;
        public int Age;
        public bool IsActive;
    }

    public static class JsonGenerator
    {
        public static string ToJson(object obj)
        {
            Type type = obj.GetType();
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

            StringBuilder json = new StringBuilder();
            json.Append("{");

            foreach (FieldInfo field in fields)
            {
                string name = field.Name;
                object value = field.GetValue(obj);

                json.Append($"\"{name}\":");

                if (value is string)
                {
                    json.Append($"\"{value}\"");
                }
                else if (value is bool)
                {
                    json.Append(value.ToString().ToLower());
                }
                else
                {
                    json.Append(value);
                }

                json.Append(",");
            }

            // Remove trailing comma
            if (json[json.Length - 1] == ',')
                json.Remove(json.Length - 1, 1);

            json.Append("}");
            return json.ToString();
        }
    }

    class Program
    {
        static void Main()
        {
            Person person = new Person
            {
                Id = 1,
                Name = "Pradeep",
                Age = 25,
                IsActive = true
            };

            string json = JsonGenerator.ToJson(person);
            Console.WriteLine(json);
        }
    }
}



