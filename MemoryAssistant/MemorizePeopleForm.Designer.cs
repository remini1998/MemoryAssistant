namespace MemoryAssistant
{
    partial class MemorizePeopleForm
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
            this.lab_ShowInfo = new System.Windows.Forms.Label();
            this.btn_Know = new System.Windows.Forms.Button();
            this.btn_Unkown = new System.Windows.Forms.Button();
            this.chkBox_ModeSelect = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pBox_ShowPhotos = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重置熟悉度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.Lab_ShowRem = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.更新日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_ShowPhotos)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_ShowInfo
            // 
            this.lab_ShowInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_ShowInfo.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_ShowInfo.Location = new System.Drawing.Point(3, 0);
            this.lab_ShowInfo.Name = "lab_ShowInfo";
            this.lab_ShowInfo.Size = new System.Drawing.Size(264, 345);
            this.lab_ShowInfo.TabIndex = 1;
            this.lab_ShowInfo.Text = "点击查看信息";
            this.lab_ShowInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_ShowInfo.Click += new System.EventHandler(this.lab_ShowInfo_Click);
            // 
            // btn_Know
            // 
            this.btn_Know.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Know.Location = new System.Drawing.Point(3, 3);
            this.btn_Know.Name = "btn_Know";
            this.btn_Know.Size = new System.Drawing.Size(126, 137);
            this.btn_Know.TabIndex = 2;
            this.btn_Know.Text = "认识";
            this.btn_Know.UseVisualStyleBackColor = true;
            this.btn_Know.Click += new System.EventHandler(this.btn_Know_Click);
            // 
            // btn_Unkown
            // 
            this.btn_Unkown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Unkown.Location = new System.Drawing.Point(135, 3);
            this.btn_Unkown.Name = "btn_Unkown";
            this.btn_Unkown.Size = new System.Drawing.Size(126, 137);
            this.btn_Unkown.TabIndex = 3;
            this.btn_Unkown.Text = "不认识";
            this.btn_Unkown.UseVisualStyleBackColor = true;
            this.btn_Unkown.Click += new System.EventHandler(this.btn_Unkown_Click);
            // 
            // chkBox_ModeSelect
            // 
            this.chkBox_ModeSelect.AutoSize = true;
            this.chkBox_ModeSelect.Checked = true;
            this.chkBox_ModeSelect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBox_ModeSelect.Location = new System.Drawing.Point(3, 348);
            this.chkBox_ModeSelect.Name = "chkBox_ModeSelect";
            this.chkBox_ModeSelect.Size = new System.Drawing.Size(119, 19);
            this.chkBox_ModeSelect.TabIndex = 4;
            this.chkBox_ModeSelect.Text = "开启测验模式";
            this.chkBox_ModeSelect.UseVisualStyleBackColor = true;
            this.chkBox_ModeSelect.CheckedChanged += new System.EventHandler(this.chkBox_ModeSelect_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pBox_ShowPhotos, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(689, 560);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.chkBox_ModeSelect, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lab_ShowInfo, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(416, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(270, 524);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btn_Unkown, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Know, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 378);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(264, 143);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // pBox_ShowPhotos
            // 
            this.pBox_ShowPhotos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox_ShowPhotos.Location = new System.Drawing.Point(3, 3);
            this.pBox_ShowPhotos.Name = "pBox_ShowPhotos";
            this.pBox_ShowPhotos.Size = new System.Drawing.Size(407, 524);
            this.pBox_ShowPhotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_ShowPhotos.TabIndex = 0;
            this.pBox_ShowPhotos.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.工具ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.更新日志ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(689, 28);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重置熟悉度ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 重置熟悉度ToolStripMenuItem
            // 
            this.重置熟悉度ToolStripMenuItem.Name = "重置熟悉度ToolStripMenuItem";
            this.重置熟悉度ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.重置熟悉度ToolStripMenuItem.Text = "重置熟悉度";
            this.重置熟悉度ToolStripMenuItem.Click += new System.EventHandler(this.重置熟悉度ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.Lab_ShowRem});
            this.statusStrip.Location = new System.Drawing.Point(0, 563);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(689, 25);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(300, 19);
            // 
            // Lab_ShowRem
            // 
            this.Lab_ShowRem.Name = "Lab_ShowRem";
            this.Lab_ShowRem.Size = new System.Drawing.Size(108, 20);
            this.Lab_ShowRem.Text = "LabShowRem";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1200000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // 更新日志ToolStripMenuItem
            // 
            this.更新日志ToolStripMenuItem.Name = "更新日志ToolStripMenuItem";
            this.更新日志ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.更新日志ToolStripMenuItem.Text = "更新日志";
            this.更新日志ToolStripMenuItem.Click += new System.EventHandler(this.更新日志ToolStripMenuItem_Click);
            // 
            // MemorizePeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 588);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MemorizePeopleForm";
            this.Text = "照片助记助手";
            this.Load += new System.EventHandler(this.MemorizePeopleForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_ShowPhotos)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lab_ShowInfo;
        private System.Windows.Forms.Button btn_Know;
        private System.Windows.Forms.Button btn_Unkown;
        private System.Windows.Forms.CheckBox chkBox_ModeSelect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pBox_ShowPhotos;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel Lab_ShowRem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重置熟悉度ToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem 更新日志ToolStripMenuItem;
    }
}

