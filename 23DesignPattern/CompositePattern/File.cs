/*********************************************************************
* FileName:    File
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-02 Simple_ 21:42:17
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

namespace CompositePattern
{
    class File:AbstractFiles
    {
        public File(string a_strName, double a_iSize) : base(a_strName) {
            base.FileSize = a_iSize;
        }

        public override double GetFileSize()
        {
            return FileSize;
        }

        public override void KillVirs()
        {
            Console.WriteLine("正在对文件:{0}进行杀毒，该文件的大小为:{1}k",base.Name,base.FileSize);
        }
    }
}
