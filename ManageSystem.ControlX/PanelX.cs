﻿using System;
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
            InitializeComponent();
        }

        public PanelX(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

    }
}
