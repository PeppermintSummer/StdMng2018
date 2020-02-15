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
    public partial class FrmStudentInfo : Form
    {
        #region 常量、变量的定义
        public const string OPERATIONFAILED = "操作错误";
        public const string INPUTWARN = "输入提示";
        public const string INPUTNAME = "请输入姓名";
        public const string INPUTSTUNO = "请输入学号";
        public const string INPUTSEX = "请您输入性别";
        public const string INPUTDEPT = "请输入系别";
        public const string INPUTEMAIL = "请输入邮箱";
        public const string INPUTDATEWRONG = "您输入的日期有误";
        public const string INPUTEMAILWRONG = "您输入的邮箱格式有误";
        public const string UPDATEFAILED = "更新失败";
        public const string UPDATESUCCESS = "更新成功";
        public const string DELETEFAILED = "删除失败";
        public const string DELETESUCCESS = "删除成功";
        public const string STUDENTISEXIST = "学号已存在";
        public const string ISDELETE = "确定要删除吗？";
        public const string NOEXPORT = "无数据导入！";
        public const string OPERATIONWARN = "操作提示";

        List<t_SC> gradelist = new List<t_SC>();
        StudentManager studentManager = new StudentManager();
        GradeManager gradeManager = new GradeManager();
        #endregion


        public FrmStudentInfo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 学生全部信息的绑定
        /// </summary>
        public void StudentDataBind()
        {
            List<t_Student> studentList = studentManager.GetT_StudentsData();
            this.DgvStuInfo.DataSource = studentList;
        }

        /// <summary>
        /// 根据检索条件取得学生信息并绑定
        /// </summary>
        public void StudentDataBindByName()
        {
            List<t_Student> studentList = studentManager.GetT_StudentsDataByName(this.TxtName1.Text.Trim());
            this.DgvStuInfo.DataSource = studentList;
        }

        /// <summary>
        /// 更新需要修改的行
        /// </summary>
        public void SetDisplayData()
        {
            if (this.DgvStuInfo.SelectedRows.Count>0)
            {
                DataGridViewRow dgvr = this.DgvStuInfo.CurrentRow;
                this.TxtStuNo.Text = dgvr.Cells[0].Value.ToString();
                this.TxtName2.Text = dgvr.Cells[1].Value.ToString();
                if (dgvr.Cells[2].Value.ToString() == "男")
                {
                    this.rbBoy.Checked = true;
                }
                else this.rbGirl.Checked = true;
                this.DtpBornDate.Text = dgvr.Cells[3].Value.ToString();
                this.TxtDept.Text = dgvr.Cells[4].Value.ToString();
                this.TxtEmail.Text = dgvr.Cells[5].Value.ToString();
            }
        }

        //非空验证
        public bool CheckInputNoEmpty()
        {
            if (this.TxtStuNo.Text.Trim()=="")
            {
                MessageBox.Show(INPUTSTUNO, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TxtStuNo.Focus();
                return false;
            }
            if (this.TxtName2.Text.Trim() == "")
            {
                MessageBox.Show(INPUTNAME, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TxtName2.Focus();
                return false;
            }
            if (!this.rbBoy.Checked && !this.rbGirl.Checked)
            {
                MessageBox.Show(INPUTSEX, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return false;
            }
            if (this.TxtDept.Text.Trim() == "")
            {
                MessageBox.Show(INPUTDEPT, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TxtDept.Focus();
                return false;
            }
            if (this.TxtEmail.Text.Trim() == "")
            {
                MessageBox.Show(INPUTEMAIL, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TxtEmail.Focus();
                return false;
            }
            return true;
            
        }

        /*public bool CheckDateFormat()   //检查出生日期格式是否正确
        {
            bool flag = false;
            if (!(this.DtpBornDate.Text.Trim() == ""))
            {
                try
                {
                    DateTime dt = Convert.ToDateTime(this.DtpBornDate.Text.Trim());
                    flag = true;
                }
                catch (Exception)
                {
                    MessageBox.Show(INPUTDATEWRONG, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            return flag;
        }*/

        //验证邮箱
        public bool CheckEmailFormat()
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
        private void FrmStudentInfo_Load(object sender, EventArgs e)
        {
            try
            {
                StudentDataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //单击查询事件
        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                StudentDataBind();
                StudentDataBindByName();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void DgvStuInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //单击单元格事件
        private void DgvStuInfo_Click(object sender, EventArgs e)
        {
            try
            {
                SetDisplayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILED, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //throw ex;
            }
        }

        //单击修改事件
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInputNoEmpty())
                {
                    return;
                }
                
                if (!CheckEmailFormat())
                {
                    return;
                }
                string strSex = "";
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
                student.Sname = this.TxtName2.Text.Trim();
                student.Sgender = strSex;
                student.Sbirth = this.DtpBornDate.Value;
                student.Sdept = this.TxtDept.Text.Trim();
                student.E_mail = this.TxtEmail.Text.Trim();

                int ret = studentManager.UpdateStudent(student);

                if (ret>0)
                {
                    MessageBox.Show(UPDATESUCCESS, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(UPDATEFAILED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILED, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            //刷新
            StudentDataBind();
        }

        //单击取消事件
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //删除事件
        private void TsmiDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr=MessageBox.Show(ISDELETE, OPERATIONWARN, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr==DialogResult.OK)
                {
                    string CellValue = this.DgvStuInfo.CurrentRow.Cells[0].Value.ToString();
                    int ret= studentManager.DeleteStudentInfo(CellValue);
                    if (ret>0)
                    {
                        MessageBox.Show(DELETESUCCESS, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        StudentDataBind();
                        //return;
                    }
                    else
                    {
                        MessageBox.Show(DELETEFAILED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILED, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //throw ex;
            }
        }

        private void TsmlInsert_Click(object sender, EventArgs e)
        {
            FrmAddGrade fag = new FrmAddGrade();
            fag.studentNo = this.DgvStuInfo.CurrentRow.Cells[0].Value.ToString();
            fag.Show();
            this.Hide();

        }
    }
}
