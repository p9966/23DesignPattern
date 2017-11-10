/*********************************************************************
* FileName:    Frame
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-10 Simple_ 22:51:32
* Description: 搬瓷砖的框子
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
    class Frame:AbstractTools
    {
        public override void Operation()
        {
            Console.WriteLine("我正在用框子搬{0}",base.ProcessObject);
        }
    }
}
