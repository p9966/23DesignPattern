/*********************************************************************
* FileName:    AbstractAskForLeave
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-08 Simple_ 21:03:41
* Description: 请假的抽象层
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
    abstract class AbstractAskForLeave
    {
        public string OperationName { get; set; }                           // 处理人名称
        public AbstractAskForLeave NextHandler { get; set; }                // 当前处理人无法处理时，下一个处理人

        public AbstractAskForLeave(string a_strOperationName)
        {
            OperationName = a_strOperationName;
        }

        public abstract void Handler(int a_iRequestDays, string a_strRequestName);
    }
}
