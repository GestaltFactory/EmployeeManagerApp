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
    public partial class EmployeeManagementForm : Form
    {
        private List<Employee> GetAllEmployees = GlobalConfig.connections.GetAllEmployees();

        public EmployeeManagementForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenuForm backToMain = new MainMenuForm();
            backToMain.FormClosed += (sender, args) => Close();
            backToMain.Show();
        }

        private void AddEmpButton_Click(object sender, EventArgs e)
        {
            Hide();
            var creationForm = new CreateEmployeeForm();
            creationForm.Closed += (s, args) => Close();
            creationForm.Show();
        }

        private void EditEmpButton_Click(object sender, EventArgs e)
        {
            Hide();
            var EditForm = new EditEmployeeForm();
            EditForm.Closed += (s, args) => Close();
            EditForm.Show();
        }

        private void EmployeeManagementForm_Load(object sender, EventArgs e)
        {
            LoginLabel.Text = LoginInfo.CurrentUserName;

            if (GetAllEmployees.Count == 0)
            {
                EditEmpButton.Enabled = false;
                EditEmployeeAccessErrorLabel.Text = "* You need at least one employee to edit an employee!";
            }
            else
            {
                EditEmpButton.Enabled = true;
                EditEmployeeAccessErrorLabel.Text = "";
            }
        }
    }
}