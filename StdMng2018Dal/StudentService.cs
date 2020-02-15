using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StdMng2018Models;
using System.Data;
using System.Data.SqlClient;

namespace StdMng2018Dal
{
    public class StudentService
    {
        #region 常量、变量的定义
        private readonly string connString = ConfigurationManager.ConnectionStrings["StdMng2018"].ConnectionString;
        #endregion

        #region 检查学号是否存在
        /// <summary>
        /// 检查学号是否存在
        /// </summary>
        /// <param name="Sno">学号</param>
        /// <returns>true:存在  false：不存在</returns>
        public bool CheckStudentIsExists(int Sno)
        {
            bool flag=false;
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select count(*) from t_Student where sno=@sno ");
            //参数
            SqlParameter[] paras =
            {
                new SqlParameter("@Sno",Sno)
            };
            //连接对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                //执行工具
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                conn.Open();
                //设置参数
                cmd.Parameters.AddRange(paras);
                //执行
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                //判断
                if (result>0)
                {
                    flag = true;
                }
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

        #region 根据学号获取学生对象
        /// <summary>
        /// 根据学号获取学生对象
        /// </summary>
        /// <param name="Sno">学号</param>
        /// <returns>学生对象</returns>
        public t_Student GetStudentByNo(int Sno)
        {
            
            t_Student stu = null;
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from t_Student where Sno=@Sno");
            //参数
            SqlParameter[] paras =
            {
                new SqlParameter("@Sno",Sno)
            };
            //连接对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                //执行工具
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                conn.Open();
                //添加参数
                cmd.Parameters.AddRange(paras);
                //执行
                SqlDataReader reader = cmd.ExecuteReader();
                //判断
                if (reader.Read()) {
                    stu = new t_Student();
                    stu.Sno = Convert.ToString(reader["Sno"]);
                    stu.Sname = Convert.ToString(reader["Sname"]);
                    stu.Sgender = Convert.ToString(reader["Sgender"]);
                    stu.Sbirth = Convert.ToDateTime(reader["Sbirth"]);
                    stu.Sdept = Convert.ToString(reader["Sdept"]);
                    stu.E_mail = Convert.ToString(reader["e_mail"]);

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
            

            return stu;
            
        }
        #endregion

        #region 新增学员
        /// <summary>
        /// 新增学员
        /// </summary>
        /// <param name="student">学员</param>
        /// <returns>受影响的行数</returns>
        public int AddStudent(t_Student student)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("insert into t_Student ");
            sb.AppendLine("values(@Sno,@Sname,@Sgender,@Sbirth,@Sdept,@e_mail)");
            //参数
            SqlParameter[] paras =
            {
                new SqlParameter("@Sno",student.Sno),
                new SqlParameter("@Sname",student.Sname),
                new SqlParameter("@Sgender",student.Sgender),
                new SqlParameter("@Sbirth",student.Sbirth),
                new SqlParameter("@Sdept",student.Sdept),
                new SqlParameter("@e_mail",student.E_mail)
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
        #endregion

        #region 更改学生的信息
        /// <summary>
        /// 更改学生的信息
        /// </summary>
        /// <param name="student">学生对象</param>
        /// <returns>受影响的行数</returns>
        public int UpdateStudent(t_Student student)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("update t_Student ");
            sb.AppendLine("set Sno=@Sno,Sname=@Sname,Sgender=@Sgender,Sbirth=@Sbirth,Sdept=@Sdept,E_mail=@e_mail ");
            sb.AppendLine("where Sno=@Sno");
            //参数
            SqlParameter[] paras =
            {
                new SqlParameter("@Sno",student.Sno),
                new SqlParameter("@Sname",student.Sname),
                new SqlParameter("@Sgender",student.Sgender),
                new SqlParameter("@Sbirth",student.Sbirth),
                new SqlParameter("@Sdept",student.Sdept),
                new SqlParameter("@e_mail",student.E_mail)
            };
            //连接对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                conn.Open();
                cmd.Parameters.AddRange(paras);
                //设置为执行存储过程
                //cmd.CommandType = CommandType.StoredProcedure;
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
        #endregion

        #region 根据学号删除学员信息
        /// <summary>
        /// 删除学员信息
        /// </summary>
        /// <param name="stuNo">学号</param>
        /// <returns>受影响的行数</returns>
        public int DeleteStudentInfo(string stuNo)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("delete t_SC where sno=@Sno;delete t_Student where sno=@Sno");
            
            //参数
            SqlParameter[] paras =
            {
                new SqlParameter("@Sno",stuNo),
                
            };
            //连接对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                conn.Open();
                cmd.Parameters.AddRange(paras);
                //设置为执行存储过程
                //cmd.CommandType = CommandType.StoredProcedure;
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
        #endregion

        #region 获取学员所有信息
        /// <summary>
        /// 获取学员所有信息
        /// </summary>
        /// <returns>学员集合</returns>
        public List<t_Student> GetT_StudentsData()
        {
            List<t_Student> students = new List<t_Student>();
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from t_Student ");
            //连接对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                //创建工具
                SqlCommand cmd = new SqlCommand(sb.ToString(),conn);
                //打开数据库
                conn.Open();
                SqlDataReader reader= cmd.ExecuteReader();
                //判断
                while (reader.Read())
                {
                    t_Student stu = new t_Student();
                    stu.Sno = Convert.ToString(reader["Sno"]);
                    stu.Sname = Convert.ToString(reader["Sname"]);
                    stu.Sgender = Convert.ToString(reader["Sgender"]);
                    stu.Sbirth = Convert.ToDateTime(reader["Sbirth"]);
                    stu.Sdept = Convert.ToString(reader["Sdept"]);
                    stu.E_mail = Convert.ToString(reader["e_mail"]);
                    students.Add(stu);//加入对象集合
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return students;
        }
        #endregion

        #region 根据姓名查询学生信息
        /// <summary>
        /// 根据姓名查询学生信息
        /// </summary>
        /// <param name="name">姓名</param>
        /// <returns>学生集合</returns>
        public List<t_Student> GetT_StudentsDataByName(string name)
        {
            List<t_Student> students = new List<t_Student>();
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from t_Student where Sname like @Sname ");
            SqlParameter[] paras =
            {
                new SqlParameter("@Sname","%"+name+"%"),
            };
            //连接对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                //创建工具
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                //添加参数
                cmd.Parameters.AddRange(paras);
                //打开数据库
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                //判断
                while (reader.Read())
                {
                    t_Student stu = new t_Student();
                    stu.Sno = Convert.ToString(reader["Sno"]);
                    stu.Sname = Convert.ToString(reader["Sname"]);
                    stu.Sgender = Convert.ToString(reader["Sgender"]);
                    stu.Sbirth = Convert.ToDateTime(reader["Sbirth"]);
                    stu.Sdept = Convert.ToString(reader["Sdept"]);
                    stu.E_mail = Convert.ToString(reader["e_mail"]);
                    students.Add(stu);//加入对象集合
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return students;
        } 
        #endregion

        
    }
}
