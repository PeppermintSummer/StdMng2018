namespace StdMng2018.AdminForm
{
    partial class FrmAddGrade
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAddGrade = new System.Windows.Forms.Button();
            this.TxtCno = new System.Windows.Forms.TextBox();
            this.TxtGrade = new System.Windows.Forms.TextBox();
            this.Cnacel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(62, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 11F);
            this.label2.Location = new System.Drawing.Point(65, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "成绩";
            // 
            // BtnAddGrade
            // 
            this.BtnAddGrade.BackColor = System.Drawing.SystemColors.Info;
            this.BtnAddGrade.Font = new System.Drawing.Font("宋体", 11F);
            this.BtnAddGrade.Location = new System.Drawing.Point(419, 127);
            this.BtnAddGrade.Name = "BtnAddGrade";
            this.BtnAddGrade.Size = new System.Drawing.Size(82, 35);
            this.BtnAddGrade.TabIndex = 2;
            this.BtnAddGrade.Text = "添加";
            this.BtnAddGrade.UseVisualStyleBackColor = false;
            this.BtnAddGrade.Click += new System.EventHandler(this.BtnAddGrade_Click);
            // 
            // TxtCno
            // 
            this.TxtCno.Location = new System.Drawing.Point(163, 29);
            this.TxtCno.Name = "TxtCno";
            this.TxtCno.Size = new System.Drawing.Size(123, 25);
            this.TxtCno.TabIndex = 3;
            // 
            // TxtGrade
            // 
            this.TxtGrade.Location = new System.Drawing.Point(163, 73);
            this.TxtGrade.Name = "TxtGrade";
            this.TxtGrade.Size = new System.Drawing.Size(123, 25);
            this.TxtGrade.TabIndex = 4;
            // 
            // Cnacel
            // 
            this.Cnacel.BackColor = System.Drawing.Color.Red;
            this.Cnacel.Font = new System.Drawing.Font("宋体", 11F);
            this.Cnacel.Location = new System.Drawing.Point(517, 127);
            this.Cnacel.Name = "Cnacel";
            this.Cnacel.Size = new System.Drawing.Size(78, 35);
            this.Cnacel.TabIndex = 5;
            this.Cnacel.Text = "取消";
            this.Cnacel.UseVisualStyleBackColor = false;
            this.Cnacel.Click += new System.EventHandler(this.Cnacel_Click);
            // 
            // FrmAddGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StdMng2018.Properties.Resources.Reg;
            this.ClientSize = new System.Drawing.Size(607, 174);
            this.Controls.Add(this.Cnacel);
            this.Controls.Add(this.TxtGrade);
            this.Controls.Add(this.TxtCno);
            this.Controls.Add(this.BtnAddGrade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加成绩";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAddGrade;
        private System.Windows.Forms.TextBox TxtCno;
        private System.Windows.Forms.TextBox TxtGrade;
        private System.Windows.Forms.Button Cnacel;
    }
}