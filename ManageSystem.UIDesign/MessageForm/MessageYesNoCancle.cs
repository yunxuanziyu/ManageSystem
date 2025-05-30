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
    public partial class MessageYesNoCancle: MessageYesNo
    {
        public MessageYesNoCancle(string message) : this(message, "询问")
        {

        }
        public MessageYesNoCancle(string message, string title)
        {
            InitializeComponent();
            base.labelMsg.Text = message;
            this.Text = title;
        }
        public static new DialogResult ShowMessage(string msg, string title = "询问")
        {
            MessageYesNoCancle yesNo = new MessageYesNoCancle(msg, title);
            return yesNo.ShowDialog();
        }

        private void buttonCancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
