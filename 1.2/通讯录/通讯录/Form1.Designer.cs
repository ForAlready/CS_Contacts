namespace 通讯录
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MBtnShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MBtnSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.MBtnAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MBtnModify = new System.Windows.Forms.ToolStripMenuItem();
            this.MBtnDel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MBtnExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.MBtnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeChat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMSFrm1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textFind = new System.Windows.Forms.TextBox();
            this.BtnFind = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TBtnShow = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.TBtnModify = new System.Windows.Forms.ToolStripButton();
            this.TBtnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TBtnExport = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.CMSFrm1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 820);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 80);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作ToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1600, 96);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 操作ToolStripMenuItem
            // 
            this.操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MBtnShow,
            this.toolStripMenuItem1,
            this.MBtnSearch,
            this.MBtnAdd,
            this.MBtnModify,
            this.MBtnDel,
            this.toolStripMenuItem2,
            this.MBtnExport,
            this.toolStripMenuItem3,
            this.MBtnExit});
            this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
            this.操作ToolStripMenuItem.Size = new System.Drawing.Size(111, 92);
            this.操作ToolStripMenuItem.Text = "操作(&F)";
            // 
            // MBtnShow
            // 
            this.MBtnShow.Image = global::通讯录.Properties.Resources.activeemergency;
            this.MBtnShow.Name = "MBtnShow";
            this.MBtnShow.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
            this.MBtnShow.Size = new System.Drawing.Size(433, 44);
            this.MBtnShow.Text = "全部显示(&V)";
            this.MBtnShow.Click += new System.EventHandler(this.MBtnShow_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(430, 6);
            // 
            // MBtnSearch
            // 
            this.MBtnSearch.Image = global::通讯录.Properties.Resources.搜索联系人;
            this.MBtnSearch.Name = "MBtnSearch";
            this.MBtnSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.MBtnSearch.Size = new System.Drawing.Size(433, 44);
            this.MBtnSearch.Text = "搜索联系人(&F)";
            this.MBtnSearch.Click += new System.EventHandler(this.MBtnSearch_Click);
            // 
            // MBtnAdd
            // 
            this.MBtnAdd.Image = global::通讯录.Properties.Resources.添加联系人;
            this.MBtnAdd.Name = "MBtnAdd";
            this.MBtnAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MBtnAdd.Size = new System.Drawing.Size(433, 44);
            this.MBtnAdd.Text = "添加联系人(&N)";
            this.MBtnAdd.Click += new System.EventHandler(this.MBtnAdd_Click);
            // 
            // MBtnModify
            // 
            this.MBtnModify.Image = global::通讯录.Properties.Resources.修改联系人;
            this.MBtnModify.Name = "MBtnModify";
            this.MBtnModify.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.MBtnModify.Size = new System.Drawing.Size(433, 44);
            this.MBtnModify.Text = "修改联系人(&M)";
            this.MBtnModify.Click += new System.EventHandler(this.MBtnModify_Click);
            // 
            // MBtnDel
            // 
            this.MBtnDel.Image = global::通讯录.Properties.Resources.删除人员2;
            this.MBtnDel.Name = "MBtnDel";
            this.MBtnDel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.MBtnDel.Size = new System.Drawing.Size(433, 44);
            this.MBtnDel.Text = "删除联系人(&D)";
            this.MBtnDel.Click += new System.EventHandler(this.MBtnDel_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(430, 6);
            // 
            // MBtnExport
            // 
            this.MBtnExport.Image = ((System.Drawing.Image)(resources.GetObject("MBtnExport.Image")));
            this.MBtnExport.Name = "MBtnExport";
            this.MBtnExport.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.MBtnExport.Size = new System.Drawing.Size(433, 44);
            this.MBtnExport.Text = "导出数据(&S)";
            this.MBtnExport.Click += new System.EventHandler(this.MBtnExport_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(430, 6);
            // 
            // MBtnExit
            // 
            this.MBtnExit.Image = global::通讯录.Properties.Resources.退出;
            this.MBtnExit.Name = "MBtnExit";
            this.MBtnExit.Size = new System.Drawing.Size(433, 44);
            this.MBtnExit.Text = "退出(&X)";
            this.MBtnExit.Click += new System.EventHandler(this.MBtnExit_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(115, 92);
            this.关于ToolStripMenuItem.Text = "关于(&A)";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(40, 92);
            this.toolStripMenuItem4.Text = "|";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.PersonName,
            this.PhoneNum,
            this.Sex,
            this.QQ,
            this.WeChat,
            this.PersonAddress});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgv.Location = new System.Drawing.Point(0, 138);
            this.dgv.Margin = new System.Windows.Forms.Padding(6);
            this.dgv.Name = "dgv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.RowHeadersWidth = 82;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1600, 682);
            this.dgv.TabIndex = 2;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // CID
            // 
            this.CID.HeaderText = "ID";
            this.CID.MinimumWidth = 10;
            this.CID.Name = "CID";
            this.CID.ReadOnly = true;
            this.CID.Width = 200;
            // 
            // PersonName
            // 
            this.PersonName.HeaderText = "姓名";
            this.PersonName.MinimumWidth = 10;
            this.PersonName.Name = "PersonName";
            this.PersonName.ReadOnly = true;
            this.PersonName.Width = 200;
            // 
            // PhoneNum
            // 
            this.PhoneNum.HeaderText = "联系电话";
            this.PhoneNum.MinimumWidth = 10;
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.ReadOnly = true;
            this.PhoneNum.Width = 200;
            // 
            // Sex
            // 
            this.Sex.HeaderText = "性别";
            this.Sex.MinimumWidth = 10;
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            this.Sex.Width = 200;
            // 
            // QQ
            // 
            this.QQ.HeaderText = "QQ号";
            this.QQ.MinimumWidth = 10;
            this.QQ.Name = "QQ";
            this.QQ.ReadOnly = true;
            this.QQ.Width = 200;
            // 
            // WeChat
            // 
            this.WeChat.HeaderText = "微信号";
            this.WeChat.MinimumWidth = 10;
            this.WeChat.Name = "WeChat";
            this.WeChat.ReadOnly = true;
            this.WeChat.Width = 200;
            // 
            // PersonAddress
            // 
            this.PersonAddress.HeaderText = "联系地址";
            this.PersonAddress.MinimumWidth = 10;
            this.PersonAddress.Name = "PersonAddress";
            this.PersonAddress.ReadOnly = true;
            this.PersonAddress.Width = 200;
            // 
            // CMSFrm1
            // 
            this.CMSFrm1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.CMSFrm1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加ToolStripMenuItem,
            this.修改ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.CMSFrm1.Name = "CMSFrm1";
            this.CMSFrm1.Size = new System.Drawing.Size(137, 118);
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(136, 38);
            this.添加ToolStripMenuItem.Text = "添加";
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(136, 38);
            this.修改ToolStripMenuItem.Text = "修改";
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(136, 38);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // textFind
            // 
            this.textFind.AllowDrop = true;
            this.textFind.Location = new System.Drawing.Point(286, 27);
            this.textFind.Name = "textFind";
            this.textFind.Size = new System.Drawing.Size(419, 35);
            this.textFind.TabIndex = 4;
            this.textFind.Visible = false;
            this.textFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textFind_KeyDown);
            // 
            // BtnFind
            // 
            this.BtnFind.Location = new System.Drawing.Point(725, 17);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(116, 61);
            this.BtnFind.TabIndex = 5;
            this.BtnFind.Text = "查询";
            this.BtnFind.UseVisualStyleBackColor = true;
            this.BtnFind.Visible = false;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "文本文件|*.txt|CSV文件|*.csv";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TBtnShow,
            this.toolStripSeparator1,
            this.TBtnAdd,
            this.TBtnModify,
            this.TBtnDel,
            this.toolStripSeparator2,
            this.TBtnExport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 96);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1600, 42);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TBtnShow
            // 
            this.TBtnShow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBtnShow.Image = global::通讯录.Properties.Resources.activeemergency;
            this.TBtnShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBtnShow.Name = "TBtnShow";
            this.TBtnShow.Size = new System.Drawing.Size(46, 36);
            this.TBtnShow.Text = "加载联系人";
            this.TBtnShow.Click += new System.EventHandler(this.MBtnShow_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // TBtnAdd
            // 
            this.TBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBtnAdd.Image = global::通讯录.Properties.Resources.添加联系人;
            this.TBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBtnAdd.Name = "TBtnAdd";
            this.TBtnAdd.Size = new System.Drawing.Size(46, 36);
            this.TBtnAdd.Text = "添加联系人";
            this.TBtnAdd.Click += new System.EventHandler(this.MBtnAdd_Click);
            // 
            // TBtnModify
            // 
            this.TBtnModify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBtnModify.Image = global::通讯录.Properties.Resources.修改联系人;
            this.TBtnModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBtnModify.Name = "TBtnModify";
            this.TBtnModify.Size = new System.Drawing.Size(46, 36);
            this.TBtnModify.Text = "修改联系人";
            this.TBtnModify.Click += new System.EventHandler(this.MBtnModify_Click);
            // 
            // TBtnDel
            // 
            this.TBtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBtnDel.Image = global::通讯录.Properties.Resources.删除人员2;
            this.TBtnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBtnDel.Name = "TBtnDel";
            this.TBtnDel.Size = new System.Drawing.Size(46, 36);
            this.TBtnDel.Text = "删除联系人";
            this.TBtnDel.Click += new System.EventHandler(this.MBtnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // TBtnExport
            // 
            this.TBtnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBtnExport.Image = global::通讯录.Properties.Resources.导出联系人;
            this.TBtnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBtnExport.Name = "TBtnExport";
            this.TBtnExport.Size = new System.Drawing.Size(46, 36);
            this.TBtnExport.Text = "导出联系人";
            this.TBtnExport.Click += new System.EventHandler(this.MBtnExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.textFind);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "通讯录";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.CMSFrm1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MBtnAdd;
        private System.Windows.Forms.ToolStripMenuItem MBtnShow;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MBtnModify;
        private System.Windows.Forms.ToolStripMenuItem MBtnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MBtnExport;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem MBtnExit;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MBtnSearch;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn QQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeChat;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonAddress;
        private System.Windows.Forms.ContextMenuStrip CMSFrm1;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.TextBox textFind;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TBtnShow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TBtnAdd;
        private System.Windows.Forms.ToolStripButton TBtnModify;
        private System.Windows.Forms.ToolStripButton TBtnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TBtnExport;
    }
}

