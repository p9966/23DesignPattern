/*********************************************************************
* FileName:    FlyweightToolsFactory
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-10 Simple_ 22:54:19
* Description: 这个是我们的工具箱，该工具箱得保证用户需要的工具只被创建一次
*
* Revision History----------------------------------------------------
* Author      MofityDate                Reason
* 
**********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyweightPattern
{
    static class FlyweightToolsFactory
    {
        static Dictionary<string, AbstractTools> m_dicTools = new Dictionary<string, AbstractTools>();

        public static AbstractTools GetTools(string a_strProcessObject)
        {
            AbstractTools l_absTools = null;
            try
            {
                l_absTools = m_dicTools[a_strProcessObject];
            }
            catch
            {
                if (a_strProcessObject == "夹子")
                    l_absTools = new Clamp();
                if (a_strProcessObject == "框子")
                    l_absTools = new Frame();
                if (a_strProcessObject == "推车")
                    l_absTools = new Cart();
                else
                    throw new Exception("请输入合法的工具");
                m_dicTools.Add(a_strProcessObject, l_absTools);
            }
            return l_absTools;
        }
    }
}
