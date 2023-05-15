using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wpf_app_finally.Models;

namespace Wpf_app_finally.Pages_app
{
    /// <summary>
    /// Логика взаимодействия для login_page.xaml
    /// </summary>
    public partial class login_page : Page
    {
        List<table_users> _Users = Controllers.tb_usr_add.users();
        public login_page()
        {
            InitializeComponent();
        }

        private void cnk_save_Click(object sender, RoutedEventArgs e)
        {
            if(txb_login.Text != "" && psb_pass.Password != "")
            {
                var checkusr = _Users.FirstOrDefault(s=>s.login == txb_login.Text && s.password == psb_pass.Password);
                if(checkusr != null)
                {
                    switch (checkusr.id_role)
                    {
                        case 1:
                            {

                                break;
                            }
                    }
                }
            }
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
