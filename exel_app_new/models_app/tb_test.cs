using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exel_app_new.models_app
{
    public class tb_test
    {
        public tb_test() { }
        public tb_test(int id, string f1, string f2, string f3)
        {
            this.id = id;
            this.f1 = f1;
            this.f2 = f2;
            this.f3 = f3;
        }

        public int id { get; set; }
        public string f1 { get; set; }
        public string f2 { get; set; }
        public string f3 { get; set; }
    }
}
