/*********************************************************************
* FileName:    StreetWay
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-29 Simple_ 23:05:09
* Description: 马路：市区街道
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
    class StreetWay:IRoad
    {
        public IVehicle VehicleName
        {
            get;
            set;
        }

        public void Run()
        {
            Console.WriteLine("{0}在市区街道上行驶",VehicleName.GetVehicleName());
        }
    }
}
