/*********************************************************************
* FileName:    Boat
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-22 Simple_ 23:08:15
* Description: 交通工具：船
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
    class Boat:Vehicle
    {
        public override void Process(Travel a_travel)
        {
            if (a_travel.Money < 2000)
            {
                Console.WriteLine(Const.m_ctStrProceeMsg, base.VehicleName, a_travel.Destination);
            }
            else
            {
                // 当用户的资金无法满足该交通工具后
                base.NextVehicle.Process(a_travel);
            }
        }
    }
}
