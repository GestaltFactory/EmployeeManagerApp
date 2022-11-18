using EmployeeClassLibrary;
using EmployeeClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmployeeManagerUI
{
    public partial class TaskManagementForm : Form
    {
        private List<Task> getAllTask = GlobalConfig.connections.GetAllTasks();

        public TaskManagementForm()
        {
            InitializeComponent();
        }

        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            Hide();
            var createTask = new CreateTaskForm();
            createTask.Closed += (s, args) => Close();
            createTask.Show();
        }

        private void EditTaskButton_Click(object sender, EventArgs e)
        {
            Hide();
            var createTask = new EditTaskForm();
            createTask.Closed += (s, args) => Close();
            createTask.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            var mainMenuForm = new MainMenuForm();
            mainMenuForm.Closed += (s, args) => Close();
            mainMenuForm.Show();
        }

        private void TaskManagementForm_Load(object sender, EventArgs e)
        {
            LoginLabel.Text = LoginInfo.CurrentUserName;

            if (getAllTask.Count == 0)
            {
                EditTaskButton.Enabled = false;
                EditTaskAccessErrorLabel.Text = "* You need at least one task to edit a Task!";
            }
            else
            {
                EditTaskButton.Enabled = true;
                EditTaskAccessErrorLabel.Text = "";
            }
        }
    }
}