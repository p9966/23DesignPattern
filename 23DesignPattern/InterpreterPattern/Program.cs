/*********************************************************************
* FileName:    Program
* Tables:      nothing
* Author:      Simple
* CreateDate:  2018-02-23 Simple_ 19:22:03
* Description: 《解释器模式》
*               需求分析:开发一个加减法计算器
* Revision History----------------------------------------------------
* Author      MofityDate                Reason
* 
**********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Compute l_cmp = new Compute();
            l_cmp.Build("15 + 9 + 4 - 3");
            Console.WriteLine(l_cmp.GetResult());
            Console.ReadKey();
        }
    }
}
