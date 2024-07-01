namespace 通讯录
{
    partial class MdFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdFrm));
            this.lbMess = new System.Windows.Forms.Label();
            this.lbPhoneWaring = new System.Windows.Forms.Label();
            this.lbWarning = new System.Windows.Forms.Label();
            this.lbPhoneStar = new System.Windows.Forms.Label();
            this.lbNameStar = new System.Windows.Forms.Label();
            this.btnCanel = new System.Windows.Forms.Button();
            this.btnConfrim = new System.Windows.Forms.Button();
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
            this.lbSexStar = new System.Windows.Forms.Label();
            this.lbQQStar = new System.Windows.Forms.Label();
            this.lbWeChatStar = new System.Windows.Forms.Label();
            this.lbAddressStar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMess
            // 
            this.lbMess.AutoSize = true;
            this.lbMess.Location = new System.Drawing.Point(431, 600);
            this.lbMess.Name = "lbMess";
            this.lbMess.Size = new System.Drawing.Size(0, 24);
            this.lbMess.TabIndex = 29;
            // 
            // lbPhoneWaring
            // 
            this.lbPhoneWaring.AutoSize = true;
            this.lbPhoneWaring.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbPhoneWaring.Location = new System.Drawing.Point(669, 170);
            this.lbPhoneWaring.Name = "lbPhoneWaring";
            this.lbPhoneWaring.Size = new System.Drawing.Size(0, 24);
            this.lbPhoneWaring.TabIndex = 28;
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbWarning.Location = new System.Drawing.Point(669, 53);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(0, 24);
            this.lbWarning.TabIndex = 27;
            // 
            // lbPhoneStar
            // 
            this.lbPhoneStar.AutoSize = true;
            this.lbPhoneStar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(54)))), ((int)(((byte)(139)))));
            this.lbPhoneStar.Location = new System.Drawing.Point(288, 165);
            this.lbPhoneStar.Name = "lbPhoneStar";
            this.lbPhoneStar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbPhoneStar.Size = new System.Drawing.Size(22, 24);
            this.lbPhoneStar.TabIndex = 26;
            this.lbPhoneStar.Text = "*";
            this.lbPhoneStar.Visible = false;
            // 
            // lbNameStar
            // 
            this.lbNameStar.AutoSize = true;
            this.lbNameStar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(54)))), ((int)(((byte)(139)))));
            this.lbNameStar.Location = new System.Drawing.Point(336, 31);
            this.lbNameStar.Name = "lbNameStar";
            this.lbNameStar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbNameStar.Size = new System.Drawing.Size(22, 24);
            this.lbNameStar.TabIndex = 25;
            this.lbNameStar.Text = "*";
            this.lbNameStar.Visible = false;
            // 
            // btnCanel
            // 
            this.btnCanel.Location = new System.Drawing.Point(600, 651);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(153, 68);
            this.btnCanel.TabIndex = 9;
            this.btnCanel.Text = "取消";
            this.btnCanel.UseVisualStyleBackColor = true;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // btnConfrim
            // 
            this.btnConfrim.Location = new System.Drawing.Point(222, 651);
            this.btnConfrim.Name = "btnConfrim";
            this.btnConfrim.Size = new System.Drawing.Size(153, 68);
            this.btnConfrim.TabIndex = 8;
            this.btnConfrim.Text = "确认修改";
            this.btnConfrim.UseVisualStyleBackColor = true;
            this.btnConfrim.Click += new System.EventHandler(this.btnConfrim_Click);
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(431, 386);
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(231, 185);
            this.textAddress.TabIndex = 7;
            this.textAddress.Enter += new System.EventHandler(this.textAddress_TextChanged);
            // 
            // textWeChat
            // 
            this.textWeChat.Location = new System.Drawing.Point(431, 310);
            this.textWeChat.Name = "textWeChat";
            this.textWeChat.Size = new System.Drawing.Size(231, 35);
            this.textWeChat.TabIndex = 6;
            this.textWeChat.Enter += new System.EventHandler(this.textWeChat_TextChanged);
            this.textWeChat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textName_KeyDown);
            // 
            // textQQ
            // 
            this.textQQ.Location = new System.Drawing.Point(431, 256);
            this.textQQ.Name = "textQQ";
            this.textQQ.Size = new System.Drawing.Size(231, 35);
            this.textQQ.TabIndex = 5;
            this.textQQ.Enter += new System.EventHandler(this.textQQ_TextChanged);
            this.textQQ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textName_KeyDown);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(431, 43);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(231, 35);
            this.textName.TabIndex = 1;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged_1);
            this.textName.Enter += new System.EventHandler(this.textName_TextChanged);
            this.textName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textName_KeyDown);
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(431, 170);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(231, 35);
            this.textPhone.TabIndex = 4;
            this.textPhone.Enter += new System.EventHandler(this.textPhone_TextChanged);
            this.textPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textName_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rBtnM);
            this.panel1.Controls.Add(this.rBtnF);
            this.panel1.Location = new System.Drawing.Point(431, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 56);
            this.panel1.TabIndex = 2;
            // 
            // rBtnM
            // 
            this.rBtnM.AutoSize = true;
            this.rBtnM.Location = new System.Drawing.Point(19, 12);
            this.rBtnM.Name = "rBtnM";
            this.rBtnM.Size = new System.Drawing.Size(65, 28);
            this.rBtnM.TabIndex = 2;
            this.rBtnM.TabStop = true;
            this.rBtnM.Text = "男";
            this.rBtnM.UseVisualStyleBackColor = true;
            this.rBtnM.Click += new System.EventHandler(this.rBtnF_CheckedChanged);
            // 
            // rBtnF
            // 
            this.rBtnF.AutoSize = true;
            this.rBtnF.Location = new System.Drawing.Point(146, 12);
            this.rBtnF.Name = "rBtnF";
            this.rBtnF.Size = new System.Drawing.Size(65, 28);
            this.rBtnF.TabIndex = 2;
            this.rBtnF.TabStop = true;
            this.rBtnF.Text = "女";
            this.rBtnF.UseVisualStyleBackColor = true;
            this.rBtnF.Click += new System.EventHandler(this.rBtnF_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "联系地址";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "微信";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "QQ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "电话号码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "性别";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(358, 46);
            this.lbName.Name = "lbName";
            this.lbName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbName.Size = new System.Drawing.Size(58, 24);
            this.lbName.TabIndex = 11;
            this.lbName.Text = "姓名";
            // 
            // lbSexStar
            // 
            this.lbSexStar.AutoSize = true;
            this.lbSexStar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(54)))), ((int)(((byte)(139)))));
            this.lbSexStar.Location = new System.Drawing.Point(336, 101);
            this.lbSexStar.Name = "lbSexStar";
            this.lbSexStar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbSexStar.Size = new System.Drawing.Size(22, 24);
            this.lbSexStar.TabIndex = 25;
            this.lbSexStar.Text = "*";
            this.lbSexStar.Visible = false;
            // 
            // lbQQStar
            // 
            this.lbQQStar.AutoSize = true;
            this.lbQQStar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(54)))), ((int)(((byte)(139)))));
            this.lbQQStar.Location = new System.Drawing.Point(357, 249);
            this.lbQQStar.Name = "lbQQStar";
            this.lbQQStar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbQQStar.Size = new System.Drawing.Size(22, 24);
            this.lbQQStar.TabIndex = 26;
            this.lbQQStar.Text = "*";
            this.lbQQStar.Visible = false;
            // 
            // lbWeChatStar
            // 
            this.lbWeChatStar.AutoSize = true;
            this.lbWeChatStar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(54)))), ((int)(((byte)(139)))));
            this.lbWeChatStar.Location = new System.Drawing.Point(336, 304);
            this.lbWeChatStar.Name = "lbWeChatStar";
            this.lbWeChatStar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbWeChatStar.Size = new System.Drawing.Size(22, 24);
            this.lbWeChatStar.TabIndex = 26;
            this.lbWeChatStar.Text = "*";
            this.lbWeChatStar.Visible = false;
            // 
            // lbAddressStar
            // 
            this.lbAddressStar.AutoSize = true;
            this.lbAddressStar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(54)))), ((int)(((byte)(139)))));
            this.lbAddressStar.Location = new System.Drawing.Point(288, 378);
            this.lbAddressStar.Name = "lbAddressStar";
            this.lbAddressStar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbAddressStar.Size = new System.Drawing.Size(22, 24);
            this.lbAddressStar.TabIndex = 26;
            this.lbAddressStar.Text = "*";
            this.lbAddressStar.Visible = false;
            // 
            // MdFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 750);
            this.Controls.Add(this.lbMess);
            this.Controls.Add(this.lbPhoneWaring);
            this.Controls.Add(this.lbWarning);
            this.Controls.Add(this.lbAddressStar);
            this.Controls.Add(this.lbWeChatStar);
            this.Controls.Add(this.lbQQStar);
            this.Controls.Add(this.lbPhoneStar);
            this.Controls.Add(this.lbSexStar);
            this.Controls.Add(this.lbNameStar);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnConfrim);
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
            this.Name = "MdFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改联系人";
            this.Load += new System.EventHandler(this.MdFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMess;
        private System.Windows.Forms.Label lbPhoneWaring;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.Label lbPhoneStar;
        private System.Windows.Forms.Label lbNameStar;
        private System.Windows.Forms.Button btnCanel;
        private System.Windows.Forms.Button btnConfrim;
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
        private System.Windows.Forms.Label lbSexStar;
        private System.Windows.Forms.Label lbQQStar;
        private System.Windows.Forms.Label lbWeChatStar;
        private System.Windows.Forms.Label lbAddressStar;
    }
}