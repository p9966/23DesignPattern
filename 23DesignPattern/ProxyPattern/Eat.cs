/*********************************************************************
* FileName:    Eat
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-15 Simple_ 15:13:53
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
    class Eat:IEat
    {
        void IEat.Eat()
        {
            Console.WriteLine("我在吃饭");
        }
    }
}
