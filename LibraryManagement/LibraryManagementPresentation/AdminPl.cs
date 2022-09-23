using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementBusinese;


namespace LibraryManagementPresentation
{
    public class AdminPL
    {
        public void menu()
        {
            Console.WriteLine("Welcome to Abc Library MAnagement");
            Console.WriteLine("1) press 1 to login as Admin \n" +
                "2) press 2 to login as a user\n"+
                "3)press 3 to exit");
            var input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    AdminPL adminpl = new AdminPL();
                    adminpl.AdminLogin();
                    break;


                case 2:
                    break;
                case 3:
                    break;

                default: Console.WriteLine("Invalid Condential");
                    break;


            }
        }
        public void AdminLogin()
        {




                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Admin_login");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Email_id : ");
                String AdnminEmail = Console.ReadLine();
                Console.Write("Admin_password : ");
                String AdminPassword = Console.ReadLine();

                AdminBiLL adminBillObj1 = new AdminBiLL();

                bool status = false;
                status = adminBillObj1.AdminLogin(AdnminEmail, AdminPassword);
                if (status)
                {
                    Console.WriteLine("Loged in Sussesfull");
                    AdminPL adminpl = new AdminPL();
                    adminpl.AdminSection();
            }
                else
                {
                    Console.WriteLine("Invalid");
                }
            
        



            //Console.WriteLine("Welcome to Admin Section________");
            // Console.WriteLine("1) press 1 to book section \n" +
            //   "2) press 2 to show  a user section\n" +
            //   "3)press 3 to show as request section \n" +
            //   "4)press 4 to show as Accepted section");
            // Console.ForegroundColor = ConsoleColor.White;
            // Console.Write("5)press 5 to ");
            // Console.ForegroundColor = ConsoleColor.Red;
            // Console.Write(" logout");
            // var input1 = Convert.ToInt32(Console.ReadLine());

            // switch (input1)
            // {
            //     case: 1  
            //             BookpL bookObj = new BookpL();
            //             bookObj.Booksection();

            //         break;
            // }




        }
        public void AdminSection()
        {

            Console.WriteLine("Welcome to Admin Section________");
            Console.WriteLine("1) press 1 to book section \n" +
              "2) press 2 to show  a user section\n" +
              "3)press 3 to show as request section \n" +
              "4)press 4 to show as Accepted section");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("5)press 5 to ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" logout");
            var input1 = Convert.ToInt32(Console.ReadLine());

            switch (input1)
            {
                case 1: 
                        BookpL bookObj = new BookpL();
                    bookObj.Booksection();

                    break;
            }

        }







    }
}
