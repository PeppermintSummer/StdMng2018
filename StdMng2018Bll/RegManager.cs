using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StdMng2018Models;
using StdMng2018Dal;

namespace StdMng2018Bll
{
    public class RegManager
    {

        RegService rg = new RegService();

        #region 新增管理员
        /// <summary>
        /// 新增管理员
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public int AddAdmin(Admin admin)
        {
            try
            {
                return rg.AddAdmin(admin);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region 注销管理员
        /// <summary>
        /// 注销用户
        /// </summary>
        /// <param name="LonginId"></param>
        /// <returns></returns>
        public int DeleteAdminInfo(string LoginId)
        {
            try
            {
                return rg.DeleteAdminInfo(LoginId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        } 
        #endregion

    }
}
