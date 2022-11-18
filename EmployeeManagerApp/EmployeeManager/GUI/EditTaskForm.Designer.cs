
namespace EmployeeManagerUI
{
    partial class EditTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTaskForm));
            this.BackButton = new System.Windows.Forms.Button();
            this.ActiveTaskListButton = new System.Windows.Forms.Button();
            this.TaskDataGridView = new System.Windows.Forms.DataGridView();
            this.ApplyChangesButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.DeleteTaskButton = new System.Windows.Forms.Button();
            this.MasterErrorLabel = new System.Windows.Forms.Label();
            this.EditTaskLabel = new System.Windows.Forms.Label();
            this.TaskGroupBox = new System.Windows.Forms.GroupBox();
            this.DeadlineErrorLabel = new System.Windows.Forms.Label();
            this.TaskStatusComboBox = new System.Windows.Forms.ComboBox();
            this.TaskStatusLabel = new System.Windows.Forms.Label();
            this.TaskAssigneeComboBox = new System.Windows.Forms.ComboBox();
            this.TaskAssigneeLabel = new System.Windows.Forms.Label();
            this.TaskDescriptionErrorLabel = new System.Windows.Forms.Label();
            this.TaskNameErrorLabel = new System.Windows.Forms.Label();
            this.TaskLeadComboBox = new System.Windows.Forms.ComboBox();
            this.TaskLeadLabel = new System.Windows.Forms.Label();
            this.DeadlineLabel = new System.Windows.Forms.Label();
            this.DeadlineDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TaskDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.TaskDescriptionLabel = new System.Windows.Forms.Label();
            this.TaskNameTextBox = new System.Windows.Forms.TextBox();
            this.TaskNameLabel = new System.Windows.Forms.Label();
            this.DeletedReasonComboBox = new System.Windows.Forms.ComboBox();
            this.DeletedReasonLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ArchievedTaskListButton = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderByStatusButton = new System.Windows.Forms.Button();
            this.OrderByNameButton = new System.Windows.Forms.Button();
            this.OrderByDeadlineButton = new System.Windows.Forms.Button();
            this.OrderByIdButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TaskDataGridView)).BeginInit();
            this.TaskGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackButton.Location = new System.Drawing.Point(1045, 709);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(158, 48);
            this.BackButton.TabIndex = 44;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ActiveTaskListButton
            // 
            this.ActiveTaskListButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ActiveTaskListButton.Location = new System.Drawing.Point(516, 690);
            this.ActiveTaskListButton.Name = "ActiveTaskListButton";
            this.ActiveTaskListButton.Size = new System.Drawing.Size(131, 25);
            this.ActiveTaskListButton.TabIndex = 62;
            this.ActiveTaskListButton.Text = "Active Task List";
            this.ActiveTaskListButton.UseVisualStyleBackColor = true;
            this.ActiveTaskListButton.Click += new System.EventHandler(this.TaskListButton_Click);
            // 
            // TaskDataGridView
            // 
            this.TaskDataGridView.AllowUserToAddRows = false;
            this.TaskDataGridView.AllowUserToDeleteRows = false;
            this.TaskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaskDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TaskDataGridView.Location = new System.Drawing.Point(145, 411);
            this.TaskDataGridView.MultiSelect = false;
            this.TaskDataGridView.Name = "TaskDataGridView";
            this.TaskDataGridView.RowTemplate.Height = 25;
            this.TaskDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TaskDataGridView.Size = new System.Drawing.Size(1058, 273);
            this.TaskDataGridView.TabIndex = 61;
            this.TaskDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TaskDataGridView_CellClick);
            // 
            // ApplyChangesButton
            // 
            this.ApplyChangesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ApplyChangesButton.Location = new System.Drawing.Point(874, 45);
            this.ApplyChangesButton.Name = "ApplyChangesButton";
            this.ApplyChangesButton.Size = new System.Drawing.Size(158, 48);
            this.ApplyChangesButton.TabIndex = 66;
            this.ApplyChangesButton.Text = "Apply Changes";
            this.ApplyChangesButton.UseVisualStyleBackColor = true;
            this.ApplyChangesButton.Click += new System.EventHandler(this.ApplyChangesButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.Location = new System.Drawing.Point(874, 106);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(158, 48);
            this.ResetButton.TabIndex = 65;
            this.ResetButton.Text = "Reset to Default";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // DeleteTaskButton
            // 
            this.DeleteTaskButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteTaskButton.Location = new System.Drawing.Point(864, 359);
            this.DeleteTaskButton.Name = "DeleteTaskButton";
            this.DeleteTaskButton.Size = new System.Drawing.Size(158, 48);
            this.DeleteTaskButton.TabIndex = 71;
            this.DeleteTaskButton.Text = "Delete Task";
            this.DeleteTaskButton.UseVisualStyleBackColor = true;
            this.DeleteTaskButton.Click += new System.EventHandler(this.DeleteTaskButton_Click);
            // 
            // MasterErrorLabel
            // 
            this.MasterErrorLabel.AutoSize = true;
            this.MasterErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.MasterErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MasterErrorLabel.Location = new System.Drawing.Point(504, 67);
            this.MasterErrorLabel.Name = "MasterErrorLabel";
            this.MasterErrorLabel.Size = new System.Drawing.Size(12, 15);
            this.MasterErrorLabel.TabIndex = 73;
            this.MasterErrorLabel.Text = "*";
            // 
            // EditTaskLabel
            // 
            this.EditTaskLabel.AutoSize = true;
            this.EditTaskLabel.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.EditTaskLabel.Location = new System.Drawing.Point(27, 24);
            this.EditTaskLabel.Name = "EditTaskLabel";
            this.EditTaskLabel.Size = new System.Drawing.Size(157, 45);
            this.EditTaskLabel.TabIndex = 74;
            this.EditTaskLabel.Text = "Edit Task";
            // 
            // TaskGroupBox
            // 
            this.TaskGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TaskGroupBox.Controls.Add(this.DeadlineErrorLabel);
            this.TaskGroupBox.Controls.Add(this.TaskStatusComboBox);
            this.TaskGroupBox.Controls.Add(this.TaskStatusLabel);
            this.TaskGroupBox.Controls.Add(this.TaskAssigneeComboBox);
            this.TaskGroupBox.Controls.Add(this.TaskAssigneeLabel);
            this.TaskGroupBox.Controls.Add(this.TaskDescriptionErrorLabel);
            this.TaskGroupBox.Controls.Add(this.TaskNameErrorLabel);
            this.TaskGroupBox.Controls.Add(this.TaskLeadComboBox);
            this.TaskGroupBox.Controls.Add(this.TaskLeadLabel);
            this.TaskGroupBox.Controls.Add(this.DeadlineLabel);
            this.TaskGroupBox.Controls.Add(this.DeadlineDateTimePicker);
            this.TaskGroupBox.Controls.Add(this.TaskDescriptionTextBox);
            this.TaskGroupBox.Controls.Add(this.TaskDescriptionLabel);
            this.TaskGroupBox.Controls.Add(this.TaskNameTextBox);
            this.TaskGroupBox.Controls.Add(this.TaskNameLabel);
            this.TaskGroupBox.Controls.Add(this.ApplyChangesButton);
            this.TaskGroupBox.Controls.Add(this.ResetButton);
            this.TaskGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.TaskGroupBox.Location = new System.Drawing.Point(42, 124);
            this.TaskGroupBox.Name = "TaskGroupBox";
            this.TaskGroupBox.Size = new System.Drawing.Size(1125, 229);
            this.TaskGroupBox.TabIndex = 75;
            this.TaskGroupBox.TabStop = false;
            this.TaskGroupBox.Text = "Edit Task Info";
            // 
            // DeadlineErrorLabel
            // 
            this.DeadlineErrorLabel.AutoSize = true;
            this.DeadlineErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.DeadlineErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeadlineErrorLabel.Location = new System.Drawing.Point(654, 22);
            this.DeadlineErrorLabel.Name = "DeadlineErrorLabel";
            this.DeadlineErrorLabel.Size = new System.Drawing.Size(12, 15);
            this.DeadlineErrorLabel.TabIndex = 78;
            this.DeadlineErrorLabel.Text = "*";
            // 
            // TaskStatusComboBox
            // 
            this.TaskStatusComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TaskStatusComboBox.FormattingEnabled = true;
            this.TaskStatusComboBox.Location = new System.Drawing.Point(642, 73);
            this.TaskStatusComboBox.Name = "TaskStatusComboBox";
            this.TaskStatusComboBox.Size = new System.Drawing.Size(200, 23);
            this.TaskStatusComboBox.TabIndex = 63;
            this.TaskStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.TaskStatusComboBox_SelectedIndexChanged);
            // 
            // TaskStatusLabel
            // 
            this.TaskStatusLabel.AutoSize = true;
            this.TaskStatusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TaskStatusLabel.Location = new System.Drawing.Point(568, 76);
            this.TaskStatusLabel.Name = "TaskStatusLabel";
            this.TaskStatusLabel.Size = new System.Drawing.Size(68, 15);
            this.TaskStatusLabel.TabIndex = 62;
            this.TaskStatusLabel.Text = "Task Status";
            // 
            // TaskAssigneeComboBox
            // 
            this.TaskAssigneeComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TaskAssigneeComboBox.FormattingEnabled = true;
            this.TaskAssigneeComboBox.Location = new System.Drawing.Point(341, 72);
            this.TaskAssigneeComboBox.Name = "TaskAssigneeComboBox";
            this.TaskAssigneeComboBox.Size = new System.Drawing.Size(189, 23);
            this.TaskAssigneeComboBox.TabIndex = 61;
            // 
            // TaskAssigneeLabel
            // 
            this.TaskAssigneeLabel.AutoSize = true;
            this.TaskAssigneeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TaskAssigneeLabel.Location = new System.Drawing.Point(253, 76);
            this.TaskAssigneeLabel.Name = "TaskAssigneeLabel";
            this.TaskAssigneeLabel.Size = new System.Drawing.Size(82, 15);
            this.TaskAssigneeLabel.TabIndex = 60;
            this.TaskAssigneeLabel.Text = "Task Assignee";
            // 
            // TaskDescriptionErrorLabel
            // 
            this.TaskDescriptionErrorLabel.AutoSize = true;
            this.TaskDescriptionErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TaskDescriptionErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TaskDescriptionErrorLabel.Location = new System.Drawing.Point(345, 108);
            this.TaskDescriptionErrorLabel.Name = "TaskDescriptionErrorLabel";
            this.TaskDescriptionErrorLabel.Size = new System.Drawing.Size(12, 15);
            this.TaskDescriptionErrorLabel.TabIndex = 57;
            this.TaskDescriptionErrorLabel.Text = "*";
            // 
            // TaskNameErrorLabel
            // 
            this.TaskNameErrorLabel.AutoSize = true;
            this.TaskNameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TaskNameErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TaskNameErrorLabel.Location = new System.Drawing.Point(142, 22);
            this.TaskNameErrorLabel.Name = "TaskNameErrorLabel";
            this.TaskNameErrorLabel.Size = new System.Drawing.Size(12, 15);
            this.TaskNameErrorLabel.TabIndex = 56;
            this.TaskNameErrorLabel.Text = "*";
            // 
            // TaskLeadComboBox
            // 
            this.TaskLeadComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TaskLeadComboBox.FormattingEnabled = true;
            this.TaskLeadComboBox.Location = new System.Drawing.Point(341, 37);
            this.TaskLeadComboBox.Name = "TaskLeadComboBox";
            this.TaskLeadComboBox.Size = new System.Drawing.Size(189, 23);
            this.TaskLeadComboBox.TabIndex = 7;
            // 
            // TaskLeadLabel
            // 
            this.TaskLeadLabel.AutoSize = true;
            this.TaskLeadLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TaskLeadLabel.Location = new System.Drawing.Point(274, 41);
            this.TaskLeadLabel.Name = "TaskLeadLabel";
            this.TaskLeadLabel.Size = new System.Drawing.Size(61, 15);
            this.TaskLeadLabel.TabIndex = 6;
            this.TaskLeadLabel.Text = "Task Lead";
            // 
            // DeadlineLabel
            // 
            this.DeadlineLabel.AutoSize = true;
            this.DeadlineLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DeadlineLabel.Location = new System.Drawing.Point(580, 41);
            this.DeadlineLabel.Name = "DeadlineLabel";
            this.DeadlineLabel.Size = new System.Drawing.Size(55, 15);
            this.DeadlineLabel.TabIndex = 5;
            this.DeadlineLabel.Text = "Deadline";
            // 
            // DeadlineDateTimePicker
            // 
            this.DeadlineDateTimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DeadlineDateTimePicker.Location = new System.Drawing.Point(642, 37);
            this.DeadlineDateTimePicker.Name = "DeadlineDateTimePicker";
            this.DeadlineDateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.DeadlineDateTimePicker.TabIndex = 4;
            // 
            // TaskDescriptionTextBox
            // 
            this.TaskDescriptionTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TaskDescriptionTextBox.Location = new System.Drawing.Point(97, 123);
            this.TaskDescriptionTextBox.Multiline = true;
            this.TaskDescriptionTextBox.Name = "TaskDescriptionTextBox";
            this.TaskDescriptionTextBox.PlaceholderText = "Task description...";
            this.TaskDescriptionTextBox.Size = new System.Drawing.Size(433, 97);
            this.TaskDescriptionTextBox.TabIndex = 3;
            // 
            // TaskDescriptionLabel
            // 
            this.TaskDescriptionLabel.AutoSize = true;
            this.TaskDescriptionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TaskDescriptionLabel.Location = new System.Drawing.Point(23, 126);
            this.TaskDescriptionLabel.Name = "TaskDescriptionLabel";
            this.TaskDescriptionLabel.Size = new System.Drawing.Size(68, 15);
            this.TaskDescriptionLabel.TabIndex = 2;
            this.TaskDescriptionLabel.Text = "Description";
            // 
            // TaskNameTextBox
            // 
            this.TaskNameTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TaskNameTextBox.Location = new System.Drawing.Point(97, 37);
            this.TaskNameTextBox.Name = "TaskNameTextBox";
            this.TaskNameTextBox.PlaceholderText = "Task name...";
            this.TaskNameTextBox.Size = new System.Drawing.Size(156, 22);
            this.TaskNameTextBox.TabIndex = 1;
            // 
            // TaskNameLabel
            // 
            this.TaskNameLabel.AutoSize = true;
            this.TaskNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TaskNameLabel.Location = new System.Drawing.Point(27, 41);
            this.TaskNameLabel.Name = "TaskNameLabel";
            this.TaskNameLabel.Size = new System.Drawing.Size(68, 15);
            this.TaskNameLabel.TabIndex = 0;
            this.TaskNameLabel.Text = "Task Name";
            // 
            // DeletedReasonComboBox
            // 
            this.DeletedReasonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeletedReasonComboBox.FormattingEnabled = true;
            this.DeletedReasonComboBox.Location = new System.Drawing.Point(1028, 382);
            this.DeletedReasonComboBox.Name = "DeletedReasonComboBox";
            this.DeletedReasonComboBox.Size = new System.Drawing.Size(139, 23);
            this.DeletedReasonComboBox.TabIndex = 76;
            // 
            // DeletedReasonLabel
            // 
            this.DeletedReasonLabel.AutoSize = true;
            this.DeletedReasonLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DeletedReasonLabel.Location = new System.Drawing.Point(1027, 366);
            this.DeletedReasonLabel.Name = "DeletedReasonLabel";
            this.DeletedReasonLabel.Size = new System.Drawing.Size(90, 15);
            this.DeletedReasonLabel.TabIndex = 58;
            this.DeletedReasonLabel.Text = "Deleted Reason";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(819, 363);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 77;
            this.pictureBox2.TabStop = false;
            // 
            // ArchievedTaskListButton
            // 
            this.ArchievedTaskListButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ArchievedTaskListButton.Location = new System.Drawing.Point(673, 690);
            this.ArchievedTaskListButton.Name = "ArchievedTaskListButton";
            this.ArchievedTaskListButton.Size = new System.Drawing.Size(151, 25);
            this.ArchievedTaskListButton.TabIndex = 78;
            this.ArchievedTaskListButton.Text = "Archieved Task List";
            this.ArchievedTaskListButton.UseVisualStyleBackColor = true;
            this.ArchievedTaskListButton.Click += new System.EventHandler(this.ArchievedTaskListButton_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.Location = new System.Drawing.Point(58, 739);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(81, 19);
            this.LoginLabel.TabIndex = 80;
            this.LoginLabel.Text = "ZZZZZZZZ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 740);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 79;
            this.label4.Text = "User: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 81;
            this.label1.Text = "Order by";
            // 
            // OrderByStatusButton
            // 
            this.OrderByStatusButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderByStatusButton.Location = new System.Drawing.Point(245, 382);
            this.OrderByStatusButton.Name = "OrderByStatusButton";
            this.OrderByStatusButton.Size = new System.Drawing.Size(66, 23);
            this.OrderByStatusButton.TabIndex = 82;
            this.OrderByStatusButton.Text = "Status";
            this.OrderByStatusButton.UseVisualStyleBackColor = true;
            this.OrderByStatusButton.Click += new System.EventHandler(this.OrderByStatusButton_Click);
            // 
            // OrderByNameButton
            // 
            this.OrderByNameButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderByNameButton.Location = new System.Drawing.Point(333, 382);
            this.OrderByNameButton.Name = "OrderByNameButton";
            this.OrderByNameButton.Size = new System.Drawing.Size(66, 23);
            this.OrderByNameButton.TabIndex = 83;
            this.OrderByNameButton.Text = "Name";
            this.OrderByNameButton.UseVisualStyleBackColor = true;
            this.OrderByNameButton.Click += new System.EventHandler(this.OrderByNameButton_Click);
            // 
            // OrderByDeadlineButton
            // 
            this.OrderByDeadlineButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderByDeadlineButton.Location = new System.Drawing.Point(421, 382);
            this.OrderByDeadlineButton.Name = "OrderByDeadlineButton";
            this.OrderByDeadlineButton.Size = new System.Drawing.Size(83, 23);
            this.OrderByDeadlineButton.TabIndex = 84;
            this.OrderByDeadlineButton.Text = "Deadline";
            this.OrderByDeadlineButton.UseVisualStyleBackColor = true;
            this.OrderByDeadlineButton.Click += new System.EventHandler(this.OrderbyDeadlineButton_Click);
            // 
            // OrderByIdButton
            // 
            this.OrderByIdButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderByIdButton.Location = new System.Drawing.Point(157, 382);
            this.OrderByIdButton.Name = "OrderByIdButton";
            this.OrderByIdButton.Size = new System.Drawing.Size(66, 23);
            this.OrderByIdButton.TabIndex = 85;
            this.OrderByIdButton.Text = "ID";
            this.OrderByIdButton.UseVisualStyleBackColor = true;
            this.OrderByIdButton.Click += new System.EventHandler(this.OrderbyIdButton_Click);
            // 
            // EditTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1292, 769);
            this.Controls.Add(this.OrderByIdButton);
            this.Controls.Add(this.OrderByDeadlineButton);
            this.Controls.Add(this.OrderByNameButton);
            this.Controls.Add(this.OrderByStatusButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ArchievedTaskListButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.DeletedReasonLabel);
            this.Controls.Add(this.DeletedReasonComboBox);
            this.Controls.Add(this.TaskGroupBox);
            this.Controls.Add(this.EditTaskLabel);
            this.Controls.Add(this.MasterErrorLabel);
            this.Controls.Add(this.DeleteTaskButton);
            this.Controls.Add(this.ActiveTaskListButton);
            this.Controls.Add(this.TaskDataGridView);
            this.Controls.Add(this.BackButton);
            this.Name = "EditTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Task Form";
            this.Load += new System.EventHandler(this.EditTaskForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TaskDataGridView)).EndInit();
            this.TaskGroupBox.ResumeLayout(false);
            this.TaskGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ActiveTaskListButton;
        private System.Windows.Forms.DataGridView TaskDataGridView;
        private System.Windows.Forms.Button ApplyChangesButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button DeleteTaskButton;
        private System.Windows.Forms.Label MasterErrorLabel;
        private System.Windows.Forms.Label EditTaskLabel;
        private System.Windows.Forms.GroupBox TaskGroupBox;
        private System.Windows.Forms.Label TaskDescriptionErrorLabel;
        private System.Windows.Forms.Label TaskNameErrorLabel;
        private System.Windows.Forms.ComboBox TaskLeadComboBox;
        private System.Windows.Forms.Label TaskLeadLabel;
        private System.Windows.Forms.Label DeadlineLabel;
        private System.Windows.Forms.DateTimePicker DeadlineDateTimePicker;
        private System.Windows.Forms.TextBox TaskDescriptionTextBox;
        private System.Windows.Forms.Label TaskDescriptionLabel;
        private System.Windows.Forms.TextBox TaskNameTextBox;
        private System.Windows.Forms.Label TaskNameLabel;
        private System.Windows.Forms.ComboBox DeletedReasonComboBox;
        private System.Windows.Forms.Label DeletedReasonLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox TaskAssigneeComboBox;
        private System.Windows.Forms.Label TaskAssigneeLabel;
        private System.Windows.Forms.ComboBox TaskStatusComboBox;
        private System.Windows.Forms.Label TaskStatusLabel;
        private System.Windows.Forms.Label DeadlineErrorLabel;
        private System.Windows.Forms.Button ArchievedTaskListButton;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OrderByStatusButton;
        private System.Windows.Forms.Button OrderByNameButton;
        private System.Windows.Forms.Button OrderByDeadlineButton;
        private System.Windows.Forms.Button OrderByIdButton;
    }
}