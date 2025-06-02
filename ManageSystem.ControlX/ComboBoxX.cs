using DevComponents.AdvTree;
using DevComponents.DotNetBar.Controls;
using ManageSystem.BusinessManage.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSystem.ControlX
{
    public partial class ComboBoxX: ComboBoxEx
    {
        ToolTip _toolTip = new ToolTip();
        public ComboBoxX()
        {
            this.MouseHover += ComboBoxX_MouseHover;
        }
        private void ComboBoxX_MouseHover(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Text)) return;
            _toolTip.SetToolTip(this, this.Text);
        }
        private void LoadEnumData()
        {
            if (string.IsNullOrEmpty(EnumBindField)) return;
            using (EnumerationService service = new EnumerationService())
            {
                var data = service?.GetEnumerationByType(EnumBindField).Result;
                this.Items.Clear();
                this.DisplayMember = "DisplayName";
                this.ValueMember = "Value";
                foreach (var item in data)
                {
                    this.Items.Add(new ItemNode() { Name = item.Name, Value = item.Value });
                }
            }
        }
        public class ItemNode
        {
            public string DisplayName { get { return $"[{Value}]{Name}"; } }
            public string Name { get; set; }
            public string Value { get; set; }
        }

        private string _BindField;

        [Category("扩展属性")]
        [Description("绑定字段，用于绑定数据。")]
        public string BindField
        {
            get { return _BindField; }
            set
            {
                _BindField = value;
                // 这里可以添加刷新显示的逻辑
                this.Invalidate();
            }
        }

        private string _EnumBindField;

        [Category("扩展属性")]
        [Description("枚举绑定字段，用于绑定枚举。")]
        public string EnumBindField
        {
            get { return _EnumBindField; }
            set
            {
                _EnumBindField = value;
                if (!this.DesignMode)
                    LoadEnumData();
                // 这里可以添加刷新显示的逻辑
                this.Invalidate();
            }
        }
    }
}
