/*********************************************************************
* FileName:    Program
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-22 Simple_ 22:58:32
* Description: 职责链模式
*              现在我们去旅游如果钱<2000我们坐船 如果钱<5000我们坐高铁，如果钱<10000我们坐飞机 否则我们租车自驾游
* Revision History----------------------------------------------------
* Author      MofityDate                Reason
* 
**********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // 初始化旅游
            Travel l_travelChengDu = new Travel();
            l_travelChengDu.Money = 6000;
            l_travelChengDu.Destination = "成都";

            // 初始化交通工具
            Vehicle l_velBoat = new Boat();                                 // 小船
            l_velBoat.VehicleName = "小船";
           
            Vehicle l_velBulletTrain = new BulletTrain();                   // 动车
            l_velBulletTrain.VehicleName = "动车";
            
            Vehicle l_velAirCraft = new Aircraft();                         // 飞机
            l_velAirCraft.VehicleName = "飞机";
            
            // 为各个交通工具设置上级交通工具
            l_velBoat.NextVehicle = l_velBulletTrain;
            l_velBulletTrain.NextVehicle = l_velAirCraft;

            // 开始调用交通工具，从最便宜的小船开始
            l_velBoat.Process(l_travelChengDu);

            Console.ReadKey();
        }
    }
}
