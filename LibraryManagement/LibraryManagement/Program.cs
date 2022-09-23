using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementBusinese;
using LibraryManagementData;
using LibraryManagementEntity;
using LibraryManagementPresentation;
namespace LibraryManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
          //  Type type = typeof(Book);
          //  var member = type.GetMembers();
          //  var method = type.GetMethods();
          //  var propingfo = type.GetProperties();
          //  var t = "";
          ////  Activator

            AdminPL admilobj = new AdminPL();


            admilobj.menu();

            Console.Read();



        }

    }
}
