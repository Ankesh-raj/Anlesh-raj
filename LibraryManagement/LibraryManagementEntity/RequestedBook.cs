using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementEntity
{
    public class RequestedBook
    {
       public  int BookId { get; set; }
      public  String Bookname { get; set; }
   public     DateTime DateRequested { get; set; }
     public    String UserName { get; set; }
      public  int UserID { get; set; }
    }
}
