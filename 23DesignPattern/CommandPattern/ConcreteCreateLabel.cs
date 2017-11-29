/*********************************************************************
* FileName:    ConcreteCreateButton
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-29 Simple_ 22:04:22
* Description: 具体命令，创建一个标签      ConcreteCommand
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
    class ConcreteCreateLabel:ICreateControlCommand
    {
        // Constructor
        public ConcreteCreateLabel(string a_strLabelName, int a_iTop, int a_iLeft, Control a_clrControl) :
            base(a_strLabelName, a_iTop, a_iLeft, a_clrControl) { }



        #region Instance Function
        // Create Label
        public override void Create()
        {
            CreateLabel l_createBtn = new CreateLabel(base.m_strClrName,
                base.m_iClrLeft, base.m_iClrTop, base.m_clrControl);
            l_createBtn.Create();
        }

        // Delete Label
        public override void Undo()
        {
            foreach (Control item_control in base.m_clrControl.Controls)
            {
                if (item_control.Name == base.m_strClrName)
                {
                    base.m_clrControl.Controls.Remove(item_control);
                    break;
                }
            }
        }
        #endregion
    }
}
