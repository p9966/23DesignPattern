/*********************************************************************
* FileName:    Honor
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-06 Simple_ 22:01:40
* Description: 荣耀手机
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
    class Honor:AbstractPhone
    {
        public override void IntrodeuceOneself()
        {
            Console.WriteLine("你好我是荣耀手机");
        }
    }
}
