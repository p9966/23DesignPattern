/*********************************************************************
* FileName:    Drank
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-15 Simple_ 15:14:22
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

namespace ProxyPattern
{
    class Drink:IEat
    {
        public void Eat()
        {
            Console.WriteLine("我在喝水");
        }
    }
}
