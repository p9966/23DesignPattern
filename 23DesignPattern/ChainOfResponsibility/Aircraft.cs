/*********************************************************************
* FileName:    Aircraft
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-22 Simple_ 23:15:30
* Description: 交通工具：飞机
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
    class Aircraft:Vehicle
    {
        public override void Process(Travel a_travel)
        {
            if (a_travel.Money < 10000)
            {
                Console.WriteLine(Const.m_ctStrProceeMsg, base.VehicleName, a_travel.Destination);
            }
            else
            {
                Console.WriteLine("咱们就是有钱，咱们租车自驾游去！");
            }
        }
    }
}
