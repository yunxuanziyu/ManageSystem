using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using FreeSql.DataAnnotations;

namespace ManageSystem.DataManage.Model
{
    public class Log : ModelBase
    {
        [Browsable(false)]
        [Column(Name = "ID", IsIdentity = true, IsPrimary = true)]
        public int ID { get; set; }
        
        [DisplayName("操作内容")]
        public string Content { get; set { field = value; OnPropertyChanged(nameof(Content)); } }
        
        [DisplayName("操作时间")]
        public DateTime OperaTime { get; set { field = value; OnPropertyChanged(nameof(OperaTime)); } }
        
        [DisplayName("操作人")]
        public string Operator { get; set { field = value; OnPropertyChanged(nameof(Operator)); } }
    }
}
