/*********************************************************************
* FileName:    AbstractDecorator
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-06 Simple_ 22:04:00
* Description: 装饰者抽象层
*
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
    abstract class AbstractDecorator:AbstractPhone
    {
        // 装饰者必须得到被装饰的对象
        private AbstractPhone m_absPhone;
        public AbstractDecorator(AbstractPhone a_absPhone)
        {
            m_absPhone = a_absPhone;
        }

        public override void IntrodeuceOneself()
        {
            if (m_absPhone != null)
                m_absPhone.IntrodeuceOneself();
        }
    }
}
