using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_app_finally.Models;

namespace Wpf_app_finally.Controllers
{
    public class tb_usr_add
    {
        public static List<table_users> users()
        {
            List<table_users> table_Users = new List<table_users>();
            table_users _Users1 = new table_users(1, "Алекс", "Александрович", "Ботнев", "admin", "admin", 1);
            table_Users.Add(_Users1);
            table_users _Users2 = new table_users(1, "Никита", "Вальфор", "Варгов", "expr", "expr", 2);
            table_Users.Add(_Users2);
            table_users _Users3 = new table_users(1, "Олег", "Святославович", "Онегин", "users", "users", 3);
            table_Users.Add(_Users3);

            return table_Users;
        }
    }
}
