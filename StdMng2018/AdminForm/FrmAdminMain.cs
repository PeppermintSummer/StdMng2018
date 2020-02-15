using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StdMng2018.AdminForm
{
    public partial class FrmAdminMain : Form
    {
        public FrmAdminMain()
        {
            InitializeComponent();
        }

        //退出事件
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr= MessageBox.Show("确定要退出吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(dr==System.Windows.Forms.DialogResult.OK)//dialogresult是枚举类型
            {
                Application.Exit();
            }
        }
        //新建用户事件
        private void TslAddStudent_Click(object sender, EventArgs e)
        {
            FrmAddStudent frm = new FrmAddStudent();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 技术支持ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TslSearchStuInfo_Click(object sender, EventArgs e)
        {
            FrmStudentInfo frm = new FrmStudentInfo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmAdminMain_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel2.Text = "登录时间：" + DateTime.Now.ToString();
        }

        //
        private void TslSearchGrade_Click(object sender, EventArgs e)
        {
            FrmGradeDisplay fgd = new FrmGradeDisplay();
            fgd.MdiParent = this;
            fgd.Show();
        }

        private void TslCourseDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCourseDisplay fcd = new FrmCourseDisplay();
                fcd.MdiParent = this;
                fcd.Show();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void MslModifyPwd_Click(object sender, EventArgs e)
        {
            FrmModifyPwd frm = new FrmModifyPwd();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
