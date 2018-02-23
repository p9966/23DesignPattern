/*********************************************************************
* FileName:    SubExpression
* Tables:      nothing
* Author:      Simple
* CreateDate:  2018-02-23 Simple_ 19:32:23
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

namespace InterpreterPattern
{
    class SubExpression:NonTerminalExpression,IExpression
    {
        public SubExpression(IExpression a_ixLeft, IExpression a_ixRight) : base(a_ixLeft, a_ixRight) { }
        
        public int Interpret()
        {
            return m_ixLeft.Interpret() - m_ixRight.Interpret();
        }
    }
}
