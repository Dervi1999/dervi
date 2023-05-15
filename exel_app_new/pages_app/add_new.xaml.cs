using exel_app_new.models_app;
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

namespace exel_app_new.pages_app
{
    /// <summary>
    /// Interaction logic for add_new.xaml
    /// </summary>
    public partial class add_new : Page
    {
        List<tb_test> tb_Tests = db_conn.entity.Execute<tb_test>("select * from tb_test");

        public add_new()
        {
            InitializeComponent();
            txb_id.Text = (tb_Tests.Max(i => i.id) + 1).ToString();
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            Page page = new main_page();
            NavigationService.GetNavigationService(this).Navigate(page);
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            if (txb_f1.Text != "" && txb_f2.Text != "" && txb_f3.Text != "")
            {
                int id = tb_Tests.Max(i => i.id) + 1;
                string sql = String.Format($"insert into tb_test  values  ({id}, '{txb_f1.Text}', '{txb_f2.Text}', '{txb_f3.Text}')");
                db_conn.entity.Execute<tb_test>(sql);
                MessageBox.Show($"Добавлена новая запись!\nid:{id}\nf1:{txb_f1.Text}\nf2:{txb_f2.Text}");
                Page page = new main_page();
                NavigationService.GetNavigationService(this).Navigate(page);
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }
    }
}
