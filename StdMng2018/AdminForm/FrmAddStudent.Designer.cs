namespace StdMng2018.AdminForm
{
    partial class FrmAddStudent
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtStuNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbBoy = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbGirl = new System.Windows.Forms.RadioButton();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtDept = new System.Windows.Forms.TextBox();
            this.TxtBornDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnCel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(87, 71);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(163, 25);
            this.TxtName.TabIndex = 5;
            // 
            // TxtStuNo
            // 
            this.TxtStuNo.Location = new System.Drawing.Point(87, 25);
            this.TxtStuNo.Name = "TxtStuNo";
            this.TxtStuNo.Size = new System.Drawing.Size(163, 25);
            this.TxtStuNo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11F);
            this.label2.Location = new System.Drawing.Point(22, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号";
            // 
            // rbBoy
            // 
            this.rbBoy.AutoSize = true;
            this.rbBoy.Checked = true;
            this.rbBoy.Location = new System.Drawing.Point(22, 6);
            this.rbBoy.Name = "rbBoy";
            this.rbBoy.Size = new System.Drawing.Size(43, 19);
            this.rbBoy.TabIndex = 0;
            this.rbBoy.TabStop = true;
            this.rbBoy.Text = "男";
            this.rbBoy.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbGirl);
            this.panel1.Controls.Add(this.rbBoy);
            this.panel1.Location = new System.Drawing.Point(82, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 28);
            this.panel1.TabIndex = 3;
            // 
            // rbGirl
            // 
            this.rbGirl.AutoSize = true;
            this.rbGirl.Location = new System.Drawing.Point(125, 6);
            this.rbGirl.Name = "rbGirl";
            this.rbGirl.Size = new System.Drawing.Size(43, 19);
            this.rbGirl.TabIndex = 1;
            this.rbGirl.Text = "女";
            this.rbGirl.UseVisualStyleBackColor = true;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(104, 260);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(133, 25);
            this.TxtEmail.TabIndex = 11;
            // 
            // TxtDept
            // 
            this.TxtDept.Location = new System.Drawing.Point(104, 217);
            this.TxtDept.Name = "TxtDept";
            this.TxtDept.Size = new System.Drawing.Size(133, 25);
            this.TxtDept.TabIndex = 10;
            // 
            // TxtBornDate
            // 
            this.TxtBornDate.Location = new System.Drawing.Point(104, 178);
            this.TxtBornDate.Name = "TxtBornDate";
            this.TxtBornDate.Size = new System.Drawing.Size(133, 25);
            this.TxtBornDate.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 11F);
            this.label6.Location = new System.Drawing.Point(23, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "e-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 11F);
            this.label5.Location = new System.Drawing.Point(23, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "系别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 11F);
            this.label4.Location = new System.Drawing.Point(6, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "出生年月";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(22, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "性别";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.TxtDept);
            this.groupBox1.Controls.Add(this.TxtBornDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.TxtStuNo);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(74, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 309);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户基本信息";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(84, 385);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(93, 34);
            this.BtnInsert.TabIndex = 2;
            this.BtnInsert.Text = "添加";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // BtnCel
            // 
            this.BtnCel.Location = new System.Drawing.Point(281, 385);
            this.BtnCel.Name = "BtnCel";
            this.BtnCel.Size = new System.Drawing.Size(87, 34);
            this.BtnCel.TabIndex = 3;
            this.BtnCel.Text = "取消";
            this.BtnCel.UseVisualStyleBackColor = true;
            this.BtnCel.Click += new System.EventHandler(this.BtnCel_Click);
            // 
            // FrmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.BtnCel);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加用户";
            this.Load += new System.EventHandler(this.FrmAddStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtStuNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbBoy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbGirl;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtDept;
        private System.Windows.Forms.TextBox TxtBornDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnCel;
    }
}