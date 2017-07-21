using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TRASY._System;
using TRASY.Referentials;

namespace TRASY
{
    static class Program
    {
        public static DataAccess da;
        public static users_info user;
        [STAThread]
        static void Main()
        {

            da = new DataAccess();
            user = new users_info();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
