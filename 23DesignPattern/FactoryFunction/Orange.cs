/*********************************************************************
* FileName:    Orange
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-23 Simple_ 23:52:18
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
    class Orange:IFruit
    {
        public void Print()
        {
            Console.WriteLine("大家好，我是橘子");
        }
    }

    class CreateOrange : ICreate
    {
        public IFruit CreateFruit()
        {
            return new Orange();
        }
    }

}
