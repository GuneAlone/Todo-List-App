using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo_List_App_WinForms.Properties;
using Timer = System.Windows.Forms.Timer;

namespace Todo_List_App_WinForms
{
    public partial class TodoForm : Form
    {
        private readonly string filePath = "tasks.json";
        private bool isResetting = false;

        public TodoForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JSONTaskStorage.LoadTasks(TasksPanel, CreateTaskPanel, filePath);
            ShowForm();
            UpdateImportantLabel();
        }

        private Panel CreateTaskPanel(TaskItem task)
        {
            var taskPanel = task.CreateTaskPanel();
            taskPanel.Tag = task;
            return taskPanel;
        }

        private void ShowForm()
        {
            this.Opacity = 0;
            this.Show();
            Timer fadeInTimer = new Timer { Interval = 30 };

            fadeInTimer.Tick += (s, args) =>
            {
                if (this.Opacity < 1)
                {
                    this.Opacity += 0.05;
                }
                else
                {
                    fadeInTimer.Stop();
                }
            };

            fadeInTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchText = TaskInputFieldSearch.Text;
            TaskSearch.SearchTasks(TasksPanel, searchText);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearFiltersAndSearch(TasksPanel);
        }

        public static void ClearFiltersAndSearch(Panel tasksPanel)
        {
            foreach (Control control in tasksPanel.Controls)
            {
                if (control is Panel taskPanel)
                {
                    taskPanel.Visible = true;
                }
            }
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TaskNameInputField.Text))
            {
                CustomExceptionHandler.HandleEmptyField();
                return;
            }

            if (TaskNameInputField.Text.Length < 3)
            {
                CustomExceptionHandler.HandleShortTaskName();
                return;
            }

            if (TaskNameInputField.Text.Length > 10)
            {
                CustomExceptionHandler.HandleLongTaskName();
                return;
            }

            TaskItem? task = null;

            switch (TaskTypePick.SelectedIndex)
            {
                case 0:
                    task = new BasicTask
                    {
                        Name = TaskNameInputField.Text,
                        Description = TaskDescriptionInputField.Text,
                        Time = DateTimePickComponent.Value
                    };
                    break;
                case 1:
                    task = new PriorityTask
                    {
                        Name = TaskNameInputField.Text,
                        Description = TaskDescriptionInputField.Text,
                        Time = DateTimePickComponent.Value
                    };
                    break;
                case 2:
                    task = new RecurringTask
                    {
                        Name = TaskNameInputField.Text,
                        Description = TaskDescriptionInputField.Text,
                        Time = DateTimePickComponent.Value
                    };
                    break;
                default:
                    CustomExceptionHandler.HandleInvalidTaskType();
                    return;
            }

            if (task is RecurringTask recurringTask)
            {
                recurringTask.ScheduleTask();
            }

            Panel taskPanel = task.CreateTaskPanel();
            TasksPanel.Controls.Add(taskPanel);
            taskPanel.Tag = task;

            UpdateImportantLabel();
            ClearInputFields();
            JSONTaskStorage.SaveTasks(TasksPanel, filePath);
        }

        internal void UpdateImportantLabel()
        {
            int importantTaskCount = TasksPanel.Controls.OfType<Panel>()
                .Count(panel => panel.Tag is PriorityTask);

            if (importantTaskCount > 0)
            {
                string taskText;
                int lastDigit = importantTaskCount % 10;
                int lastTwoDigits = importantTaskCount % 100;

                if (lastTwoDigits >= 11 && lastTwoDigits <= 14)
                {
                    taskText = "подій";
                }
                else if (lastDigit == 1)
                {
                    taskText = "подія";
                }
                else if (lastDigit >= 2 && lastDigit <= 4)
                {
                    taskText = "події";
                }
                else
                {
                    taskText = "подій";
                }

                string taskForm = importantTaskCount == 1 ? "запланована" : "заплановано";
                ImportantLabel.Text = $"На сьогодні {taskForm} {importantTaskCount} {taskText}";
            }
            else
            {
                ImportantLabel.Text = "На сьогодні у вас нічого не заплановано";
            }
        }

        private void ClearInputFields()
        {
            TaskNameInputField.Text = string.Empty;
            TaskDescriptionInputField.Text = string.Empty;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            isResetting = true;
            this.Opacity = 1;
            Timer fadeOutTimer = new Timer { Interval = 30 };

            fadeOutTimer.Tick += (s, args) =>
            {
                if (this.Opacity > 0)
                {
                    this.Opacity -= 0.05;
                }
                else
                {
                    fadeOutTimer.Stop();
                    Application.Restart();
                }
            };

            fadeOutTimer.Start();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {

            if (TaskTypePickFilter.SelectedIndex == -1)
            {
                CustomExceptionHandler.HandleNoTypeSelectedForFilter();
                return;
            }
            int selectedTypeIndex = TaskTypePickFilter.SelectedIndex;
            TaskFilter.FilterTasksByType(TasksPanel, selectedTypeIndex);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (!(isResetting || string.IsNullOrEmpty(TaskNameInputField.Text) && string.IsNullOrEmpty(TaskDescriptionInputField.Text)))
            {
                CustomExceptionHandler.HandleUnfinishedTaskAddition(e);
                if (e.Cancel)
                {
                    return;
                }
            }
            else
            {
                JSONTaskStorage.SaveTasks(TasksPanel, filePath);
            }
        }

      
    }
}
