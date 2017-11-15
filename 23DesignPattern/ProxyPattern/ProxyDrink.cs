/*********************************************************************
* FileName:    ProxyDrink
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-15 Simple_ 15:20:20
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

namespace ProxyPattern
{
    class ProxyDrink:IEat
    {
        Drink m_drink = new Drink();
        int m_iDrinkDepth;

        public ProxyDrink(int a_iDepth)
        {
            m_iDrinkDepth = a_iDepth;
        }

        public void Eat()
        {
            Ready();                                    // 喝前准备
            m_drink.Eat();                              // 开始喝水
            DrinkDepth();                               // 喝完反馈
        }

        private void DrinkDepth()
        {
            if(m_iDrinkDepth<=50)
                Console.WriteLine("还是有点渴");
            else if(m_iDrinkDepth<=80)
                Console.WriteLine("喝的正好");
            else
                Console.WriteLine("喝的有点涨啦");
        }

        private void Ready()
        {
            Console.WriteLine("我要准备一个杯子");
        }
    }
}
