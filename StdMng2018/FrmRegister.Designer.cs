namespace StdMng2018
{
    partial class FrmRegister
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPwd1 = new System.Windows.Forms.TextBox();
            this.TxtPwd2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnReg = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(61, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 11F);
            this.label2.Location = new System.Drawing.Point(61, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(160, 49);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(185, 25);
            this.TxtName.TabIndex = 2;
            // 
            // TxtPwd1
            // 
            this.TxtPwd1.Location = new System.Drawing.Point(160, 104);
            this.TxtPwd1.Name = "TxtPwd1";
            this.TxtPwd1.PasswordChar = '*';
            this.TxtPwd1.Size = new System.Drawing.Size(185, 25);
            this.TxtPwd1.TabIndex = 3;
            // 
            // TxtPwd2
            // 
            this.TxtPwd2.Location = new System.Drawing.Point(160, 161);
            this.TxtPwd2.Name = "TxtPwd2";
            this.TxtPwd2.PasswordChar = '*';
            this.TxtPwd2.Size = new System.Drawing.Size(185, 25);
            this.TxtPwd2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 11F);
            this.label3.Location = new System.Drawing.Point(61, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "确认密码";
            // 
            // BtnReg
            // 
            this.BtnReg.Font = new System.Drawing.Font("宋体", 11F);
            this.BtnReg.Location = new System.Drawing.Point(90, 270);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(73, 34);
            this.BtnReg.TabIndex = 6;
            this.BtnReg.Text = "注册";
            this.BtnReg.UseVisualStyleBackColor = true;
            this.BtnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("宋体", 11F);
            this.Cancel.Location = new System.Drawing.Point(302, 270);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(80, 34);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StdMng2018.Properties.Resources.Reg;
            this.ClientSize = new System.Drawing.Size(473, 330);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.BtnReg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPwd2);
            this.Controls.Add(this.TxtPwd1);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册界面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtPwd1;
        private System.Windows.Forms.TextBox TxtPwd2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnReg;
        private System.Windows.Forms.Button Cancel;
    }
}