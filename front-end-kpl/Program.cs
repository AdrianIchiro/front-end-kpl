using front_end_kpl.utils;
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


            
           

            Doctor doctor = new Doctor();
            doctor.id = 2;
            doctor.firstName = "kevin";
            doctor.lastName = "Albany";
            doctor.specialization = "string";
            doctor.address = "bogor";
            doctor.phoneNumber = "082367837542";
            doctor.email = "kevin.junaidi@gmail.com";

            MyAppoiment myAppoiment = new MyAppoiment(doctor);
            Application.Run(myAppoiment);
        }
    }
}