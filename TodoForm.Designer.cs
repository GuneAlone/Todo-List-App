namespace Todo_List_App_WinForms
{
    partial class TodoForm
    {
        private System.Windows.Forms.TextBox TaskNameInputField;
        private System.Windows.Forms.TextBox TaskDescriptionInputField;
        private System.Windows.Forms.DateTimePicker DateTimePickComponent;
        private System.Windows.Forms.Label LogoText;
        private System.Windows.Forms.ComboBox TaskTypePickFilter;
        private System.Windows.Forms.Label LabelTaskType;



        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodoForm));
            TaskNameInputField = new TextBox();
            TaskDescriptionInputField = new TextBox();
            DateTimePickComponent = new DateTimePicker();
            LogoText = new Label();
            EnterButton = new Button();
            SearchButton = new Button();
            TaskInputFieldSearch = new TextBox();
            FilterButton = new Button();
            TasksPanel = new FlowLayoutPanel();
            TaskContainer = new Panel();
            StarPicture = new PictureBox();
            TaskSettingsButton = new Button();
            TaskName = new Label();
            TaskDescription = new Label();
            TaskTypePickFilter = new ComboBox();
            LabelTaskType = new Label();
            TextImportantPanel = new Panel();
            ImportantLabel = new Label();
            TaskTypePick = new ComboBox();
            KNTtext = new Label();
            ClearFilterAndSearchButton = new Button();
            ResetButton = new Button();
            ((System.ComponentModel.ISupportInitialize)StarPicture).BeginInit();
            TextImportantPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TaskNameInputField
            // 
            TaskNameInputField.BackColor = Color.WhiteSmoke;
            TaskNameInputField.ForeColor = Color.DarkOrchid;
            TaskNameInputField.Location = new Point(65, 57);
            TaskNameInputField.Margin = new Padding(4, 3, 4, 3);
            TaskNameInputField.Name = "TaskNameInputField";
            TaskNameInputField.PlaceholderText = "Введіть назву задачі...";
            TaskNameInputField.Size = new Size(272, 23);
            TaskNameInputField.TabIndex = 0;
            // 
            // TaskDescriptionInputField
            // 
            TaskDescriptionInputField.BackColor = Color.WhiteSmoke;
            TaskDescriptionInputField.ForeColor = Color.DarkOrchid;
            TaskDescriptionInputField.Location = new Point(65, 86);
            TaskDescriptionInputField.Margin = new Padding(4, 3, 4, 3);
            TaskDescriptionInputField.Multiline = true;
            TaskDescriptionInputField.Name = "TaskDescriptionInputField";
            TaskDescriptionInputField.PlaceholderText = "Опис задачі...";
            TaskDescriptionInputField.Size = new Size(303, 78);
            TaskDescriptionInputField.TabIndex = 1;
            // 
            // DateTimePickComponent
            // 
            DateTimePickComponent.AccessibleRole = AccessibleRole.List;
            DateTimePickComponent.CalendarTitleBackColor = SystemColors.ControlText;
            DateTimePickComponent.CalendarTitleForeColor = Color.WhiteSmoke;
            DateTimePickComponent.CausesValidation = false;
            DateTimePickComponent.Cursor = Cursors.Hand;
            DateTimePickComponent.Format = DateTimePickerFormat.Time;
            DateTimePickComponent.ImeMode = ImeMode.Off;
            DateTimePickComponent.Location = new Point(65, 170);
            DateTimePickComponent.Margin = new Padding(4, 3, 4, 3);
            DateTimePickComponent.Name = "DateTimePickComponent";
            DateTimePickComponent.Size = new Size(303, 23);
            DateTimePickComponent.TabIndex = 2;
            // 
            // LogoText
            // 
            LogoText.AutoSize = true;
            LogoText.BackColor = Color.Transparent;
            LogoText.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LogoText.ForeColor = Color.White;
            LogoText.Location = new Point(142, 9);
            LogoText.Margin = new Padding(4, 0, 4, 0);
            LogoText.Name = "LogoText";
            LogoText.Size = new Size(134, 33);
            LogoText.TabIndex = 6;
            LogoText.Text = "To Do List";
            // 
            // EnterButton
            // 
            EnterButton.BackColor = Color.Transparent;
            EnterButton.BackgroundImage = (Image)resources.GetObject("EnterButton.BackgroundImage");
            EnterButton.BackgroundImageLayout = ImageLayout.Zoom;
            EnterButton.Cursor = Cursors.Hand;
            EnterButton.ForeColor = Color.Transparent;
            EnterButton.Location = new Point(344, 57);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(24, 23);
            EnterButton.TabIndex = 10;
            EnterButton.UseVisualStyleBackColor = false;
            EnterButton.Click += EnterButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.Transparent;
            SearchButton.BackgroundImage = (Image)resources.GetObject("SearchButton.BackgroundImage");
            SearchButton.BackgroundImageLayout = ImageLayout.Zoom;
            SearchButton.CausesValidation = false;
            SearchButton.Cursor = Cursors.Hand;
            SearchButton.ForeColor = Color.Transparent;
            SearchButton.Location = new Point(316, 276);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(24, 23);
            SearchButton.TabIndex = 14;
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += button2_Click;
            // 
            // TaskInputFieldSearch
            // 
            TaskInputFieldSearch.BackColor = Color.WhiteSmoke;
            TaskInputFieldSearch.ForeColor = Color.DarkOrchid;
            TaskInputFieldSearch.Location = new Point(65, 276);
            TaskInputFieldSearch.Margin = new Padding(4, 3, 4, 3);
            TaskInputFieldSearch.Name = "TaskInputFieldSearch";
            TaskInputFieldSearch.PlaceholderText = "Пошук...";
            TaskInputFieldSearch.Size = new Size(244, 23);
            TaskInputFieldSearch.TabIndex = 13;
            // 
            // FilterButton
            // 
            FilterButton.BackColor = Color.Transparent;
            FilterButton.BackgroundImage = (Image)resources.GetObject("FilterButton.BackgroundImage");
            FilterButton.BackgroundImageLayout = ImageLayout.Zoom;
            FilterButton.CausesValidation = false;
            FilterButton.Cursor = Cursors.Hand;
            FilterButton.ForeColor = Color.Transparent;
            FilterButton.Location = new Point(316, 306);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(24, 23);
            FilterButton.TabIndex = 15;
            FilterButton.UseVisualStyleBackColor = false;
            FilterButton.Click += FilterButton_Click;
            // 
            // TasksPanel
            // 
            TasksPanel.Anchor = AnchorStyles.Top;
            TasksPanel.AutoScroll = true;
            TasksPanel.BackColor = Color.Transparent;
            TasksPanel.BackgroundImage = (Image)resources.GetObject("TasksPanel.BackgroundImage");
            TasksPanel.BackgroundImageLayout = ImageLayout.Stretch;
            TasksPanel.BorderStyle = BorderStyle.FixedSingle;
            TasksPanel.Location = new Point(65, 335);
            TasksPanel.Margin = new Padding(4, 3, 4, 3);
            TasksPanel.Name = "TasksPanel";
            TasksPanel.Size = new Size(303, 238);
            TasksPanel.TabIndex = 7;
            // 
            // TaskContainer
            // 
            TaskContainer.Location = new Point(0, 0);
            TaskContainer.Name = "TaskContainer";
            TaskContainer.Size = new Size(200, 100);
            TaskContainer.TabIndex = 0;
            // 
            // StarPicture
            // 
            StarPicture.Location = new Point(0, 0);
            StarPicture.Name = "StarPicture";
            StarPicture.Size = new Size(100, 50);
            StarPicture.TabIndex = 0;
            StarPicture.TabStop = false;
            // 
            // TaskSettingsButton
            // 
            TaskSettingsButton.Location = new Point(0, 0);
            TaskSettingsButton.Name = "TaskSettingsButton";
            TaskSettingsButton.Size = new Size(75, 23);
            TaskSettingsButton.TabIndex = 0;
            // 
            // TaskName
            // 
            TaskName.Location = new Point(0, 0);
            TaskName.Name = "TaskName";
            TaskName.Size = new Size(100, 23);
            TaskName.TabIndex = 0;
            // 
            // TaskDescription
            // 
            TaskDescription.Location = new Point(0, 0);
            TaskDescription.Name = "TaskDescription";
            TaskDescription.Size = new Size(100, 23);
            TaskDescription.TabIndex = 0;
            // 
            // TaskTypePickFilter
            // 
            TaskTypePickFilter.BackColor = Color.WhiteSmoke;
            TaskTypePickFilter.Cursor = Cursors.Hand;
            TaskTypePickFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            TaskTypePickFilter.FlatStyle = FlatStyle.Popup;
            TaskTypePickFilter.ForeColor = Color.DarkOrchid;
            TaskTypePickFilter.FormattingEnabled = true;
            TaskTypePickFilter.Items.AddRange(new object[] { "Звичайна задача", "Важлива задача", "Регулярна задача" });
            TaskTypePickFilter.Location = new Point(65, 305);
            TaskTypePickFilter.Margin = new Padding(4, 3, 4, 3);
            TaskTypePickFilter.Name = "TaskTypePickFilter";
            TaskTypePickFilter.Size = new Size(244, 24);
            TaskTypePickFilter.TabIndex = 3;
           
            // 
            // LabelTaskType
            // 
            LabelTaskType.AutoSize = true;
            LabelTaskType.BackColor = Color.Transparent;
            LabelTaskType.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LabelTaskType.ForeColor = Color.GhostWhite;
            LabelTaskType.Location = new Point(65, 196);
            LabelTaskType.Name = "LabelTaskType";
            LabelTaskType.Size = new Size(131, 13);
            LabelTaskType.TabIndex = 2;
            LabelTaskType.Text = "Виберіть тип завдання:";
            // 
            // TextImportantPanel
            // 
            TextImportantPanel.BackColor = Color.White;
            TextImportantPanel.BackgroundImage = (Image)resources.GetObject("TextImportantPanel.BackgroundImage");
            TextImportantPanel.BackgroundImageLayout = ImageLayout.Stretch;
            TextImportantPanel.Controls.Add(ImportantLabel);
            TextImportantPanel.Location = new Point(1, 591);
            TextImportantPanel.Margin = new Padding(5);
            TextImportantPanel.Name = "TextImportantPanel";
            TextImportantPanel.Size = new Size(436, 32);
            TextImportantPanel.TabIndex = 16;
            // 
            // ImportantLabel
            // 
            ImportantLabel.AutoSize = true;
            ImportantLabel.BackColor = Color.Transparent;
            ImportantLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ImportantLabel.ForeColor = Color.WhiteSmoke;
            ImportantLabel.Location = new Point(64, 7);
            ImportantLabel.Name = "ImportantLabel";
            ImportantLabel.Size = new Size(121, 19);
            ImportantLabel.TabIndex = 11;
            ImportantLabel.Text = "ImportantLabel";
            // 
            // TaskTypePick
            // 
            TaskTypePick.BackColor = Color.WhiteSmoke;
            TaskTypePick.Cursor = Cursors.Hand;
            TaskTypePick.DropDownStyle = ComboBoxStyle.DropDownList;
            TaskTypePick.FlatStyle = FlatStyle.Popup;
            TaskTypePick.ForeColor = Color.DarkOrchid;
            TaskTypePick.FormattingEnabled = true;
            TaskTypePick.Items.AddRange(new object[] { "Звичайна задача", "Важлива задача", "Регулярна задача" });
            TaskTypePick.Location = new Point(65, 212);
            TaskTypePick.Margin = new Padding(4, 3, 4, 3);
            TaskTypePick.Name = "TaskTypePick";
            TaskTypePick.Size = new Size(303, 24);
            TaskTypePick.TabIndex = 18;
            // 
            // KNTtext
            // 
            KNTtext.AutoSize = true;
            KNTtext.BackColor = Color.Transparent;
            KNTtext.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            KNTtext.ForeColor = Color.DarkSlateBlue;
            KNTtext.Location = new Point(340, 5);
            KNTtext.Margin = new Padding(4, 0, 4, 0);
            KNTtext.Name = "KNTtext";
            KNTtext.Size = new Size(69, 17);
            KNTtext.TabIndex = 19;
            KNTtext.Text = "КНТ-213";
            // 
            // ClearFilterAndSearchButton
            // 
            ClearFilterAndSearchButton.BackColor = Color.Transparent;
            ClearFilterAndSearchButton.BackgroundImage = (Image)resources.GetObject("ClearFilterAndSearchButton.BackgroundImage");
            ClearFilterAndSearchButton.BackgroundImageLayout = ImageLayout.Zoom;
            ClearFilterAndSearchButton.CausesValidation = false;
            ClearFilterAndSearchButton.Cursor = Cursors.Hand;
            ClearFilterAndSearchButton.ForeColor = Color.Transparent;
            ClearFilterAndSearchButton.Location = new Point(344, 292);
            ClearFilterAndSearchButton.Name = "ClearFilterAndSearchButton";
            ClearFilterAndSearchButton.Size = new Size(24, 23);
            ClearFilterAndSearchButton.TabIndex = 20;
            ClearFilterAndSearchButton.UseVisualStyleBackColor = false;
            ClearFilterAndSearchButton.Click += button4_Click;
            // 
            // ResetButton
            // 
            ResetButton.BackColor = Color.Transparent;
            ResetButton.BackgroundImage = (Image)resources.GetObject("ResetButton.BackgroundImage");
            ResetButton.BackgroundImageLayout = ImageLayout.Zoom;
            ResetButton.Cursor = Cursors.Hand;
            ResetButton.ForeColor = Color.Transparent;
            ResetButton.Location = new Point(405, 3);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(20, 20);
            ResetButton.TabIndex = 21;
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            // 
            // TodoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(429, 637);
            Controls.Add(ResetButton);
            Controls.Add(ClearFilterAndSearchButton);
            Controls.Add(KNTtext);
            Controls.Add(TaskTypePick);
            Controls.Add(TextImportantPanel);
            Controls.Add(LabelTaskType);
            Controls.Add(TaskTypePickFilter);
            Controls.Add(FilterButton);
            Controls.Add(SearchButton);
            Controls.Add(TaskInputFieldSearch);
            Controls.Add(EnterButton);
            Controls.Add(TaskNameInputField);
            Controls.Add(TaskDescriptionInputField);
            Controls.Add(DateTimePickComponent);
            Controls.Add(LogoText);
            Controls.Add(TasksPanel);
            DoubleBuffered = true;
            Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Indigo;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "TodoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "To Do List";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)StarPicture).EndInit();
            TextImportantPanel.ResumeLayout(false);
            TextImportantPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button EnterButton;
        private Button SearchButton;
        private TextBox TaskInputFieldSearch;
        private Button FilterButton;
        private FlowLayoutPanel TasksPanel;
        private Panel TextImportantPanel;
        private ComboBox TaskTypePick;
        private Label KNTtext;
        private Button ClearFilterAndSearchButton;
        private Panel TaskContainer;
        private PictureBox StarPicture;
        private Button TaskSettingsButton;
        private Label TaskName;
        private Label TaskDescription;
        private Button ResetButton;
        private Label ImportantLabel;
    }
}
