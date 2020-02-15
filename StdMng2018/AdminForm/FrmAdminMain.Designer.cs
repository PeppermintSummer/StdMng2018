namespace StdMng2018.AdminForm
{
    partial class FrmAdminMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MslModifyPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.密码加密ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TslDeleteAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TslAddStudent = new System.Windows.Forms.ToolStripButton();
            this.TslSearchStuInfo = new System.Windows.Forms.ToolStripButton();
            this.TslSearchGrade = new System.Windows.Forms.ToolStripButton();
            this.TslCourseDisplay = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem,
            this.TsmiExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改密码ToolStripMenuItem,
            this.注销ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MslModifyPwd,
            this.密码加密ToolStripMenuItem});
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.修改密码ToolStripMenuItem.Text = "密码";
            // 
            // MslModifyPwd
            // 
            this.MslModifyPwd.Name = "MslModifyPwd";
            this.MslModifyPwd.Size = new System.Drawing.Size(216, 26);
            this.MslModifyPwd.Text = "修改密码";
            this.MslModifyPwd.Click += new System.EventHandler(this.MslModifyPwd_Click);
            // 
            // 密码加密ToolStripMenuItem
            // 
            this.密码加密ToolStripMenuItem.Name = "密码加密ToolStripMenuItem";
            this.密码加密ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.密码加密ToolStripMenuItem.Text = "密码加密";
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TslDeleteAdmin});
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.注销ToolStripMenuItem.Text = "注销";
            // 
            // TslDeleteAdmin
            // 
            this.TslDeleteAdmin.Name = "TslDeleteAdmin";
            this.TslDeleteAdmin.Size = new System.Drawing.Size(159, 26);
            this.TslDeleteAdmin.Text = "注销此用户";
            // 
            // TsmiExit
            // 
            this.TsmiExit.Name = "TsmiExit";
            this.TsmiExit.Size = new System.Drawing.Size(51, 24);
            this.TsmiExit.Text = "退出";
            this.TsmiExit.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TslAddStudent,
            this.TslSearchStuInfo,
            this.TslSearchGrade,
            this.TslCourseDisplay});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(785, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // TslAddStudent
            // 
            this.TslAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("TslAddStudent.Image")));
            this.TslAddStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TslAddStudent.Name = "TslAddStudent";
            this.TslAddStudent.Size = new System.Drawing.Size(93, 24);
            this.TslAddStudent.Text = "新建学生";
            this.TslAddStudent.Click += new System.EventHandler(this.TslAddStudent_Click);
            // 
            // TslSearchStuInfo
            // 
            this.TslSearchStuInfo.Image = ((System.Drawing.Image)(resources.GetObject("TslSearchStuInfo.Image")));
            this.TslSearchStuInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TslSearchStuInfo.Name = "TslSearchStuInfo";
            this.TslSearchStuInfo.Size = new System.Drawing.Size(123, 24);
            this.TslSearchStuInfo.Text = "学生信息管理";
            this.TslSearchStuInfo.Click += new System.EventHandler(this.TslSearchStuInfo_Click);
            // 
            // TslSearchGrade
            // 
            this.TslSearchGrade.Image = ((System.Drawing.Image)(resources.GetObject("TslSearchGrade.Image")));
            this.TslSearchGrade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TslSearchGrade.Name = "TslSearchGrade";
            this.TslSearchGrade.Size = new System.Drawing.Size(123, 24);
            this.TslSearchGrade.Text = "查询学生成绩";
            this.TslSearchGrade.Click += new System.EventHandler(this.TslSearchGrade_Click);
            // 
            // TslCourseDisplay
            // 
            this.TslCourseDisplay.Image = ((System.Drawing.Image)(resources.GetObject("TslCourseDisplay.Image")));
            this.TslCourseDisplay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TslCourseDisplay.Name = "TslCourseDisplay";
            this.TslCourseDisplay.Size = new System.Drawing.Size(93, 24);
            this.TslCourseDisplay.Text = "课程信息";
            this.TslCourseDisplay.Click += new System.EventHandler(this.TslCourseDisplay_Click);
            // 
            // FrmAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎使用";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsmiExit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TslAddStudent;
        private System.Windows.Forms.ToolStripButton TslSearchStuInfo;
        private System.Windows.Forms.ToolStripButton TslSearchGrade;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem MslModifyPwd;
        private System.Windows.Forms.ToolStripMenuItem 密码加密ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TslDeleteAdmin;
        private System.Windows.Forms.ToolStripButton TslCourseDisplay;
    }
}