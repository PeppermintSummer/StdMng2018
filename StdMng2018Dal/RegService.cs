using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using StdMng2018Models;
using System.Data;
using System.Data.SqlClient;

namespace StdMng2018Dal
{
    public class RegService
    {

        #region 常量、变量的定义
        private readonly string connString = ConfigurationManager.ConnectionStrings["StdMng2018"].ConnectionString;
        #endregion


        /// <summary>
        /// 新增管理员
        /// </summary>
        /// <param name="admin"></param>
        /// <returns>返回受影响的行数</returns>
        public int AddAdmin(Admin admin)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("insert into Admin ");
            sb.AppendLine("values(@LoginId,@LoginPwd)");
            //参数
            SqlParameter[] paras =
            {
                new SqlParameter("@LoginId",admin.LoginId),
                new SqlParameter("@LoginPwd",admin.LoginPwd),
                
            };
            //连接对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                conn.Open();
                cmd.Parameters.AddRange(paras);
                int result = cmd.ExecuteNonQuery();//返回受影响的行数，适用于增删改
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }


        /// <summary>
        /// 注销用户
        /// </summary>
        /// <param name="LonginId"></param>
        /// <returns></returns>
        public int DeleteAdminInfo(string LonginId)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("delete Admin where LoginId=@LoginId ");

            //参数
            SqlParameter[] paras =
            {
                new SqlParameter("@LoginId",LonginId)

            };
            //连接对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                conn.Open();
                cmd.Parameters.AddRange(paras);
                
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
