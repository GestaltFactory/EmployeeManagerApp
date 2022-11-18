
namespace EmployeeManagerUI
{
    partial class EmployeeManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagementForm));
            this.BackButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AddEmpButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EditEmpButton = new System.Windows.Forms.Button();
            this.AddLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EditEmployeeAccessErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackButton.Location = new System.Drawing.Point(900, 615);
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
            this.label2.Location = new System.Drawing.Point(160, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(726, 65);
            this.label2.TabIndex = 48;
            this.label2.Text = "Employee Management System";
            // 
            // AddEmpButton
            // 
            this.AddEmpButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddEmpButton.FlatAppearance.BorderSize = 3;
            this.AddEmpButton.Image = ((System.Drawing.Image)(resources.GetObject("AddEmpButton.Image")));
            this.AddEmpButton.Location = new System.Drawing.Point(96, 255);
            this.AddEmpButton.Name = "AddEmpButton";
            this.AddEmpButton.Size = new System.Drawing.Size(372, 283);
            this.AddEmpButton.TabIndex = 47;
            this.AddEmpButton.UseVisualStyleBackColor = true;
            this.AddEmpButton.Click += new System.EventHandler(this.AddEmpButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(606, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 37);
            this.label1.TabIndex = 46;
            this.label1.Text = "Edit an existing Employee";
            // 
            // EditEmpButton
            // 
            this.EditEmpButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.EditEmpButton.FlatAppearance.BorderSize = 3;
            this.EditEmpButton.Image = ((System.Drawing.Image)(resources.GetObject("EditEmpButton.Image")));
            this.EditEmpButton.Location = new System.Drawing.Point(612, 255);
            this.EditEmpButton.Name = "EditEmpButton";
            this.EditEmpButton.Size = new System.Drawing.Size(372, 283);
            this.EditEmpButton.TabIndex = 45;
            this.EditEmpButton.UseVisualStyleBackColor = true;
            this.EditEmpButton.Click += new System.EventHandler(this.EditEmpButton_Click);
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.AddLabel.Location = new System.Drawing.Point(124, 215);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(318, 37);
            this.AddLabel.TabIndex = 44;
            this.AddLabel.Text = "Add a new Employee";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.Location = new System.Drawing.Point(54, 667);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(81, 19);
            this.LoginLabel.TabIndex = 51;
            this.LoginLabel.Text = "ZZZZZZZZ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 668);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 50;
            this.label4.Text = "User: ";
            // 
            // EditEmployeeAccessErrorLabel
            // 
            this.EditEmployeeAccessErrorLabel.AutoSize = true;
            this.EditEmployeeAccessErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.EditEmployeeAccessErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EditEmployeeAccessErrorLabel.Location = new System.Drawing.Point(623, 553);
            this.EditEmployeeAccessErrorLabel.Name = "EditEmployeeAccessErrorLabel";
            this.EditEmployeeAccessErrorLabel.Size = new System.Drawing.Size(12, 15);
            this.EditEmployeeAccessErrorLabel.TabIndex = 56;
            this.EditEmployeeAccessErrorLabel.Text = "*";
            // 
            // EmployeeManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1119, 697);
            this.Controls.Add(this.EditEmployeeAccessErrorLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddEmpButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditEmpButton);
            this.Controls.Add(this.AddLabel);
            this.Name = "EmployeeManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management Form";
            this.Load += new System.EventHandler(this.EmployeeManagementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddEmpButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditEmpButton;
        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label EditEmployeeAccessErrorLabel;
    }
}