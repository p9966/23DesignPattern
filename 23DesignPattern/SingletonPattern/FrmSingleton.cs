/*********************************************************************
* FileName:    FrmSingleton
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-06 Simple_ 22:19:33
* Description: Love life, love programming
*
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

namespace SingletonPattern
{
    public partial class FrmSingleton : Form
    {
        #region Variable
        private static FrmSingleton m_frmSingletonFrm;
        #endregion

        // 将构造函数改为私有的，即外部无法访问
        private FrmSingleton()
        {
            InitializeComponent();
        }

        // 该函数用于只创建一个对象
        public static FrmSingleton CreateFrm()
        {
            if (m_frmSingletonFrm == null)
                m_frmSingletonFrm = new FrmSingleton();
            return m_frmSingletonFrm;
        }

        // 当该窗口关闭时释放
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            m_frmSingletonFrm = null;
        }
    }
}
