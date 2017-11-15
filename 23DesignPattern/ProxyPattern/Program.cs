/*********************************************************************
* FileName:    Program
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-15 Simple_ 15:06:19
* Description: 《代理模式》
*               理解：代理模式就是给某一个对象提供一个代理，并由代理对象控制对原对象的引用。
*               需求分析：就以我们平时生活中为例子吧，我们都知道我们喝水需要杯子，吃饭需要碗
*               喝完吃完之后再反馈喝或吃的怎么样是饱了还是半饱。现在我们就以代理模式来演示这
*               个例子。
* Revision History----------------------------------------------------
* Author      MofityDate                Reason
* 
**********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 现在我准备吃60粒米饭
            IEat l_eat = new ProxyEat(60);
            l_eat.Eat();

            // 现在我准备喝80口水
            IEat l_drink = new ProxyDrink(80);
            l_drink.Eat();
            Console.ReadKey();
        }
    }
}
