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
    /// <summary>
    /// 提供管理员信息操作
    /// </summary>
    public class AdminService
    {

        #region 常量、变量的定义
        private readonly string connString = ConfigurationManager.ConnectionStrings["StdMng2018"].ConnectionString;
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

            bool flag = false;
            //创建sql语句
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from Admin ");//一定不要忘记隔行连接时要加入空格
            sb.Append("where loginId=@loginId and loginPWd=@loginPWd");
            //设置参数
            SqlParameter[] paras =
            {
                new SqlParameter("@LoginId",loginId),
                new SqlParameter("@LoginPwd",loginPwd)
            };
            //创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                //创建执行工具
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);//第一个参数生成sql语句，第二个参数生成连接对象
                //设置执行工具的参数
                cmd.Parameters.AddRange(paras);//增加一个数组
                //打开连接
                conn.Open();
                //执行
                SqlDataReader reader = cmd.ExecuteReader();
                //判断
                if (reader.Read())
                {
                    flag = true;

                }
                reader.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return flag;
        } 
        #endregion

        /// <summary>
        /// 更改用户密码
        /// </summary>
        /// <param name="admin"></param>
        /// <returns>返回受影响的行数</returns>
        public int UpdateAdminPwd(Admin admin)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("update Admin set LoginPwd=@LoginPwd where LoginID=@LoginID ");
            SqlParameter[] paras =
            {
                new SqlParameter("@LoginID",admin.LoginId),
                new SqlParameter("@LoginPwd",admin.LoginPwd)
                
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
