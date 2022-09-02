using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wolves_Login_Local
{
    static class Program
    {
        public static Login WL = new Login();
        public static PremiumAd PA = new PremiumAd();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            // Delete "Application.Run(PA);" to disable the starting ad
            Application.Run(PA);
            Application.Run(WL);
        }
    }
}
