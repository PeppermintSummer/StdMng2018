using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StdMng2018Models;
using StdMng2018Dal;

namespace StdMng2018Bll
{
    public class StudentManager
    {
        #region 变量、常量的定义
        StudentService ss = new StudentService();
        #endregion

        #region 根据学号获取学生对象
        /// <summary>
        /// 根据学号获取学生对象
        /// </summary>
        /// <param name="Sno">学号</param>
        /// <returns>学生对象</returns>
        public t_Student GetStudentByNo(int Sno)
        {
            try
            {
                return ss.GetStudentByNo(Sno);
            }
            catch (Exception ex)
            {

                throw ex;
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
            try
            {
                return ss.GetT_StudentsData();
            }
            catch (Exception ex)
            {

                throw ex;
            }
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
            try
            {
                return  ss.GetT_StudentsDataByName(name);
            }
            catch (Exception ex)
            {

                throw ex;
            }
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
            try
            {
                return ss.AddStudent(student);
            }
            catch (Exception ex)
            {
                throw ex;
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
            try
            {
                return ss.UpdateStudent(student);
            }
            catch (Exception ex)
            {
                throw ex;

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
            try
            {
                return ss.DeleteStudentInfo(stuNo);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        #endregion
    }
}
