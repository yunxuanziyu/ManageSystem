using FreeSql.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.DataManage.Model
{
    public class ModelBase : INotifyPropertyChanged
    {
        [Column(IsIgnore = true)]
        [Browsable(false)]
        [DisplayName("实体名称")]
        public virtual string EntityName { get; set; }

        [Column(IsIgnore = true)]
        [Browsable(false)]
        [DisplayName("编辑状态")]
        public EnumEditState EditState { get; set; } = EnumEditState.eNoEdit;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class ModelBaseList: List<ModelBase>
    {

    }
    public enum EnumEditState
    {
        [Description("未编辑")]
        eNoEdit = 0,
        [Description("更新")]
        eUpdate = 1,
        [Description("删除")]
        eDelete = 2,
        [Description("新增")]
        eInsert = 3
    }
}
