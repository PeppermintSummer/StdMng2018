namespace StdMng2018.AdminForm
{
    partial class FrmGradeDisplay
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
            this.TxtCno = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.DgvGrade = new System.Windows.Forms.DataGridView();
            this.Cancel = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCno
            // 
            this.TxtCno.AutoSize = true;
            this.TxtCno.Font = new System.Drawing.Font("宋体", 11F);
            this.TxtCno.Location = new System.Drawing.Point(47, 103);
            this.TxtCno.Name = "TxtCno";
            this.TxtCno.Size = new System.Drawing.Size(66, 19);
            this.TxtCno.TabIndex = 0;
            this.TxtCno.Text = "课程号";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("宋体", 11F);
            this.BtnSearch.Location = new System.Drawing.Point(375, 89);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(77, 37);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "查询";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // DgvGrade
            // 
            this.DgvGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGrade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3});
            this.DgvGrade.Location = new System.Drawing.Point(51, 150);
            this.DgvGrade.Name = "DgvGrade";
            this.DgvGrade.RowTemplate.Height = 27;
            this.DgvGrade.Size = new System.Drawing.Size(401, 266);
            this.DgvGrade.TabIndex = 3;
            this.DgvGrade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGrade_CellContentClick);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("宋体", 11F);
            this.Cancel.Location = new System.Drawing.Point(375, 446);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(77, 37);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(119, 35);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(150, 25);
            this.TxtName.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 11F);
            this.button1.Location = new System.Drawing.Point(375, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(56, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "姓名";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Cno";
            this.Column2.HeaderText = "课程号";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Grade";
            this.Column3.HeaderText = "成绩";
            this.Column3.Name = "Column3";
            // 
            // FrmGradeDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.DgvGrade);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TxtCno);
            this.Name = "FrmGradeDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成绩系统";
            this.Load += new System.EventHandler(this.FrmGradeDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxtCno;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridView DgvGrade;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}