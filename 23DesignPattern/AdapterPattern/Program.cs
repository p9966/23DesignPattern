/*********************************************************************
* FileName:    Program
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-10-19 Simple_ 21:46:06
* Description: 适配器模式
*           　　这里，我假设家用功率为 220v，经过适配器，输出为 18v，可供我的笔记本进行使用。 
*                 类适配器：
*           　　　　Portal（入口） 类：只有一个方法 Input()，来表示输入的电流功率。
*                 IOutput（输出）接口：只有一个方法 Output()，来表示经过转换后输出的电流功率。
*　　              Adapter（适配器）类：实现了 IOutput 接口
* 
*
* Revision History----------------------------------------------------
* Author      MofityDate                Reason
* 
**********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdapterPattern.ClassAdapter;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IOutput l_outPut = new Adapter("220V");
            l_outPut.OutPut();

            Console.ReadKey();
        }
    }
}
