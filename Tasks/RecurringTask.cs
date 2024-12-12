using System;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace Todo_List_App_WinForms
{
    public class RecurringTask : TaskItem
    {
        public System.Windows.Forms.Timer TaskTimer { get; private set; }
  
        public RecurringTask()
        {
            TaskTimer = new System.Windows.Forms.Timer();
        }

        [JsonConstructor]
        public RecurringTask(System.Windows.Forms.Timer taskTimer)
        {
            TaskTimer = taskTimer;
        }

        public void ScheduleTask()
        {
            TimeSpan timeUntilTask = Time - DateTime.Now;

            if (timeUntilTask.TotalMilliseconds <= 0)
            {
                CustomExceptionHandler.HandlePastTimeSet();
                return; 
            }

            TaskTimer.Interval = (int)timeUntilTask.TotalMilliseconds;
            TaskTimer.Tick += (s, e) =>
            {
                TaskTimer.Stop();
                ShowTaskNotification();
            };
            TaskTimer.Start();
        }

        private void ShowTaskNotification()
        {
            string taskDescription = string.IsNullOrEmpty(Description) ? "Деталі відсутні" : Description;

            MessageBox.Show(
                $"Наближається час події: {Name}\nОпис: {taskDescription}",
                "Нагадування",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        protected override Image GetStarImage()
        {
            return Properties.Resources.blueStar;
        }
    }
}