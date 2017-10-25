/*********************************************************************
* FileName:    CreateBnezProduct
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-25 Simple_ 23:00:03
* Description: 创建奔驰车产品的工厂
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
    class CreateBnezProduct:ICreateProduct
    {
        public IWindow CreateWindow()
        {
            return new BenzWindow();
        }

        public IWheel CreateWheel()
        {
            return new BenzWheel();
        }
    }
}
