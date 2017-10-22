/*********************************************************************
* FileName:    Travel
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-22 Simple_ 23:00:38
* Description: 旅游类
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
    class Travel
    {
        /// <summary>
        /// 旅游的资金
        /// </summary>
        public double Money { get; set; }

        /// <summary>
        /// 旅游的目的地
        /// </summary>
        public string Destination { get; set; }
    }
}
