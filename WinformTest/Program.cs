﻿using BMap.Core.Model;
using BMap.WinForm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformTest
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Test();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static void Test()
        {
            //PointInt lineA = new PointInt(0, 0);
            //PointInt lineB = new PointInt(10, 10);
            //PointInt pM = new PointInt(2, 1);
            //var n = BMap.Core.MapHelper.JudgePointToLine(lineA, lineB, pM);
            var imgPath = "Map\\12\\3336\\1775.jpg";
            var bs =File.ReadAllBytes(imgPath);
            
            
            DateTime dt = DateTime.Now;
            for (int i = 0; i < 100; i++)
            {
                var img = ImageHelper.BytesToImage(bs);
                //var img = Image.FromFile(imgPath);
                //Bitmap bm = new Bitmap(imgPath);
            }

            var ts = DateTime.Now - dt;
        }
    }
}
