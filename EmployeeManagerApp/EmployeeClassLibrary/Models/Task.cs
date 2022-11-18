using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassLibrary.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public bool HasBeenAssigned { get; set; }
        public TaskStatus Status { get; set; }
        public string TaskCreator { get; set; }
        public DateTime TaskCreationDate { get; set; }
        public DateTime TaskDeadline { get; set; }
        public DateTime? TaskCompletedDate { get; set; }
        public string TaskLead { get; set; }
        public string TaskAssignee { get; set; }

        public Task(){}

        public string WriteToTaskFile()
        {
            return $"{TaskId},{TaskName},{TaskDescription},{HasBeenAssigned},{Status},{TaskCreator},{TaskCreationDate},{TaskDeadline},{TaskCompletedDate},{TaskLead},{TaskAssignee}";
        }

        /// <summary>
        /// Will keep history of some values from tasks and emnployees
        /// </summary>
        /// <returns></returns>
        public virtual string WriteToHistoryFile()
        {
            return $"{TaskId},{TaskName},{TaskDescription},{TaskLead},{TaskAssignee},{Status}";
        }
    }
}