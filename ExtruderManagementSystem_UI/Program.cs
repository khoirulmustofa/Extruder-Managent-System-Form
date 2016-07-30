using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtruderManagementSystem_UI.Extruder;
using ExtruderManagementSystem_UI.Report;
using ExtruderManagementSystem_UI.Spec_System;


namespace ExtruderManagementSystem_UI
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
            Application.Run(new FormLogin());
            //FormPopUpKodeDies

            //FormLogin
        }
    }
}
