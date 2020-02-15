using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StdMng2018Bll;
using StdMng2018Models;

namespace StdMng2018.AdminForm
{
    public partial class FrmAddGrade : Form
    {
        public string studentNo { get; set; }
        //public string CourseNo { get; set; }


        private const string INPUTWARN = "请输入提示";
        private const string INPUTCNO = "请输入课程号";
        private const string INPUTGRADE = "请输入成绩";
        private const string INPUTGRADEWRONG = "输入成绩错误";
        private const string OPERATIONWARN = "操作提示";
        private const string OPERATIONFAILED = "操作错误";
        private const string ADDSUCCESS = "添加成功";
        private const string ADDFAILED = "添加失败";

        private GradeManager gradeManager = new GradeManager();

        public FrmAddGrade()
        {
            InitializeComponent();
        }

        //非空验证
        public bool CheckInputNoEmpty()
        {
            if (this.TxtCno.Text.Trim() == "")
            {
                MessageBox.Show(INPUTCNO, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TxtCno.Focus();
                return false;
            }
            if (this.TxtGrade.Text.Trim() == "")
            {
                MessageBox.Show(INPUTGRADE, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TxtGrade.Focus();
                return false;
            }
            return true;
        }

        public bool CheckGrade(short  grade)
        {
            try
            {
                if (grade < 0 || grade > 100)
                {
                    MessageBox.Show(INPUTGRADEWRONG, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //throw;
                return false;
            }
        }

        //单击添加事件
        private void BtnAddGrade_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInputNoEmpty())
                {
                    return;
                }
                if (!CheckGrade(Convert.ToInt16(TxtGrade.Text.Trim())))
                {
                    return;
                }
                t_SC grade = new t_SC();
                grade.Sno = this.studentNo;
                grade.Cno = this.TxtCno.Text.Trim();
                grade.Grade =Convert.ToInt16(this.TxtGrade.Text.Trim());
                int ret = gradeManager.AddStudentGrade(grade);
                if (ret>0)
                {
                    MessageBox.Show(ADDSUCCESS, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Close();
                    
                }
                else
                {
                    MessageBox.Show(ADDFAILED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, OPERATIONFAILED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Cnacel_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmStudentInfo frm = new FrmStudentInfo();
            frm.Show();
        }
    }
}
