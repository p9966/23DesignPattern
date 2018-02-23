/*********************************************************************
* FileName:    AddExpression
* Tables:      nothing
* Author:      Simple
* CreateDate:  2018-02-23 Simple_ 19:28:50
* Description: 加法运算
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
    class AddExpression:NonTerminalExpression,IExpression
    {
        public AddExpression(IExpression a_ixLeft, IExpression a_ixRight) : base(a_ixLeft, a_ixRight) { }

        public int Interpret()
        {
            return m_ixLeft.Interpret() + m_ixRight.Interpret();
        }
    }
}
