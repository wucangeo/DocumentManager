namespace DocumentManager
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_DateFull = new System.Windows.Forms.RadioButton();
            this.radio_Date_Full = new System.Windows.Forms.RadioButton();
            this.radio_dateShort = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_RenameSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_AheadStr = new System.Windows.Forms.TextBox();
            this.radio_radom = new System.Windows.Forms.RadioButton();
            this.radio_ReplaceStrAsDate = new System.Windows.Forms.RadioButton();
            this.radio_AddDateAhead = new System.Windows.Forms.RadioButton();
            this.radio_AsDateFormat = new System.Windows.Forms.RadioButton();
            this.chk_AddSubFolders = new System.Windows.Forms.CheckBox();
            this.btn_SetRenameFolder = new System.Windows.Forms.Button();
            this.txt_RenameFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(636, 436);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_RenameSubmit);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.chk_AddSubFolders);
            this.tabPage1.Controls.Add(this.btn_SetRenameFolder);
            this.tabPage1.Controls.Add(this.txt_RenameFolder);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(628, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "重命名文件";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_DateFull);
            this.groupBox2.Controls.Add(this.radio_Date_Full);
            this.groupBox2.Controls.Add(this.radio_dateShort);
            this.groupBox2.Location = new System.Drawing.Point(19, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 47);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "日期格式";
            // 
            // radio_DateFull
            // 
            this.radio_DateFull.AutoSize = true;
            this.radio_DateFull.Checked = true;
            this.radio_DateFull.Location = new System.Drawing.Point(254, 20);
            this.radio_DateFull.Name = "radio_DateFull";
            this.radio_DateFull.Size = new System.Drawing.Size(125, 16);
            this.radio_DateFull.TabIndex = 0;
            this.radio_DateFull.TabStop = true;
            this.radio_DateFull.Text = "2015-01-01 235959";
            this.radio_DateFull.UseVisualStyleBackColor = true;
            // 
            // radio_Date_Full
            // 
            this.radio_Date_Full.AutoSize = true;
            this.radio_Date_Full.Location = new System.Drawing.Point(102, 20);
            this.radio_Date_Full.Name = "radio_Date_Full";
            this.radio_Date_Full.Size = new System.Drawing.Size(137, 16);
            this.radio_Date_Full.TabIndex = 0;
            this.radio_Date_Full.Text = "2015-01-01 23-59-59";
            this.radio_Date_Full.UseVisualStyleBackColor = true;
            // 
            // radio_dateShort
            // 
            this.radio_dateShort.AutoSize = true;
            this.radio_dateShort.Location = new System.Drawing.Point(7, 21);
            this.radio_dateShort.Name = "radio_dateShort";
            this.radio_dateShort.Size = new System.Drawing.Size(83, 16);
            this.radio_dateShort.TabIndex = 0;
            this.radio_dateShort.Text = "2015-01-01";
            this.radio_dateShort.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "修改前请将文件备份。";
            // 
            // btn_RenameSubmit
            // 
            this.btn_RenameSubmit.Location = new System.Drawing.Point(533, 365);
            this.btn_RenameSubmit.Name = "btn_RenameSubmit";
            this.btn_RenameSubmit.Size = new System.Drawing.Size(75, 23);
            this.btn_RenameSubmit.TabIndex = 5;
            this.btn_RenameSubmit.Text = "确认修改";
            this.btn_RenameSubmit.UseVisualStyleBackColor = true;
            this.btn_RenameSubmit.Click += new System.EventHandler(this.btn_RenameSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_AheadStr);
            this.groupBox1.Controls.Add(this.radio_radom);
            this.groupBox1.Controls.Add(this.radio_ReplaceStrAsDate);
            this.groupBox1.Controls.Add(this.radio_AddDateAhead);
            this.groupBox1.Controls.Add(this.radio_AsDateFormat);
            this.groupBox1.Location = new System.Drawing.Point(19, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 119);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件名格式";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "替换：";
            // 
            // txt_AheadStr
            // 
            this.txt_AheadStr.Location = new System.Drawing.Point(483, 86);
            this.txt_AheadStr.Name = "txt_AheadStr";
            this.txt_AheadStr.Size = new System.Drawing.Size(100, 21);
            this.txt_AheadStr.TabIndex = 2;
            // 
            // radio_radom
            // 
            this.radio_radom.AutoSize = true;
            this.radio_radom.Location = new System.Drawing.Point(6, 20);
            this.radio_radom.Name = "radio_radom";
            this.radio_radom.Size = new System.Drawing.Size(167, 16);
            this.radio_radom.TabIndex = 1;
            this.radio_radom.Text = "随机排序：1.*,2.*,3.*...";
            this.radio_radom.UseVisualStyleBackColor = true;
            // 
            // radio_ReplaceStrAsDate
            // 
            this.radio_ReplaceStrAsDate.AutoSize = true;
            this.radio_ReplaceStrAsDate.Location = new System.Drawing.Point(6, 86);
            this.radio_ReplaceStrAsDate.Name = "radio_ReplaceStrAsDate";
            this.radio_ReplaceStrAsDate.Size = new System.Drawing.Size(329, 16);
            this.radio_ReplaceStrAsDate.TabIndex = 1;
            this.radio_ReplaceStrAsDate.Text = "将制定字符修改为日期：abc_def.* -> 2015-01-01_def.*";
            this.radio_ReplaceStrAsDate.UseVisualStyleBackColor = true;
            // 
            // radio_AddDateAhead
            // 
            this.radio_AddDateAhead.AutoSize = true;
            this.radio_AddDateAhead.Location = new System.Drawing.Point(6, 64);
            this.radio_AddDateAhead.Name = "radio_AddDateAhead";
            this.radio_AddDateAhead.Size = new System.Drawing.Size(227, 16);
            this.radio_AddDateAhead.TabIndex = 1;
            this.radio_AddDateAhead.Text = "在文件名前加日期：2015-01-01 abc.*";
            this.radio_AddDateAhead.UseVisualStyleBackColor = true;
            // 
            // radio_AsDateFormat
            // 
            this.radio_AsDateFormat.AutoSize = true;
            this.radio_AsDateFormat.Checked = true;
            this.radio_AsDateFormat.Location = new System.Drawing.Point(6, 42);
            this.radio_AsDateFormat.Name = "radio_AsDateFormat";
            this.radio_AsDateFormat.Size = new System.Drawing.Size(179, 16);
            this.radio_AsDateFormat.TabIndex = 0;
            this.radio_AsDateFormat.TabStop = true;
            this.radio_AsDateFormat.Text = "重命名为日期：2015-01-01.*";
            this.radio_AsDateFormat.UseVisualStyleBackColor = true;
            // 
            // chk_AddSubFolders
            // 
            this.chk_AddSubFolders.AutoSize = true;
            this.chk_AddSubFolders.Location = new System.Drawing.Point(19, 45);
            this.chk_AddSubFolders.Name = "chk_AddSubFolders";
            this.chk_AddSubFolders.Size = new System.Drawing.Size(96, 16);
            this.chk_AddSubFolders.TabIndex = 3;
            this.chk_AddSubFolders.Text = "包含子文件夹";
            this.chk_AddSubFolders.UseVisualStyleBackColor = true;
            // 
            // btn_SetRenameFolder
            // 
            this.btn_SetRenameFolder.Location = new System.Drawing.Point(533, 11);
            this.btn_SetRenameFolder.Name = "btn_SetRenameFolder";
            this.btn_SetRenameFolder.Size = new System.Drawing.Size(75, 23);
            this.btn_SetRenameFolder.TabIndex = 2;
            this.btn_SetRenameFolder.Text = "浏览";
            this.btn_SetRenameFolder.UseVisualStyleBackColor = true;
            this.btn_SetRenameFolder.Click += new System.EventHandler(this.btn_SetRenameFolder_Click);
            // 
            // txt_RenameFolder
            // 
            this.txt_RenameFolder.Location = new System.Drawing.Point(78, 13);
            this.txt_RenameFolder.Name = "txt_RenameFolder";
            this.txt_RenameFolder.Size = new System.Drawing.Size(449, 21);
            this.txt_RenameFolder.TabIndex = 1;
            this.txt_RenameFolder.Text = "C:\\Users\\WUCAN\\Desktop\\pic";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件夹";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(628, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 436);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件管理软件(by:cc)";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_SetRenameFolder;
        private System.Windows.Forms.TextBox txt_RenameFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_AddSubFolders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_AsDateFormat;
        private System.Windows.Forms.RadioButton radio_AddDateAhead;
        private System.Windows.Forms.RadioButton radio_radom;
        private System.Windows.Forms.RadioButton radio_ReplaceStrAsDate;
        private System.Windows.Forms.Button btn_RenameSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio_DateFull;
        private System.Windows.Forms.RadioButton radio_Date_Full;
        private System.Windows.Forms.RadioButton radio_dateShort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_AheadStr;
    }
}

