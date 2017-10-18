/*********************************************************************
* FileName:    Apple
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-19 Simple_ 00:04:37
* Description: 苹果
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
    /// <summary>
    /// 苹果
    /// </summary>
    class Apple:IFruit
    {
        public void IntroduceOneSelf()
        {
            Console.WriteLine("您好，我是苹果");
        }
    }
}
