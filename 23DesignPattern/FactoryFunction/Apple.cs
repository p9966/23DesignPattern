/*********************************************************************
* FileName:    Apple
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-23 Simple_ 23:51:10
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
    class Apple:IFruit
    {
        public void Print()
        {
            Console.WriteLine("大家好我是苹果");
        }
    }

    class CreateApple : ICreate
    {
        public IFruit CreateFruit()
        {
            return new Apple();
        }
    }

}
