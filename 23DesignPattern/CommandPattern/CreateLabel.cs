﻿/*********************************************************************
* FileName:    CreateButton
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-29 Simple_ 21:53:39
* Description: 创建一个标签 执行者  Receive
*
* Revision History----------------------------------------------------
* Author      MofityDate                Reason
* 
**********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommandPattern
{
    class CreateLabel
    {
        // variable
        private string m_strControlNmae;
        private int m_iControlLeft;
        private int m_iControlTop;
        private Control m_clrControl;



        // Constructor
        public CreateLabel(string a_strClrName, int a_iLeft, int a_iTop, Control a_clr)
        {
            this.m_clrControl = a_clr;
            this.m_strControlNmae = a_strClrName;
            this.m_iControlLeft = a_iLeft;
            this.m_iControlTop = a_iTop;
        }



        // Function
        public void Create() {
            Label l_lb = new Label();
            l_lb.Name = l_lb.Text = m_strControlNmae;
            l_lb.Location = new System.Drawing.Point(m_iControlLeft, m_iControlTop);
            m_clrControl.Controls.Add(l_lb);
        }
    }
}
