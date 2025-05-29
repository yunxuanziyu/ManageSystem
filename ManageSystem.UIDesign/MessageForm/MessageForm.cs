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
    public partial class MessageForm: FormBase
    {
        public static bool NoPromptAgain { get; set; } = false;
        public MessageForm(string message) : this(message, "提示")
        {
        }
        public MessageForm(string message, string title):this(message, title,false)
        {

        }

        public static void ShowMessage(string message)
        {
            ShowMessage(message, "提示", false);
        }
        public static void ShowMessage(string message, string title,bool IsCancleAutoClose)
        {
            MessageForm form = new MessageForm(message, title,IsCancleAutoClose);
            form.ShowDialog();
        }

        public MessageForm(string message, string title,bool IsCancleAutoClose)
        {
            InitializeComponent();
            this.Text = title;
            labelMsg.Text = message;
            timer1.Start();
            if (IsCancleAutoClose)
            {
                timer1.Stop();
                buttonSure.Text = $"确定";
            }
        }

        private void buttonSure_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

        int CountDown = 3;
        private void timer1_Tick(object sender, EventArgs e)
        {
            CountDown--;
            if (CountDown == 0)
                this.Close();
            else
                buttonSure.Text = $"确定({CountDown})";
        }

        private void MessageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            NoPromptAgain = checkBoxX1.Checked;
        }
    }
}
