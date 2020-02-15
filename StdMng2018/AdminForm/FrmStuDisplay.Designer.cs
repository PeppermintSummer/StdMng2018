namespace StdMng2018.AdminForm
{
    partial class FrmStudentInfo
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.TxtName1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.TxtName2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtDept = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpBornDate = new System.Windows.Forms.DateTimePicker();
            this.rbGirl = new System.Windows.Forms.RadioButton();
            this.rbBoy = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtStuNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvStuInfo = new System.Windows.Forms.DataGridView();
            this.Sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sgender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmsDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmlInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStuInfo)).BeginInit();
            this.CmsDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.TxtName1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(59, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(543, 40);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(77, 31);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // TxtName1
            // 
            this.TxtName1.Location = new System.Drawing.Point(81, 46);
            this.TxtName1.Name = "TxtName1";
            this.TxtName1.Size = new System.Drawing.Size(126, 25);
            this.TxtName1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(29, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnUpdate);
            this.groupBox2.Controls.Add(this.TxtName2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtEmail);
            this.groupBox2.Controls.Add(this.TxtDept);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.DtpBornDate);
            this.groupBox2.Controls.Add(this.rbGirl);
            this.groupBox2.Controls.Add(this.rbBoy);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxtStuNo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(59, 410);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(668, 188);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "修改";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(535, 143);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(85, 36);
            this.BtnUpdate.TabIndex = 13;
            this.BtnUpdate.Text = "修改";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // TxtName2
            // 
            this.TxtName2.Location = new System.Drawing.Point(275, 35);
            this.TxtName2.Name = "TxtName2";
            this.TxtName2.Size = new System.Drawing.Size(129, 25);
            this.TxtName2.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 11F);
            this.label7.Location = new System.Drawing.Point(222, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "姓名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 11F);
            this.label6.Location = new System.Drawing.Point(33, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(107, 146);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(228, 25);
            this.TxtEmail.TabIndex = 9;
            // 
            // TxtDept
            // 
            this.TxtDept.Location = new System.Drawing.Point(483, 86);
            this.TxtDept.Name = "TxtDept";
            this.TxtDept.Size = new System.Drawing.Size(100, 25);
            this.TxtDept.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 11F);
            this.label5.Location = new System.Drawing.Point(420, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "系别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 11F);
            this.label4.Location = new System.Drawing.Point(29, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "出生年月";
            // 
            // DtpBornDate
            // 
            this.DtpBornDate.Location = new System.Drawing.Point(135, 92);
            this.DtpBornDate.Name = "DtpBornDate";
            this.DtpBornDate.Size = new System.Drawing.Size(200, 25);
            this.DtpBornDate.TabIndex = 5;
            // 
            // rbGirl
            // 
            this.rbGirl.AutoSize = true;
            this.rbGirl.Font = new System.Drawing.Font("宋体", 11F);
            this.rbGirl.Location = new System.Drawing.Point(543, 31);
            this.rbGirl.Name = "rbGirl";
            this.rbGirl.Size = new System.Drawing.Size(49, 23);
            this.rbGirl.TabIndex = 4;
            this.rbGirl.TabStop = true;
            this.rbGirl.Text = "女";
            this.rbGirl.UseVisualStyleBackColor = true;
            // 
            // rbBoy
            // 
            this.rbBoy.AutoSize = true;
            this.rbBoy.Font = new System.Drawing.Font("宋体", 11F);
            this.rbBoy.Location = new System.Drawing.Point(483, 33);
            this.rbBoy.Name = "rbBoy";
            this.rbBoy.Size = new System.Drawing.Size(49, 23);
            this.rbBoy.TabIndex = 3;
            this.rbBoy.TabStop = true;
            this.rbBoy.Text = "男";
            this.rbBoy.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 11F);
            this.label3.Location = new System.Drawing.Point(420, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "性别";
            // 
            // TxtStuNo
            // 
            this.TxtStuNo.Location = new System.Drawing.Point(83, 34);
            this.TxtStuNo.Name = "TxtStuNo";
            this.TxtStuNo.Size = new System.Drawing.Size(124, 25);
            this.TxtStuNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11F);
            this.label2.Location = new System.Drawing.Point(29, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "学号";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DgvStuInfo
            // 
            this.DgvStuInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStuInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sno,
            this.Sname,
            this.Sgender,
            this.Sbirth,
            this.Sdept,
            this.e_mail});
            this.DgvStuInfo.ContextMenuStrip = this.CmsDelete;
            this.DgvStuInfo.Location = new System.Drawing.Point(59, 147);
            this.DgvStuInfo.Name = "DgvStuInfo";
            this.DgvStuInfo.RowTemplate.Height = 27;
            this.DgvStuInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvStuInfo.Size = new System.Drawing.Size(668, 257);
            this.DgvStuInfo.TabIndex = 2;
            this.DgvStuInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStuInfo_CellContentClick);
            this.DgvStuInfo.Click += new System.EventHandler(this.DgvStuInfo_Click);
            // 
            // Sno
            // 
            this.Sno.DataPropertyName = "Sno";
            this.Sno.HeaderText = "学号";
            this.Sno.Name = "Sno";
            // 
            // Sname
            // 
            this.Sname.DataPropertyName = "Sname";
            this.Sname.HeaderText = "姓名";
            this.Sname.Name = "Sname";
            // 
            // Sgender
            // 
            this.Sgender.DataPropertyName = "Sgender";
            this.Sgender.HeaderText = "性别";
            this.Sgender.Name = "Sgender";
            // 
            // Sbirth
            // 
            this.Sbirth.DataPropertyName = "Sbirth";
            this.Sbirth.HeaderText = "出生年月";
            this.Sbirth.Name = "Sbirth";
            // 
            // Sdept
            // 
            this.Sdept.DataPropertyName = "Sdept";
            this.Sdept.HeaderText = "系别";
            this.Sdept.Name = "Sdept";
            // 
            // e_mail
            // 
            this.e_mail.DataPropertyName = "e_mail";
            this.e_mail.HeaderText = "Email";
            this.e_mail.Name = "e_mail";
            // 
            // CmsDelete
            // 
            this.CmsDelete.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CmsDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiDelete,
            this.TsmlInsert});
            this.CmsDelete.Name = "CmsDelete";
            this.CmsDelete.Size = new System.Drawing.Size(211, 80);
            // 
            // TsmiDelete
            // 
            this.TsmiDelete.Name = "TsmiDelete";
            this.TsmiDelete.Size = new System.Drawing.Size(210, 24);
            this.TsmiDelete.Text = "删除";
            this.TsmiDelete.Click += new System.EventHandler(this.TsmiDelete_Click);
            // 
            // TsmlInsert
            // 
            this.TsmlInsert.Name = "TsmlInsert";
            this.TsmlInsert.Size = new System.Drawing.Size(210, 24);
            this.TsmlInsert.Text = "新增成绩";
            this.TsmlInsert.Click += new System.EventHandler(this.TsmlInsert_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(641, 622);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(86, 38);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // FrmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 672);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.DgvStuInfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmStudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息管理";
            this.Load += new System.EventHandler(this.FrmStudentInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStuInfo)).EndInit();
            this.CmsDelete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox TxtName1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvStuInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpBornDate;
        private System.Windows.Forms.RadioButton rbGirl;
        private System.Windows.Forms.RadioButton rbBoy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtStuNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtDept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox TxtName2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip CmsDelete;
        private System.Windows.Forms.ToolStripMenuItem TsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem TsmlInsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sgender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sbirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdept;
        private System.Windows.Forms.DataGridViewTextBoxColumn e_mail;
        private System.Windows.Forms.Button BtnUpdate;
    }
}