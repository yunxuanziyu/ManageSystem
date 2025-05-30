using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageSystem.BasicCommonBase;
using ManageSystem.BusinessManage;
using ManageSystem.DataManage;
using ManageSystem.DataManage.Model;
using ManageSystem.UIDesign;

namespace ManageSystem
{
    public partial class FormLogin: FormBase
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private  async void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageForm.ShowMessage("用户名或密码不能为空！","错误",true);
                return;
            }
            string passwordEncrypt = GlobalMethod.AESEncrypt(password);
            using(UserService userService = new UserService())
            {
                User user = await userService.GetUser(username, passwordEncrypt);
                if (user == null)
                {
                    MessageForm.ShowMessage("用户名或密码错误！", "错误", true);
                    return;
                }
                FormMain formMain = new FormMain(user);
                formMain.Show();
                this.Hide();
                bool Remreber = checkBoxRememberPwd.Checked;
                GlobalVariable.LoginUser = user;
                XmlLocalSetting.WriteXml<LoginInfo>(new LoginInfo() { UserName = username, Password = Remreber? passwordEncrypt : "", Remreber = Remreber }, "LoginInfo");
                using (LogService serviceLog = new LogService())
                {
                    _ = serviceLog.AddLog(new Log() { Content = user.ChineseName + "登录系统", OperaTime = DateTime.Now, Operator = user.Name });
                }
            }
        }

        public class LoginInfo
        {
            public string UserName { get; set; }
            public bool Remreber { get; set; }
            public string Password { get; set; }
        }
        private void buttonCancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\ManageSystem");
            if (key == null || key.GetValue("Registered")?.ToString() == null)
            {
                MessageBox.Show("系统未注册！");
                return;
            }
            if (key != null)
            {
                string Lifespen = key.GetValue("Lifespen")?.ToString();
                string CloseMsg = key.GetValue("CloseMsg")?.ToString();
                if (DateTime.Parse(Lifespen) < DateTime.Now)
                    MessageForm.ShowMessage("系统到期，请尽快续费！", "提示", true);
                else if (DateTime.Parse(Lifespen).Subtract(DateTime.Now).Days < 20 && CloseMsg == "0")
                {
                    MessageForm.ShowMessage("系统即将到期，请尽快续费！", "提示", true);
                    bool NoPromptAgain = MessageForm.NoPromptAgain;
                    if (NoPromptAgain)
                    {
                        key.SetValue("CloseMsg", "1");
                        key.Close();
                    }
                }
                key.Close();
            }
            LoginInfo info = XmlLocalSetting.ReadXml<LoginInfo>("LoginInfo");
            if (info != null && info is LoginInfo)
            {
                textBoxUserName.Text = info.UserName;
                checkBoxRememberPwd.Checked = info.Remreber;
                if (info.Remreber)
                    textBoxPassword.Text = GlobalMethod.AESDecrypt(info.Password);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistered.Instance.Show();
        }

        private void FormLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Escape)
            {
                FormDataSource form = new FormDataSource();
                form.Show();
                e.Handled = true;
            }
        }
    }
}
