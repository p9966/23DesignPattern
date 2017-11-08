/*********************************************************************
* FileName:    Program
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-08 Simple_ 20:37:28
* Description: 外观模式
*              需求分析一：假如我们现在需要准备去上班，上班之前我们需要起床，刷牙，吃早饭，最后上班
*              这时我们在客户端就需要new这些对象实例，会非常麻烦，现在我们只要将这些操作封装在外外观模式中即可
*             
*              需求分析二：将职责链模式封装在外观模式中，职责链模式的例子就以请假为例子
* Revision History----------------------------------------------------
* Author      MofityDate                Reason
* 
**********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacadePattern.GotoWorkFlow;
using FacadePattern.AskForLeave;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 起床上班
            FacadeGotoWork l_gotoWorking = new FacadeGotoWork();
            l_gotoWorking.GotoWorking();

            // 请假
            FacadeAskForLeave l_askForLeave = new FacadeAskForLeave();
            l_askForLeave.AskForLeave(20, "小小");
            Console.ReadKey();
        }
    }
}
