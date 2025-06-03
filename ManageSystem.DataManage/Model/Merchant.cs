using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using FreeSql.DataAnnotations;

namespace ManageSystem.DataManage.Model
{
    [Table(Name = "Merchant")]
    [DisplayName("商户信息")]
    public class Merchant : ModelBase
    {
        [Column(IsIgnore = true)]
        [Browsable(false)]
        [DisplayName("实体名称")]
        public override string EntityName => MerchantName ?? MerchantCode;

        [Browsable(false)]
        public int ID { get; set; }

        [DisplayName("商户代码")]
        [Required]
        public string MerchantCode { get; set; }

        [DisplayName("商户名称")]
        [Required]
        public string MerchantName { get; set; }

        [DisplayName("商户地址")]
        public string MerchantAddress { get; set; }

        [DisplayName("联系人")]
        public string ContactMan { get; set; }

        [DisplayName("联系电话")]
        public string ContactPhone { get; set; }

        [DisplayName("联系邮箱")]
        public string ContactEmail { get; set; }

        [DisplayName("备注")]
        public string Remark { get; set; }
    }
}
