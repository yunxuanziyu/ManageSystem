using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ManageSystem.DataManage.Model
{
    public class Log : ModelBase
    {
        public string Content { get; set { field = value; OnPropertyChanged(nameof(Content)); } }
        public DateTime OperaTime { get; set { field = value; OnPropertyChanged(nameof(OperaTime)); } }
        public string Operator { get; set { field = value; OnPropertyChanged(nameof(Operator)); } }
    }
}
