/*********************************************************************
* FileName:    NonTerminalExpression
* Tables:      nothing
* Author:      Simple
* CreateDate:  2018-02-23 Simple_ 19:27:12
* Description: 非终止符表达式
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
    class NonTerminalExpression
    {
        public IExpression m_ixLeft, m_ixRight;

        public NonTerminalExpression(IExpression a_ixLeft, IExpression a_ixRight)
        {
            m_ixLeft = a_ixLeft;
            m_ixRight = a_ixRight;
        }
    }
}
