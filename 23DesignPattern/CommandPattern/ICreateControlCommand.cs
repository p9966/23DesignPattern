/*********************************************************************
* FileName:    ICreateControlCommand
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-29 Simple_ 21:59:19
* Description: 抽象命令层，创建控件   ICommand
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
    abstract class ICreateControlCommand
    {
        // Variable
        public string m_strClrName;
        public int m_iClrLeft;
        public int m_iClrTop;
        public Control m_clrControl;



        // Constructor
        public ICreateControlCommand(string a_strClrName, int a_iTop, int a_iLeft, Control a_clrControl) {
            m_clrControl = a_clrControl;
            m_iClrLeft = a_iLeft;
            m_iClrTop = a_iTop;
            m_strClrName = a_strClrName;
        }



        #region Function

        public abstract void Create();          // 创建
      
        public abstract void Undo();            // 撤销

        #endregion
    }
}
