/*********************************************************************
* FileName:    IVehicle
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-29 Simple_ 22:59:12
* Description: 交通工具接口
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
    interface IVehicle
    {
        /// <summary>
        /// 获取交通工具名称
        /// </summary>
        /// <returns></returns>
        string GetVehicleName();
    }
}
