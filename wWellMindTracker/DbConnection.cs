using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace wWellMindTracker.Data
{
    public class DbConnection
    {

        private static SqlConnection _connection;

        private DbConnection() { }

        public static SqlConnection GetConnection()
        {

            if (_connection == null)
            {

                _connection = new SqlConnection("Server=.;Database=WellMindTracker;Trusted_Connection=True;");

            }

            return _connection;
        }

    }
}
