using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassLibrary
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }

    public enum DatabaseType
    {
        Sql,
        TextFile
    }

    public enum Selection
    {
        No,
        Yes
    }

    public enum TaskStatus
    {
        Locked,
        Open,
        InProgress,
        Completed,
        Archieved
    }

    public enum EmployeeTaskEndReason
    {
        TaskCompleted,
        TaskCancelled,
        TaskSuspended,
        WasReplaced,
        WasFired,
        wasAbandonned
    }

    public enum TerminationReason
    {
        Incompetence,
        Insubordination,
        AttendanceIssues,
        CriminalBehavior,
        SexualHarassment,
        ViolentBehavior,
        EndOfCOntract,
        Layoff,
        Resignation,
        StillActive
    }

    public enum ArchievedTaskReason
    {
        NoLongerRelevant,
        NewVersionAvailable,
        Duplicate,
        Error
    }

    public enum SelectedListForSearch
    {
        None,
        EmployeeList,
        ArchievedEmployeeList,
        TaskList,
        TaskArchievedList,
        History
    }
}