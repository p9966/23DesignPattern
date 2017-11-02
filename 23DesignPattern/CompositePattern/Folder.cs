/*********************************************************************
* FileName:    Mp
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-02 Simple_ 21:35:40
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
    class Folder:AbstractFiles
    {
        List<AbstractFiles> m_lstFiles = new List<AbstractFiles>();
        public Folder(string a_strFileName) : base(a_strFileName) { }
        
        public override double GetFileSize()
        {
            double m_iTotalSize = 0;
            foreach (var item_file in m_lstFiles)
            {
                m_iTotalSize += item_file.GetFileSize();
            }
            return m_iTotalSize;
        }

        public override void KillVirs()
        {
            foreach (var item_file in m_lstFiles)
            {
                item_file.KillVirs();
            }
        }

        public void Add(AbstractFiles a_absFile)
        {
            m_lstFiles.Add(a_absFile);
        }

        public void Remove(AbstractFiles a_absFile)
        {
            m_lstFiles.Remove(a_absFile);
        }
    }
}
