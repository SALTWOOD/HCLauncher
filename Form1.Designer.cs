﻿namespace EMCL
{
    partial class winMain
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
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnJavaSearch = new System.Windows.Forms.Button();
            this.cmbJavaList = new System.Windows.Forms.ComboBox();
            this.btnChooseJava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(12, 367);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(142, 71);
            this.btnLaunch.TabIndex = 0;
            this.btnLaunch.Text = "MC，启动！";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnJavaSearch
            // 
            this.btnJavaSearch.Location = new System.Drawing.Point(12, 290);
            this.btnJavaSearch.Name = "btnJavaSearch";
            this.btnJavaSearch.Size = new System.Drawing.Size(142, 71);
            this.btnJavaSearch.TabIndex = 1;
            this.btnJavaSearch.Text = "扫描 Java";
            this.btnJavaSearch.UseVisualStyleBackColor = true;
            this.btnJavaSearch.Click += new System.EventHandler(this.btnJavaSearch_Click);
            // 
            // cmbJavaList
            // 
            this.cmbJavaList.FormattingEnabled = true;
            this.cmbJavaList.Location = new System.Drawing.Point(169, 415);
            this.cmbJavaList.Name = "cmbJavaList";
            this.cmbJavaList.Size = new System.Drawing.Size(619, 23);
            this.cmbJavaList.TabIndex = 2;
            this.cmbJavaList.Text = "Java 列表";
            this.cmbJavaList.SelectedIndexChanged += new System.EventHandler(this.cmbJavaList_SelectedIndexChanged);
            // 
            // btnChooseJava
            // 
            this.btnChooseJava.Location = new System.Drawing.Point(169, 367);
            this.btnChooseJava.Name = "btnChooseJava";
            this.btnChooseJava.Size = new System.Drawing.Size(112, 42);
            this.btnChooseJava.TabIndex = 3;
            this.btnChooseJava.Text = "手动选择";
            this.btnChooseJava.UseVisualStyleBackColor = true;
            this.btnChooseJava.Click += new System.EventHandler(this.btnChooseJava_Click);
            // 
            // winMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChooseJava);
            this.Controls.Add(this.cmbJavaList);
            this.Controls.Add(this.btnJavaSearch);
            this.Controls.Add(this.btnLaunch);
            this.Name = "winMain";
            this.Text = "EMCL 启动器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.winMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.winMain_FormClosed);
            this.Load += new System.EventHandler(this.winMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button btnJavaSearch;
        private System.Windows.Forms.ComboBox cmbJavaList;
        private System.Windows.Forms.Button btnChooseJava;
    }
}

