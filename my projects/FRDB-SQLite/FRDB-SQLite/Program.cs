﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FRDB_SQLite.GUI;

namespace FRDB_SQLite
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
