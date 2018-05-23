using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity.EntityFramework;
using Entity.Entities;

namespace WinFormsUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //"DefaultDbConnection"
            var context = new ApplicationDbContext();
            if (!context.Database.Exists())
            {
                context.Database.Initialize(true);
            }          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            //Application.Run(new MainForm());
        }
    }
}
