using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSystem.ControlX
{
    public partial class PanelX: Panel
    {    
        public PanelX()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }

        public PanelX(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

    }
}
