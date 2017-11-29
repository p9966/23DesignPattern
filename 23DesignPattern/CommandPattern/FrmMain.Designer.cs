namespace CommandPattern
{
    partial class frmMain
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
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.btn_Redo = new System.Windows.Forms.Button();
            this.btn_Undo = new System.Windows.Forms.Button();
            this.btnCreateButton = new System.Windows.Forms.Button();
            this.txtBox_Top = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_Left = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.btnCreateLabel = new System.Windows.Forms.Button();
            this.gbControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.btnCreateLabel);
            this.gbControl.Controls.Add(this.btn_Redo);
            this.gbControl.Controls.Add(this.btn_Undo);
            this.gbControl.Controls.Add(this.btnCreateButton);
            this.gbControl.Controls.Add(this.txtBox_Top);
            this.gbControl.Controls.Add(this.label3);
            this.gbControl.Controls.Add(this.txtBox_Left);
            this.gbControl.Controls.Add(this.label2);
            this.gbControl.Controls.Add(this.txtBox_Name);
            this.gbControl.Controls.Add(this.label1);
            this.gbControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbControl.Location = new System.Drawing.Point(0, 0);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(563, 100);
            this.gbControl.TabIndex = 0;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "控制台";
            // 
            // btn_Redo
            // 
            this.btn_Redo.Location = new System.Drawing.Point(476, 47);
            this.btn_Redo.Name = "btn_Redo";
            this.btn_Redo.Size = new System.Drawing.Size(75, 23);
            this.btn_Redo.TabIndex = 8;
            this.btn_Redo.Text = "redo";
            this.btn_Redo.UseVisualStyleBackColor = true;
            this.btn_Redo.Click += new System.EventHandler(this.btn_Redo_Click);
            // 
            // btn_Undo
            // 
            this.btn_Undo.Location = new System.Drawing.Point(476, 15);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(75, 23);
            this.btn_Undo.TabIndex = 7;
            this.btn_Undo.Text = "undo";
            this.btn_Undo.UseVisualStyleBackColor = true;
            this.btn_Undo.Click += new System.EventHandler(this.btn_Undo_Click);
            // 
            // btnCreateButton
            // 
            this.btnCreateButton.Location = new System.Drawing.Point(217, 15);
            this.btnCreateButton.Name = "btnCreateButton";
            this.btnCreateButton.Size = new System.Drawing.Size(96, 23);
            this.btnCreateButton.TabIndex = 6;
            this.btnCreateButton.Text = "CreateButton";
            this.btnCreateButton.UseVisualStyleBackColor = true;
            this.btnCreateButton.Click += new System.EventHandler(this.btnCreateButton_Click);
            // 
            // txtBox_Top
            // 
            this.txtBox_Top.Location = new System.Drawing.Point(95, 71);
            this.txtBox_Top.Name = "txtBox_Top";
            this.txtBox_Top.Size = new System.Drawing.Size(100, 21);
            this.txtBox_Top.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Top";
            // 
            // txtBox_Left
            // 
            this.txtBox_Left.Location = new System.Drawing.Point(95, 44);
            this.txtBox_Left.Name = "txtBox_Left";
            this.txtBox_Left.Size = new System.Drawing.Size(100, 21);
            this.txtBox_Left.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Left";
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Location = new System.Drawing.Point(95, 17);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(100, 21);
            this.txtBox_Name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplay.Location = new System.Drawing.Point(0, 100);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(563, 344);
            this.pnlDisplay.TabIndex = 0;
            // 
            // btnCreateLabel
            // 
            this.btnCreateLabel.Location = new System.Drawing.Point(217, 47);
            this.btnCreateLabel.Name = "btnCreateLabel";
            this.btnCreateLabel.Size = new System.Drawing.Size(96, 23);
            this.btnCreateLabel.TabIndex = 9;
            this.btnCreateLabel.Text = "CreateLabel";
            this.btnCreateLabel.UseVisualStyleBackColor = true;
            this.btnCreateLabel.Click += new System.EventHandler(this.btnCreateLabel_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 444);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.gbControl);
            this.Name = "frmMain";
            this.Text = "CommandPattern";
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.Button btn_Redo;
        private System.Windows.Forms.Button btn_Undo;
        private System.Windows.Forms.Button btnCreateButton;
        private System.Windows.Forms.TextBox txtBox_Top;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_Left;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Button btnCreateLabel;
    }
}

