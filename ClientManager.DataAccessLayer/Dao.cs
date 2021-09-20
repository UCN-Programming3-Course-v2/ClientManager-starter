using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.DataAccessLayer
{
    internal abstract class Dao
    {
        protected static string GetConnectionString()
        {
            SqlConnectionStringBuilder connStrBuilder = new SqlConnectionStringBuilder
            {
                DataSource = "", // TODO: insert your datasource
                InitialCatalog = "", // TODO: insert the name of your database
                IntegratedSecurity = true
            };

            return connStrBuilder.ConnectionString;
        }

    }
}
