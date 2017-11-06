/*********************************************************************
* FileName:    Sticker
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-06 Simple_ 22:07:54
* Description: 具体的装饰者：为手机贴膜
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
    class Sticker:AbstractDecorator
    {
        public Sticker(AbstractPhone a_absPhone) : base(a_absPhone) { }

        public override void IntrodeuceOneself()
        {
            base.IntrodeuceOneself();
            AddSticker();
        }

        private void AddSticker()
        {
            Console.WriteLine("已经贴上钢化膜");
        }
    }
}
