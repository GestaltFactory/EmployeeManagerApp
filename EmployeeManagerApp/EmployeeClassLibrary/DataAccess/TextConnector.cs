using EmployeeClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeClassLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string EmployeeFile = "Employee.csv";
        private const string ArchievedEmployeeFile = "ArchievedEmployee.csv";
        private const string TaskFile = "Task.csv";
        private const string TaskHistoryFile = "TaskHistory.csv";
        private const string ArchievedTaskFile = "ArchievedTask.csv";

        public Employee CreateEmployee(Employee model)
        {
            List<Employee> employees = EmployeeFile.RelativeFilePath().LoadFile().ConvertToEmployeeModel();
            List<Employee> archievedEmployees = ArchievedEmployeeFile.RelativeFilePath().LoadFile().ConvertToEmployeeModel();

            int tempEmployeeId = 1;
            int tempArchievedId = 1;
            int currentId = 1;

            if (employees.Count > 0)
            {
                currentId = employees.OrderByDescending(x => x.Id).First().Id;
            }

            if (archievedEmployees.Count > 0)
            {
                tempArchievedId = archievedEmployees.OrderByDescending(x => x.Id).First().Id;

                if (tempEmployeeId > tempArchievedId)
                {
                    currentId = tempEmployeeId;
                }
                else
                {
                    currentId = tempArchievedId;
                }
            }
            else
            {
                currentId = tempEmployeeId;
            }

            model.Id = currentId + 1;

            employees.Add(model);
            employees.SaveToEmployeeFile(EmployeeFile);

            return model;
        }

        public Task CreateTask(Task model)
        {
            List<Task> tasks = TaskFile.RelativeFilePath().LoadFile().ConvertToTaskModel();
            List<Task> archievedTasks = ArchievedTaskFile.RelativeFilePath().LoadFile().ConvertToTaskModel();

            int tempTaskId = 1;
            int tempArchievedId = 1;
            int currentId = 1;

            if (tasks.Count > 0)
            {
                tempTaskId = tasks.OrderByDescending(x => x.TaskId).First().TaskId;
            }

            if (archievedTasks.Count > 0)
            {
                tempArchievedId = archievedTasks.OrderByDescending(x => x.TaskId).First().TaskId;

                if (tempTaskId > tempArchievedId)
                {
                    currentId = tempTaskId;
                }
                else
                {
                    currentId = tempArchievedId;
                }
            }
            else
            {
                currentId = tempTaskId;
            }


            model.TaskId = currentId + 1;

            tasks.Add(model);
            tasks.SaveToTaskFile(TaskFile);

            return model;
        }

        public void EditEmployee(Employee model, int index, int id)
        {
            List<Employee> emp = EmployeeFile.RelativeFilePath().LoadFile().ConvertToEmployeeModel();

            model.Id = id;

            emp.Add(model);
            emp.EditEmployeeFile(EmployeeFile, index, id);
        }

        public void EditTask(Task model, int index, int id)
        {
            List<Task> tasks = TaskFile.RelativeFilePath().LoadFile().ConvertToTaskModel();

            model.TaskId = id;

            tasks.Add(model);
            tasks.EditTaskFile(TaskFile, index, id);
        }

        public List<Employee> GetAllEmployees()
        {
            return EmployeeFile.RelativeFilePath().LoadFile().ConvertToEmployeeModel();
        }

        public List<Task> GetAllTasks()
        {
            return TaskFile.RelativeFilePath().LoadFile().ConvertToTaskModel();
        }

        public List<TaskHistory> GetAllHistoryTask()
        {
            return TaskHistoryFile.RelativeFilePath().LoadFile().ConvertToTaskHistoryModel();
        }

        public List<Task> GetAllArchievedTasks()
        {
            return ArchievedTaskFile.RelativeFilePath().LoadFile().ConvertToTaskModel();
        }

        public List<Employee> GetAllArchievedEmployees()
        {
            return ArchievedEmployeeFile.RelativeFilePath().LoadFile().ConvertToEmployeeModel();
        }

        public void CopyActiveTaskToArchievedTaskFile(Task model, int index)
        {
            List<Task> tasks = TaskFile.RelativeFilePath().LoadFile().ConvertToTaskModel();

            model.TaskId = index;
            model.Status = TaskStatus.Archieved;

            tasks.Add(model);
            tasks.CopytoTaskFile(ArchievedTaskFile, index);
        }   

        public void CopyActiveEmployeeToArchievedEmployeeFile(Employee model, int index, string reason, string details)
        {
            List<Employee> emp = EmployeeFile.RelativeFilePath().LoadFile().ConvertToEmployeeModel();

            model.Id = index;
            model.IsActive = false;
            model.TerminationDate = DateTime.Now;
            model.ReasonForTermination = (TerminationReason)Enum.Parse(typeof(TerminationReason), reason);
            model.TerminationDetails = details;

            emp.Add(model);
            emp.CopytoEmployeeFile(ArchievedEmployeeFile, index, reason, details);
        }

        public void DeleteTask(Task model, int index)
        {
            List<Task> tasks = TaskFile.RelativeFilePath().LoadFile().ConvertToTaskModel();

            model.TaskId = index;

            tasks.Add(model);
            tasks.DeletetoTaskFile(TaskFile, index);
        }

        public void DeleteEmployee(Employee model, int index)
        {
            List<Employee> emp = EmployeeFile.RelativeFilePath().LoadFile().ConvertToEmployeeModel();

            model.Id = index;

            emp.Add(model);
            emp.DeletetoEmployeeFile(EmployeeFile, index);
        }

        public TaskHistory RecordHistoryEntry(TaskHistory model)
        {
            List<TaskHistory> history = TaskHistoryFile.RelativeFilePath().LoadFile().ConvertToTaskHistoryModel();

            int currentId = 1;

            if (history.Count > 0)
            {
                currentId = history.OrderByDescending(x => x.TaskUpdateId).First().TaskUpdateId + 1;
            }

            model.TaskUpdateId = currentId;

            history.Add(model);
            history.SaveToTaskHistoryFile(TaskHistoryFile);

            return model;
        }
    }
}