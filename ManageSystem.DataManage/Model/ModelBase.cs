using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.DataManage.Model
{
    public class ModelBase: INotifyPropertyChanged
    {
        [Key]
        [Browsable(false)]
        public int ID { get; set { field = value; OnPropertyChanged("ID"); } }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
