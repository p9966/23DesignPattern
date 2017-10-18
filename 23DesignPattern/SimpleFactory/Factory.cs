/*********************************************************************
* FileName:    Factory
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-19 Simple_ 00:07:02
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
    class Factory
    {
        /// <summary>
        /// 创建水果
        /// </summary>
        /// <param name="a_strFruitName">水果名称</param>
        /// <returns></returns>
        public static IFruit Create(string a_strFruitName)
        {
            IFruit l_fruit;
            switch (a_strFruitName)
            {
                case "apple":
                    l_fruit = new Apple();
                    break;
                case "banana":
                    l_fruit = new Banana();
                    break;
                case "orange":
                    l_fruit = new Orange();
                    break;
                default:
                    l_fruit = new Apple();
                    break;
            }
            return l_fruit;
        }
    }
}
