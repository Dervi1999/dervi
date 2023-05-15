using exel_app_new.db_conn;
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
    /// Interaction logic for upd_page.xaml
    /// </summary>
    public partial class upd_page : Page
    {
        List<tb_test> tb_Tests = db_conn.entity.Execute<tb_test>($"select * from tb_test");
        public upd_page()
        {
            InitializeComponent();
            var info_test = tb_Tests.Where(s => s.id == data_bank.id).FirstOrDefault();
            txb_id.Text = info_test.id.ToString();
            txb_f1.Text = info_test.f1.ToString();
            txb_f2.Text = info_test.f2.ToString();
            txb_f3.Text = info_test.f3.ToString();
        }

        private void btn_upd_Click(object sender, RoutedEventArgs e)
        {
            var info_test = tb_Tests.Where(s => s.id == data_bank.id).FirstOrDefault();
            string f1 = txb_f1.Text;
            string f2 = txb_f2.Text;
            string f3 = txb_f3.Text;
            if(f1 != info_test.f1.ToString() || f2 != info_test.f2.ToString() || f3 != info_test.f3.ToString())
            {
                string sql_upd = String.Format($"update tb_test set f1 = '{f1}', f2 = '{f2}', f3 = '{f3}' where id = {data_bank.id}");
                entity.Execute<tb_test>(sql_upd);
                MessageBox.Show($"Данные записи обновлены!\nid={data_bank.id}\nf1={f1}\n");
                Page page = new main_page();
                NavigationService.GetNavigationService(this).Navigate(page);
            }
            else
            {
                MessageBox.Show("Нечего менять!");
            }
            
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            Page page = new main_page();
            NavigationService.GetNavigationService(this).Navigate(page);
        }
    }
}
