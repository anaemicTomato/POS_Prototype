using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Prototype.Data
{
    public static class DBhelper
    {
        private static readonly string DataFolder = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, @"..\..\..", "Data"
        );
        private static readonly string TemplateDb = Path.Combine(DataFolder, "pos_templateDB.db");
        private static readonly string LocalDb = Path.Combine(DataFolder, "pos.db");

        public static string GetProjectDbPath()
        {
            Directory.CreateDirectory(DataFolder);

            if (!File.Exists(LocalDb))
            {
                if (File.Exists(TemplateDb))
                {
                    // Copy template to create local DB
                    File.Copy(TemplateDb, LocalDb);
                }
                else
                {
                    throw new FileNotFoundException("Template database not found. Cannot create runtime DB.");
                }
            }

            return LocalDb;
        }

        public static string GetConnectionString()
        {
            return $"Data Source={GetProjectDbPath()}";
        }
    }

    //sup
}
