/*********************************************************************
* FileName:    Program
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-06 Simple_ 21:55:39
* Description: 装饰者模式
*              需求分析：假如我们是手机制造商，我们会生产苹果手机和荣誉手机
*              当手机生产完毕后客户突然说需要在手机上面添加一个钢化玻璃膜这
*              时我们利用装饰者模式来完成该项目
* Revision History----------------------------------------------------
* Author      MofityDate                Reason
* 
**********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecroatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractPhone l_iphone = new IPhone();
            l_iphone.IntrodeuceOneself();

            // 这是用户提需求说要在荣耀手机上面添加一块钢化模
            // 这是我们需要创建一个装饰者类
            AbstractPhone l_absHonor = new Honor();
            AbstractDecorator l_absStickToHonor = new Sticker(l_absHonor);
            l_absStickToHonor.IntrodeuceOneself();
            Console.ReadKey();
        }
    }
}
