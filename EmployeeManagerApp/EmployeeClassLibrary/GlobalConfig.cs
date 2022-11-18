using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using EmployeeClassLibrary.DataAccess;

namespace EmployeeClassLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection connections { get; private set; }

        public static void InitializeConnection(DatabaseType db)
        {
            switch (db)
            {
                case DatabaseType.Sql:
                    // TODO - set up new db connection if require
                    break;
                case DatabaseType.TextFile:
                    TextConnector text = new TextConnector();
                    connections = text;
                    break;
                default:
                    break;
            }
        }
    }
}