﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge.UI
{
    public partial class Highlights : UserControl
    {
        public Highlights()
        {
            InitializeComponent();
        }

        public Panel GetPanel()
        {
            return panel1;
        }
    }
}
