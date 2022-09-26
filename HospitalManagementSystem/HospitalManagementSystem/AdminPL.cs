using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementBLL;

namespace HospitalManagementSystem

{
    public class AdminPL
    {
        public void menu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to Abc Hospital Management Service\n" +
             "1)Press 1 to login as Admin\n" +
             "2)Press 2 to login as Doctor\n" +
             "3)Press 3 to login as Patient\n" +
             "4)Press 4 to logout");
            Console.ForegroundColor = ConsoleColor.White;
            int codeentered;
            codeentered = Convert.ToInt32(Console.ReadLine());

            switch (codeentered)
            {
                case 1:
                    AdminPL adminPLObj = new AdminPL();
                    adminPLObj.AdminLogin();
                    break;
                case 2:
                    DoctorPL userPLObj = new DoctorPL();
                    userPLObj.DoctorLogin();
                    break;
                case 3:
                    PatientPL patientPLObj = new PatientPL();
                    patientPLObj.PatientLogin();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Code");
                    break;
            }

        }
        public void AdminLogin()
        {
            string AdminEmail;
            string AdminPassword;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter the Email :");
            AdminEmail = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter the Password :");
            AdminPassword = Console.ReadLine();
            AdminBLL adminBLLObj = new AdminBLL();

            bool flag = adminBLLObj.AdminLogin(AdminEmail, AdminPassword);
            if (flag)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Logged in Successfully");
                AdminPL adminPlObj = new AdminPL();
                adminPlObj.AdminSection();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid credentials");
            }

        }

        public void AdminSection()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome-to-Admin-Section");
            int input;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press 1 to show  Doctor section");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press 2 to show Patient section");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press 3 to logout");
            Console.ForegroundColor = ConsoleColor.White;
            input = Convert.ToInt32(Console.ReadLine());
            DoctorPL doctorPLObj = new DoctorPL();
            PatientPL patientPLObj = new PatientPL();
            switch (input)
            {
                case 1:
                    bool flag = true;
                    while (flag)
                    {

                        flag = doctorPLObj.AdminDoctorSection();
                            
                            
                    }

                    break;
                case 2:
                    bool flag1 = true;
                    while (flag1)
                    {
                        flag1=patientPLObj.AdminPatientSection();
                    }
                    break;
                case 3:

                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("invalid code");
                    break;

            }

        }
    }
}

