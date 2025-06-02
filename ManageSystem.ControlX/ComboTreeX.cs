using DevComponents.AdvTree;
using DevComponents.DotNetBar.Controls;
using ManageSystem.BusinessManage.Service;
using ManageSystem.DataManage.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSystem.ControlX
{
    public class ComboTreeX:ComboTree
    {
        ToolTip _toolTip = new ToolTip();
        public ComboTreeX()
        {
            this.MouseHover += ComboBoxX_MouseHover;
            LoadEnumData();
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
                var data = service.GetEnumerationByType(EnumBindField).Result;
                var root = data.Where(x => x.ParentValue == "0");
                this.Nodes.Clear();
                foreach (var item in root)
                {
                    EnumerationNode node = new EnumerationNode() { Name = item.Name, Value = item.Value, ParentValue = item.ParentValue };
                    this.Nodes.Add(node);
                    AddChildNodes(data, node);
                }
            }
        }

        private void AddChildNodes(List<Enumeration> data, EnumerationNode parentNode)
        {
            var children = data.Where(x => x.ParentValue == parentNode.Value).ToList();
            foreach (var item in children)
            {
                EnumerationNode node = new EnumerationNode() { Name = item.Name, Value = item.Value, ParentValue = item.ParentValue };
                this.Nodes.Add(node);
                AddChildNodes(data, node);
            }
        }

        public class EnumerationNode:Node
        {
            public string DisplayName { get { return $"[{Value}]{Text}"; } }
            public string Value { get; set; }
            public string ParentValue { get; set; }
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
                // 这里可以添加刷新显示的逻辑
                this.Invalidate();
            }
        }
    }
}
