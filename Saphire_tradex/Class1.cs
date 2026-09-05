using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Saphire_tradex
{
    public static class Database
    {
        public static string DbFolder
        {
            get
            {
                return Path.Combine(
                    Environment.GetFolderPath(
                        Environment.SpecialFolder.LocalApplicationData),
                    "Saphire Tradex"
                );
            }
        }

        public static string DbPath
        {
            get
            {
                return Path.Combine(DbFolder, "pos.db");
            }
        }

        public static string ConnectionString
        {
            get
            {
                Directory.CreateDirectory(DbFolder);

                return $"Data Source={DbPath};Version=3;";
            }
        }

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(ConnectionString);
        }

        // Call this once, before any form or query runs.
        public static void EnsureDatabaseExists()
        {
            Directory.CreateDirectory(DbFolder);

            if (!File.Exists(DbPath))
            {
                // The real database (with your existing products/sales data)
                // must be copied to the output folder alongside the .exe.
                string sourceDb = Path.Combine(Application.StartupPath, "pos.db");

                if (File.Exists(sourceDb))
                {
                    File.Copy(sourceDb, DbPath);
                }
                else
                {
                    throw new FileNotFoundException(
                        "Template database not found. Expected it at: " + sourceDb);
                }
            }
        }
    }
}