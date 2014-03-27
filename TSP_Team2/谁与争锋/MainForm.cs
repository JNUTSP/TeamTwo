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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {   
            login = new Login();

            //panel挂载loginform
            login.TopLevel = false;
            login.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(login);

            login.Show();

                     
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        /*
         * 以下是自定义外部接口函数
         * 
         */
        public void LoadMainInterFace() 
        {
            /*
             * 载入并显示主界面
             */
            mainInterface = new Challenge.UI.MainInterface();

            //取消form的顶级控件,否则会产生中断
            mainInterface.TopLevel = false;

            //去掉外部边框
            mainInterface.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(mainInterface);
            mainInterface.Show();
        }

        public void ReloadLogin(Control mainInterface)
        {
            //移除主界面
            this.panel1.Controls.Remove(mainInterface);
            login = new Login();

            //取消作为顶级控件
            login.TopLevel = false;

            //去掉外边框
            login.FormBorderStyle = FormBorderStyle.None;

            panel1.Controls.Add(login);
            login.Show();

        }

        
    }
}
