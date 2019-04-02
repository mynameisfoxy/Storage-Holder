﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageHolder
{
    enum FileTypes
    {
        File = 0,
        Folder = 1,
        Text = 2,
        Music = 3,
        Document = 4,
        PDF = 5,
        Image = 6,
        URL = 7,
        Archive = 8
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LogInForm());
            Application.Run(new WorkDirectioryForm());
        }
    }
}