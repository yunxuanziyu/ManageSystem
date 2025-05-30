using ManageSystem.BasicCommonBase;
using ManageSystem.DataManage.Model;
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
    public partial class FormDataSource: FormBase
    {
        public FormDataSource()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string path = textBoxPath.Text;
            XmlLocalSetting.WriteXml<DataSourceModel>(new DataSourceModel()
            { DataSourceName = "SqliteDataSource", DataSourcePath = path, DataSourceType = EnumDataSourceType.Sqlite }, "SqliteDataSource");
            MessageForm.ShowMessage("保存成功!");
        }

        private void textBoxPath_ButtonCustomClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Sqlite数据库文件|*.db";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = openFileDialog.FileName;
            }
        }
    }
}
