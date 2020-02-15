namespace StdMng2018.AdminForm
{
    partial class FrmCourseDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvCourse = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtCno = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvCourse
            // 
            this.DgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DgvCourse.Location = new System.Drawing.Point(41, 99);
            this.DgvCourse.Name = "DgvCourse";
            this.DgvCourse.RowTemplate.Height = 27;
            this.DgvCourse.Size = new System.Drawing.Size(619, 221);
            this.DgvCourse.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Cno";
            this.Column1.HeaderText = "课程号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Cname";
            this.Column2.HeaderText = "课程名";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CPno";
            this.Column3.HeaderText = "先行课";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Ccredit";
            this.Column4.HeaderText = "学分";
            this.Column4.Name = "Column4";
            // 
            // TxtCno
            // 
            this.TxtCno.Location = new System.Drawing.Point(123, 34);
            this.TxtCno.Name = "TxtCno";
            this.TxtCno.Size = new System.Drawing.Size(144, 25);
            this.TxtCno.TabIndex = 1;
            this.TxtCno.TextChanged += new System.EventHandler(this.TxtCno_TextChanged);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("宋体", 11F);
            this.BtnSearch.Location = new System.Drawing.Point(413, 26);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(90, 37);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "查询";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "课程号";
            // 
            // FrmCourseDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtCno);
            this.Controls.Add(this.DgvCourse);
            this.Name = "FrmCourseDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程系统";
            this.Load += new System.EventHandler(this.FrmCourseDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCourse;
        private System.Windows.Forms.TextBox TxtCno;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}