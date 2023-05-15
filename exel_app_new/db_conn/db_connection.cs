using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exel_app_new.db_conn
{
    public class db_connection
    {
        private const string connectionString = @"Server=176.56.14.200;Port=5432;DataBase=user3;UID=prb03;PWD=prb03";
        static NpgsqlConnection _sqlConnection;
        public static NpgsqlConnection npgsqlConnection
        {
            get
            {
                if (_sqlConnection == null)
                {
                    _sqlConnection = new NpgsqlConnection(connectionString);
                }
                if (_sqlConnection.State != System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Open();
                }

                return _sqlConnection;
            }
        }
    }
}
