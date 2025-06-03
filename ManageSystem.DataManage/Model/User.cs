using FreeSql.DataAnnotations;
using ManageSystem.BasicCommonBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ManageSystem.DataManage.Model
{
    public class User : ModelBase
    {
        [Column(IsIgnore = true)]
        [Browsable(false)]
        [DisplayName("实体名称")]
        public override string EntityName => ChineseName ?? Name;

        [Column(Name = "ID", IsIdentity = true)]
        public int ID { get; set; }

        [Column(Name = "Name", IsPrimary = true)]
        [Required]
        [DisplayName("用户名")]
        public string Name { get; set { field = value; OnPropertyChanged(nameof(Name)); } }

        [DisplayName("邮箱")]
        public string Email { get; set { field = value; OnPropertyChanged(nameof(Email)); } }

        [DisplayName("密码")]
        [Browsable(false)]
        public string Password { get { return GlobalMethod.AESDecrypt(field); } set { field = GlobalMethod.AESEncrypt(value); OnPropertyChanged(nameof(Password)); } }

        [DisplayName("手机号")]
        public string Phone { get; set { field = value; OnPropertyChanged(nameof(Phone)); } }

        [DisplayName("创建日趋")]
        [Column(CanUpdate = false)]
        public DateTime? CreatedDate { get; set { field = value; OnPropertyChanged(nameof(CreatedDate)); } }

        [DisplayName("更新日期")]
        [Column(CanInsert = false)]
        public DateTime? UpdatedDate { get; set { field = value; OnPropertyChanged(nameof(UpdatedDate)); } }

        [DisplayName("生日")]
        public DateTime Birtdate { get; set { field = value; OnPropertyChanged(nameof(Birtdate)); } }

        [DisplayName("身份证号")]
        public string IDCard { get { return GlobalMethod.AESDecrypt(field); } set { field = GlobalMethod.AESEncrypt(value); OnPropertyChanged(nameof(IDCard)); } }

        [DisplayName("姓名")]
        public string ChineseName { get; set { field = value; OnPropertyChanged(nameof(ChineseName)); } }

        [Column(Name = "Age", IsIgnore = true)]
        [DisplayName("年龄")]
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                int age = today.Year - Birtdate.Year;
                if (Birtdate > today.AddYears(-age)) age--;
                return age;
            }
        }

        [DisplayName("性别")]
        public string Sex { get; set { field = value; OnPropertyChanged(nameof(Sex)); } }

        [DisplayName("备注")]
        public string Remark { get; set { field = value; OnPropertyChanged(nameof(Remark)); } }

        [DisplayName("籍贯")]
        public string Hometown { get; set { field = value; OnPropertyChanged(nameof(Remark)); } }

        [DisplayName("部门代码")]
        [Browsable(false)]
        [Column(Name = "DeptCode")]
        public string DeptCode { get; set { field = value; OnPropertyChanged(nameof(DeptCode)); } }

        [Browsable(false)]
        [Column(Name = "Photo", MapType = typeof(byte[]))]
        public byte[] Photo { get; set { field = value; OnPropertyChanged(nameof(Photo)); } }

        [Browsable(false)]
        public Image Image
        {
            get
            {
                if (Photo == null || Photo.Length == 0)
                    return null;
                using (var ms = new MemoryStream(Photo))
                {
                    return Image.FromStream(ms);
                }
            }
            set
            {
                using (var ms = new MemoryStream())
                {
                    value.Save(ms, value.RawFormat);
                    Photo = ms.ToArray();
                }
                ;
            }
        }

        [DisplayName("部门名称")]
        public string DepartmentName { get { return Department?.DeptName; } }
        
        [Browsable(false)]
        [Navigate(nameof(DeptCode))]
        public Department Department { get; set; }
    }

    public class UserList : List<ModelBase>
    {

    }
}
