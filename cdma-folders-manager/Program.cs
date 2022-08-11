using cdma_folders_manager.forms;
using cdma_folders_manager.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cdma_folders_manager
{
    internal static class Program
    {
        public static LocalService service = LocalService.getInstance();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            service.readLocalData();
            
            Application.Run(Layout.getInstance());
        }
    }
}
