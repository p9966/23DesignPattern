/*********************************************************************
* FileName:    Program
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-18 Simple_ 23:59:22
* Description: 《简单工厂设计模式》
*              需求分析：假设我为水果店开发一个小系统，当用户输入指定水果就返回该水果的实例
*              用简单工厂设计模式设计
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
    class Program
    {
        static void Main(string[] args)
        {
            // 苹果
            IFruit l_apple = Factory.Create("apple");
            l_apple.IntroduceOneSelf();

            // 橘子
            IFruit l_orange = Factory.Create("orange");
            l_orange.IntroduceOneSelf();

            // 香蕉
            IFruit l_banana = Factory.Create("banana");
            l_banana.IntroduceOneSelf();
            Console.ReadKey();
        }
    }
}
