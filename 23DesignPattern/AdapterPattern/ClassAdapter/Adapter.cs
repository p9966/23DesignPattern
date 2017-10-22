/*********************************************************************
* FileName:    Adapter
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-19 Simple_ 21:53:06
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
    /// <summary>
    /// 适配器
    /// </summary>
    class Adapter:Portal,IOutput
    {
        public Adapter(string a_strMsg) : base(a_strMsg) { }

        public void OutPut()
        {
            base.Input();
        }
    }
}
