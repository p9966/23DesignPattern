/*********************************************************************
* FileName:    Bus
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-29 Simple_ 23:02:36
* Description: 交通工具：公共汽车
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
    class Bus:IVehicle
    {
        public string GetVehicleName()
        {
            return "公共汽车";
        }
    }
}
