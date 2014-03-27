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
    
    public partial class MainInterface : Form
    {

        public MainInterface()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            /*
            dateInput = new Challenge.DateInput();

            dateInput.TopLevel = false;
            dateInput.Parent = panel1;
       
            dateInput.FormBorderStyle = FormBorderStyle.None;
            //dateInput.BackColor = Color.Transparent;

            dateInput.TransparencyKey = dateInput.BackColor;
    

            panel1.Controls.Add(dateInput);
            dateInput.Show();
             * */
        }

        private void MainInterface_Load(object sender, EventArgs e)
        {
           
           //根据搜索结果进行选择,因为可能有多个相同名称的账号
           searchResult = new SearchResult();
           panel1.Controls.Add(searchResult);
           searchResult.Show();

           superiorSelect = new SuperiorSelect();
           panel3.Controls.Add(superiorSelect);
           superiorSelect.Show();
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

           // treeView1.SelectedNode.
            
            if (treeView1.SelectedNode.Parent == null)
            {
                switch (treeView1.SelectedNode.Index)
                {
                    case 0:
                        break;
                    case 1:
                        if (resultToPie == null)
                        {
                            resultToPie = new ResultToPie();
                            panel1.Controls.Add(resultToPie);
                            
                        }
                        foreach (Control n in panel1.Controls)
                        {
                            n.Hide();
                        }
                        
                        //隐藏当前panel下的子控件
                        resultToPie.Show();
                        //MessageBox.Show("类型分析");
                        break;

                    case 2:
                        if (highlights == null)
                        {
                            highlights = new Highlights();
                            panel1.Controls.Add(highlights);
                            
                        }
                        //隐藏当前panel下的子控件
                        foreach (Control n in panel1.Controls)
                        {
                            n.Hide();
                        }
                        highlights.Show();
                        //MessageBox.Show("我的亮点");
                        break;

                }

            }
            else //选中的是子节点
            {
                switch (treeView1.SelectedNode.Index)
                {
                        /*
                         * 第一次点击TreeView上相关子节点的时候,如果resultAccordingToDate的panel控件
                         * 没有创建出来,说明是第一次点击该子节点,所以需要创建一个dateInput用来进行用
                         * 户选择日期的输入,后期不再进行这个步骤,直接进入else语句
                         * 
                         */
                    case 0:

                        //隐藏当前panel下的子控件
                        foreach (Control n in panel1.Controls)
                        {
                            n.Hide();
                        }

                         if (resultAccordingToDate == null)
                        {
                            dateInput = new DateInput();
                            panel1.Controls.Add(dateInput);
                            dateInput.Show();
                            break;
                            
                        }
                         else
                         {  
                             resultAccordingToDate.Show();
                             // MessageBox.Show("按日期分析");
                             break;
                         }
                        

                    case 1:
                         //隐藏当前panel下的子控件
                         foreach (Control n in panel1.Controls)
                         {
                             n.Hide();
                         }

                         if (resultAccordingToMonth == null)
                         {
                             monthInput = new MonthInput();
                             panel1.Controls.Add(monthInput);
                             monthInput.Show();
                             break;

                         }
                         else
                         {
                             resultAccordingToMonth.Show();
                             // MessageBox.Show("按日期分析");
                             break;
                         }
                   
                }
            }//end of else


        }//end of treeView1_AfterSelect_1

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (treeView2.SelectedNode.Index)
            {
                case 0:
                    foreach (Control n in panel3.Controls)
                    {
                        n.Hide();
                    }

                    if (completionAccordingToProblems == null)
                    {
                        completionAccordingToProblems = new CompletionAccordingToproblems();
                        panel3.Controls.Add(completionAccordingToProblems);
                    }
                    completionAccordingToProblems.Show();      
                   // MessageBox.Show("题目数完成度分析");
                    break;

                case 1:
                    foreach (Control n in panel3.Controls)
                    {
                        n.Hide();
                    }

                    if (completionAccordingToType == null)
                    {
                        completionAccordingToType = new CompletionAccordingToType();
                        panel3.Controls.Add(completionAccordingToType);
                    }
                    completionAccordingToType.Show();      
                    //MessageBox.Show("题目类型完成度分析");
                    break;

                case 2:
                    foreach (Control n in panel3.Controls)
                    {
                        n.Hide();
                    }

                    if (problemRecommend == null)
                    {
                        problemRecommend = new ProblemRecommend();
                        panel3.Controls.Add(problemRecommend);
                    }
                    problemRecommend.Show();      
                   // MessageBox.Show("推荐题目");
                    break;

            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }//end of treeView2_AfterSelect

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.ParentForm;
            mainForm.ReloadLogin(this);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
             * 因为MainInterface中有以下三个控件的引用,如果不赋值为null,则执行clear操作的时候,
             * 控件不会被真正销毁
             * 
             */
            completionAccordingToProblems = null;
            completionAccordingToType = null;
            problemRecommend = null;

            //清除所有子控件
            panel3.Controls.Clear();

            superiorSelect = new SuperiorSelect();
            panel3.Controls.Add(superiorSelect);
            superiorSelect.Show();

            treeView2.Visible = false;
            button2.Visible = false;
        }



        /*
         * 以下是自定义外部接口函数
         * 
         */
        public void LoadResultPanel(Control sender, int selectNum)
        {
            //隐藏日期选择控件
            panel1.Controls.Remove(sender);
            switch(selectNum)
            {     
                    
                case 0:
                    resultAccordingToDate = new ResultAccordingToDate();
                    foreach (Control n in panel1.Controls)
                    {
                        n.Hide();
                    }
                    panel1.Controls.Add(resultAccordingToDate);
                    resultAccordingToDate.Show();
                    break;

                case 1:
                    resultAccordingToMonth = new ResultAccordingToMonth();
                    foreach (Control n in panel1.Controls)
                    {
                        n.Hide();
                    }
                    panel1.Controls.Add(resultAccordingToMonth);
                    resultAccordingToMonth.Show();
                    break;
            }
        }

        public void EnterMyMemory(Control control)
        {
            this.panel1.Controls.Remove(control);

            //窗体初始化的时候treeView1默认是不可见的
            treeView1.Visible = true;


            //进入后台进行信息提取和存储
        }

        public void EntryComparison(Control control)
        {
            this.panel3.Controls.Remove(control);

            //窗体初始化的时候treeView2默认是不可见的
            treeView2.Visible = true;

            button2.Visible = true;

            //进入后台进行信息提取和存储
        }

        public void ReselectDate()
        {
            foreach (Control n in panel1.Controls)
            {
                n.Hide();
            }

            //先进入后台操作
            panel1.Controls.Add(dateInput);
            dateInput.Show();
            
        }

        public void ReselectMonth()
        {
            foreach (Control n in panel1.Controls)
            {
                n.Hide();
            }

            //先进入后台操作
            panel1.Controls.Add(monthInput);
            monthInput.Show();
        }

    }


}//end of namespace
            