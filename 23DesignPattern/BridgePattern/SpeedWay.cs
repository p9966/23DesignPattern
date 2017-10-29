/*********************************************************************
* FileName:    SpeedWay
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-29 Simple_ 23:03:52
* Description: 马路：高速公路
*
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
    class SpeedWay:IRoad
    {
        public IVehicle VehicleName
        {
            get;
            set;
        }

        public void Run()
        {
            Console.WriteLine("{0}在高速公路上行驶",VehicleName.GetVehicleName());
        }
    }
}
