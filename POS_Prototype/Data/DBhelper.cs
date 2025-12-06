using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Prototype.Data
{
    public static class DBhelper
    {
        public static string GetProjectDbPath()
        {
            string projectFolder = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
            string dbPath = Path.Combine(projectFolder, "Data", "pos.db");
            return dbPath;
        }

        public static string GetConnectionString()
        {
            return $"Data Source={GetProjectDbPath()}";
        }
    }
}
