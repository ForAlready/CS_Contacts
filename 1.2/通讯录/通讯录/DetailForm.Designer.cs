namespace 通讯录
{
    partial class DetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailForm));
            this.lbMess = new System.Windows.Forms.Label();
            this.lbPhoneWaring = new System.Windows.Forms.Label();
            this.lbWarning = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textWeChat = new System.Windows.Forms.TextBox();
            this.textQQ = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rBtnM = new System.Windows.Forms.RadioButton();
            this.rBtnF = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMess
            // 
            this.lbMess.AutoSize = true;
            this.lbMess.Location = new System.Drawing.Point(363, 598);
            this.lbMess.Name = "lbMess";
            this.lbMess.Size = new System.Drawing.Size(0, 24);
            this.lbMess.TabIndex = 27;
            // 
            // lbPhoneWaring
            // 
            this.lbPhoneWaring.AutoSize = true;
            this.lbPhoneWaring.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbPhoneWaring.Location = new System.Drawing.Point(601, 172);
            this.lbPhoneWaring.Name = "lbPhoneWaring";
            this.lbPhoneWaring.Size = new System.Drawing.Size(0, 24);
            this.lbPhoneWaring.TabIndex = 25;
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbWarning.Location = new System.Drawing.Point(601, 51);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(0, 24);
            this.lbWarning.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(220, 163);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(22, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(268, 29);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(22, 24);
            this.label7.TabIndex = 24;
            this.label7.Text = "*";
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(363, 388);
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.ReadOnly = true;
            this.textAddress.Size = new System.Drawing.Size(231, 185);
            this.textAddress.TabIndex = 22;
            // 
            // textWeChat
            // 
            this.textWeChat.Location = new System.Drawing.Point(363, 312);
            this.textWeChat.Name = "textWeChat";
            this.textWeChat.ReadOnly = true;
            this.textWeChat.Size = new System.Drawing.Size(231, 35);
            this.textWeChat.TabIndex = 21;
            // 
            // textQQ
            // 
            this.textQQ.Location = new System.Drawing.Point(363, 258);
            this.textQQ.Name = "textQQ";
            this.textQQ.ReadOnly = true;
            this.textQQ.Size = new System.Drawing.Size(231, 35);
            this.textQQ.TabIndex = 20;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(363, 41);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(231, 35);
            this.textName.TabIndex = 13;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(363, 172);
            this.textPhone.Name = "textPhone";
            this.textPhone.ReadOnly = true;
            this.textPhone.Size = new System.Drawing.Size(231, 35);
            this.textPhone.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rBtnM);
            this.panel1.Controls.Add(this.rBtnF);
            this.panel1.Location = new System.Drawing.Point(363, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 56);
            this.panel1.TabIndex = 14;
            // 
            // rBtnM
            // 
            this.rBtnM.AutoCheck = false;
            this.rBtnM.AutoSize = true;
            this.rBtnM.Checked = true;
            this.rBtnM.Location = new System.Drawing.Point(19, 12);
            this.rBtnM.Name = "rBtnM";
            this.rBtnM.Size = new System.Drawing.Size(65, 28);
            this.rBtnM.TabIndex = 2;
            this.rBtnM.TabStop = true;
            this.rBtnM.Text = "男";
            this.rBtnM.UseVisualStyleBackColor = true;
            // 
            // rBtnF
            // 
            this.rBtnF.AutoCheck = false;
            this.rBtnF.AutoSize = true;
            this.rBtnF.Location = new System.Drawing.Point(146, 12);
            this.rBtnF.Name = "rBtnF";
            this.rBtnF.Size = new System.Drawing.Size(65, 28);
            this.rBtnF.TabIndex = 2;
            this.rBtnF.TabStop = true;
            this.rBtnF.Text = "女";
            this.rBtnF.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "联系地址";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "微信";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "QQ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "电话号码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "性别";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(290, 44);
            this.lbName.Name = "lbName";
            this.lbName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbName.Size = new System.Drawing.Size(58, 24);
            this.lbName.TabIndex = 11;
            this.lbName.Text = "姓名";
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 651);
            this.Controls.Add(this.lbMess);
            this.Controls.Add(this.lbPhoneWaring);
            this.Controls.Add(this.lbWarning);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textWeChat);
            this.Controls.Add(this.textQQ);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "联系人详情：";
            this.Load += new System.EventHandler(this.DetailForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMess;
        private System.Windows.Forms.Label lbPhoneWaring;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textWeChat;
        private System.Windows.Forms.TextBox textQQ;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rBtnM;
        private System.Windows.Forms.RadioButton rBtnF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbName;
    }
}