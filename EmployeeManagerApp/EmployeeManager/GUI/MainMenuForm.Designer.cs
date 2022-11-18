
namespace EmployeeManagerUI
{
    partial class MainMenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.EmployeeManagementLabel = new System.Windows.Forms.Label();
            this.TaskManagementLabel = new System.Windows.Forms.Label();
            this.TaskManagementButton = new System.Windows.Forms.Button();
            this.EmployeeManagementButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AssigmentButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.TaskFormAccessErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmployeeManagementLabel
            // 
            this.EmployeeManagementLabel.AutoSize = true;
            this.EmployeeManagementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.EmployeeManagementLabel.Location = new System.Drawing.Point(35, 174);
            this.EmployeeManagementLabel.Name = "EmployeeManagementLabel";
            this.EmployeeManagementLabel.Size = new System.Drawing.Size(352, 37);
            this.EmployeeManagementLabel.TabIndex = 1;
            this.EmployeeManagementLabel.Text = "Employee Management";
            // 
            // TaskManagementLabel
            // 
            this.TaskManagementLabel.AutoSize = true;
            this.TaskManagementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TaskManagementLabel.Location = new System.Drawing.Point(909, 174);
            this.TaskManagementLabel.Name = "TaskManagementLabel";
            this.TaskManagementLabel.Size = new System.Drawing.Size(282, 37);
            this.TaskManagementLabel.TabIndex = 3;
            this.TaskManagementLabel.Text = "Task Management";
            // 
            // TaskManagementButton
            // 
            this.TaskManagementButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.TaskManagementButton.FlatAppearance.BorderSize = 3;
            this.TaskManagementButton.Image = ((System.Drawing.Image)(resources.GetObject("TaskManagementButton.Image")));
            this.TaskManagementButton.Location = new System.Drawing.Point(865, 214);
            this.TaskManagementButton.Name = "TaskManagementButton";
            this.TaskManagementButton.Size = new System.Drawing.Size(372, 283);
            this.TaskManagementButton.TabIndex = 2;
            this.TaskManagementButton.UseVisualStyleBackColor = true;
            this.TaskManagementButton.Click += new System.EventHandler(this.TaskManagementButton_Click);
            // 
            // EmployeeManagementButton
            // 
            this.EmployeeManagementButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.EmployeeManagementButton.FlatAppearance.BorderSize = 3;
            this.EmployeeManagementButton.Image = ((System.Drawing.Image)(resources.GetObject("EmployeeManagementButton.Image")));
            this.EmployeeManagementButton.Location = new System.Drawing.Point(26, 214);
            this.EmployeeManagementButton.Name = "EmployeeManagementButton";
            this.EmployeeManagementButton.Size = new System.Drawing.Size(372, 283);
            this.EmployeeManagementButton.TabIndex = 4;
            this.EmployeeManagementButton.UseVisualStyleBackColor = true;
            this.EmployeeManagementButton.Click += new System.EventHandler(this.EmployeeManagementButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 65);
            this.label2.TabIndex = 5;
            this.label2.Text = "Main Menu";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogoutButton.Location = new System.Drawing.Point(1079, 553);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(158, 48);
            this.LogoutButton.TabIndex = 43;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(578, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 37);
            this.label3.TabIndex = 45;
            this.label3.Text = "Display";
            // 
            // AssigmentButton
            // 
            this.AssigmentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AssigmentButton.FlatAppearance.BorderSize = 3;
            this.AssigmentButton.Image = ((System.Drawing.Image)(resources.GetObject("AssigmentButton.Image")));
            this.AssigmentButton.Location = new System.Drawing.Point(446, 214);
            this.AssigmentButton.Name = "AssigmentButton";
            this.AssigmentButton.Size = new System.Drawing.Size(372, 283);
            this.AssigmentButton.TabIndex = 44;
            this.AssigmentButton.UseVisualStyleBackColor = true;
            this.AssigmentButton.Click += new System.EventHandler(this.AssigmentButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 591);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 46;
            this.label4.Text = "User: ";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.Location = new System.Drawing.Point(51, 590);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(81, 19);
            this.LoginLabel.TabIndex = 47;
            this.LoginLabel.Text = "ZZZZZZZZ";
            // 
            // TaskFormAccessErrorLabel
            // 
            this.TaskFormAccessErrorLabel.AutoSize = true;
            this.TaskFormAccessErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TaskFormAccessErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TaskFormAccessErrorLabel.Location = new System.Drawing.Point(878, 500);
            this.TaskFormAccessErrorLabel.Name = "TaskFormAccessErrorLabel";
            this.TaskFormAccessErrorLabel.Size = new System.Drawing.Size(12, 15);
            this.TaskFormAccessErrorLabel.TabIndex = 57;
            this.TaskFormAccessErrorLabel.Text = "*";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1281, 620);
            this.Controls.Add(this.TaskFormAccessErrorLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AssigmentButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmployeeManagementButton);
            this.Controls.Add(this.TaskManagementLabel);
            this.Controls.Add(this.TaskManagementButton);
            this.Controls.Add(this.EmployeeManagementLabel);
            this.Name = "MainMenuForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management System Main Menu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label EmployeeManagementLabel;
        private System.Windows.Forms.Label TaskManagementLabel;
        private System.Windows.Forms.Button TaskManagementButton;
        private System.Windows.Forms.Button EmployeeManagementButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AssigmentButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label TaskFormAccessErrorLabel;
    }
}

