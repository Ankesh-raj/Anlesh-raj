using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementEntityy;
using HospitalManagementDAL;
using HospitalManagementBLL;

namespace HospitalManagementSystem
{
    public class PatientPL
    {
       
        public void PatientLogin()
        {
            PatientPL patientPLObj = new PatientPL();
            string PatientEmail;
            string PatientPassword;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Email :");
            PatientEmail = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Password :");
            PatientPassword = Console.ReadLine();
            
            PatientBLL patientBLLObj = new PatientBLL();

            bool flag = patientBLLObj.PatientLogin(PatientEmail, PatientPassword);
            if (flag)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Logged in Successfully");
                patientPLObj.PatientSection();
               

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry Try Again");
            }

        }

        public void BookAppointment()
        {
            Patient patient = new Patient();
            Console.WriteLine("Enter patient details");
            Console.Write(" Enter the Patient Id :");
            patient.PatientId = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter the Patient Name :");
            patient.PatientName = Console.ReadLine();
            Console.Write(" Enter the Doctor Name :");
            patient.PatientEmail = Console.ReadLine();
            Console.Write("Enter the Patient Password :");
            patient.PatientPassword = Console.ReadLine();
            PatientBLL patientBLLObj = new PatientBLL();
            string msg = patientBLLObj.AddPatientBLL(patient);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);

        }
        public void ViewAppointment()
        {

        }
        public  void DeleteAppointment()
        {

        }
        public void ViewBillReport()
        {

        }
        public void PatientSection()
        {
            PatientPL patientPLObj = new PatientPL();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Welcome to Patient Section");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press 1 to Book Appoinment");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press 2 to View Appointment");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press 3 to Delete Appointment");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press 4 to View Prescription Report");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press 5 to logout");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    patientPLObj.BookAppointment();

                    break;
                case 2:
                    patientPLObj.ViewAppointment();
                    break;
                case 3:
                    patientPLObj.DeleteAppointment();
                    break;
                case 4:
                    patientPLObj.ViewBillReport();
                    break;
                case 5:

                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("invalid code");
                    break;


            }
        }

        public void AddPatient()
        {
            Patient patient = new Patient();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter patient details");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Patient Id :");
            Console.ForegroundColor = ConsoleColor.Blue;
            patient.PatientId = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Patient Name :");
            patient.PatientName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Patient Email :");
            patient.PatientEmail = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Patient Password :");
            patient.PatientPassword = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            PatientBLL patientBLLObj = new PatientBLL();
            string msg = patientBLLObj.AddPatientBLL(patient);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);



        }

        public void UpdatePatient()
        {
            Patient patient = new Patient();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter patient details");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Patient Id :");
            patient.PatientId = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Patient Name :");
            patient.PatientName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Patient Email :");
            patient.PatientEmail = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Patient Password :");
            patient.PatientPassword = Console.ReadLine();
            PatientBLL patientBLLObj = new PatientBLL();
            string msg = patientBLLObj.UpdatePatientBLL(patient);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);

        }

        public void GetAllPatient()
        {
            PatientBLL patientBLLObj = new PatientBLL();
            List<Patient> patients= patientBLLObj.GetAllPatientBLL();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-------------------------------PatientsList----------------------------");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--Id-----------Name--------Email-------------------Password---------");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-------------------------------------------------------------------------");
            foreach (var item in patients)
            {

                Console.WriteLine("  " + item.PatientId + " \t" + item.PatientName.PadLeft(10) + " \t" + item.PatientEmail.PadLeft(8) + " \t" + item.PatientPassword.PadLeft(16));

            }

        }

        public void RemovePatient()
        {
            PatientBLL patientBLLObj = new PatientBLL();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter patient Details");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Patient Id :");
            int PatientId = Convert.ToInt32(Console.ReadLine());
            
            string msg = patientBLLObj.RemovePatientBLL(PatientId);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
            Console.Read();


        }
        public bool AdminPatientSection()
        {
            bool flag1 = true;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome-to Patient-Section");
            int codeentered;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press 1 to add a Patient");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press 2 to update a Patient");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press 3 to delete a Patient");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press 4 to show all Patient");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press 5 to exit");
            Console.ForegroundColor = ConsoleColor.White;
            codeentered = Convert.ToInt32(Console.ReadLine());
            PatientPL patientObj1 = new PatientPL();
            switch (codeentered)
            {
                case 1:

                    patientObj1.AddPatient();

                    break;

                case 2:
                    patientObj1.UpdatePatient();

                    break;
                case 3:
                    patientObj1.RemovePatient();

                    break;
                case 4:
                    patientObj1.GetAllPatient();

                    break;
                case 5:

                    flag1 = false;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("invalid input");
                    break;

            }

            return flag1;


        }
    }
}
