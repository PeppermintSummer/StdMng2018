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

namespace StdMng2018
{
    public partial class FrmRegister : Form
    {
        #region 常量、变量的定义
        public const string INPUTNAME = "请输入用户ID";
        public const string INPUTPWD = "请输入密码";
        public const string INPUTPWD2 = "请输入确认密码";
        public const string PWDNOTCONSISTANT = "两次输入密码不一致";
        public const string NAMEISEXIST = "用户ID已存在";
        public const string INPUTWARN = "输入提示";
        public const string OPERATIONFAILED = "操作错误";
        public const string REGSUCCESS = "注册成功";
        #endregion


        public FrmRegister()
        {
            InitializeComponent();
        }

        //验证非空
        public bool CheckInputNotEmpty()
        {
            if (this.TxtName.Text.Trim()=="")
            {
                MessageBox.Show(INPUTNAME,INPUTWARN,MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.TxtName.Focus();
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
                MessageBox.Show(INPUTPWD2, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TxtPwd2.Focus();
                return false;
            }
            if (this.TxtPwd1.Text.Trim()!=this.TxtPwd2.Text.Trim())
            {
                MessageBox.Show(PWDNOTCONSISTANT, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //单击添加事件
        private void BtnReg_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInputNotEmpty())
                {
                    return;
                }

                Admin admin = new Admin();
                admin.LoginId = this.TxtName.Text.Trim();
                admin.LoginPwd = this.TxtPwd1.Text.Trim();

                int ret = new RegManager().AddAdmin(admin);

                if (ret>0)
                {
                    MessageBox.Show(REGSUCCESS, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILED, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
    }
}
