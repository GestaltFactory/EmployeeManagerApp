
namespace EmployeeManagerUI
{
    partial class TaskManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskManagementForm));
            this.BackButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateTaskButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EditTaskButton = new System.Windows.Forms.Button();
            this.AddLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EditTaskAccessErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackButton.Location = new System.Drawing.Point(887, 597);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(158, 48);
            this.BackButton.TabIndex = 49;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(238, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(614, 65);
            this.label2.TabIndex = 48;
            this.label2.Text = "Task Management System";
            // 
            // CreateTaskButton
            // 
            this.CreateTaskButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTaskButton.FlatAppearance.BorderSize = 3;
            this.CreateTaskButton.Image = ((System.Drawing.Image)(resources.GetObject("CreateTaskButton.Image")));
            this.CreateTaskButton.Location = new System.Drawing.Point(83, 237);
            this.CreateTaskButton.Name = "CreateTaskButton";
            this.CreateTaskButton.Size = new System.Drawing.Size(372, 283);
            this.CreateTaskButton.TabIndex = 47;
            this.CreateTaskButton.UseVisualStyleBackColor = true;
            this.CreateTaskButton.Click += new System.EventHandler(this.CreateTaskButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(609, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 37);
            this.label1.TabIndex = 46;
            this.label1.Text = "Edit and assign a Task";
            // 
            // EditTaskButton
            // 
            this.EditTaskButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.EditTaskButton.FlatAppearance.BorderSize = 3;
            this.EditTaskButton.Image = ((System.Drawing.Image)(resources.GetObject("EditTaskButton.Image")));
            this.EditTaskButton.Location = new System.Drawing.Point(599, 237);
            this.EditTaskButton.Name = "EditTaskButton";
            this.EditTaskButton.Size = new System.Drawing.Size(372, 283);
            this.EditTaskButton.TabIndex = 45;
            this.EditTaskButton.UseVisualStyleBackColor = true;
            this.EditTaskButton.Click += new System.EventHandler(this.EditTaskButton_Click);
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.AddLabel.Location = new System.Drawing.Point(142, 197);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(248, 37);
            this.AddLabel.TabIndex = 44;
            this.AddLabel.Text = "Add a new Task";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.Location = new System.Drawing.Point(55, 639);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(81, 19);
            this.LoginLabel.TabIndex = 51;
            this.LoginLabel.Text = "ZZZZZZZZ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 640);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 50;
            this.label4.Text = "User: ";
            // 
            // EditTaskAccessErrorLabel
            // 
            this.EditTaskAccessErrorLabel.AutoSize = true;
            this.EditTaskAccessErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.EditTaskAccessErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EditTaskAccessErrorLabel.Location = new System.Drawing.Point(609, 539);
            this.EditTaskAccessErrorLabel.Name = "EditTaskAccessErrorLabel";
            this.EditTaskAccessErrorLabel.Size = new System.Drawing.Size(12, 15);
            this.EditTaskAccessErrorLabel.TabIndex = 57;
            this.EditTaskAccessErrorLabel.Text = "*";
            // 
            // TaskManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1109, 669);
            this.Controls.Add(this.EditTaskAccessErrorLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CreateTaskButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditTaskButton);
            this.Controls.Add(this.AddLabel);
            this.Name = "TaskManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Management Form";
            this.Load += new System.EventHandler(this.TaskManagementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateTaskButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditTaskButton;
        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label EditTaskAccessErrorLabel;
    }
}