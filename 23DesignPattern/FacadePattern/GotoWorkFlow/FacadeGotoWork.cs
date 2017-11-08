/*********************************************************************
* FileName:    FacadeGotoWork
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-08 Simple_ 20:53:49
* Description: 外观模式，执行所有上班之前的所有流程
*
* Revision History----------------------------------------------------
* Author      MofityDate                Reason
* 
**********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern.GotoWorkFlow
{
    class FacadeGotoWork
    {
        #region Variable
        GetUp m_getUp = new GetUp();                                    // 起床
        BrushTeeth m_brushTeeth = new BrushTeeth();                     // 刷牙
        EatBreakfast m_eatBreakFast = new EatBreakfast();               // 吃早饭
        GotoWork m_gotoWork = new GotoWork();
        #endregion

        public void GotoWorking()
        {
            m_getUp.Get();
            m_brushTeeth.Brush();
            m_eatBreakFast.Eat();
            m_gotoWork.StartWork();
        }
    }
}
