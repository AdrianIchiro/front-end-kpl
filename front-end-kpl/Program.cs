using front_end_kpl.utils;
using front_end_kpl.view;
using frontEnd.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using front_end_kpl.view;

namespace front_end_kpl
{
    internal static class Program
    {
     
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //RoomGUI room = new RoomGUI();
            //Application.Run(room);

            Login login = new Login();
            Application.Run(login);
        }
    }
}