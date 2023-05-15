using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace exel_app_new.db_conn
{
    public class entity
    {
        public static List<T> Execute<T>(string command) where T : new()
        {
            var list = new List<T>();
            var typeObject = typeof(T);
            var properties = typeof(T).GetProperties();
            db_connection conn = new db_connection();
            try
            {
                using (NpgsqlCommand sqlCommand = new NpgsqlCommand(command, db_connection.npgsqlConnection))
                {
                    var sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        var element = new T();
                        int number = 0;
                        foreach (var property in properties)
                        {
                            typeObject.GetProperty(property.Name).SetValue(element, sqlDataReader.GetValue(number));
                            number++;
                        }
                        list.Add(element);
                    }
                }
                db_connection.npgsqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ошибка получения объектов" + ex.ToString());
            }
            return list;
        }
        public static void Execute(string command)
        {
            try
            {
                NpgsqlCommand sqlCommand = new NpgsqlCommand(command, db_connection.npgsqlConnection);
                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            db_connection.npgsqlConnection.Close();
        }
        public static T Single<T>(string sqlCommand) where T : new()
        {
            var listObject = Execute<T>(sqlCommand);
            if (listObject != null)
            {
                if (listObject.Count != 0)
                {
                    return listObject[0]; //single object
                }
            }
            return default(T);
        }

        public static Int64 ExecuteNum(string command)
        {

            using (var sqlCommand = new NpgsqlCommand(command, db_connection.npgsqlConnection))
            {

                int num = 0;
                NpgsqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    num = Int32.Parse(reader[0].ToString());
                    //do whatever you like
                }
                db_connection.npgsqlConnection.Close();
                return num;
            }


        }
    }
}
