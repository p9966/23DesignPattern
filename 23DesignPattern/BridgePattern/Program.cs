/*********************************************************************
* FileName:    Program
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-29 Simple_ 22:53:57
* Description: 《桥接模式》
*               需求分析：交通工具在马路上行驶
*              按照个人经验，现在我们需要选择一个变化里最多的类别（交通工具肯定比马路多）
*              所以，我们就选择在变化量比较少的哪一个类别中（马路）架一座桥梁，让两个类别
*              能够连接起来
* Revision History----------------------------------------------------
* Author      MofityDate                Reason
* 
**********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 公共汽车在市区街道上面行驶
            IVehicle l_bus = new Bus();
            IRoad l_road = new StreetWay();
            l_road.VehicleName = l_bus;
            l_road.Run();

            // 公共汽车在高速公路上面行驶
            IRoad l_speedWay = new SpeedWay();
            l_speedWay.VehicleName = l_bus;
            l_speedWay.Run();
            Console.ReadKey();
        }
    }
}
