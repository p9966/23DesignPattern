/*********************************************************************
* FileName:    Manager
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-08 Simple_ 21:13:02
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
    class Manager:AbstractAskForLeave
    {
        public Manager(string a_strOperationName) : base(a_strOperationName) { }

        public override void Handler(int a_iRequestDays, string a_strRequestName)
        {
            if (a_iRequestDays <= 10)
            {
                Console.WriteLine("{0}的{1}天请假已经同意，处理人{2}", a_strRequestName, a_iRequestDays, base.OperationName);
            }
            else
            {
                Console.WriteLine("{0}的请假天数太多，需要开会讨论",a_strRequestName);
            }
        }
    }
}
