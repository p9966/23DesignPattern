/*********************************************************************
* FileName:    Orange
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-19 Simple_ 00:06:09
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

namespace SimpleFactory
{
    class Orange:IFruit
    {
        public void IntroduceOneSelf()
        {
            Console.WriteLine("您好，我是橘子");
        }
    }
}
