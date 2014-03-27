using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // label1.BackColor = Color.Transparent;
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //移除自身
            Panel mainFramePanel = (Panel)this.Parent;
            mainFramePanel.Controls.Remove(this);

            //载入主界面
            MainForm mainForm = (MainForm)mainFramePanel.Parent;
            mainForm.LoadMainInterFace();
        }
    }
}
