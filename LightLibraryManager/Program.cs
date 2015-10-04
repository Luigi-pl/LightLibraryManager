using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LightLibraryManager.View;

namespace LightLibraryManager
{
    static class Program
    {
        /// <summary>
        /// Główna pętla programu.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoadingWindow());
        }
    }
}
