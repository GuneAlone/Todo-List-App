using System.Text.Json;
using System.Text.Json.Serialization;
using Todo_List_App_WinForms;

public class TaskItemJsonConverter : JsonConverter<TaskItem>
{
    public override TaskItem? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
        {
            var json = doc.RootElement;

            if (!json.TryGetProperty("Type", out var typeProperty))
            {
                return null;
            }

            var type = typeProperty.GetString();
            TaskItem task = type switch
            {
                "BasicTask" => new BasicTask(),
                "PriorityTask" => new PriorityTask(),
                "RecurringTask" => new RecurringTask(),
                _ => throw new JsonException($"Невідомий тип завдання: {type}")
            };
    
            task.Name = json.GetProperty("Name").GetString();
            task.Description = json.GetProperty("Description").GetString();
            task.Time = json.GetProperty("Time").GetDateTime();

            return task;
        }
    }

    public override void Write(Utf8JsonWriter writer, TaskItem value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteString("Type", value.GetType().Name); 
        writer.WriteString("Name", value.Name);
        writer.WriteString("Description", value.Description);
        writer.WriteString("Time", value.Time.ToString("o")); 
        writer.WriteEndObject();
    }
}
