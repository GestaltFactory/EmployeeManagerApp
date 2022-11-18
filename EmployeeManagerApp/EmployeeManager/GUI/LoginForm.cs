using EmployeeClassLibrary;
using EmployeeClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EmployeeManagerUI
{
    public partial class LoginForm : Form
    {
        private List<Employee> GetCredentialsFromList = GlobalConfig.connections.GetAllEmployees();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {         
            if (Login())
            {
                if (PasswordTextBox.Text == ConfirmPassTextBox.Text)
                {
                    Hide();
                    var mainMenuForm = new MainMenuForm();
                    mainMenuForm.Closed += (s, args) => Close();
                    mainMenuForm.Show();
                }
                else
                {
                    ErrorLabel.Text = "Passwords do not match!";
                    Reset();
                }
            }
            else
            {
                ErrorLabel.Text = "Invalid Username or Password!";
                Reset();
            }
        }

        private bool Login()
        {
            List<Employee> admin = new List<Employee>();
            foreach (Employee emp in GetCredentialsFromList)
            {
                if (emp.IsAdmin)
                {
                    admin.Add(emp);
                }
            }
            
            
            
            
            
            if (GetCredentialsFromList.Count == 0 || admin.Count == 0)
            {
                if (AdminRadioButton.Checked && UsernameTextBox.Text == LoginInfo.SuperUser && PasswordTextBox.Text == LoginInfo.SuperPassword)
                {
                    LoginInfo.CurrentUserName = $"GOD";
                    LoginInfo.Admin = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                foreach (Employee emp in GetCredentialsFromList)
                {
                    if (EmployeeRadioButton.Checked)
                    {
                        if (emp.IsAdmin == false && UsernameTextBox.Text == emp.AdminUsername && PasswordTextBox.Text == emp.AdminPassword)
                        {
                            LoginInfo.CurrentUserName = $"{emp.FirstName} {emp.LastName}";
                            LoginInfo.Id = emp.Id;
                            LoginInfo.Admin = false;
                            return true;
                        }
                    }
                    else
                    {
                        if (emp.IsAdmin == true && UsernameTextBox.Text == emp.AdminUsername && PasswordTextBox.Text == emp.AdminPassword)
                        {
                            LoginInfo.CurrentUserName = $"{emp.FirstName} {emp.LastName}";
                            LoginInfo.Id = emp.Id;
                            LoginInfo.Admin = true;
                            return true;
                        }
                    }
                }

                return false;
            }                  
        }

        private void Reset() 
        {
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
            ConfirmPassTextBox.Text = "";
            UsernameTextBox.Focus();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            ErrorReset(UsernameTextBox);
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            ErrorReset(PasswordTextBox);
        }

        private void ConfirmPassTextBox_TextChanged(object sender, EventArgs e)
        {
            ErrorReset(ConfirmPassTextBox);
        }

        private void ErrorReset(TextBox tb)
        {
            if (tb.Focused)
            {
                ErrorLabel.Text = "";
            }
        }

        private void EmployeeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AdminPictureBox.Visible = false;
            ErrorLabel.Text = "";
        }

        private void AdminRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AdminPictureBox.Visible = true;
            ErrorLabel.Text = "";
        }
    }
}