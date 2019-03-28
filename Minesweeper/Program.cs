using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        public static int fertig = 0;
        public static int richtigB = 0;
        public static int B_Size = 25;
        public static int grigsize = 10;
        public static int bomben = 0;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while (true) {
                Application.Run(new Einstellungen());
                Application.Run(new Form1());
            }
        }
    }
}
