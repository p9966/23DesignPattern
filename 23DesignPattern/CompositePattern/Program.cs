/*********************************************************************
* FileName:    Program
* Tables:      nothing
* Author:      Simple
* CreateDate:  2017-11-02 Simple_ 21:25:47
* Description: 组合模式
*              需求分析：现在我们开发一个文件管理系统，
*              最后我们会计算出所有文件的总大小，和对
*              所有文件进行杀毒
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
    class Program
    {
        static void Main(string[] args)
        {
            // 创建一个总的文件系统
            Folder l_absFileSys = new Folder("文件系统");

            // 创建一个音乐文件夹
            Folder l_folMp3 = new Folder("Mp3文件");

            // 创建一个文档文件夹
            Folder l_folDoc = new Folder("文档文件夹");

            // 创建音乐文件
            File l_fileDaoXiang = new File("稻香.mp3", 3000);
            File l_fileQingHuaCi = new File("青花瓷", 4000);

            // 创建文档文件
            File l_fileDoc = new File("评审.doc", 10);
            File l_fileTxt = new File("demo.txt", 50);

            // 装包文档
            l_folDoc.Add(l_fileTxt);
            l_folDoc.Add(l_fileDoc);

            // 装包音乐
            l_folMp3.Add(l_fileDaoXiang);
            l_folMp3.Add(l_fileQingHuaCi);

            // 将文件夹装包到文件系统
            l_absFileSys.Add(l_folMp3);
            l_absFileSys.Add(l_folDoc);

            // 对文件系统进行杀毒
            l_absFileSys.KillVirs();

            // 获取所有文件的大小
            double l_iTotalSize = l_absFileSys.GetFileSize();
            Console.WriteLine("文件总大小为{0}",l_iTotalSize);
            Console.ReadKey();
        }
    }
}
