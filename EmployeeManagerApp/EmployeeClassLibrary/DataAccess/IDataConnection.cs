using EmployeeClassLibrary.Models;
using System.Collections.Generic;

namespace EmployeeClassLibrary.DataAccess
{
    public interface IDataConnection
    {
        Employee CreateEmployee(Employee model);
        List<Employee> GetAllEmployees();
        List<Employee> GetAllArchievedEmployees();
        List<Task> GetAllTasks();
        List<Task> GetAllArchievedTasks();
        List<TaskHistory> GetAllHistoryTask();
        Task CreateTask(Task model);
        void EditTask(Task model, int index, int id);
        void EditEmployee(Employee model, int index, int id);
        void CopyActiveEmployeeToArchievedEmployeeFile(Employee model, int index, string reason, string details);
        void CopyActiveTaskToArchievedTaskFile(Task model, int index);
        void DeleteEmployee(Employee model, int index);
        void DeleteTask(Task model, int index);
        TaskHistory RecordHistoryEntry(TaskHistory model);
    }
}