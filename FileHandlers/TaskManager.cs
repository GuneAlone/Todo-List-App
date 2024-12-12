using System.Text.Json;
using Todo_List_App_WinForms;

public static class JSONTaskStorage
{   
    public static void SaveTasks(Control tasksPanel, string filePath)
    {
        var tasks = tasksPanel.Controls
            .OfType<Panel>()
            .Select(panel => panel.Tag as TaskItem)
            .Where(task => task != null)
            .ToList();

        var options = new JsonSerializerOptions
        {
            Converters = { new TaskItemJsonConverter() },
            WriteIndented = true
        }; 
            string json = JsonSerializer.Serialize(tasks, options);
            File.WriteAllText(filePath, json);
    }
    public static void LoadTasks(Control tasksPanel, Func<TaskItem, Panel> createTaskPanel, string filePath)
    {
        if (!File.Exists(filePath))
        {
            CustomExceptionHandler.HandleTaskFileNotFoundError(filePath); 
            return;
        }

        string json = File.ReadAllText(filePath);

        if (string.IsNullOrWhiteSpace(json))
            return;

        var options = new JsonSerializerOptions
        {
            Converters = { new TaskItemJsonConverter() }
        };
           var tasks = JsonSerializer.Deserialize<List<TaskItem>>(json, options);
            tasksPanel.Controls.Clear();
            if (tasks != null)
            {
                tasksPanel.Controls.Clear();

                foreach (var task in tasks)
                {
                    if (task != null) 
                    {
                        Panel panel = createTaskPanel(task);
                        tasksPanel.Controls.Add(panel);
                        panel.Tag = task;
                    }
                }
            }      
    }
}
