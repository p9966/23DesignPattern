﻿namespace SingletonPattern
{
    partial class FrmMain
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
            this.btn_CreateSingletonFrm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CreateSingletonFrm
            // 
            this.btn_CreateSingletonFrm.Location = new System.Drawing.Point(228, 12);
            this.btn_CreateSingletonFrm.Name = "btn_CreateSingletonFrm";
            this.btn_CreateSingletonFrm.Size = new System.Drawing.Size(112, 38);
            this.btn_CreateSingletonFrm.TabIndex = 0;
            this.btn_CreateSingletonFrm.Text = "创建单例窗口";
            this.btn_CreateSingletonFrm.UseVisualStyleBackColor = true;
            this.btn_CreateSingletonFrm.Click += new System.EventHandler(this.btn_CreateSingletonFrm_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 282);
            this.Controls.Add(this.btn_CreateSingletonFrm);
            this.Name = "FrmMain";
            this.Text = "单例模式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateSingletonFrm;
    }
}
