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
    public partial class MonthInput : UserControl
    {
        public MonthInput()
        {
            InitializeComponent();
        }

        public Panel GetPanel()
        {
            return panel1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ParentForm代表容纳该控件的Form窗体
            MainInterface mainInterface = (MainInterface)this.ParentForm;

            //1表示创建月份分析的panel
            mainInterface.LoadResultPanel(this, 1);
        }
    }
}
