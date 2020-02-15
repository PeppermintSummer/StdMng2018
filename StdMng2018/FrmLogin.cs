using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StdMng2018Models;
using StdMng2018Bll;
using StdMng2018.AdminForm;

namespace StdMng2018
{
    public partial class FrmLogin : Form
    {
        
        #region 常量、变量的定义
        public const string INPUTUSERNAME = "请输入用户名：";
        public const string INPUTWARN = "输入提示";
        public const string INPUTPWD = "请输入密码";
        public const string LOGINFAILED = "登录失败";
        public const string INPUTNOEXIST = "用户名密码不存在";

        AdminManager am = new AdminManager();

        #endregion

        //构造函数
        public FrmLogin()
        {
            InitializeComponent();
        }
        //窗体加载事件
        private void FrmLogin_Load(object sender,EventArgs e)
        {
            //this.cboType.SelectedIndex = 0;
           
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.cboType.SelectedIndex = 0;
        }

        
        #region 输入验证
        /// <summary>
        /// 输入验证
        /// </summary>
        /// <returns>true:通过  false：拒绝通过</returns>
        public bool CheckInput()
        {
            //bool flag = false;
            if(this.txtName.Text=="")
            {
                MessageBox.Show(INPUTUSERNAME, INPUTWARN, MessageBoxButtons.OK , MessageBoxIcon.Information);
                this.txtName.Focus();//获取光标
                return false;
            }
            if (this.txtPwd.Text == "")
            {
                MessageBox.Show(INPUTPWD, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPwd.Focus();//获取光标
                return false;
            }
            return true;
        }
        #endregion

        //单击登录事件
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInput())
                {
                    return;
                }
                //if (this.cboType.SelectedIndex == 0)//管理员
                
                    if (am.CheckAdminLogin(txtName.Text.Trim(), txtPwd.Text.Trim()))
                    {
                        //MessageBox.Show("管理员登录成功！");
                        UserInfo.loginId = this.txtName.Text.Trim();//进行记录,静态不需要实例化
                        UserInfo.loginPwd = this.txtPwd.Text.Trim();
                        //UserInfo.loginType = this.cboType.Text;

                        //this.Visible = false;
                        this.DialogResult = DialogResult.OK;
                        //FrmAdminMain frm = new FrmAdminMain();
                        //frm.Show();
                        

                    }
                    else
                    {
                        MessageBox.Show(INPUTNOEXIST, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, LOGINFAILED, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //throw ex;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        //单击取消事件
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegLb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.Show();
        }
    }
}
