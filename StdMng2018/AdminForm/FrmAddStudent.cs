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
    public partial class FrmAddStudent : Form
    {
        #region 变量、常量的定义
        public const string INPUTWARN = "输入提示";
        public const string INPUTSTUNO = "请输入学号";
        public const string INPUTNAME = "请输入姓名";
        public const string INPUTSEX = "请输入性别";
        public const string INPUTDATEWRONG = "输入的出生年月日格式有误";
        public const string INPUTDEPT = "请输入系别";
        public const string INPUTEMAILWRONG = "输入Email格式有误";
        public const string INSERTFAILED = "添加失败";
        public const string INSERTSUCESS = "添加成功";
        public const string STUDENTNOISEXIST = "学号已存在";
        public const string OPERATIONWARN = "操作提示";
        public const string OPERATIONFAILED = "操作失误";
        #endregion

        public FrmAddStudent()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        //验证
        public bool CheckInputNotEmpty()
        {
            if (this.TxtStuNo.Text.Trim() == "")
            {
                MessageBox.Show(INPUTSTUNO, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TxtStuNo.Focus();
                return false;
            }
            if (this.TxtName.Text.Trim() == "")//姓名
            {
                MessageBox.Show(INPUTNAME, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TxtName.Focus();
                return false;
            }
            if (this.TxtDept.Text.Trim() == "")//系别
            {
                MessageBox.Show(INPUTDEPT, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TxtDept.Focus();
                return false;
            }
            if (!this.rbBoy.Checked && !this.rbGirl.Checked)//性别
            {
                MessageBox.Show(INPUTSEX, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.rbBoy.Focus();
                return false;
            }
            return true;
        }

        public bool CheckFormat()   //检查出生日期格式是否正确
        {
            bool flag = false;
            if (!(this.TxtBornDate.Text.Trim() == ""))
            {
                try
                {
                    DateTime dt = Convert.ToDateTime(this.TxtBornDate.Text.Trim());
                    flag = true;
                }
                catch (Exception)
                {
                    MessageBox.Show(INPUTDATEWRONG, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            return flag;
        }

        public bool CheckEmailFormat()//检查邮箱格式是否正确，也可以和上面出生日期写在一起
        {

            if (!(this.TxtEmail.Text.Trim() == ""))
            {
                if (!this.TxtEmail.Text.Contains("@"))
                {
                    MessageBox.Show(INPUTEMAILWRONG, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            return true;
        }

        //窗体加载事件
        private void FrmAddStudent_Load(object sender, EventArgs e)
        {

        }

        //单击添加事件
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInputNotEmpty())
                {
                    return;
                }
                if (!CheckFormat())
                { return; }
                if (!CheckEmailFormat())
                { return; }
                string strSex = " ";
                if (this.rbGirl.Checked)
                {
                    strSex = "女";
                }
                else if (this.rbBoy.Checked)
                {
                    strSex = "男";
                }
                else return;

                t_Student student = new t_Student();
                student.Sno = this.TxtStuNo.Text.Trim();
                student.Sname = this.TxtName.Text.Trim();
                student.Sgender = strSex;
                student.Sbirth = Convert.ToDateTime(this.TxtBornDate.Text.Trim());
                student.Sdept = this.TxtDept.Text.Trim();
                student.E_mail = this.TxtEmail.Text.Trim();


                int ret = new StudentManager().AddStudent(student);//返回受影响的行数
            if (ret > 0)
            {
                MessageBox.Show(INSERTSUCESS, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILED, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //throw ex;
            }
        }

        private void BtnCel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
