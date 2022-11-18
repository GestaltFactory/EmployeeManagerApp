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
    public partial class EditTaskForm : Form
    {
        private List<Task> getAllTask = GlobalConfig.connections.GetAllTasks();
        private List<Task> getAllArchievedTask = GlobalConfig.connections.GetAllArchievedTasks();
        private List<Employee> getNameFromList = GlobalConfig.connections.GetAllEmployees();
        private int count;
        private bool selectedTaskList;
        
        public EditTaskForm()
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

        private void ApplyChangesButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                int index = TaskDataGridView.CurrentRow.Index;

                getAllTask[index].TaskName = TaskNameTextBox.Text;
                getAllTask[index].TaskDescription = TaskDescriptionTextBox.Text;
                getAllTask[index].TaskDeadline = DateTime.Parse(DeadlineDateTimePicker.Text);
                getAllTask[index].Status = (TaskStatus)Enum.Parse(typeof(TaskStatus), TaskStatusComboBox.SelectedItem.ToString());

                if (getAllTask[index].Status == TaskStatus.Completed)
                {
                    getAllTask[index].TaskCompletedDate = DateTime.Now;
                }
                else
                {
                    getAllTask[index].TaskCompletedDate = null;
                }            
                
                getAllTask[index].TaskLead = TaskLeadComboBox.SelectedItem.ToString();
                getAllTask[index].TaskAssignee = TaskAssigneeComboBox.SelectedItem.ToString();

                if (getAllTask[index].TaskAssignee == "Unassigned")
                {
                    getAllTask[index].HasBeenAssigned = false;
                }
                else
                {
                    getAllTask[index].HasBeenAssigned = true;
                }

                GlobalConfig.connections.EditTask(getAllTask[index], index, getAllTask[index].TaskId);

                TaskHistory history = new TaskHistory();
                history.TaskEntryDate = DateTime.Now;
                history.TaskId = getAllTask[index].TaskId;
                history.TaskName = getAllTask[index].TaskName;
                history.TaskDescription = getAllTask[index].TaskDescription;
                history.TaskLead = getAllTask[index].TaskLead;
                history.TaskAssignee = getAllTask[index].TaskAssignee;
                history.Status = getAllTask[index].Status;
                history.TaskArchievedReason = null;
                history = GlobalConfig.connections.RecordHistoryEntry(history);

                TaskDataGridView.DataSource = null;
                TaskDataGridView.Rows.Clear();

                getAllTask = GlobalConfig.connections.GetAllTasks();
                TaskDataGridView.DataSource = getAllTask;

                Reset();
                TaskDataGridView.ClearSelection();
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
            TaskStatusComboBox.SelectedIndex = 0;
            TaskAssigneeComboBox.SelectedIndex = 0;
            DeadlineDateTimePicker.Value = DateTime.Now;
            DeadlineErrorLabel.Text = "";
            TaskDescriptionTextBox.Text = "";
            TaskNameErrorLabel.Text = "";
            TaskDescriptionErrorLabel.Text = "";
            MasterErrorLabel.Text = "";
            TaskStatusComboBox.SelectedIndex = 0;
            DeletedReasonComboBox.SelectedIndex = 0;

            TaskNameTextBox.Focus();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void EditTaskForm_Load(object sender, EventArgs e)
        {
            OrderByState(false);
            FormControlsState(false);

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
            TaskAssigneeComboBox.DataSource = empNameAssignee;

            TaskStatusComboBox.DataSource = Enum.GetValues(typeof(TaskStatus)).Cast<TaskStatus>().Take(4).ToList();
            DeletedReasonComboBox.DataSource = Enum.GetValues(typeof(ArchievedTaskReason)).Cast<ArchievedTaskReason>();

            Reset();
        }

        private void OrderByState(bool state)
        {
            OrderByStatusButton.Enabled = state;
            OrderByNameButton.Enabled = state;
            OrderByIdButton.Enabled = state;
            OrderByDeadlineButton.Enabled = state;
        }

        private void TaskListButton_Click(object sender, EventArgs e)
        {
            FormControlsState(true);
            OrderByState(true);
            getAllTask = GlobalConfig.connections.GetAllTasks();
            TaskDataGridView.DataSource = getAllTask;
        }

        private void FormControlsState(bool state)
        {
            TaskGroupBox.Enabled = state;
            selectedTaskList = state;
            DeleteTaskButton.Enabled = state;
            DeletedReasonComboBox.Enabled = state;
        }

        private void ArchievedTaskListButton_Click(object sender, EventArgs e)
        {
            FormControlsState(false);
            OrderByState(true);
            getAllArchievedTask = GlobalConfig.connections.GetAllArchievedTasks();
            TaskDataGridView.DataSource = getAllArchievedTask;
        }

        private void TaskDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedTaskList)
            {
                TaskNameTextBox.Text = getAllTask[TaskDataGridView.CurrentCell.RowIndex].TaskName;
                TaskDescriptionTextBox.Text = getAllTask[TaskDataGridView.CurrentCell.RowIndex].TaskDescription;
                DeadlineDateTimePicker.Value = getAllTask[TaskDataGridView.CurrentCell.RowIndex].TaskDeadline;
                TaskStatusComboBox.SelectedItem = getAllTask[TaskDataGridView.CurrentCell.RowIndex].Status;
                TaskLeadComboBox.SelectedItem = getAllTask[TaskDataGridView.CurrentCell.RowIndex].TaskLead;
                TaskAssigneeComboBox.SelectedItem = getAllTask[TaskDataGridView.CurrentCell.RowIndex].TaskAssignee; 
            }
        }

        private void DeleteTaskButton_Click(object sender, EventArgs e)
        {
            int index = TaskDataGridView.CurrentRow.Index;
            int temp = getAllTask[index].TaskId;

            getAllTask[index].Status = TaskStatus.Archieved;

            GlobalConfig.connections.CopyActiveTaskToArchievedTaskFile(getAllTask[index], getAllTask[index].TaskId);
            GlobalConfig.connections.DeleteTask(getAllTask[index], index);

            TaskHistory history = new TaskHistory();
            history.TaskEntryDate = DateTime.Now;
            history.TaskId = temp;
            history.TaskName = getAllTask[index].TaskName;
            history.TaskDescription = getAllTask[index].TaskDescription;
            history.TaskLead = getAllTask[index].TaskLead;
            history.TaskAssignee = getAllTask[index].TaskAssignee;
            history.Status = TaskStatus.Archieved;
            history.TaskArchievedReason = (ArchievedTaskReason)Enum.Parse(typeof(ArchievedTaskReason), DeletedReasonComboBox.SelectedItem.ToString());
            history = GlobalConfig.connections.RecordHistoryEntry(history);

            TaskDataGridView.DataSource = null;
            TaskDataGridView.Rows.Clear();

            getAllTask = GlobalConfig.connections.GetAllTasks();
            TaskDataGridView.DataSource = getAllTask;

            Reset();
            TaskDataGridView.ClearSelection();
        }

        private void TaskStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TaskStatusComboBox.SelectedIndex == 0)
            {
                TaskAssigneeComboBox.Enabled = false;
                TaskAssigneeComboBox.SelectedIndex = 0;
            }
            else if (TaskStatusComboBox.SelectedIndex == 3)
            {
                TaskAssigneeComboBox.Enabled = false;
            }
            else
            {
                TaskAssigneeComboBox.Enabled = true;
            }
        }

        private void OrderByStatusButton_Click(object sender, EventArgs e)
        {
            if (selectedTaskList)
            {
                getAllTask = GlobalConfig.connections.GetAllTasks().OrderByDescending(o => o.Status).ToList();
                TaskDataGridView.DataSource = getAllTask;
            }
            else
            {
                getAllArchievedTask = GlobalConfig.connections.GetAllArchievedTasks().OrderByDescending(o => o.Status).ToList();
                TaskDataGridView.DataSource = getAllArchievedTask;
            }
        }

        private void OrderByNameButton_Click(object sender, EventArgs e)
        {
            if (selectedTaskList)
            {
                getAllTask = GlobalConfig.connections.GetAllTasks().OrderBy(o => o.TaskName).ToList();
                TaskDataGridView.DataSource = getAllTask;
            }
            else
            {
                getAllArchievedTask = GlobalConfig.connections.GetAllArchievedTasks().OrderBy(o => o.TaskName).ToList();
                TaskDataGridView.DataSource = getAllArchievedTask;
            }
        }

        private void OrderbyDeadlineButton_Click(object sender, EventArgs e)
        {
            if (selectedTaskList)
            {
                getAllTask = GlobalConfig.connections.GetAllTasks().OrderByDescending(o => o.TaskDeadline).ToList();
                TaskDataGridView.DataSource = getAllTask;
            }
            else
            {
                getAllArchievedTask = GlobalConfig.connections.GetAllArchievedTasks().OrderByDescending(o => o.TaskDeadline).ToList();
                TaskDataGridView.DataSource = getAllArchievedTask;
            }
        }

        private void OrderbyIdButton_Click(object sender, EventArgs e)
        {
            if (selectedTaskList)
            {
                getAllTask = GlobalConfig.connections.GetAllTasks().OrderBy(o => o.TaskId).ToList();
                TaskDataGridView.DataSource = getAllTask;
            }
            else
            {
                getAllArchievedTask = GlobalConfig.connections.GetAllArchievedTasks().OrderBy(o => o.TaskId).ToList();
                TaskDataGridView.DataSource = getAllArchievedTask;
            }
        }
    }
}