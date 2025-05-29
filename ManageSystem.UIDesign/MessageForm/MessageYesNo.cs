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
    public partial class MessageYesNo: FormBase
    {
        public MessageYesNo(string message):this(message, "询问")
        {
            
        }
        public MessageYesNo(string message, string title)
        {
            InitializeComponent();
            labelMsg.Text = message;
            this.Text = title;
        }
        
        public static DialogResult ShowMessage(string msg)
        {
            MessageYesNo yesNo = new MessageYesNo(msg);
            return yesNo.ShowDialog();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
