/*********************************************************************
* FileName:    Vehicle
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-22 Simple_ 23:04:47
* Description: 交通工具
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
    abstract class Vehicle
    {
        /// <summary>
        /// 交通工具名称
        /// </summary>
        public string VehicleName { get; set; }

        /// <summary>
        /// 当用户的钱无法满足该交通工具时，将调用下一个交通工具来执行
        /// </summary>
        public Vehicle NextVehicle { get; set; }

        /// <summary>
        /// 交通工具，判断处理类
        /// </summary>
        /// <param name="a_travel"></param>
        public abstract void Process(Travel a_travel);
    }
}
