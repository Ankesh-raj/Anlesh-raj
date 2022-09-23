using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementEntity
{
  
    public class Admin
    {
     public   String AdminEmail { get; set; }
     public   String AdminPassword { get; set; }
     public   String AdminName { get; set; }
     public   int AdminId { get; set; }
        public Admin(string AdminEmail,String AdminPassword,String AdminName,int AdminId)
        {
            this.AdminId = AdminId;
            this.AdminPassword = AdminPassword;
            this.AdminName = AdminName; 
            this.AdminEmail = AdminEmail;   
               
        }
    }
}
