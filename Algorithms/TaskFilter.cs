using System.Windows.Forms;
using Todo_List_App_WinForms;

public static class TaskFilter
{
    public static void FilterTasksByType(Panel tasksPanel, int selectedTypeIndex)
    {
        bool anyVisible = false;

        if (selectedTypeIndex == -1)
        {
            CustomExceptionHandler.HandleNoTypeSelectedForFilter(); 
            return; 
        }

        foreach (Control control in tasksPanel.Controls)
        {
            if (control is Panel taskPanel && taskPanel.Tag is TaskItem task)
            {
                bool isVisible = selectedTypeIndex switch
                {
                    0 => task is BasicTask,
                    1 => task is PriorityTask,
                    2 => task is RecurringTask,
                    _ => true
                };

                taskPanel.Visible = isVisible;

                if (isVisible)
                {
                    anyVisible = true;
                }
            }
        }

        if (!anyVisible)
        {
            CustomExceptionHandler.HandleNoTasksFound();
        }
    }
}
