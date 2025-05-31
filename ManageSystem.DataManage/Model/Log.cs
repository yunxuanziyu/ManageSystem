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
        [Column(Name = "ID", IsIdentity = true, IsPrimary = true)]
        public int ID { get; set; }
        public string Content { get; set { field = value; OnPropertyChanged(nameof(Content)); } }
        public DateTime OperaTime { get; set { field = value; OnPropertyChanged(nameof(OperaTime)); } }
        public string Operator { get; set { field = value; OnPropertyChanged(nameof(Operator)); } }
    }
}
