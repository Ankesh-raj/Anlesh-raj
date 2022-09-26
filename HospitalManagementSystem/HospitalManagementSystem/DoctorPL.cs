using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementBLL;
using HospitalManagementEntityy;


namespace HospitalManagementSystem
{
    public class DoctorPL
    { 
         
        public void DoctorLogin()
        {
            DoctorPL doctorPLObj = new DoctorPL();
            string DoctorEmail;
            string DoctorPassword;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" Enter the Email id  :");
            DoctorEmail = Console.ReadLine();
            Console.Write(" Enter the Password :");
            DoctorPassword = Console.ReadLine();

            DoctorBLL doctorBLLObj = new DoctorBLL();

            bool flag = doctorBLLObj.DoctorLogin(DoctorEmail, DoctorPassword);
            if (flag)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Logged in Successfully as Doctor");
                doctorPLObj.DoctorSection();


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid credentials");
            }
        }
        public void DoctorSection()
        {
            DoctorPL doctorPLObj = new DoctorPL();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to Doctor Section");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press 1 to View  Appoinment");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press 2 to Accept Appointment");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press 3 to Delete Appointment");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press 4 to View Prescription Report");
            Console.WriteLine("Press 5 to logout");
            int codeentered = Convert.ToInt32(Console.ReadLine());
            switch (codeentered)
            {
                case 1:
                    doctorPLObj.ViewAppoinment();

                    break;
                case 2:
                    doctorPLObj.AcceptAppointment();
                    break;
                case 3:
                    doctorPLObj.RejectAppointment();
                    break;
                case 4:
                    doctorPLObj.GivePrescription();
                    break;
                case 5:

                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("invalid code");
                    break;

            }
        }

        public void ViewAppoinment()
        {
            
        }

        public void AcceptAppointment()
        {

        }

        public void RejectAppointment()
        {

        }
        public void GivePrescription()
        {

        }


        public void AddDoctor()
        {
            Doctor doctor = new Doctor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter Doctor details");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Doctor Id :");
            doctor.DoctorId = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Doctor Name :");
            doctor.DoctorName = Console.ReadLine();
            Console.Write("Doctor Email :");
            Console.ForegroundColor = ConsoleColor.Blue;
            doctor.DoctorEmail = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Doctor Password :");
            doctor.DoctorPassword = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Doctor Speciality :");
            doctor.DoctorSpeciality = Console.ReadLine();

            DoctorBLL doctorBLLObj = new DoctorBLL();
            string msg = doctorBLLObj.AddDoctorBLL(doctor);

            Console.WriteLine(msg);

        }

        public void UpdateDoctor()
        {
            Doctor doctor = new Doctor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter The  Doctor details");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Doctor Id :");
            doctor.DoctorId = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Doctor Name :");
            doctor.DoctorName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Doctor Email :");
            doctor.DoctorEmail = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Doctor Password :");
            doctor.DoctorPassword = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Doctor Speciality :");
            doctor.DoctorSpeciality = Console.ReadLine();
            DoctorBLL doctorBLLObj = new DoctorBLL();
            string msg = doctorBLLObj.UpdateDoctorBLL(doctor);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);

        }

        public void GetAllDoctor()
        {
            DoctorBLL doctorBLLObj = new DoctorBLL();
            List<Doctor> doctors = doctorBLLObj.ShowAllDoctorDALBLL();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-------------------------------DoctorsList--------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--Id-----------Name-----------------Email---------------------Speciality----------Password");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
        
            foreach (var item in doctors)
            {

                Console.WriteLine("  " + item.DoctorId + " \t" + item.DoctorName.PadLeft(12) + " \t\t" + item.DoctorEmail.PadLeft(8) + "\t \t" + item.DoctorSpeciality.PadLeft(12)+"\t"+item.DoctorPassword.PadLeft(17));

            }

        }

        public void RemoveDoctor()
        {

            DoctorBLL doctorBLLObj = new DoctorBLL();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Doctor Details");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Doctor Id :");
            Console.ForegroundColor = ConsoleColor.Blue;
            int DoctorId = Convert.ToInt32(Console.ReadLine());

            string msg = doctorBLLObj.RemoveDoctorsBLL(DoctorId);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
            Console.Read();

        }

        public bool AdminDoctorSection()
        {
            DoctorPL doctorPLObj = new DoctorPL();
            bool flag1 = true;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome-to-Admin-Doctor-Section");
            int codeentered;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press 1 to add a Doctor");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press 2 to update a Doctor");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press 3 to delete a Doctor");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press 4 to show all Doctor");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press 5 to exit");
            Console.ForegroundColor = ConsoleColor.White;
            codeentered = Convert.ToInt32(Console.ReadLine());
           
            switch (codeentered)
            {
                case 1:

                    doctorPLObj.AddDoctor();

                    break;

                case 2:
                    doctorPLObj.UpdateDoctor();

                    break;
                case 3:
                    doctorPLObj.RemoveDoctor();

                    break;
                case 4:
                    doctorPLObj.GetAllDoctor();

                    break;
                case 5:
                    flag1 = false;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("invalid code");
                    break;

            }

            return flag1;

           
        }
    }
}
