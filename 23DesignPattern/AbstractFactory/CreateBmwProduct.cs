/*********************************************************************
* FileName:    CreateBmwProduct
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-25 Simple_ 22:57:31
* Description: 宝马产品的车窗和车轮工厂
*
* Revision History----------------------------------------------------
* Author      MofityDate                Reason
* 
**********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class CreateBmwProduct:ICreateProduct
    {
        public IWindow CreateWindow()
        {
            return new BmwWindow();
        }

        public IWheel CreateWheel()
        {
            return new BmwWheel();
        }
    }
}
