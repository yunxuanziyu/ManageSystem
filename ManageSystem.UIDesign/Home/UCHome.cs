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
    public partial class UCHome : UserControl
    {

        public UCHome()
        {
            InitializeComponent();
        }

        private static UCHome home;
        public static UCHome Instance()
        {
            if (home == null)
                home=new UCHome();
            return home;
        }
    }
}
