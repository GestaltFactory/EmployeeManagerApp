
namespace EmployeeManagerUI
{
    partial class EmployeeSimpleViewForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeSimpleViewForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EmployeeViewLabel = new System.Windows.Forms.Label();
            this.SearchCategoryTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.DisplayDataGridView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.HistoryListButton = new System.Windows.Forms.Button();
            this.ActiveEmployeeListButton = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InactiveEmployeeListButton = new System.Windows.Forms.Button();
            this.ActiveTaskListButton = new System.Windows.Forms.Button();
            this.ArchievedTaskButton = new System.Windows.Forms.Button();
            this.MyActiveTaskListButton = new System.Windows.Forms.Button();
            this.SearchToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.EmployeePicturePictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MessageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePicturePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(956, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // EmployeeViewLabel
            // 
            this.EmployeeViewLabel.AutoSize = true;
            this.EmployeeViewLabel.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.EmployeeViewLabel.Location = new System.Drawing.Point(245, 10);
            this.EmployeeViewLabel.Name = "EmployeeViewLabel";
            this.EmployeeViewLabel.Size = new System.Drawing.Size(564, 37);
            this.EmployeeViewLabel.TabIndex = 67;
            this.EmployeeViewLabel.Text = "Display Inactive Employee List Information";
            // 
            // SearchCategoryTextBox
            // 
            this.SearchCategoryTextBox.Location = new System.Drawing.Point(741, 77);
            this.SearchCategoryTextBox.Name = "SearchCategoryTextBox";
            this.SearchCategoryTextBox.PlaceholderText = "search...";
            this.SearchCategoryTextBox.Size = new System.Drawing.Size(209, 23);
            this.SearchCategoryTextBox.TabIndex = 66;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SearchButton.Location = new System.Drawing.Point(868, 106);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(82, 23);
            this.SearchButton.TabIndex = 65;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DisplayDataGridView
            // 
            this.DisplayDataGridView.AllowUserToAddRows = false;
            this.DisplayDataGridView.AllowUserToDeleteRows = false;
            this.DisplayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DisplayDataGridView.Location = new System.Drawing.Point(12, 154);
            this.DisplayDataGridView.MultiSelect = false;
            this.DisplayDataGridView.Name = "DisplayDataGridView";
            this.DisplayDataGridView.RowTemplate.Height = 25;
            this.DisplayDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DisplayDataGridView.Size = new System.Drawing.Size(1016, 463);
            this.DisplayDataGridView.TabIndex = 61;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackButton.Location = new System.Drawing.Point(870, 695);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(158, 48);
            this.BackButton.TabIndex = 60;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // HistoryListButton
            // 
            this.HistoryListButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HistoryListButton.Location = new System.Drawing.Point(897, 623);
            this.HistoryListButton.Name = "HistoryListButton";
            this.HistoryListButton.Size = new System.Drawing.Size(131, 25);
            this.HistoryListButton.TabIndex = 79;
            this.HistoryListButton.Text = "Task History";
            this.HistoryListButton.UseVisualStyleBackColor = true;
            this.HistoryListButton.Click += new System.EventHandler(this.HistoryListButton_Click);
            // 
            // ActiveEmployeeListButton
            // 
            this.ActiveEmployeeListButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ActiveEmployeeListButton.Location = new System.Drawing.Point(12, 623);
            this.ActiveEmployeeListButton.Name = "ActiveEmployeeListButton";
            this.ActiveEmployeeListButton.Size = new System.Drawing.Size(152, 25);
            this.ActiveEmployeeListButton.TabIndex = 80;
            this.ActiveEmployeeListButton.Text = "Active Employee List";
            this.ActiveEmployeeListButton.UseVisualStyleBackColor = true;
            this.ActiveEmployeeListButton.Click += new System.EventHandler(this.ActiveEmployeeListButton_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.Location = new System.Drawing.Point(51, 739);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(81, 19);
            this.LoginLabel.TabIndex = 82;
            this.LoginLabel.Text = "ZZZZZZZZ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 740);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 81;
            this.label4.Text = "User: ";
            // 
            // InactiveEmployeeListButton
            // 
            this.InactiveEmployeeListButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InactiveEmployeeListButton.Location = new System.Drawing.Point(192, 623);
            this.InactiveEmployeeListButton.Name = "InactiveEmployeeListButton";
            this.InactiveEmployeeListButton.Size = new System.Drawing.Size(166, 25);
            this.InactiveEmployeeListButton.TabIndex = 83;
            this.InactiveEmployeeListButton.Text = "Inactive Employee List";
            this.InactiveEmployeeListButton.UseVisualStyleBackColor = true;
            this.InactiveEmployeeListButton.Click += new System.EventHandler(this.InactiveEmployeeListButton_Click);
            // 
            // ActiveTaskListButton
            // 
            this.ActiveTaskListButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ActiveTaskListButton.Location = new System.Drawing.Point(580, 623);
            this.ActiveTaskListButton.Name = "ActiveTaskListButton";
            this.ActiveTaskListButton.Size = new System.Drawing.Size(123, 25);
            this.ActiveTaskListButton.TabIndex = 84;
            this.ActiveTaskListButton.Text = "Active Task List";
            this.ActiveTaskListButton.UseVisualStyleBackColor = true;
            this.ActiveTaskListButton.Click += new System.EventHandler(this.ActiveTaskListButton_Click);
            // 
            // ArchievedTaskButton
            // 
            this.ArchievedTaskButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ArchievedTaskButton.Location = new System.Drawing.Point(731, 623);
            this.ArchievedTaskButton.Name = "ArchievedTaskButton";
            this.ArchievedTaskButton.Size = new System.Drawing.Size(138, 25);
            this.ArchievedTaskButton.TabIndex = 85;
            this.ArchievedTaskButton.Text = "Archieved Task List";
            this.ArchievedTaskButton.UseVisualStyleBackColor = true;
            this.ArchievedTaskButton.Click += new System.EventHandler(this.ArchievedTaskButton_Click);
            // 
            // MyActiveTaskListButton
            // 
            this.MyActiveTaskListButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MyActiveTaskListButton.Location = new System.Drawing.Point(386, 623);
            this.MyActiveTaskListButton.Name = "MyActiveTaskListButton";
            this.MyActiveTaskListButton.Size = new System.Drawing.Size(166, 25);
            this.MyActiveTaskListButton.TabIndex = 86;
            this.MyActiveTaskListButton.Text = "My Task List";
            this.MyActiveTaskListButton.UseVisualStyleBackColor = true;
            this.MyActiveTaskListButton.Click += new System.EventHandler(this.MyActiveTaskListButton_Click);
            // 
            // EmployeePicturePictureBox
            // 
            this.EmployeePicturePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmployeePicturePictureBox.Location = new System.Drawing.Point(16, 10);
            this.EmployeePicturePictureBox.Name = "EmployeePicturePictureBox";
            this.EmployeePicturePictureBox.Size = new System.Drawing.Size(180, 135);
            this.EmployeePicturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EmployeePicturePictureBox.TabIndex = 87;
            this.EmployeePicturePictureBox.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.MessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MessageLabel.Location = new System.Drawing.Point(309, 669);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(12, 15);
            this.MessageLabel.TabIndex = 88;
            this.MessageLabel.Text = "*";
            // 
            // EmployeeSimpleViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1081, 769);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.EmployeePicturePictureBox);
            this.Controls.Add(this.MyActiveTaskListButton);
            this.Controls.Add(this.ArchievedTaskButton);
            this.Controls.Add(this.ActiveTaskListButton);
            this.Controls.Add(this.InactiveEmployeeListButton);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ActiveEmployeeListButton);
            this.Controls.Add(this.HistoryListButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EmployeeViewLabel);
            this.Controls.Add(this.SearchCategoryTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DisplayDataGridView);
            this.Controls.Add(this.BackButton);
            this.Name = "EmployeeSimpleViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeSimpleViewForm";
            this.Load += new System.EventHandler(this.EmployeeSimpleViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePicturePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label EmployeeViewLabel;
        private System.Windows.Forms.TextBox SearchCategoryTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView DisplayDataGridView;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button HistoryListButton;
        private System.Windows.Forms.Button ActiveEmployeeListButton;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button InactiveEmployeeListButton;
        private System.Windows.Forms.Button ActiveTaskListButton;
        private System.Windows.Forms.Button ArchievedTaskButton;
        private System.Windows.Forms.Button MyActiveTaskListButton;
        private System.Windows.Forms.ToolTip SearchToolTip;
        private System.Windows.Forms.PictureBox EmployeePicturePictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label MessageLabel;
    }
}