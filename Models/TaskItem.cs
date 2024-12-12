using System;
using System.Drawing;
using System.Windows.Forms;

namespace Todo_List_App_WinForms
{
    public abstract class TaskItem
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public DateTime Time { get; set; }
        public Image StarImage { get; set; } = Properties.Resources.star;

        public virtual Panel CreateTaskPanel()
        {
            Panel taskContainer = InitializeTaskContainer();
            PictureBox starPicture = CreateStarPicture(GetStarImage());
            Button taskSettingsButton = CreateSettingsButton(taskContainer);
            Label taskName = CreateLabel("TaskName", new Point(3, 0), new Size(191, 20), Name ?? "Ім'я відсутнє", FontStyle.Bold);
            Label taskDescription = CreateLabel("TaskDescription", new Point(4, 20), new Size(190, 37), string.IsNullOrEmpty(Description) ? "Деталі відсутні" : Description);
            taskDescription.Click += TaskDescription_Click;
            taskContainer.Controls.Add(starPicture);
            taskContainer.Controls.Add(taskSettingsButton);
            taskContainer.Controls.Add(taskName);
            taskContainer.Controls.Add(taskDescription);

            return taskContainer;
        }
        private Panel InitializeTaskContainer() => new Panel
        {
            BackColor = Color.White,
            BackgroundImage = Properties.Resources.taskBackground,
            BackgroundImageLayout = ImageLayout.Stretch,
            BorderStyle = BorderStyle.FixedSingle,
            Location = new Point(5, 5),
            Margin = new Padding(5),
            Name = "TaskContainer",
            Size = new Size(273, 63),
            TabIndex = 3
        };

        protected virtual Image GetStarImage() => StarImage;

        private PictureBox CreateStarPicture(Image starImage) => new PictureBox
        {
            BackColor = Color.Transparent,
            BackgroundImage = starImage,
            BackgroundImageLayout = ImageLayout.Stretch,
            Location = new Point(207, 14),
            Name = "StarPicture",
            Size = new Size(35, 33),
            SizeMode = PictureBoxSizeMode.StretchImage,
            TabIndex = 0,
            TabStop = false
        };

        private Button CreateSettingsButton(Panel taskContainer)
        {
            var taskSettingsButton = new Button
            {
                BackColor = Color.Transparent,
                BackgroundImage = Properties.Resources.menuTaskButton,
                BackgroundImageLayout = ImageLayout.Zoom,
                Cursor = Cursors.Hand,
                FlatAppearance = { BorderSize = 0 },
                FlatStyle = FlatStyle.Flat,
                Location = new Point(240, 3),
                Name = "TaskSettingsButton",
                Size = new Size(28, 27),
                TabIndex = 3
            };

            var taskContextMenu = CreateContextMenu(taskContainer);

            taskSettingsButton.Click += (s, e) =>
            {
                taskContextMenu.Show(taskSettingsButton, new Point(0, taskSettingsButton.Height));
            };

            return taskSettingsButton;
        }

        private ContextMenuStrip CreateContextMenu(Panel taskContainer)
        {
            var taskContextMenu = new ContextMenuStrip();

            var editMenuItem = new ToolStripMenuItem("Редагувати");
            editMenuItem.Click += (s, e) => EditTask(taskContainer);

            var deleteMenuItem = new ToolStripMenuItem("Видалити");
            deleteMenuItem.Click += (s, e) =>
            {
                var parentForm = taskContainer.FindForm() as TodoForm;
                if (parentForm != null)
                {
                    DeleteTask(taskContainer, parentForm);
                }
               
            };

            taskContextMenu.Items.AddRange(new ToolStripItem[] { editMenuItem, deleteMenuItem });
            return taskContextMenu;
        }

        private Label CreateLabel(string name, Point location, Size size, string text, FontStyle fontStyle = FontStyle.Regular) => new Label
        {
            BackColor = Color.Transparent,
            Font = new Font("Segoe UI", fontStyle == FontStyle.Bold ? 10F : 9F, fontStyle),
            ForeColor = fontStyle == FontStyle.Bold ? Color.WhiteSmoke : Color.Gray,
            Location = location,
            Name = name,
            Size = size,
            Text = text,
            TabIndex = fontStyle == FontStyle.Bold ? 1 : 2
        };

        private void TaskDescription_Click(object? sender, EventArgs e)
        {
            if (sender is Label descriptionLabel)
            {
                using (Form descriptionForm = new Form { Text = "Опис задачі", Size = new Size(300, 200) })
                {
                    TextBox descriptionTextBox = new TextBox
                    {
                        Multiline = true,
                        ReadOnly = true,
                        Text = descriptionLabel.Text,
                        Dock = DockStyle.Fill,
                        ScrollBars = ScrollBars.Vertical
                    };

                    descriptionForm.Controls.Add(descriptionTextBox);
                    descriptionForm.ShowDialog();
                }
            }
        }

        private void EditTask(Panel taskContainer)
        {
            using (Form editForm = new Form { Text = "Редагувати завдання" })
            {
                TextBox nameTextBox = new TextBox { Text = Name, Location = new Point(10, 10), Width = 200 };
                TextBox descriptionTextBox = new TextBox { Text = Description, Location = new Point(10, 40), Width = 200, Height = 50, Multiline = true };
                Button saveButton = new Button { Text = "Сохранить", Location = new Point(10, 100) };

                saveButton.Click += (s, e) =>
                {

                    if (string.IsNullOrWhiteSpace(nameTextBox.Text)) 
                    {
                        CustomExceptionHandler.HandleEmptyField(); 
                        return;
                    }
             
                    if (nameTextBox.Text.Length < 3)
                    {
                        CustomExceptionHandler.HandleShortTaskName();
                        return;
                    }

                    if (nameTextBox.Text.Length > 10)
                    {
                        CustomExceptionHandler.HandleLongTaskName();
                        return;
                    }

                    Name = nameTextBox.Text;
                    Description = descriptionTextBox.Text;

                    foreach (Control control in taskContainer.Controls)
                    {
                        if (control is Label label)
                        {
                            if (label.Name == "TaskName")
                            {
                                label.Text = Name;
                            }
                            else if (label.Name == "TaskDescription")
                            {
                                label.Text = string.IsNullOrEmpty(Description) ? "Деталі відсутні" : Description;
                            }
                        }
                    }

                    editForm.Close();
                };

                editForm.Controls.Add(nameTextBox);
                editForm.Controls.Add(descriptionTextBox);
                editForm.Controls.Add(saveButton);
                editForm.ShowDialog();
            }
        }

        private void DeleteTask(Panel taskContainer, TodoForm todoForm)
        {
            if (taskContainer.Parent is Panel parentPanel)
            {
                taskContainer.Dispose();

                if (parentPanel.FindForm() is TodoForm parentForm)
                {
                    parentForm.UpdateImportantLabel();
                }
            }
        }
    }
}
