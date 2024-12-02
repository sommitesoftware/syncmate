using DevExpress.Skins;
using DevExpress.UserSkins;
using SyncMate_Client.Forms.Special;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SyncMate_Client
{
    internal static class Program
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
