using EmployeeClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;

namespace EmployeeClassLibrary.DataAccess
{
    public static class TextConnectorProcessor
    {
        public static string RelativeFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();         
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<Employee> ConvertToEmployeeModel(this List<string> lines)
        {
            List<Employee> output = new List<Employee>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                Employee emp = new Employee();
                emp.Id = int.Parse(cols[0]);
                emp.FirstName = cols[1];
                emp.LastName = cols[2];
                emp.MiddleName = cols[3];
                emp.Dob = DateTime.Parse(cols[4]);
                emp.Age = int.Parse(cols[5]);
                emp.Gender = (Gender)Enum.Parse(typeof(Gender), cols[6]);
                emp.EmailAddress = cols[7];
                emp.CellphoneNumber = cols[8];

                emp.StreetNumber = int.Parse(cols[9]);
                emp.StreetName = cols[10];

                if (emp.AppartmentNumber == null)
                {
                    emp.AppartmentNumber = null;
                }
                else
                {
                    emp.AppartmentNumber = int.Parse(cols[11]);
                }
                
                emp.Zipcode = cols[12];
                emp.Country = cols[13];
                emp.Province = cols[14];      
                
                emp.BaseSalary = decimal.Parse(cols[15]);
                emp.HasCommission = bool.Parse(cols[16]);
                emp.Commission = decimal.Parse(cols[17]);
                emp.JobTitle = cols[18];
                emp.Department = cols[19];
                emp.Doh = DateTime.Parse(cols[20]);
                emp.IsAdmin = bool.Parse(cols[21]);
                emp.AdminUsername = cols[22];
                emp.AdminPassword = cols[23];
                emp.IsActive = bool.Parse(cols[24]);

                emp.TerminationDate = DateTime.Parse(cols[25]);
                emp.ReasonForTermination = (TerminationReason)Enum.Parse(typeof(TerminationReason), cols[26]);
                emp.TerminationDetails = cols[27];

                emp.Headshot = cols[28];

                output.Add(emp);
            }

            return output;
        }

        public static List<Task> ConvertToTaskModel(this List<string> lines)
        {
            List<Task> output = new List<Task>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                Task task = new Task();
                task.TaskId = int.Parse(cols[0]);
                task.TaskName = cols[1];
                task.TaskDescription = cols[2];
                task.HasBeenAssigned = bool.Parse(cols[3]);
                task.Status = (TaskStatus)Enum.Parse(typeof(TaskStatus), cols[4]);
                task.TaskCreator = cols[5];
                task.TaskCreationDate = DateTime.Parse(cols[6]);
                task.TaskDeadline = DateTime.Parse(cols[7]);

                if (cols[8] == null || cols[8] == "")
                {
                    task.TaskCompletedDate = null;
                }
                else
                {
                    task.TaskCompletedDate = DateTime.Parse(cols[8]);
                }
                
                task.TaskLead = cols[9];
                task.TaskAssignee = cols[10];

                output.Add(task);
            }

            return output;
        }

        public static List<TaskHistory> ConvertToTaskHistoryModel(this List<string> lines)
        {
            List<TaskHistory> output = new List<TaskHistory>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TaskHistory history = new TaskHistory();
                history.TaskUpdateId = int.Parse(cols[0]);
                history.TaskEntryDate = DateTime.Parse(cols[1]);
                history.TaskId = int.Parse(cols[2]);
                history.TaskName = cols[3];
                history.TaskDescription = cols[4];
                history.TaskLead = cols[5];
                history.TaskAssignee = cols[6];
                history.Status = (TaskStatus)Enum.Parse(typeof(TaskStatus), cols[7]);

                if (cols[8] == null || cols[8] == "")
                {
                    history.TaskArchievedReason = null;
                }
                else
                {
                    history.TaskArchievedReason = (ArchievedTaskReason)Enum.Parse(typeof(ArchievedTaskReason), cols[8]);
                }               

                output.Add(history);
            }

            return output;
        }

        public static void SaveToEmployeeFile(this List<Employee> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (Employee emp in models)
            {
                lines.Add(emp.WriteToEmployeeFile());
            }

            File.WriteAllLines(fileName.RelativeFilePath(), lines);
        }

        public static void SaveToTaskFile(this List<Task> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (Task t in models)
            {
                lines.Add(t.WriteToTaskFile());
            }

            File.WriteAllLines(fileName.RelativeFilePath(), lines);
        }

        public static void SaveToTaskHistoryFile(this List<TaskHistory> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TaskHistory th in models)
            {
                lines.Add(th.WriteToHistoryFile());
            }

            File.WriteAllLines(fileName.RelativeFilePath(), lines);
        }

        public static void CopytoTaskFile(this List<Task> models, string fileNameDestination, int index)
        {
            List<string> newLine = new List<string>();

            foreach (Task t in models)
            {
                if (t.TaskId == index)
                {
                    t.Status = TaskStatus.Archieved;
                    newLine.Add(t.WriteToTaskFile());
                    break;
                }
            }

            File.AppendAllLines(fileNameDestination.RelativeFilePath(), newLine);
        }

        public static void CopytoEmployeeFile(this List<Employee> models, string fileNameDestination, int index, string reason, string details)
        {
            List<string> newLine = new List<string>();

            foreach (Employee emp in models)
            {
                if (emp.Id == index)
                {
                    emp.IsActive = false;
                    emp.TerminationDate = DateTime.Now;
                    emp.ReasonForTermination = (TerminationReason)Enum.Parse(typeof(TerminationReason), reason);
                    emp.TerminationDetails = details;
                    newLine.Add(emp.WriteToEmployeeFile());
                    break;
                }
            }

            File.AppendAllLines(fileNameDestination.RelativeFilePath(), newLine);
        }

        public static void DeletetoTaskFile(this List<Task> models, string fileName, int index)
        {
            List<string> lines = File.ReadAllLines(fileName.RelativeFilePath()).ToList();

            foreach (Task t in models)
            {
                if (t.TaskId == index)
                {
                    lines.RemoveAt(index);
                    break;
                }              
            }

            File.WriteAllLines(fileName.RelativeFilePath(), lines);
        }

        public static void DeletetoEmployeeFile(this List<Employee> models, string fileName, int index)
        {
            List<string> lines = File.ReadAllLines(fileName.RelativeFilePath()).ToList();

            foreach (Employee emp in models)
            {
                if (emp.Id == index)
                {
                    lines.RemoveAt(index);
                    break;
                }
            }

            File.WriteAllLines(fileName.RelativeFilePath(), lines);
        }

        public static void EditTaskFile(this List<Task> models, string fileName, int index, int id)
        {
            string[] lines = File.ReadAllLines(fileName.RelativeFilePath());
            
            foreach (Task t in models)
            {
                if (t.TaskId == id)
                {
                    t.TaskId = id;
                    lines[index] = $"{t.WriteToTaskFile()}";
                }
            }

            File.WriteAllLines(fileName.RelativeFilePath(), lines);
        }

        public static void EditEmployeeFile(this List<Employee> models, string fileName, int index, int id)
        {
            string[] lines = File.ReadAllLines(fileName.RelativeFilePath());

            foreach (Employee emp in models)
            {
                if (emp.Id == id)
                {
                    emp.Id = id;
                    lines[index] = $"{emp.WriteToEmployeeFile()}";
                }
            }

            File.WriteAllLines(fileName.RelativeFilePath(), lines);
        }
    }
}