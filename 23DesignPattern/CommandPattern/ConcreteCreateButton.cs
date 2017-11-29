/*********************************************************************
* FileName:    ConcreteCreateButton
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-29 Simple_ 22:04:22
* Description: 具体命令，创建一个按钮      ConcreteCommand
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
    class ConcreteCreateButton:ICreateControlCommand
    {
        // Constructor
        public ConcreteCreateButton(string a_strButtonName, int a_iTop, int a_iLeft, Control a_clrControl) :
            base(a_strButtonName, a_iTop, a_iLeft, a_clrControl) { }



        #region Instance Function
        // Create Button
        public override void Create()
        {
            CreateButton l_createBtn = new CreateButton(base.m_strClrName,
                base.m_iClrLeft, base.m_iClrTop, base.m_clrControl);
            l_createBtn.Create();
        }

        // Delete Button
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
