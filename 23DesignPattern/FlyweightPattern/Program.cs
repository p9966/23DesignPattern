/*********************************************************************
* FileName:    Program
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-10 Simple_ 22:32:33
* Description: 享元模式
*              个人理解：
*              假如一个人在重复做着一件事（搬砖），搬着不同的砖块需要不同的工具
*              比如搬普通的红砖需要一个夹子，搬瓷砖需要一个框子，搬大理石需要推车，这时假
*              如我们搬的是红砖，我们先在我们的工具箱里面找是否有夹子，如果有我们就用夹子
*              搬红砖，如果没有我们就去商场买一个夹子再搬，如果现在我们搬的是大理石，我们
*              也是先从我们的仓库找是否有推车，如果有就用推车否则我们就去商场买一个然后用
*              买到的推车继续搬大理石，依此类推，这样就避免了每次我们搬不同的产品都去商场
*              买对应的工具从而加大开销。享元模式就是由此诞生。避免每次都去new()对象从而
*              加大内存的开销
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
    class Program
    {
        static void Main(string[] args)
        {
            // 现在我们需要运输大理石，我们选一个推车吧
            AbstractTools l_Tools = FlyweightToolsFactory.GetTools("推车");
            l_Tools.ProcessObject = "大理石";
            l_Tools.Operation();

            // 现在我们再用推车搬运红砖吧
            AbstractTools l_Cart = FlyweightToolsFactory.GetTools("推车");
            l_Cart.ProcessObject = "红砖";
            l_Cart.Operation();

            // 我们再判断l_Tools 和 l_Cart的类型是否相同
            Console.WriteLine(object.Equals(l_Cart,l_Tools));
            Console.ReadKey();
        }
    }
}
