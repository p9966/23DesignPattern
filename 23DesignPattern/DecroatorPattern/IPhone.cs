/*********************************************************************
* FileName:    IPhone
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-06 Simple_ 22:00:56
* Description: 苹果手机
*
* Revision History----------------------------------------------------
* Author      MofityDate                Reason
* 
**********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecroatorPattern
{
    class IPhone:AbstractPhone
    {
        public override void IntrodeuceOneself()
        {
            Console.WriteLine("你好我是苹果手机");
        }
    }
}
