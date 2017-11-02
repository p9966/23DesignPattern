/*********************************************************************
* FileName:    AbstractFiles
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-02 Simple_ 21:30:36
* Description: 所有文件和文件夹的抽象层
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
    abstract class AbstractFiles
    {
        public string Name { get; set; }                                    // 文件名称
        public double FileSize { get; set; }                                // 文件大小

        public AbstractFiles(string a_strName) {
            this.Name = a_strName;
        }

       public abstract double GetFileSize();                                // 获取文件大小
       public abstract void KillVirs();                                     // 文件杀毒
    }
}
