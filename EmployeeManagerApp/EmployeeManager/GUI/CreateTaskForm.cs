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
    public partial class CreateTaskForm : Form
    {
        private List<Employee> getNameFromList = GlobalConfig.connections.GetAllEmployees();
        private int count;

        public CreateTaskForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            var taskManagement = new TaskManagementForm();
            taskManagement.Closed += (s, args) => Close();
            taskManagement.Show();
        }

        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Task newTask = new Task();
                newTask.TaskName = TaskNameTextBox.Text;
                newTask.TaskDescription = TaskDescriptionTextBox.Text;
                newTask.HasBeenAssigned = false;
                newTask.Status = TaskStatus.Locked;
                newTask.TaskCreator = LoginLabel.Text;
                newTask.TaskCreationDate = DateTime.Now;
                newTask.TaskDeadline = DateTime.Parse(DeadlineDateTimePicker.Text);
                newTask.TaskCompletedDate = null;
                newTask.TaskLead = TaskLeadComboBox.SelectedItem.ToString();
                newTask.TaskAssignee = "Unassigned";
                newTask = GlobalConfig.connections.CreateTask(newTask);

                TaskHistory history = new TaskHistory();
                history.TaskEntryDate = newTask.TaskCreationDate;
                history.TaskId = newTask.TaskId;
                history.TaskName = newTask.TaskName;
                history.TaskDescription = newTask.TaskDescription;
                history.TaskLead = newTask.TaskLead;
                history.TaskAssignee = newTask.TaskAssignee;
                history.Status = newTask.Status;
                history.TaskArchievedReason = null;
                history = GlobalConfig.connections.RecordHistoryEntry(history);

                Reset();
            }
            else
            {
                MasterErrorLabel.Text = "* Please Fix all <" + count + "> errors to proceed!";
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;
            count = 0;

            count += TaskValidation.TaskNameValidation(TaskNameTextBox, TaskNameErrorLabel);
            count += TaskValidation.TaskDescriptionValidation(TaskDescriptionTextBox, TaskDescriptionErrorLabel);
            count += TaskValidation.TaskDeadlineValidation(DeadlineDateTimePicker, DeadlineErrorLabel);

            if (count != 0)
            {
                isValid = false;
            }
            else
            {
                isValid = true;
            }

            return isValid;
        }

        private void ResetFormButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            TaskNameTextBox.Text = "";
            TaskLeadComboBox.SelectedIndex = 0;
            DeadlineDateTimePicker.Value = DateTime.Now;
            DeadlineErrorLabel.Text = "";
            TaskDescriptionTextBox.Text = "";
            TaskNameErrorLabel.Text = "";
            TaskDescriptionErrorLabel.Text = "";
            MasterErrorLabel.Text = "";

            TaskNameTextBox.Focus();
        }

        private void CreateTaskForm_Load(object sender, EventArgs e)
        {
            LoginLabel.Text = LoginInfo.CurrentUserName;

            List<string> empNameLead = new List<string>();
            List<string> empNameAssignee = new List<string>();

            foreach (Employee emp in getNameFromList)
            {
                empNameLead.Add($"{emp.LastName} {emp.FirstName}");
            }

            empNameAssignee.Add($"Unassigned");
            foreach (Employee emp in getNameFromList)
            {              
                empNameAssignee.Add($"{emp.LastName} {emp.FirstName}");
            }

            TaskLeadComboBox.DataSource = empNameLead;

            Reset();
        }
    }
}