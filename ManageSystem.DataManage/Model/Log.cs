using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.DataManage.Model
{
    public class Log : ModelBase
    {
        public string Content { get; set; }
        public DateTime OperaTime { get; set; }
        public string Operator { get; set; }
    }
}
