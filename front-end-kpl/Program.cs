<<<<<<< HEAD
using front_end_kpl.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

=======
>>>>>>> cc51ae77958e7cbe714ba018ee5844b7cf332c31
namespace front_end_kpl
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
<<<<<<< HEAD
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

 
            MedicalCheckupForm medicalCheckupForm = new MedicalCheckupForm();
            medicalCheckupForm.GetAppoimentPatient(1);
            Application.Run(medicalCheckupForm);
=======
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Specialization());
>>>>>>> cc51ae77958e7cbe714ba018ee5844b7cf332c31
        }
    }
}