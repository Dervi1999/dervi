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
using System.Xml;

namespace exel_app_new.pages_app.ofline_mode
{
    /// <summary>
    /// Interaction logic for ofline_main_page.xaml
    /// </summary>
    public partial class ofline_main_page : Page
    {
        List<tb_ofline> tbs = new List<tb_ofline>();
        public ofline_main_page()
        {
            InitializeComponent();
            
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("tb_offline.xml");

            XmlNodeList nodeList = xmlDocument.SelectNodes("/data-list/data");
            foreach (XmlNode node in nodeList)
            {
                    int id = int.Parse(node.SelectSingleNode("id").InnerText);
                    string f1 = node.SelectSingleNode("f1").InnerText;
                    string f2 = node.SelectSingleNode("f2").InnerText;
                    string f3 = node.SelectSingleNode("f3").InnerText;
                    tb_ofline tb_xml = new tb_ofline(id, f1, f2, f3);
                    tbs.Add(tb_xml);
            }

            grbData.ItemsSource = tbs;
        }

        private void btn_ofline_Click(object sender, RoutedEventArgs e)
        {
            Page page = new main_page();
            NavigationService.GetNavigationService(this).Navigate(page);
        }

        private void btn_exel_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application
            {
                //Отобразить Excel
                Visible = true,
                //Количество листов в рабочей книге
                SheetsInNewWorkbook = 2
            };

            //Добавить рабочую книгу
            Microsoft.Office.Interop.Excel.Workbook workBook = app.Workbooks.Add(Type.Missing);
            //Отключить отображение окон с сообщениями
            app.DisplayAlerts = false;
            //Получаем первый лист документа (счет начинается с 1)
            Microsoft.Office.Interop.Excel.Worksheet sheet = (Microsoft.Office.Interop.Excel.Worksheet)app.Worksheets.get_Item(1);
            //Название листа (вкладки снизу)
            sheet.Name = "Первый лист тестовых данных";
            int id_f = 1;
            //Заполнение ячеек
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j < 2; j++)
                {
                    var info_test = tbs.Where(s => s.id == id_f).FirstOrDefault();
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
                        sheet.Cells[i, j].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenterAcrossSelection;
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
            Page page = new offline_add_new();
            NavigationService.GetNavigationService(this).Navigate(page);
        }

        private void btn_upd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_del_Click(object sender, RoutedEventArgs e)
        {
            int id = grbData.SelectedIndex;
            tbs.RemoveAt(id);
            grbData.ItemsSource = tbs;
        }

        private void btn_edit_xml_Click(object sender, RoutedEventArgs e)
        {
            tb_ofline tb1 = new tb_ofline(1, date_text.text_f1_1, date_text.text_f2_1, date_text.text_f3_1);
            tbs.Add(tb1);
            tb_ofline tb2 = new tb_ofline(2, date_text.text_f1_2, date_text.text_f2_2, date_text.text_f3_2);
            tbs.Add(tb2);
            tb_ofline tb3 = new tb_ofline(3, date_text.text_f1_3, date_text.text_f2_3, date_text.text_f3_3);
            tbs.Add(tb3);
            //Создаём новый документ
            XmlDocument document = new XmlDocument();

            XmlElement data_list = document.CreateElement("data-list");
            
            foreach (tb_ofline ofline in tbs)
            {
                XmlElement data = document.CreateElement("data");
                XmlElement id = document.CreateElement("id");
                id.InnerText = ofline.id.ToString();
                data.AppendChild(id);
                XmlElement f1 = document.CreateElement("f1");
                f1.InnerText = ofline.f1.ToString();
                data.AppendChild(f1);
                XmlElement f2 = document.CreateElement("f2");
                f2.InnerText = ofline.f2.ToString();
                data.AppendChild(f2);
                XmlElement f3 = document.CreateElement("f3");
                f3.InnerText = ofline.f3.ToString();
                data.AppendChild(f3);
                data_list.AppendChild(data);
            }
            
            document.AppendChild(data_list);

            document.Save("tb_offline.xml");

        }
    }
}
