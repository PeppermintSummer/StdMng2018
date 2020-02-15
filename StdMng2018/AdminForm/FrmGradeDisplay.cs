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
    public partial class FrmGradeDisplay : Form
    {
        StudentManager studentManager = new StudentManager();
        GradeManager gradeManager = new GradeManager();
        CourseManager courseManager = new CourseManager();
        List<t_SC> gradelist = new List<t_SC>();

        public FrmGradeDisplay()
        {
            InitializeComponent();
            this.DgvGrade.AutoGenerateColumns = false;
        }

        public void GradeDataBind()
        {
            List<t_SC> gradelist = gradeManager.GetT_SCData();
            this.DgvGrade.DataSource = gradelist;
        }

        public void GradeDataBindByName()
        {
            List<t_SC> gradelist = gradeManager.ReviewStuResultBySname(this.TxtName.Text.Trim());
            this.DgvGrade.DataSource = gradelist;
        }

        public void GradeDataBindByCno()
        {
            List<t_SC> gradelist = gradeManager.ReviewStuResultByCno(this.textBox1.Text.Trim());
            this.DgvGrade.DataSource = gradelist;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void FrmGradeDisplay_Load(object sender, EventArgs e)
        {
            GradeDataBind();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                GradeDataBind();
                GradeDataBindByCno();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //throw ex;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GradeDataBindByName();
        }

        private void DgvGrade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
