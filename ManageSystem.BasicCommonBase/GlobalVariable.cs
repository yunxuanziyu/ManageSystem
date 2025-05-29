using ManageSystem.DataManage.Model;
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
        public static User LoginUser { get; set; }
        private List<string> UserPurview=new();

        public static string XmlSetPath { get; set; } = Application.StartupPath+ "\\XmlPath";
    }
}
