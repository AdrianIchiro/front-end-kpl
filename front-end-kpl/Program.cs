using AppointmentApp;
using frontEnd.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using front_end_kpl.view;


namespace frontEnd
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
            Login login = new Login();
            //  _ = form2.LoadAppointmentsAsync(); // Memanggil metode LoadAppointmentsAsync
          
            Application.Run(login);
        }
    }
}
