
namespace EmployeeManagerUI
{
    partial class CreateTaskForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.TaskGroupBox = new System.Windows.Forms.GroupBox();
            this.DeadlineErrorLabel = new System.Windows.Forms.Label();
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
            this.CreateTaskButton = new System.Windows.Forms.Button();
            this.ResetFormButton = new System.Windows.Forms.Button();
            this.MasterErrorLabel = new System.Windows.Forms.Label();
            this.CreateTaskLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TaskGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackButton.Location = new System.Drawing.Point(457, 444);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(158, 48);
            this.BackButton.TabIndex = 44;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TaskGroupBox
            // 
            this.TaskGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TaskGroupBox.Controls.Add(this.DeadlineErrorLabel);
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
            this.TaskGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.TaskGroupBox.Location = new System.Drawing.Point(74, 105);
            this.TaskGroupBox.Name = "TaskGroupBox";
            this.TaskGroupBox.Size = new System.Drawing.Size(845, 226);
            this.TaskGroupBox.TabIndex = 45;
            this.TaskGroupBox.TabStop = false;
            this.TaskGroupBox.Text = "Task Creation";
            // 
            // DeadlineErrorLabel
            // 
            this.DeadlineErrorLabel.AutoSize = true;
            this.DeadlineErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.DeadlineErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeadlineErrorLabel.Location = new System.Drawing.Point(363, 63);
            this.DeadlineErrorLabel.Name = "DeadlineErrorLabel";
            this.DeadlineErrorLabel.Size = new System.Drawing.Size(12, 15);
            this.DeadlineErrorLabel.TabIndex = 60;
            this.DeadlineErrorLabel.Text = "*";
            // 
            // TaskDescriptionErrorLabel
            // 
            this.TaskDescriptionErrorLabel.AutoSize = true;
            this.TaskDescriptionErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TaskDescriptionErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TaskDescriptionErrorLabel.Location = new System.Drawing.Point(142, 106);
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
            this.TaskLeadComboBox.Size = new System.Drawing.Size(200, 23);
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
            this.DeadlineLabel.Location = new System.Drawing.Point(279, 82);
            this.DeadlineLabel.Name = "DeadlineLabel";
            this.DeadlineLabel.Size = new System.Drawing.Size(55, 15);
            this.DeadlineLabel.TabIndex = 5;
            this.DeadlineLabel.Text = "Deadline";
            // 
            // DeadlineDateTimePicker
            // 
            this.DeadlineDateTimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DeadlineDateTimePicker.Location = new System.Drawing.Point(341, 78);
            this.DeadlineDateTimePicker.Name = "DeadlineDateTimePicker";
            this.DeadlineDateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.DeadlineDateTimePicker.TabIndex = 4;
            // 
            // TaskDescriptionTextBox
            // 
            this.TaskDescriptionTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TaskDescriptionTextBox.Location = new System.Drawing.Point(97, 121);
            this.TaskDescriptionTextBox.Multiline = true;
            this.TaskDescriptionTextBox.Name = "TaskDescriptionTextBox";
            this.TaskDescriptionTextBox.PlaceholderText = "Task description...";
            this.TaskDescriptionTextBox.Size = new System.Drawing.Size(444, 97);
            this.TaskDescriptionTextBox.TabIndex = 3;
            // 
            // TaskDescriptionLabel
            // 
            this.TaskDescriptionLabel.AutoSize = true;
            this.TaskDescriptionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TaskDescriptionLabel.Location = new System.Drawing.Point(23, 124);
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
            // CreateTaskButton
            // 
            this.CreateTaskButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateTaskButton.Location = new System.Drawing.Point(374, 352);
            this.CreateTaskButton.Name = "CreateTaskButton";
            this.CreateTaskButton.Size = new System.Drawing.Size(106, 42);
            this.CreateTaskButton.TabIndex = 47;
            this.CreateTaskButton.Text = "Create Task";
            this.CreateTaskButton.UseVisualStyleBackColor = true;
            this.CreateTaskButton.Click += new System.EventHandler(this.CreateTaskButton_Click);
            // 
            // ResetFormButton
            // 
            this.ResetFormButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetFormButton.Location = new System.Drawing.Point(509, 352);
            this.ResetFormButton.Name = "ResetFormButton";
            this.ResetFormButton.Size = new System.Drawing.Size(106, 42);
            this.ResetFormButton.TabIndex = 48;
            this.ResetFormButton.Text = "Reset Form";
            this.ResetFormButton.UseVisualStyleBackColor = true;
            this.ResetFormButton.Click += new System.EventHandler(this.ResetFormButton_Click);
            // 
            // MasterErrorLabel
            // 
            this.MasterErrorLabel.AutoSize = true;
            this.MasterErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.MasterErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MasterErrorLabel.Location = new System.Drawing.Point(442, 76);
            this.MasterErrorLabel.Name = "MasterErrorLabel";
            this.MasterErrorLabel.Size = new System.Drawing.Size(12, 15);
            this.MasterErrorLabel.TabIndex = 49;
            this.MasterErrorLabel.Text = "*";
            // 
            // CreateTaskLabel
            // 
            this.CreateTaskLabel.AutoSize = true;
            this.CreateTaskLabel.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CreateTaskLabel.Location = new System.Drawing.Point(74, 21);
            this.CreateTaskLabel.Name = "CreateTaskLabel";
            this.CreateTaskLabel.Size = new System.Drawing.Size(197, 45);
            this.CreateTaskLabel.TabIndex = 50;
            this.CreateTaskLabel.Text = "Create Task";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.Location = new System.Drawing.Point(52, 495);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(81, 19);
            this.LoginLabel.TabIndex = 52;
            this.LoginLabel.Text = "ZZZZZZZZ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 51;
            this.label4.Text = "User: ";
            // 
            // CreateTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(702, 525);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CreateTaskLabel);
            this.Controls.Add(this.MasterErrorLabel);
            this.Controls.Add(this.ResetFormButton);
            this.Controls.Add(this.CreateTaskButton);
            this.Controls.Add(this.TaskGroupBox);
            this.Controls.Add(this.BackButton);
            this.Name = "CreateTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Task Form";
            this.Load += new System.EventHandler(this.CreateTaskForm_Load);
            this.TaskGroupBox.ResumeLayout(false);
            this.TaskGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.GroupBox TaskGroupBox;
        private System.Windows.Forms.Label DeadlineLabel;
        private System.Windows.Forms.DateTimePicker DeadlineDateTimePicker;
        private System.Windows.Forms.TextBox TaskDescriptionTextBox;
        private System.Windows.Forms.Label TaskDescriptionLabel;
        private System.Windows.Forms.TextBox TaskNameTextBox;
        private System.Windows.Forms.Label TaskNameLabel;
        private System.Windows.Forms.ComboBox TaskLeadComboBox;
        private System.Windows.Forms.Label TaskLeadLabel;
        private System.Windows.Forms.Button CreateTaskButton;
        private System.Windows.Forms.Button ResetFormButton;
        private System.Windows.Forms.Label TaskNameErrorLabel;
        private System.Windows.Forms.Label TaskDescriptionErrorLabel;
        private System.Windows.Forms.Label MasterErrorLabel;
        private System.Windows.Forms.Label CreateTaskLabel;
        private System.Windows.Forms.Label DeadlineErrorLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label label4;
    }
}