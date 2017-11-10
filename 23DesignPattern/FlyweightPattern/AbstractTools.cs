/*********************************************************************
* FileName:    AbstractTools
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-10 Simple_ 22:45:56
* Description: Love life, love programming
*
* Revision History----------------------------------------------------
* Author      MofityDate                Reason
* 
**********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyweightPattern
{
    abstract class AbstractTools
    {
        public string ProcessObject { get; set; }

        public abstract void Operation();
    }
}
