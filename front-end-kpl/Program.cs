using front_end_kpl.view;
using frontEnd.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace front_end_kpl
{
    internal static class Program
    {
     
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            AppoimentManagement appoimentManagement

                = new AppoimentManagement();
            Application.Run(appoimentManagement);
        }
    }
}