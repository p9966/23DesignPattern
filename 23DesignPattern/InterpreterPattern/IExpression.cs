/*********************************************************************
* FileName:    IExpression
* Tables:      nothing
* Author:      Simple
* CreateDate:  2018-02-23 Simple_ 19:23:41
* Description: 解释器抽象层
*
* Revision History----------------------------------------------------
* Author      MofityDate                Reason
* 
**********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterpreterPattern
{
    interface IExpression
    {
        int Interpret();
    }
}
