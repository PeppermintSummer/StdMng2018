using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StdMng2018Models;
using StdMng2018Dal;

namespace StdMng2018Bll
{
    public class AdminManager
    {
        #region 常量、变量的定义
        AdminService ads = new AdminService();
        #endregion

        #region 执行管理员登录检查
        /// <summary>
        /// 执行管理员登录检查
        /// </summary>
        /// <param name="logId">用户名</param>
        /// <param name="loginPwd">密码</param>
        /// <returns>true:登录成功 flase:登录失败</returns>
        public bool CheckAdminLogin(string loginId, string loginPwd)
        {
            try
            {
                return ads.CheckAdminLogin(loginId, loginPwd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        /// <summary>
        /// 更改用户密码
        /// </summary>
        /// <param name="admin"></param>
        /// <returns>返回受影响的行数</returns>
        public int UpdateAdminPwd(Admin admin)
        {
            try
            {
                return ads.UpdateAdminPwd(admin);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
