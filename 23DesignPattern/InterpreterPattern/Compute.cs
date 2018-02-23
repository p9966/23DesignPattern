/*********************************************************************
* FileName:    Compute
* Tables:      nothing
* Author:      Simple
* CreateDate:  2018-02-23 Simple_ 19:33:24
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
    class Compute
    {
        IExpression m_ixResult;
        public void Build(string a_strExpression)
        {
            IExpression l_ixLeft, l_ixRight;
            string[] l_strElements = a_strExpression.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < l_strElements.Length; i++)
            {
                if (l_strElements[i] == "+")
                {
                    l_ixLeft = m_ixResult;
                    l_ixRight = new TerminalExpression(Convert.ToInt32(l_strElements[++i]));
                    m_ixResult = new AddExpression(l_ixLeft, l_ixRight);
                }
                else if (l_strElements[i] == "-")
                {
                    l_ixLeft = m_ixResult;
                    l_ixRight = new TerminalExpression(Convert.ToInt32(l_strElements[++i]));
                    m_ixResult = new SubExpression(l_ixLeft, l_ixRight);
                }
                else
                {
                    m_ixResult = new TerminalExpression(Convert.ToInt32(l_strElements[i]));
                }
            }
        }

        public int GetResult()
        {
            return m_ixResult.Interpret();
        }
    }
}
