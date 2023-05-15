using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Wpf_app_finally.DB_conn
{
    public class DB_connection
    {
        private static string sql_info_conn = @"Server=; Port=; DataBase=; UID=; PWD=;";
        static NpgsqlConnection _conn;

        public NpgsqlConnection npgsqlConnection
        {
            get
            {
                if (_conn == null)
                {
                    _conn = new NpgsqlConnection(sql_info_conn);
                }
                if(_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }
                return _conn;
            }
        }

        public List<T> Execute<T> (string comm) where T : new()
        {
            var list_obj = new List<T>();
            var list_type = typeof(T);
            var list_prop = typeof(T).GetProperties();

            try
            {
                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(comm, npgsqlConnection))
                {
                    var DataRead = npgsqlCommand.ExecuteReader();
                    while (DataRead.Read())
                    {
                        var elem = new T();
                        int num = 0;

                        foreach(var prop in list_prop)
                        {
                            list_type.GetProperty(prop.Name).SetValue(elem, DataRead.GetValue(num));
                            num++;
                        }
                        list_obj.Add(elem);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            return list_obj;
        }
    }
}
