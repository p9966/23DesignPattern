/*********************************************************************
* FileName:    BulletTrain
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-22 Simple_ 23:13:37
* Description: 交通工具：动车
*
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
    class BulletTrain:Vehicle
    {
        public override void Process(Travel a_travel)
        {
            if (a_travel.Money < 5000)
            {
                Console.WriteLine(Const.m_ctStrProceeMsg, base.VehicleName, a_travel.Destination);
            }
            else
            {
                base.NextVehicle.Process(a_travel);
            }
        }
    }
}
