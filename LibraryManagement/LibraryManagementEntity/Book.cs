using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementEntity
{
    public class Book
    {
       public string BookAuthor { get; set; }
     public string BookName { get; set; }
   public int BookCopies { get; set; }
        public int BookId { get; set; }
      


        public Book(String BookAuthor,String Bookname,int Bookcopies,int BookId)
            
        {
            this.BookAuthor = BookAuthor;   
            this.BookName = Bookname;
            this.BookCopies = Bookcopies;
            this.BookId = BookId;

        }
        public Book()
        {

        }
    }
}
