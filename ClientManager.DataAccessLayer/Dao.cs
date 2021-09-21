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
        public string ConnectionString { get; protected set; }

        public Dao(string connectionString)
        {
            ConnectionString = connectionString;
        }
      
    }
}
