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
    public partial class FrmModifyPwd : Form
    {

        #region 常量、变量的定义
        public const string INPUTID= "请输入用户ID";
        public const string INPUTPWD= "请输入密码";
        public const string INPUTPWDAGAIN= "请再次输入密码";
        public const string INPUTWARN= "输入提示";
        public const string UPDATESUCCESS= "修改成功";
        public const string UPDATEFAILED= "修改失败";
        public const string OPERATIONWRONG= "操作错误";

        AdminManager adminManager = new AdminManager();
        #endregion
        public FrmModifyPwd()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckNotEmpty())
                {
                    return;
                }

                Admin ad = new Admin();
                ad.LoginId = this.TxtId.Text.Trim();
                ad.LoginPwd = this.TxtPwd1.Text.Trim();

                int ret = adminManager.UpdateAdminPwd(ad);
                if (ret > 0)
                {
                    MessageBox.Show(UPDATESUCCESS, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(UPDATEFAILED, OPERATIONWRONG, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //非空验证
        public bool CheckNotEmpty()
        {
            if(this.TxtId.Text.Trim()=="")
            {
                MessageBox.Show(INPUTID, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TxtId.Focus();
                return false;
            }
            if (this.TxtPwd1.Text.Trim() == "")
            {
                MessageBox.Show(INPUTPWD, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TxtPwd1.Focus();
                return false;
            }
            if (this.TxtPwd2.Text.Trim() == "")
            {
                MessageBox.Show(INPUTPWDAGAIN, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TxtPwd2.Focus();
                return false;
            }
            if (this.TxtPwd1.Text.Trim()!=this.TxtPwd2.Text.Trim())
            {
                MessageBox.Show("两次输入密码不一致，请重新输入！",INPUTWARN,MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
