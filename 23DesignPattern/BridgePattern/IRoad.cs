/*********************************************************************
* FileName:    IRoad
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-29 Simple_ 23:00:35
* Description: 马路接口
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
    interface IRoad
    {
        /// <summary>
        /// 桥接模式的接口获取或返回交通工具名称
        /// </summary>
        IVehicle VehicleName { get; set; }

        /// <summary>
        /// 交通工具的方法
        /// </summary>
        void Run();
    }
}
