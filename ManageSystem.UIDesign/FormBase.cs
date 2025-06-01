using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace ManageSystem.UIDesign
{
    public partial class FormBase: DevComponents.DotNetBar.Office2007Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        private bool _isDragging = false;
        private Point _lastMousePosition;
        private void FormBase_MouseDown(object sender, MouseEventArgs e)
        {
            // 当左键按下时开始拖拽
            if (e.Button == MouseButtons.Left)
            {
                _isDragging = true;
                _lastMousePosition = e.Location;

                // 可选：改变光标样式提示拖拽状态
                this.Cursor = Cursors.SizeAll;
            }
        }

        private void FormBase_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                // 计算移动偏移量
                int deltaX = e.X - _lastMousePosition.X;
                int deltaY = e.Y - _lastMousePosition.Y;

                // 更新窗体位置
                this.Location = new Point(
                    this.Location.X + deltaX,
                    this.Location.Y + deltaY);
            }
        }

        private void FormBase_MouseUp(object sender, MouseEventArgs e)
        {
            _isDragging = false;
            this.Cursor = Cursors.Default;
        }

        private static Dictionary<Type,Form> _formCache = new Dictionary<Type, Form>();
        public static Form CreateForm<T>(object[] param = null) where T : Form
        {
            if (!_formCache.ContainsKey(typeof(T)))
                _formCache.Add(typeof(T), Activator.CreateInstance(typeof(T), param) as T);
            return _formCache[typeof(T)];
        }
    }
}
