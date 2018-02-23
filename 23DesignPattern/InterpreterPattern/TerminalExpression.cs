/*********************************************************************
* FileName:    TerminalExpression
* Tables:      nothing
* Author:      Simple
* CreateDate:  2018-02-23 Simple_ 19:24:45
* Description: 终止符表达式
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
    class TerminalExpression:IExpression
    {
        int m_iValue;
        public TerminalExpression(int a_iValue)
        {
            m_iValue = a_iValue;
        }

        public int Interpret()
        {
            return m_iValue;
        }
    }
}
