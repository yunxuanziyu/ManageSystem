using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSystem.BasicCommonBase
{
    public class GlobalVariable
    {
        public static object LoginUser { get; set; }
        private List<object> UserPurview=new();

        public static string XmlSetPath { get; set; } = Application.StartupPath+ "\\XmlPath";
    }
}
