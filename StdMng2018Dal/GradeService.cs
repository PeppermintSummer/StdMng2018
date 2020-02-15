using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using StdMng2018Models;

namespace StdMng2018Dal
{
    public class GradeService
    {
        #region 常量、变量的定义
        private readonly string connString = ConfigurationManager.ConnectionStrings["StdMng2018"].ConnectionString;
        #endregion

        #region 新增学员成绩
        /// <summary>
        /// 新增学员成绩
        /// </summary>
        /// <param name="grade">成绩</param>
        /// <returns>受影响的行数</returns>
        public int AddStudentGrade(t_SC grade)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("insert into t_SC ");
            sb.AppendLine("values( @Sno,@Cno,@Grade)  ");
            //参数
            SqlParameter[] paras =
            {
                new SqlParameter("@Sno",grade.Sno),
                new SqlParameter("@Cno",grade.Cno),
                new SqlParameter("@Grade",grade.Grade)
            };
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
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
        #endregion

        #region 获取所有的成绩
        /// <summary>
        /// 获取所有的成绩
        /// </summary>
        /// <returns>所有的成绩信息的集合</returns>
        public List<t_SC> GetT_SCData()
        {
            List<t_SC> grades = new List<t_SC>();
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from t_SC ");
            //创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                //打开连接
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    t_SC grade = new t_SC();
                    grade.Sno = Convert.ToString(reader["Sno"]);
                    grade.Cno = Convert.ToString(reader["Cno"]);
                    grade.Grade = Convert.ToInt16(reader["Grade"]);
                    grades.Add(grade);
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


            return grades;
        }
        #endregion

        #region 根据课程号查询学生的成绩
        /// <summary>
        /// 根据课程号查询学生的成绩
        /// </summary>
        /// <param name="cno">课程号</param>
        /// <returns>成绩的集合</returns>
        public List<t_SC> ReviewStuResultByCno(string cno)
        {
            List<t_SC> grades = new List<t_SC>();
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select Cno,Grade ");
            sb.AppendLine("from t_SC ");
            sb.AppendLine("where Cno = @Cno ");
            SqlParameter[] paras = {
                new SqlParameter("@Cno",cno)
            };
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                //打开连接
                cmd.Parameters.AddRange(paras);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    t_SC grade = new t_SC();
                    //grade.Sno = Convert.ToString(reader["Sno"]);
                    grade.Cno = Convert.ToString(reader["Cno"]);
                    grade.Grade = Convert.ToInt16(reader["Grade"]);
                    grades.Add(grade);
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
            return grades;
        }
        #endregion

        #region 根据姓名查询学生的成绩
        /// <summary>
        /// 根据姓名查询学生的成绩
        /// </summary>
        /// <param name="Sname">学员姓名</param>
        /// <returns></returns>
        public List<t_SC> ReviewStuResultBySname(string Sname)
        {
            List<t_SC> grades = new List<t_SC>();
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select b.Cno,b.Grade from t_Student a,t_sc b ");
            sb.AppendLine("where a.Sno=b.Sno and a.Sname like @Sname ");
            
            SqlParameter[] paras = {
                new SqlParameter("@Sname","%"+Sname+"%")
            };
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                cmd.Parameters.AddRange(paras);
                //打开连接
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    t_SC grade = new t_SC();
                    grade.Cno = Convert.ToString(reader["Cno"]);
                    grade.Grade = Convert.ToInt16(reader["Grade"]);
                    grades.Add(grade);
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
            return grades;
        } 
        #endregion

        #region 更新学生的成绩表
        /// <summary>
        /// 更新学生的成绩表
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public int UpdateStudentGrade(t_SC grade)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("update t_SC ");
            sb.AppendLine("set Sno=@Sno,Cno=@Cno,grade=@grade ");
            //参数
            SqlParameter[] paras =
            {
                new SqlParameter("@Sno",grade.Sno),
                new SqlParameter("@Cno",grade.Cno),
                new SqlParameter("@Grade",grade.Grade)
            };
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                cmd.Parameters.AddRange(paras);
                //设置执行类型
                //cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
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
        #endregion

        #region 删除学员信息
        /// <summary>
        /// 删除学员信息
        /// </summary>
        /// <param name="Sno">学号</param>
        /// <param name="Cno">课程号</param>
        /// <returns></returns>
        public int DeleteStudentGrade(int Sno, int Cno)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("delete from t_SC where Sno=@Sno and Cno=@Cno ");
            
            //参数
            SqlParameter[] paras =
            {
                new SqlParameter("@Sno",Sno),
                new SqlParameter("@Cno",Cno)
                
            };
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                cmd.Parameters.AddRange(paras);
                conn.Open();
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
        #endregion
    }
}
