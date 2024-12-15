using System;
using System.Linq;
using System.Windows.Forms;
using Todo_List_App_WinForms;

public static class TaskSearch
{
    public static void SearchTasks(Panel tasksPanel, string searchText)
    {
        bool anyMatch = false;

        if (string.IsNullOrWhiteSpace(searchText))
        {
            CustomExceptionHandler.HandleEmptySearchField();  
            return; 
        }

        foreach (Control control in tasksPanel.Controls)
        {
            if (control is Panel taskPanel && taskPanel.Tag is TaskItem task)
            {
                bool matches = (task.Name != null && task.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase)) ||
                               (task.Description != null && task.Description.Contains(searchText, StringComparison.OrdinalIgnoreCase));

                taskPanel.Visible = matches;

                if (matches)
                {
                    anyMatch = true;
                }
            }
        }

        if (!anyMatch)
        { 
        }
    }
}
