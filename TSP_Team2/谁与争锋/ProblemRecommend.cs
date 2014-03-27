using System;
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
    public partial class ProblemRecommend : UserControl
    {
        public ProblemRecommend()
        {
            InitializeComponent();
        }

        public Panel GetPanel()
        {
            return panel1;
        }
    }
}
