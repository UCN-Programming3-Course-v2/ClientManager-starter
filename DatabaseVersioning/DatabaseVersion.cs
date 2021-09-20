using DbUp;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseVersioning
{
    public static class DatabaseVersion
    {
        public static bool Upgrade(string connectionString)
        {
            EnsureDatabase.For.SqlDatabase(connectionString);

            var upgrader =
              DeployChanges.To
                  .SqlDatabase(connectionString)
                  .WithScriptsEmbeddedInAssembly(Assembly.GetAssembly(typeof(DatabaseVersion)))
                  .Build();

            var result = upgrader.PerformUpgrade();

            if (result.Successful)
            {
                return true;
            }
            throw new Exception($"Could not create database: {result.Error.Message}");
        }

        public static void Destroy(string connectionString)
        {
            // TODO: Implement destruction of database.
            DropDatabase.For
                .SqlDatabase(connectionString);
        }
    }
}
