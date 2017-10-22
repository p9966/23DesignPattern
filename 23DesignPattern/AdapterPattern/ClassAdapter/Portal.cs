/*********************************************************************
* FileName:    Portal
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-19 Simple_ 21:50:30
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

namespace AdapterPattern.ClassAdapter
{
    class Portal
    {
        string m_strMsg;

        public Portal(string a_strMsg)
        {
            m_strMsg = a_strMsg;
        }

        /// <summary>
        /// 输入（电流）
        /// </summary>
        public void Input()
        {
            Console.WriteLine(m_strMsg+"--->18v。");
        }
    }
}
