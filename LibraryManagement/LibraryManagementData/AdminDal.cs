using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementEntity;

namespace LibraryManagementData
{
    public class AdminDal
    {
        public List<Admin> admins;
        public List<Admin> GetAllAdminsDal()
        {
            admins = new List<Admin>();
            Admin adminobj1 = new Admin("Ankeshraj1702@gmail.com", "12345","Ankesh",123);

            admins.Add(adminobj1);
            Admin adminobj2 = new Admin("rajaj@134", "1234A126", "raj", 123);
           
            admins.Add(adminobj2);
            return admins;
            

        }



    }
}
