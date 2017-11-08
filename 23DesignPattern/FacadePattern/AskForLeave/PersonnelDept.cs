/*********************************************************************
* FileName:    PersonnelDept
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-08 Simple_ 21:12:28
* Description: Love life, love programming
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
    class PersonnelDept : AbstractAskForLeave
    {
        public PersonnelDept(string a_strOperationName) : base(a_strOperationName) { }

        public override void Handler(int a_iRequestDays, string a_strRequestName)
        {
            if (a_iRequestDays <= 5 )
            {
                Console.WriteLine("{0}的{1}天请假已经同意，处理人{2}", a_strRequestName, a_iRequestDays, base.OperationName);
            }
            else
            {
                base.NextHandler.Handler(a_iRequestDays, a_strRequestName);
            }
        }
    }
}
