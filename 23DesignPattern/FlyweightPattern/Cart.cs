/*********************************************************************
* FileName:    Cart
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-10 Simple_ 22:52:59
* Description: 搬运大理石的推车
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
    class Cart:AbstractTools
    {
        public override void Operation()
        {
            Console.WriteLine("我正在用推车搬运{0}",base.ProcessObject);
        }
    }
}
