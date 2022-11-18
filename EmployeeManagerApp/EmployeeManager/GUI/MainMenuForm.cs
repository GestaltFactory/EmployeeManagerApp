using EmployeeClassLibrary;
using EmployeeClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagerUI
{
    public partial class MainMenuForm : Form
    {
        private List<Employee> GetAllEmployees = GlobalConfig.connections.GetAllEmployees();

        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void EmployeeManagementButton_Click(object sender, EventArgs e)
        {
            Hide();
            var empManagement = new EmployeeManagementForm();
            empManagement.Closed += (s, args) => Close();
            empManagement.Show();
        }

        private void TaskManagementButton_Click(object sender, EventArgs e)
        {
            Hide();
            var taskManagement = new TaskManagementForm();
            taskManagement.Closed += (s, args) => Close();
            taskManagement.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Hide();
            LoginInfo.CurrentUserName = "";
            LoginInfo.Admin = false;
            var loginForm = new LoginForm();
            loginForm.Closed += (s, args) => Close();
            loginForm.Show();
        }

        private void AssigmentButton_Click(object sender, EventArgs e)
        {
            Hide();
            var loginForm = new EmployeeSimpleViewForm();
            loginForm.Closed += (s, args) => Close();
            loginForm.Show();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            LoginLabel.Text = LoginInfo.CurrentUserName;

            if (LoginInfo.Admin == true)
            {
                SetLoginInfo(true);
            }
            else
            {
                SetLoginInfo(false);
            }

            if (LoginInfo.Admin == true && GetAllEmployees.Count == 0)
            {
                TaskManagementButton.Enabled = false;
                TaskFormAccessErrorLabel.Text = "* You need at least one employee to create a Task!";
            }
            else
            {
                TaskManagementButton.Enabled = true;
                TaskFormAccessErrorLabel.Text = "";
            }
        }

        private void SetLoginInfo(bool state)
        {
            EmployeeManagementButton.Visible = state;
            EmployeeManagementLabel.Visible = state;
            TaskManagementButton.Visible = state;
            TaskManagementLabel.Visible = state;
        }
    }
}