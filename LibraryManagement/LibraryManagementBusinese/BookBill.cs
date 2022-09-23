using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementData;
using LibraryManagementEntity;

namespace LibraryManagementBusinese
{
    public class BookBill
    {
        List<Book> dalBook = new List<Book>();
        public string AddBookBill(Book book)

        {
            BookDal bookdal = new BookDal();
            return bookdal.Addbook(book);

        }

        public List<Book> GetallBook()
        {
            BookDal bookdal = new BookDal();
            return bookdal.GetAllBooksDAL();
        }
        public bool RemoveBookBill(int book)
        {
            BookDal bookdal = new BookDal();
            return bookdal.RemoveBooksDAL(book);
        }
        public bool UpdateBookBill(Book book)
        {
            BookDal bookdal = new BookDal();
            return bookdal.UpdateBookDal(book);
        }





    }
}
