using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StdMng2018Bll;
using StdMng2018Models;

namespace StdMng2018.AdminForm
{
    public partial class FrmCourseDisplay : Form
    {
        CourseManager courseManager = new CourseManager();
        List<t_Course> courselist = new List<t_Course>();
        GradeManager gradeManager = new GradeManager();


        public FrmCourseDisplay()
        {
            InitializeComponent();
        }

        public void CourseDataBind()
        {
            this.DgvCourse.DataSource = courseManager.GetT_CoursesData();
            
        }

        public void CourseDataBindByCno()
        {
            List<t_Course> courselist = courseManager.ReviewStuByCno(this.TxtCno.Text.Trim());
            this.DgvCourse.DataSource = courselist;
        }

        private void TxtCno_TextChanged(object sender, EventArgs e)
        {

        }

        //窗体加载事件
        private void FrmCourseDisplay_Load(object sender, EventArgs e)
        {
            CourseDataBind();
            
        }

        

        
        
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            CourseDataBind();
            CourseDataBindByCno();
            
        }
    }
}
