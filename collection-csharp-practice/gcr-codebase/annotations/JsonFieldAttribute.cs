using System;
using System.Reflection;
using System.Text;


namespace Collections.collection_csharp_practice.gcr_codebase.annotations
{
    [AttributeUsage(AttributeTargets.Field)]
    public class JsonFieldAttribute : Attribute
    {
        public string Name { get; set; }
    }

    public class User
    {
        [JsonField(Name = "user_name")]
        public string Name;

        [JsonField(Name = "user_email")]
        public string Email;

        [JsonField(Name = "user_age")]
        public int Age;

        // Field without JsonField --> ignored
        public string InternalCode = "X123";
    }

    public static class JsonSerializer
    {
        public static string ToJson(object obj)
        {
            StringBuilder json = new StringBuilder();
            json.Append("{");

            FieldInfo[] fields = obj.GetType().GetFields();

            foreach (FieldInfo field in fields)
            {
                JsonFieldAttribute attribute =
                    field.GetCustomAttribute<JsonFieldAttribute>();

                if (attribute != null)
                {
                    string key = attribute.Name;
                    object value = field.GetValue(obj);

                    // Handle string vs non-string values
                    if (value is string)
                    {
                        json.Append($"\"{key}\":\"{value}\",");
                    }
                    else
                    {
                        json.Append($"\"{key}\":{value},");
                    }
                }
            }

            // Remove last comma if exists
            if (json[^1] == ',')
                json.Remove(json.Length - 1, 1);

            json.Append("}");
            return json.ToString();
        }
    }

    class Program
    {
        static void Main()
        {
            User user = new User
            {
                Name = "Pradeep",
                Email = "pradeep@example.com",
                Age = 25
            };

            string json = JsonSerializer.ToJson(user);
            Console.WriteLine(json);
        }
    }
}



