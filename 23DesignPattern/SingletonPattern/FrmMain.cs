/*********************************************************************
* FileName:    Form1
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-06 Simple_ 22:17:20
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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btn_CreateSingletonFrm_Click(object sender, EventArgs e)
        {
            FrmSingleton l_frmSingleton = FrmSingleton.CreateFrm();
            l_frmSingleton.Show();
        }
    }
}
