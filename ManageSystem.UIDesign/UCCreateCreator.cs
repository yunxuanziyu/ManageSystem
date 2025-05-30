using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.UIDesign
{
    public class UCCreateCreator
    {
        private static Dictionary<Type, UCBaseControl> _instanceList = new Dictionary<Type, UCBaseControl>();
        public static UCBaseControl Create<T>(object[] parameter = null)
        {
            Type type = typeof(T);
            if (_instanceList.ContainsKey(type))
            {
                return _instanceList[type];
            }
            var UC = (UCBaseControl)Activator.CreateInstance(typeof(T), parameter);
            UC.Dock = System.Windows.Forms.DockStyle.Fill;
            _instanceList.Add(typeof(T), UC);
            return _instanceList[typeof(T)];
        }
    }
}
