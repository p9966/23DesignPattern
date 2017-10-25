/*********************************************************************
* FileName:    BmwWheel
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-25 Simple_ 22:56:48
* Description: 宝马车的车轮
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
    class BmwWheel:IWheel
    {
        public void Wheel()
        {
            Console.WriteLine("你好，这是宝马车的车轮");
        }
    }
}
