/*********************************************************************
* FileName:    BenzWheel
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-25 Simple_ 22:58:39
* Description: 奔驰车的车轮
*
* Revision History----------------------------------------------------
* Author      MofityDate                Reason
* 
**********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class BenzWheel:IWheel
    {
        public void Wheel()
        {
            Console.WriteLine("你好，这是奔驰车的车轮");
        }
    }
}
