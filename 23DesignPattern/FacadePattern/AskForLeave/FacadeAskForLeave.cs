/*********************************************************************
* FileName:    FacadeAskForWork
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-08 Simple_ 21:14:49
* Description: 外观模式请假
*
* Revision History----------------------------------------------------
* Author      MofityDate                Reason
* 
**********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern.AskForLeave
{
    class FacadeAskForLeave
    {
        Leader m_leader = new Leader("p9966");
        PersonnelDept m_personnelDept = new PersonnelDept("Simple");
        Manager m_manager = new Manager("韩超");

        public void AskForLeave(int a_iRequestDays, string a_strRequestName)
        {
            m_leader.NextHandler = m_personnelDept;
            m_personnelDept.NextHandler = m_manager;

            m_leader.Handler(a_iRequestDays,a_strRequestName);
        }
    }
}
