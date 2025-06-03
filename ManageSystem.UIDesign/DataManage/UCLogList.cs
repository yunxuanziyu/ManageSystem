using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageSystem.BusinessManage;
using ManageSystem.Extensions;

namespace ManageSystem.UIDesign
{
    public partial class UCLogList: UCBaseControl
    {
        public UCLogList()
        {
            InitializeComponent();
        }

        private void buttonXSearch_Click(object sender, EventArgs e)
        {
            try
            {
                loadingCircle1.Visible = loadingCircle1.Active =buttonXSearch.Visible = true;
                buttonXSearch.Enabled = false;
                using (LogService logService = new LogService())
                {
                    var logs = logService.GetLogsByCondition(textBoxXMan.Text,
                        dateTimeInputStart.LockUpdateChecked, dateTimeInputStart.Value,
                        dateTimeInputEnd.LockUpdateChecked, dateTimeInputEnd.Value).Result;
                    dataGridViewXLog.DataSource = logs.ToDataTable();
                }
            }
            catch {
                MessageForm.ShowErrorMessage("查询失败！");
            }
            finally
            {
                loadingCircle1.Visible = loadingCircle1.Active = false;
                buttonXSearch.Enabled = true;
            }
        }
    }
}
