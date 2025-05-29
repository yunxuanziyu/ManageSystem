using ManageSystem.BasicCommonBase;
using ManageSystem.BusinessManage;
using ManageSystem.UIDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSystem
{
    public partial class FormRegistered: FormBase
    {
        static FormRegistered form = null;
        public FormRegistered()
        {
            InitializeComponent();
        }

        public static FormRegistered Instance
        {
            get
            {
                if (form == null || form.IsDisposed)
                    form = new FormRegistered();
                return form;
            }
        }

        private void buttonGetMachineCode_Click(object sender, EventArgs e)
        {
            textBoxMachineCode.Text=GlobalMethod.GetMachineCode();
            textBoxRegisterCode.Text = GlobalMethod.GetRegisterCode(1);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string RegisterCode = textBoxRegisterCode.Text.Trim();
                if (CheckRegisterCode(RegisterCode, out string Lifespen) == false)
                {
                    MessageForm.ShowMessage("注册码错误！");
                    return;
                }
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\ManageSystem",Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree);
                if (key == null)
                {
                    key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\ManageSystem", Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree);
                }
                Lifespen = Encoding.UTF8.GetString(GlobalMethod.HexStringToBytes(Lifespen));
                key.SetValue("Registered", 1);
                key.SetValue("RegisterCode", RegisterCode);
                key.SetValue("Lifespen", Lifespen);
                key.SetValue("CloseMsg", "0");
                key.Flush();
                key.Close();
                labelX3.Text = "注册成功!有限期限至：" + Lifespen;
            }
            catch(UnauthorizedAccessException ex)
            {
                MessageForm.ShowMessage("注册失败！"+ex.ToString(), "错误",true);
            }
        }

        private bool CheckRegisterCode(string RegisterCode,out string Lifespen)
        {
            string[] strs = RegisterCode.Split('-');
            string Date1 = Encoding.UTF8.GetString(GlobalMethod.HexStringToBytes(strs[0]));
            bool b1 = DateTime.TryParse(Date1, out DateTime dt);
            string Date2 = Encoding.UTF8.GetString(GlobalMethod.HexStringToBytes(strs[1]));
            bool b2 = DateTime.TryParse(Date2, out DateTime dt2);
            GlobalMethod.ComputeSha256Hash(GlobalMethod.GetMachineCode() + GlobalMethod.SALT_VALUE);
            bool b3 = strs[2] == GlobalMethod.ComputeSha256Hash(GlobalMethod.GetMachineCode() + GlobalMethod.SALT_VALUE);
            Lifespen = strs[0];
            return b1 && b2 && b3;
        }
    }
}
