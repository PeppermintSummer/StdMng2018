using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StdMng2018Models;
using StdMng2018Dal;


namespace StdMng2018Bll
{
    public class GradeManager
    {
        private GradeService gs = new GradeService();//对象实例化
        #region 获取所有的成绩
        /// <summary>
        /// 获取所有的成绩
        /// </summary>
        /// <returns>所有的成绩信息的集合</returns>
        public List<t_SC> GetT_SCData()
        {
            try
            {
                return gs.GetT_SCData();
            }
            catch (Exception ex)
            {

                throw ex;
            }
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
            try
            {
                return gs.ReviewStuResultBySname(Sname);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        public int AddStudentGrade(t_SC grade)
        {
            try
            {
                return gs.AddStudentGrade(grade);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #region 根据课程号查询学生的成绩
        /// <summary>
        /// 根据课程号查询学生的成绩
        /// </summary>
        /// <param name="cno">课程号</param>
        /// <returns>成绩的集合</returns>
        public List<t_SC> ReviewStuResultByCno(string cno)
        {
            try
            {
                return gs.ReviewStuResultByCno(cno);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
    }
}
