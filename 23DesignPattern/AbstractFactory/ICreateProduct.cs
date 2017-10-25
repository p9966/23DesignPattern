/*********************************************************************
* FileName:    ICreateProduct
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-25 Simple_ 22:54:11
* Description: 抽象工厂，创建指定品牌的车轮和车窗
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
    interface ICreateProduct
    {
        /// <summary>
        ///  创建车窗
        /// </summary>
        /// <returns></returns>
        IWindow CreateWindow();
        
        /// <summary>
        /// 创建车轮
        /// </summary>
        /// <returns></returns>
        IWheel CreateWheel();
    }
}
