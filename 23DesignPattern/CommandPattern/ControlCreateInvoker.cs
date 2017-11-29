/*********************************************************************
* FileName:    ControlCreateInvoker
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-29 Simple_ 22:12:04
* Description: 操作命令者    invoker 控件创建控件
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
    class ControlCreateInvoker
    {
        // Variable
        List<ICreateControlCommand> m_lstControlcmds = new List<ICreateControlCommand>();
        int m_iOperateIndex = 0;



        #region Function
        public void CreateButton(string a_strButtonName, int a_iTop,int a_iLeft, Control a_clrControl)
        {
            ICreateControlCommand l_createBtnCmd = new ConcreteCreateButton(a_strButtonName,
                a_iTop, a_iLeft, a_clrControl);
            l_createBtnCmd.Create();

            m_lstControlcmds.Add(l_createBtnCmd);
            m_iOperateIndex++;
        }

        public void CreateLabel(string a_strButtonName, int a_iTop, int a_iLeft, Control a_clrControl)
        {
            ICreateControlCommand l_createBtnCmd = new ConcreteCreateLabel(a_strButtonName,
                a_iTop, a_iLeft, a_clrControl);
            l_createBtnCmd.Create();

            m_lstControlcmds.Add(l_createBtnCmd);
            m_iOperateIndex++;
        }

        public void Undo()
        {
            if (m_iOperateIndex > 0)
                m_lstControlcmds[--m_iOperateIndex].Undo();
        }

        public void Redo()
        {
            if (m_iOperateIndex < m_lstControlcmds.Count)
            {
                m_lstControlcmds[m_iOperateIndex].Create();
                m_iOperateIndex++;
            }
        }
        #endregion
    }
}
