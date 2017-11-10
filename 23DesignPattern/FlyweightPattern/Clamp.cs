/*********************************************************************
* FileName:    Clamp
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-10 Simple_ 22:49:26
* Description: 这是搬红砖的夹子
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
    class Clamp:AbstractTools
    {
        public override void Operation()
        {
            Console.WriteLine("我正在用夹子搬{0}",base.ProcessObject);
        }
    }
}
