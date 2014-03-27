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
    public partial class ResultAccordingToMonth : UserControl
    {
        public ResultAccordingToMonth()
        {
            InitializeComponent();
        }


        public Panel GetPanel()
        {
            return panel1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainInterface mainInterface = (MainInterface)this.ParentForm;
            mainInterface.ReselectMonth();
        }

    }
}
