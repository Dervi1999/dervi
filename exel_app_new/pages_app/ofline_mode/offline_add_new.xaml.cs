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
    /// Логика взаимодействия для offline_add_new.xaml
    /// </summary>
    public partial class offline_add_new : Page
    {
        List<tb_ofline> tbs = new List<tb_ofline>();
        
        public offline_add_new()
        {
            InitializeComponent();
            select_tb_ofline();
           
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {

        }

        public void select_tb_ofline()
        {
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
        }
    }
}
