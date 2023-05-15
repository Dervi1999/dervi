using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_app_finally.Models
{
    public class table_users
    {
        public table_users() { }    
        public table_users(int id, string first_name, string last_name, string second_name, string login, string password, int id_role)
        {
            this.id = id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.second_name = second_name;
            this.login = login;
            this.password = password;
            this.id_role = id_role;
        }

        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string second_name { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public int id_role { get; set; }

    }
}
