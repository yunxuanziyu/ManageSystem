using DevComponents.Editors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.ControlX
{
    public class IntegetInputX: IntegerInput
    {
        public IntegetInputX()
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
    }
}
