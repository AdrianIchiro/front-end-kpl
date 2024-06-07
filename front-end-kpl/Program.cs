using frontEnd.view;
using front_end_kpl.view;
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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            AppoimentManagement appoimentManagement = new AppoimentManagement();
            MedicalCheckupForm medicalCheckupForm = new MedicalCheckupForm();
            Application.Run(medicalCheckupForm);
        }
    }
}