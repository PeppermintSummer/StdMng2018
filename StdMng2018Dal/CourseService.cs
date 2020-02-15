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
    public class CourseService
    {
        #region 常量、变量的定义
        private readonly string connString = ConfigurationManager.ConnectionStrings["StdMng2018"].ConnectionString;
        #endregion


        #region 获取所有的课程信息
        /// <summary>
        /// 获取所有的课程信息
        /// </summary>
        /// <returns>所有课程信息的集合</returns>
        public List<t_Course> GetT_CoursesData()
        {
            List<t_Course> courses = new List<t_Course>();
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from t_Course ");
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    t_Course course = new t_Course();
                    course.Cno = Convert.ToString(reader["Cno"]);
                    course.Cname = Convert.ToString(reader["Cname"]);
                    course.CPno = Convert.ToString(reader["CPno"]);
                    course.Ccredit = Convert.ToInt16(reader["Ccredit"]);
                    courses.Add(course);
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
            return courses;
        } 
        #endregion


        #region 新增课程信息
        /// <summary>
        /// 新增课程信息
        /// </summary>
        /// <param name="course">课程</param>
        /// <returns></returns>
        public int AddStudentCourse(t_Course course)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("insert into t_Course ");
            sb.AppendLine("values (@Cno,@Cname,@CPno,@Ccredit) ");

            SqlParameter[] paras = {
            new SqlParameter("@Cno",course.Cno),
            new SqlParameter("@Cname", course.Cname),
            new SqlParameter("@CPno", course.CPno),
            new SqlParameter("@Ccredit",course.Ccredit)
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


        #region 根据课程号查询所有的课程信息
        /// <summary>
        /// 根据课程号查询所有的课程信息
        /// </summary>
        /// <param name="cno">课程号</param>
        /// <returns>返回科目信息集合</returns>
        public List<t_Course> ReviewStuByCno(string cno)
        {
            List<t_Course> courses = new List<t_Course>();
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from t_Course ");
            sb.AppendLine("where Cno=@Cno ");
            //设置参数
            SqlParameter[] paras =
            {
                new SqlParameter("@Cno",cno)
            };
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                conn.Open();
                cmd.Parameters.AddRange(paras);
                
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    t_Course course = new t_Course();
                    course.Cno = Convert.ToString(reader["Cno"]);
                    course.Cname = Convert.ToString(reader["Cname"]);
                    course.CPno = Convert.ToString(reader["CPno"]);
                    course.Ccredit = Convert.ToInt16(reader["Ccredit"]);
                    courses.Add(course);
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
            return courses;
        }
        #endregion

        #region 根据课程号查询科目信息（对象）
        /// <summary>
        /// 根据课程号查询学分
        /// </summary>
        /// <param name="cno">课程号</param>
        /// <returns>返回科目信息集合</returns>
        public t_Course ReviewStuByCname(string cname)
        {
            t_Course course = null;
            //t_Course courses = new t_Course();
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from t_Course ");
            sb.AppendLine("where Cname=@Cname ");
            //设置参数
            SqlParameter[] paras =
            {
                new SqlParameter("@Cname",cname)
            };
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                cmd.Parameters.AddRange(paras);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    course = new t_Course();
                    course.Cno = Convert.ToString(reader["Cno"]);
                    course.Cname = Convert.ToString(reader["Cname"]);
                    course.CPno = Convert.ToString(reader["CPno"]);
                    course.Ccredit = Convert.ToInt16(reader["Ccredit"]);
                    
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
            return course;

        }
        #endregion
    }
}
