namespace Challenge.UI
{
    partial class MainInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInterface));
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("按日期区间");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("按月份区间");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("我的成长史", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("题目类型分析");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("我的亮点");
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("题目数完成度");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("题目类型完成度");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("推荐题目");
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MyMemory = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Study = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.tabControl1.SuspendLayout();
            this.MyMemory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Study.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MyMemory);
            this.tabControl1.Controls.Add(this.Study);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(127, 8);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(657, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // MyMemory
            // 
            this.MyMemory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MyMemory.BackgroundImage")));
            this.MyMemory.Controls.Add(this.treeView1);
            this.MyMemory.Controls.Add(this.button1);
            this.MyMemory.Controls.Add(this.panel1);
            this.MyMemory.Controls.Add(this.pictureBox1);
            this.MyMemory.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MyMemory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MyMemory.Location = new System.Drawing.Point(4, 40);
            this.MyMemory.Name = "MyMemory";
            this.MyMemory.Padding = new System.Windows.Forms.Padding(3);
            this.MyMemory.Size = new System.Drawing.Size(649, 403);
            this.MyMemory.TabIndex = 0;
            this.MyMemory.Text = "旧的回忆";
            this.MyMemory.UseVisualStyleBackColor = true;
            this.MyMemory.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(246)))), ((int)(((byte)(152)))));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.ItemHeight = 19;
            this.treeView1.Location = new System.Drawing.Point(3, 37);
            this.treeView1.Name = "treeView1";
            treeNode9.Name = "节点1";
            treeNode9.Text = "按日期区间";
            treeNode10.Name = "节点2";
            treeNode10.Text = "按月份区间";
            treeNode11.Name = "节点0";
            treeNode11.Text = "我的成长史";
            treeNode12.Name = "节点3";
            treeNode12.Text = "题目类型分析";
            treeNode13.Name = "节点4";
            treeNode13.Text = "我的亮点";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(164, 97);
            this.treeView1.TabIndex = 4;
            this.treeView1.Visible = false;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "图标3.png");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "重新选择账号";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(184, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6);
            this.panel1.Size = new System.Drawing.Size(469, 383);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 153);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Study
            // 
            this.Study.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Study.BackgroundImage")));
            this.Study.Controls.Add(this.panel2);
            this.Study.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Study.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Study.Location = new System.Drawing.Point(4, 40);
            this.Study.Name = "Study";
            this.Study.Padding = new System.Windows.Forms.Padding(3);
            this.Study.Size = new System.Drawing.Size(649, 403);
            this.Study.TabIndex = 1;
            this.Study.Text = "想牛人学习";
            this.Study.UseVisualStyleBackColor = true;
            this.Study.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.treeView2);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 375);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "重新选择对比账号";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel3.Location = new System.Drawing.Point(-7, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(468, 375);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(477, 139);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 153);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // treeView2
            // 
            this.treeView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(246)))), ((int)(((byte)(152)))));
            this.treeView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView2.ImageIndex = 0;
            this.treeView2.ImageList = this.imageList1;
            this.treeView2.ItemHeight = 22;
            this.treeView2.Location = new System.Drawing.Point(463, 51);
            this.treeView2.Name = "treeView2";
            treeNode1.Name = "节点0";
            treeNode1.Text = "题目数完成度";
            treeNode2.Name = "节点3";
            treeNode2.Text = "题目类型完成度";
            treeNode3.Name = "节点4";
            treeNode3.Text = "推荐题目";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView2.SelectedImageIndex = 0;
            this.treeView2.Size = new System.Drawing.Size(179, 70);
            this.treeView2.TabIndex = 5;
            this.treeView2.Visible = false;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 421);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainInterface";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainInterface_Load);
            this.tabControl1.ResumeLayout(false);
            this.MyMemory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Study.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MyMemory;
        private System.Windows.Forms.TabPage Study;

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;

        //挂载外部的panel
        private System.Windows.Forms.Panel staticsPanel;

        private DateInput dateInput;
        private MonthInput monthInput;
        private ResultToPie resultToPie;
        private Highlights highlights;
        private ResultAccordingToDate resultAccordingToDate;
        private ResultAccordingToMonth resultAccordingToMonth;
        private CompletionAccordingToproblems completionAccordingToProblems;
        private CompletionAccordingToType completionAccordingToType;
        private SearchResult searchResult;
        private ProblemRecommend problemRecommend;
        private SuperiorSelect superiorSelect;

            
    }
}