using exel_app_new.db_conn;
using exel_app_new.models_app;
using Microsoft.Office.Interop.Excel;
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
using Excel = Microsoft.Office.Interop.Excel;

namespace exel_app_new.pages_app
{
    /// <summary>
    /// Interaction logic for main_page.xaml
    /// </summary>
    public partial class main_page : System.Windows.Controls.Page
    {
        List<tb_test> tb_Tests = entity.Execute<tb_test>("select * from tb_test");
        public main_page()
        {
            InitializeComponent();
            grbData.ItemsSource = tb_Tests;
        }

        private void btn_exel_Click(object sender, RoutedEventArgs e)
        {
            Excel.Application app = new Excel.Application
            {
                //Отобразить Excel
                Visible = true,
                //Количество листов в рабочей книге
                SheetsInNewWorkbook = 2
            };
            
            //Добавить рабочую книгу
            Excel.Workbook workBook = app.Workbooks.Add(Type.Missing);
            //Отключить отображение окон с сообщениями
            app.DisplayAlerts = false;
            //Получаем первый лист документа (счет начинается с 1)
            Excel.Worksheet sheet = (Excel.Worksheet)app.Worksheets.get_Item(1);
            //Название листа (вкладки снизу)
            sheet.Name = "Первый лист тестовых данных";
            int id_f = 1;
            //Заполнение ячеек
            for (int i = 1; i <= 9; i++)
            {
              for (int j = 1; j < 2; j++)
                    {
                    var info_test = tb_Tests.Where(s => s.id == id_f).FirstOrDefault();
                    if (info_test == null)
                    {
                        id_f++;
                    }
                    else
                    {
                        sheet.Cells[i, j] = String.Format($" {info_test.f1} {info_test.f2} \n {info_test.f3} ");
                        var cell = sheet.Cells[i, j];
                        int f1_length = info_test.f1.Length;
                        int f2_length = info_test.f2.Length;
                        int f1_f2_length = f1_length + 1 + f2_length;
                        int f3_length = info_test.f3.Length;
                        cell.Characters[1, f1_f2_length].Font.Bold = true;
                        sheet.Columns[1].ColumnWidth = 60;
                        sheet.Cells[i, j].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        if (f3_length > 60)
                        {
                            sheet.Cells[i, j].WrapText = true;
                        }
                    }
                    id_f++;
                }
                System.Threading.Thread.Sleep(50);
            }
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.Page page = new add_new();
            NavigationService.GetNavigationService(this).Navigate(page);
        }

        private void btn_upd_Click(object sender, RoutedEventArgs e)
        {
            int id = (grbData.SelectedItem as tb_test).id;
            data_bank.id = id;
            System.Windows.Controls.Page page = new upd_page();
            NavigationService.GetNavigationService(this).Navigate(page);

        }

        private void btn_del_Click(object sender, RoutedEventArgs e)
        {
            int id = (grbData.SelectedItem as tb_test).id;
            string sql = String.Format($"delete from tb_test where id={id}");
            entity.Execute<tb_test>(sql);
            MessageBox.Show($"Запись с id:{id} удалена!");
            List<tb_test> tb_Tests_new = entity.Execute<tb_test>("select * from tb_test");
            grbData.ItemsSource = tb_Tests_new;
        }

        private void btn_ofline_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.Page page = new ofline_mode.ofline_main_page();
            NavigationService.GetNavigationService(this).Navigate(page);
        }
    }
}
