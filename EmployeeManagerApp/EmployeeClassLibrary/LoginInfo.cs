using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassLibrary
{
    public static class LoginInfo
    {
        public static string CurrentUserName;
        public static int Id;
        public static bool Admin;

        // to use is case there are no user yet in the application you can use to log into it.
        public static string SuperUser = "yan";
        public static string SuperPassword = "123";
    }
}