/*********************************************************************
* FileName:    Program
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-23 Simple_ 23:47:06
* Description: 工厂方法模式
*              需求分析：假设我为水果店开发一个小系统，用户需要什么水果就可以创建该水果的实例
* Revision History----------------------------------------------------
* Author      MofityDate                Reason
* 
**********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            IFruit l_createApple = new CreateApple().CreateFruit();
            l_createApple.Print();

            IFruit l_createOrange = new CreateOrange().CreateFruit();
            l_createOrange.Print();
            Console.ReadKey();
        }
    }
}
