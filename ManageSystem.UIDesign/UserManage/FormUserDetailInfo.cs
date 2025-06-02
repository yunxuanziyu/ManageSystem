using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSystem.UIDesign
{
    public partial class FormUserDetailInfo: FormBase
    {
        public FormUserDetailInfo(User user)
        {
            InitializeComponent();
            BindingUser(user);
        }

        public void BindingUser(User user)
        {
            this.ucBaseControl1.WriteData<User>(user, this);
        }
    }
}
