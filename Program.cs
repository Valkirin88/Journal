﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
<<<<<<< Updated upstream
	// 12 часовой рабочий день
=======
	// 12 часовой рабочий день 7 дней в неделю
	// новая ветка ISO
    // изменение 2 ANV
>>>>>>> Stashed changes
        }
    }
}
