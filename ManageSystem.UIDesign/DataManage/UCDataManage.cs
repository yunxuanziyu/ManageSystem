using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSystem.UIDesign
{
    public partial class UCDataManage: UserControl
    {
        public UCDataManage()
        {
            InitializeComponent();
        }
        private static UCDataManage home;
        public static UCDataManage Instance()
        {
            if (home == null)
                home = new UCDataManage();
            return home;
        }
    }
}
