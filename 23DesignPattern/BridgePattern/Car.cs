/*********************************************************************
* FileName:    Car
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-29 Simple_ 23:03:13
* Description: 交通工具：小轿车
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
    class Car:IVehicle
    {
        public string GetVehicleName()
        {
            return "小轿车";
        }
    }
}
