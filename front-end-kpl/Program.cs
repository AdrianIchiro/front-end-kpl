using AppointmentApp;
using frontEnd.view;
<<<<<<< HEAD
using front_end_kpl.view;
namespace front_end_kpl
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontEnd
>>>>>>> c67254def3c1ba76678262be742b0d14caef14a9
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
            AppoimentManagement appoimentManagement = new AppoimentManagement();
<<<<<<< HEAD
            MedicalCheckupForm medicalCheckupForm = new MedicalCheckupForm();
            Application.Run(medicalCheckupForm);
=======
            //  _ = form2.LoadAppointmentsAsync(); // Memanggil metode LoadAppointmentsAsync
          
            Application.Run(appoimentManagement);
>>>>>>> c67254def3c1ba76678262be742b0d14caef14a9
        }
    }
}
