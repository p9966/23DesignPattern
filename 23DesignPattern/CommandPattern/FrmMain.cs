/*********************************************************************
* FileName:    Form1
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-29 Simple_ 21:48:05
* Description: 命令模式
*              需求分析：winform项目，手动创建一些控件，带撤销功能，用命令模式完成
* Revision History----------------------------------------------------
* Author      MofityDate                Reason
* 
**********************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommandPattern
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        // Variable
        ControlCreateInvoker m_createClrInvoke = new ControlCreateInvoker();



        #region FrmEvent
        private void btnCreateButton_Click(object sender, EventArgs e)
        {
            m_createClrInvoke.CreateButton(txtBox_Name.Text, Convert.ToInt32(txtBox_Top.Text),
                Convert.ToInt32(txtBox_Left.Text), pnlDisplay);
        }

        private void btnCreateLabel_Click(object sender, EventArgs e)
        {
            m_createClrInvoke.CreateLabel(txtBox_Name.Text, Convert.ToInt32(txtBox_Top.Text),
    Convert.ToInt32(txtBox_Left.Text), pnlDisplay);
        }

        private void btn_Undo_Click(object sender, EventArgs e)
        {
            m_createClrInvoke.Undo();
        }

        private void btn_Redo_Click(object sender, EventArgs e)
        {
            m_createClrInvoke.Redo();
        }
        #endregion



    }
}
