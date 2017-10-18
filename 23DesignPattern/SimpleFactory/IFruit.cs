/*********************************************************************
* FileName:    Fruit
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-19 Simple_ 00:01:58
* Description: 水果实例的接口
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
    interface IFruit
    {
        /// <summary>
        /// 水果的描述
        /// </summary>
        void IntroduceOneSelf();
    }
}
