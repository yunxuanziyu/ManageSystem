using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.ControlX
{
    public partial class ComboBoxX:ComboBoxEx
    {
        public ComboBoxX()
        {

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
