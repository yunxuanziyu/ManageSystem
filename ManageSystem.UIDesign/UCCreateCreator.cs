using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.UIDesign
{
    public class UCCreateCreator
    {
        private static readonly MemoryCache cache = new MemoryCache(null);
        //private static Dictionary<Type, UCBaseControl> _instanceList = new Dictionary<Type, UCBaseControl>();
        public static UCBaseControl Create<T>(object[] parameter = null)
        {
            //Type type = typeof(T);
            //if (_instanceList.ContainsKey(type))
            //{
            //    return _instanceList[type];
            //}
            //var UC = (UCBaseControl)Activator.CreateInstance(typeof(T), parameter);
            //UC.Dock = System.Windows.Forms.DockStyle.Fill;
            //_instanceList.Add(typeof(T), UC);
            //cache.Add(typeof(T).ToString(), UC, new DateTimeOffset().AddMinutes(10));
            //return _instanceList[typeof(T)];

            Type type = typeof(T);
            if(cache.Contains(type.ToString()))
                return (UCBaseControl)cache.Get(type.ToString());
            var UC = (UCBaseControl)Activator.CreateInstance(typeof(T), parameter);
            UC.Dock = System.Windows.Forms.DockStyle.Fill;
            cache.Add(typeof(T).ToString(), UC, new DateTimeOffset().AddMinutes(10));
            return UC;
        }

        public static void Clear()
        {
            //_instanceList.Clear();
            cache.Dispose();
        }
    }
}
