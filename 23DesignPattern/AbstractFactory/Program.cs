/*********************************************************************
* FileName:    Program
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-25 Simple_ 22:50:22
* Description: 抽象工厂设计模式
*              需求分析:有一个造车厂,分别制造汽车的车轮和车窗，利用抽象工厂设计模式完成。
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
    class Program
    {
        static void Main(string[] args)
        {
            // 创建一个奔驰车的车轮和车窗
            ICreateProduct l_createBenzProduct = new CreateBnezProduct();
            IWindow l_benzWindow = l_createBenzProduct.CreateWindow();
            IWheel l_benzWeel = l_createBenzProduct.CreateWheel();
            l_benzWeel.Wheel();
            l_benzWindow.Window();

            // 创建一个宝马车的车轮
            IWheel l_bmwWheel = new CreateBmwProduct().CreateWheel();
            l_bmwWheel.Wheel();
            Console.ReadKey();
        }
    }
}
