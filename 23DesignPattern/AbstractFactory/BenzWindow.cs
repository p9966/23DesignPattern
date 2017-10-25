/*********************************************************************
* FileName:    BnezWindow
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-25 Simple_ 22:59:18
* Description: 奔驰车的车窗
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
    class BenzWindow:IWindow
    {
        public void Window()
        {
            Console.WriteLine("你好，这是奔驰车的车窗");
        }
    }
}
