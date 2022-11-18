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
    public partial class EmployeeSimpleViewForm : Form
    {
        private List<TaskHistory> getAllHistoryTask = GlobalConfig.connections.GetAllHistoryTask();
        private List<Employee> GetAllEmployees = GlobalConfig.connections.GetAllEmployees();
        private List<Employee> GetAllArchievedEmployees = GlobalConfig.connections.GetAllArchievedEmployees();
        private List<Task> getAllTask = GlobalConfig.connections.GetAllTasks();
        private List<Task> getAllArchievedTask = GlobalConfig.connections.GetAllArchievedTasks();
        private SelectedListForSearch selectedCategoryList = SelectedListForSearch.None;

        public EmployeeSimpleViewForm()
        {
            InitializeComponent();
        }

        private void AdjustColumnOrderForEmployeeFile()
        {
            DisplayDataGridView.Columns["Id"].DisplayIndex = 0;
            DisplayDataGridView.Columns["FirstName"].DisplayIndex = 1;
            DisplayDataGridView.Columns["LastName"].DisplayIndex = 2;
            DisplayDataGridView.Columns["MiddleName"].DisplayIndex = 3;
            DisplayDataGridView.Columns["Dob"].DisplayIndex = 4;
            DisplayDataGridView.Columns["Age"].DisplayIndex = 5;
            DisplayDataGridView.Columns["Gender"].DisplayIndex = 6;
            DisplayDataGridView.Columns["EmailAddress"].DisplayIndex = 7;
            DisplayDataGridView.Columns["CellphoneNumber"].DisplayIndex = 8;

            DisplayDataGridView.Columns["StreetNumber"].DisplayIndex = 9;
            DisplayDataGridView.Columns["StreetName"].DisplayIndex = 10;
            DisplayDataGridView.Columns["AppartmentNumber"].DisplayIndex = 11;
            DisplayDataGridView.Columns["Zipcode"].DisplayIndex = 12;
            DisplayDataGridView.Columns["Country"].DisplayIndex = 13;
            DisplayDataGridView.Columns["Province"].DisplayIndex = 14;

            DisplayDataGridView.Columns["StreetNumber"].Visible = true;
            DisplayDataGridView.Columns["StreetName"].Visible = true;
            DisplayDataGridView.Columns["AppartmentNumber"].Visible = true;
            DisplayDataGridView.Columns["Zipcode"].Visible = true;
            DisplayDataGridView.Columns["Country"].Visible = true;
            DisplayDataGridView.Columns["Province"].Visible = true;

            DisplayDataGridView.Columns["MiddleName"].Visible = true;
            DisplayDataGridView.Columns["Dob"].Visible = true;
            DisplayDataGridView.Columns["Age"].Visible = true;
            DisplayDataGridView.Columns["Gender"].Visible = true;
            DisplayDataGridView.Columns["EmailAddress"].Visible = true;
            DisplayDataGridView.Columns["CellphoneNumber"].Visible = true;
            DisplayDataGridView.Columns["Address"].Visible = false;

            DisplayDataGridView.Columns["BaseSalary"].Visible = true;
            DisplayDataGridView.Columns["HasCommission"].Visible = true;
            DisplayDataGridView.Columns["Commission"].Visible = true;
            DisplayDataGridView.Columns["JobTitle"].Visible = true;
            DisplayDataGridView.Columns["Department"].Visible = true;
            DisplayDataGridView.Columns["Doh"].Visible = true;
            DisplayDataGridView.Columns["IsAdmin"].Visible = true;
            DisplayDataGridView.Columns["IsActive"].Visible = true;
            DisplayDataGridView.Columns["TerminationDate"].Visible = false;
            DisplayDataGridView.Columns["ReasonForTermination"].Visible = false;
            DisplayDataGridView.Columns["TerminationDetails"].Visible = false;
            DisplayDataGridView.Columns["Headshot"].Visible = false;
        }

        private void AdjustColumnOrderForHistoryTaskFile()
        {
            DisplayDataGridView.Columns["TaskUpdateId"].DisplayIndex = 0;
            DisplayDataGridView.Columns["TaskEntryDate"].DisplayIndex = 1;
            DisplayDataGridView.Columns["TaskId"].DisplayIndex = 2;
            DisplayDataGridView.Columns["TaskName"].DisplayIndex = 3;
            DisplayDataGridView.Columns["TaskDescription"].DisplayIndex = 4;
            DisplayDataGridView.Columns["TaskLead"].DisplayIndex = 5;
            DisplayDataGridView.Columns["TaskAssignee"].DisplayIndex = 6;
            DisplayDataGridView.Columns["Status"].DisplayIndex = 7;
            DisplayDataGridView.Columns["TaskArchievedReason"].DisplayIndex = 8;

            DisplayDataGridView.Columns["HasBeenAssigned"].Visible = false;
            DisplayDataGridView.Columns["TaskCreator"].Visible = false;
            DisplayDataGridView.Columns["TaskCreationDate"].Visible = false;
            DisplayDataGridView.Columns["TaskDeadline"].Visible = false;
            DisplayDataGridView.Columns["TaskCompletedDate"].Visible = false;
        }

        private void EmployeeSimpleViewForm_Load(object sender, EventArgs e)
        {
            SearchToolTip = new ToolTip();
            SearchToolTip.SetToolTip(SearchButton, "Select a list before doing a search or it will return nothing.");
            ViewDataState(false, "", "Select a list to Display!");

            LoginLabel.Text = LoginInfo.CurrentUserName;

            foreach (Employee emp in GetAllEmployees)
            {
                if (emp.Id == LoginInfo.Id)
                {
                    string head = emp.Headshot;
                    EmployeePicturePictureBox.Load(head);
                }
            }

            if (LoginInfo.Admin == true)
            {
                UserView(true);
                MessageLabel.Text = "";
            }
            else
            {
                UserView(false);
                MessageLabel.Text = "At all time, you may contact an admin and request to be assigned to an open task.";
            }
        }

        private void UserView(bool state)
        {
            HistoryListButton.Visible = state;
            ActiveEmployeeListButton.Visible = state;
            InactiveEmployeeListButton.Visible = state;
            ArchievedTaskButton.Visible = state;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenuForm backToMain = new MainMenuForm();
            backToMain.FormClosed += (sender, args) => Close();
            backToMain.Show();
        }

        private void HistoryListButton_Click(object sender, EventArgs e)
        {
            ViewDataState(true, "Search history...", "Display Task History List Information");
            selectedCategoryList = SelectedListForSearch.History;
            getAllHistoryTask = GlobalConfig.connections.GetAllHistoryTask();
            DisplayDataGridView.DataSource = getAllHistoryTask;
            AdjustColumnOrderForHistoryTaskFile();
        }

        private void ActiveTaskListButton_Click(object sender, EventArgs e)
        {
            ViewDataState(true, "Search task...", "Display Active Task List Information");
            selectedCategoryList = SelectedListForSearch.TaskList;
            getAllTask = GlobalConfig.connections.GetAllTasks();
            DisplayDataGridView.DataSource = getAllTask;
        }

        private void ArchievedTaskButton_Click(object sender, EventArgs e)
        {
            ViewDataState(true, "Search archieved task...", "Display Archieved Task List Information");
            selectedCategoryList = SelectedListForSearch.TaskArchievedList;
            getAllArchievedTask = GlobalConfig.connections.GetAllArchievedTasks();
            DisplayDataGridView.DataSource = getAllArchievedTask;
        }

        private void ActiveEmployeeListButton_Click(object sender, EventArgs e)
        {
            ViewDataState(true, "Search employee...", "Display Active Employee List Information");
            selectedCategoryList = SelectedListForSearch.EmployeeList;
            GetAllEmployees = GlobalConfig.connections.GetAllEmployees();
            DisplayDataGridView.DataSource = GetAllEmployees;
            AdjustColumnOrderForEmployeeFile();
        }

        private void InactiveEmployeeListButton_Click(object sender, EventArgs e)
        {
            ViewDataState(true, "Search terminated employee...", "Display Inactive Employee List Information");
            selectedCategoryList = SelectedListForSearch.ArchievedEmployeeList;
            GetAllArchievedEmployees = GlobalConfig.connections.GetAllArchievedEmployees();
            DisplayDataGridView.DataSource = GetAllArchievedEmployees;
            AdjustColumnOrderForEmployeeFile();
            DisplayDataGridView.Columns["TerminationDate"].Visible = true;
            DisplayDataGridView.Columns["ReasonForTermination"].Visible = true;
            DisplayDataGridView.Columns["TerminationDetails"].Visible = true;
        }

        private void ViewDataState(bool state, string txtValue, string title)
        {
            SearchCategoryTextBox.Enabled = state;
            SearchCategoryTextBox.PlaceholderText = txtValue;
            SearchButton.Enabled = state;
            EmployeeViewLabel.Text = title;
        }

        private void MyActiveTaskListButton_Click(object sender, EventArgs e)
        {
            ViewDataState(false, "", "Display My Active Task List Information");

            List<Task> filteredListTask = new List<Task>();

            getAllTask = GlobalConfig.connections.GetAllTasks();
            foreach (Task t in getAllTask)
            {
                if (t.TaskLead.ToUpper().Equals(LoginLabel.Text.ToUpper()) || t.TaskAssignee.ToUpper().Equals(LoginLabel.Text.ToUpper()))
                {
                    filteredListTask.Add(t);
                }
            }

            DisplayDataGridView.DataSource = filteredListTask;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            List<Employee> filteredListEmp = new List<Employee>();
            List<Task> filteredListTask = new List<Task>();
            List<TaskHistory> filteredListTaskHistory = new List<TaskHistory>();

            if (selectedCategoryList == SelectedListForSearch.EmployeeList)
            {
                GetAllEmployees = GlobalConfig.connections.GetAllEmployees();
                foreach (Employee emp in GetAllEmployees)
                {
                    if (emp.FirstName.ToUpper().Contains(SearchCategoryTextBox.Text.ToUpper()) || emp.LastName.ToUpper().Contains(SearchCategoryTextBox.Text.ToUpper()) ||
                        emp.JobTitle.ToUpper().Contains(SearchCategoryTextBox.Text.ToUpper()) || emp.Department.ToUpper().Contains(SearchCategoryTextBox.Text.ToUpper()) ||
                        emp.EmailAddress.ToUpper().Contains(SearchCategoryTextBox.Text.ToUpper()) || emp.Age.ToString().Contains(SearchCategoryTextBox.Text.ToUpper()) ||
                        emp.Id.ToString().Contains(SearchCategoryTextBox.Text.ToUpper()) || emp.BaseSalary.ToString().Contains(SearchCategoryTextBox.Text.ToUpper()))
                    {
                        filteredListEmp.Add(emp);
                    }
                }

                DisplayDataGridView.DataSource = filteredListEmp;
                AdjustColumnOrderForEmployeeFile();
            }
            else if (selectedCategoryList == SelectedListForSearch.ArchievedEmployeeList)
            {
                GetAllArchievedEmployees = GlobalConfig.connections.GetAllArchievedEmployees();
                foreach (Employee emp in GetAllArchievedEmployees)
                {
                    if (emp.FirstName.ToUpper().Contains(SearchCategoryTextBox.Text.ToUpper()) || emp.LastName.ToUpper().Contains(SearchCategoryTextBox.Text.ToUpper()) ||
                        emp.JobTitle.ToUpper().Contains(SearchCategoryTextBox.Text.ToUpper()) || emp.Department.ToUpper().Contains(SearchCategoryTextBox.Text.ToUpper()) ||
                        emp.EmailAddress.ToUpper().Contains(SearchCategoryTextBox.Text.ToUpper()) || emp.Age.ToString().Contains(SearchCategoryTextBox.Text.ToUpper()) ||
                        emp.Id.ToString().Contains(SearchCategoryTextBox.Text.ToUpper()) || emp.BaseSalary.ToString().Contains(SearchCategoryTextBox.Text.ToUpper()))
                    {
                        filteredListEmp.Add(emp);
                    }
                }

                DisplayDataGridView.DataSource = filteredListEmp;
                AdjustColumnOrderForEmployeeFile();
            }
            else if (selectedCategoryList == SelectedListForSearch.TaskList)
            {
                getAllTask = GlobalConfig.connections.GetAllTasks();
                foreach (Task t in getAllTask)
                {
                    if (t.TaskName.ToUpper().Contains(SearchCategoryTextBox.Text.ToUpper()) || t.TaskDescription.ToUpper().Contains(SearchCategoryTextBox.Text.ToUpper()) ||
                        t.TaskLead.ToUpper().Contains(SearchCategoryTextBox.Text.ToUpper()) || t.TaskAssignee.ToUpper().Contains(SearchCategoryTextBox.Text.ToUpper()) ||
                        t.Status.ToString().ToUpper().Contains(SearchCategoryTextBox.Text.ToUpper()))
                    {
                        filteredListTask.Add(t);
                    }
                }

                DisplayDataGridView.DataSource = filteredListTask;
            }
            else if (selectedCategoryList == SelectedListForSearch.TaskArchievedList)
            {
                GetAllArchievedEmployees = GlobalConfig.connections.GetAllArchievedEmployees();
                foreach (Task t in getAllArchievedTask)
                {
                    if (t.TaskName.ToUpper().Contains(SearchCategoryTextBox.Text.ToUpper()) || t.TaskDescription.ToUpper().Contains(SearchCategoryTextBox.Text.ToUpper()) ||
                        t.TaskLead.ToUpper().Contains(SearchCategoryTextBox.Text.ToUpper()) || t.TaskAssignee.ToUpper().Contains(SearchCategoryTextBox.Text.ToUpper()) ||
                        t.Status.ToString().ToUpper().Contains(SearchCategoryTextBox.Text.ToUpper()))
                    {
                        filteredListTask.Add(t);
                    }
                }

                DisplayDataGridView.DataSource = filteredListTask;
            }
            else if (selectedCategoryList == SelectedListForSearch.History)
            {
                getAllHistoryTask = GlobalConfig.connections.GetAllHistoryTask();
                foreach (TaskHistory th in getAllHistoryTask)
                {
                    if (th.TaskName.ToUpper().Contains(SearchCategoryTextBox.Text.ToUpper()) || th.TaskDescription.ToUpper().Contains(SearchCategoryTextBox.Text.ToUpper()) ||
                        th.TaskLead.ToUpper().Contains(SearchCategoryTextBox.Text.ToUpper()) || th.TaskAssignee.ToUpper().Contains(SearchCategoryTextBox.Text.ToUpper()) ||
                        th.Status.ToString().ToUpper().Contains(SearchCategoryTextBox.Text.ToUpper()))
                    {
                        filteredListTaskHistory.Add(th);
                    }
                }

                DisplayDataGridView.DataSource = filteredListTaskHistory;
                AdjustColumnOrderForHistoryTaskFile();
            }
        }
    }
}