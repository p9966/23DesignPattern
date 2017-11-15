/*********************************************************************
* FileName:    ProxyEat
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-15 Simple_ 15:15:22
* Description: 吃饭的代理模式
*
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
    class ProxyEat:IEat
    {
        private int m_iPercent;
        IEat m_eat = new Eat();
        public ProxyEat(int a_iEatPercent)
        {
            m_iPercent = a_iEatPercent;
        }

        public void Eat()
        {
            Ready();                                    // 喝前准备
            m_eat.Eat();                                // 开始喝水
            EatDepth();                                 // 喝完反馈
            
        }

        private void EatDepth()
        {
            if(m_iPercent<=50)
                Console.WriteLine("还是有点饿");
            else if(m_iPercent<=80)
                Console.WriteLine("八分饱");
            else
                Console.WriteLine("吃的好饱啊");
        }

        private void Ready()
        {
            Console.WriteLine("我要准备一个碗");
        }
    }
}
