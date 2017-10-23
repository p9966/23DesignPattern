/*********************************************************************
* FileName:    ICreate
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-23 Simple_ 23:50:32
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

namespace FactoryFunction
{
    interface ICreate
    {
        IFruit CreateFruit();
    }
}
