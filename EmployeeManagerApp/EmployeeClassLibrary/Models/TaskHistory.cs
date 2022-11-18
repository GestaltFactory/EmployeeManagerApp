using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassLibrary.Models
{
    public class TaskHistory : Task
    {
        public int TaskUpdateId { get; set; }
        public DateTime TaskEntryDate { get; set; }
        public ArchievedTaskReason? TaskArchievedReason { get; set; }      

        public TaskHistory(){}

        public override string WriteToHistoryFile()
        {
            return $"{TaskUpdateId},{TaskEntryDate}," + base.WriteToHistoryFile() + $",{TaskArchievedReason}";
        }
    }
}