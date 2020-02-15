using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StdMng2018Models;
using StdMng2018Dal;

namespace StdMng2018Bll
{
    public class CourseManager
    {
        CourseService cs = new CourseService();

        #region 获取所有的课程信息
        /// <summary>
        /// 获取所有的课程信息
        /// </summary>
        /// <returns>所有课程信息的集合</returns>
        public List<t_Course> GetT_CoursesData()
        {
            try
            {
                return cs.GetT_CoursesData();
            }
            catch (Exception ex)
            {

                throw ex;
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
            try
            {
                return cs.ReviewStuByCno(cno);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion


        #region 根据课程号查询科目信息（对象）(课程名)
        /// <summary>
        /// 根据课程号查询学分
        /// </summary>
        /// <param name="cno">课程号</param>
        /// <returns>返回科目信息集合</returns>
        public t_Course ReviewStuByCname(string cname)
        {
            try
            {
                return ReviewStuByCname(cname);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
    }
}
