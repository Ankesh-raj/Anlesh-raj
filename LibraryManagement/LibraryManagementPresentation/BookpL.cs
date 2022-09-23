using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementEntity;
using LibraryManagementData;
using System.Net;
using LibraryManagementBusinese;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlClient;
using System.Net.Configuration;

namespace LibraryManagementPresentation
{
    public class BookpL
    {
        private List<Book> book;
      



        public void Addbook()

        {
            Book book1 = new Book();
            Console.WriteLine("Enter Book Details...");
            Console.ForegroundColor = ConsoleColor.White;
           /* Console.Write("Book Id: ");
            book1.BookId = Convert.ToInt32(Console.ReadLine());*/
            Console.Write("Book Name: ");
            book1.BookName = Console.ReadLine();
          
            Console.Write("Book Author: ");
            book1.BookAuthor = Console.ReadLine();
            
            Console.Write("Book Copies: ");
            book1.BookCopies = Convert.ToInt32(Console.ReadLine());
           
            BookBill bookBLL = new BookBill();
            string msg = bookBLL.AddBookBill(book1);
            Console.WriteLine(msg);
            BookpL bookpL = new BookpL();


            bookpL.Booksection();
        }
        //   // Console.ForegroundColor = ConsoleColor.Cyan;
        //    Console.WriteLine("Enter Book Details...");
        //    Console.ForegroundColor = ConsoleColor.White;
        //    Console.Write("Book Id: ");
        //    int bookId = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Book Name: ");
        //    string bookName = Console.ReadLine();
        //    Console.Write("Book Author: ");
        //    string bookAuthor = Console.ReadLine();
        //    Console.Write("Book Copies: ");
        //    int bookCopies = Convert.ToInt32(Console.ReadLine());
        //    BookBill bookBLL = new BookBill();
        //    bool flag = bookBLL.AddBookBill(BookAuthor, Bookname, Bookcopies, BookId);
        //    if (flag)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.WriteLine("Book added successfully...");
        //    }
        //    else
        //    {
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.WriteLine("Sorry, Try once again !!");
        //    }

        //}

    


    public void Booksection()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Welcome to Book Section________");
        Console.WriteLine("1) press 1 to Add a book \n" +
        "2) press 2 to upgrade a  book \n" +
        "3)press 3 to delete a book \n" +
        "4)press 4 to show all book");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("5)press 5 to ");
        Console.Write(" logout");
        var input1 = Convert.ToInt32(Console.ReadLine());
        BookDal bookDalobj = new BookDal();
        Book book = new Book();

        switch (input1)
        {
            case 1:
                    BookpL bookpL = new BookpL();

                    bookpL.Addbook();

                break;
            case 2:
                    BookpL bookpL3 = new BookpL();

                    bookpL3.UpdateBook();
                break;
            case 3:
                    BookpL bookpL2 = new BookpL();
                    bookpL2.RemoveBook();
                break;
            case 4:

                    BookpL bookpL1 = new BookpL();
                    bookpL1.GetAllBook();
                    break;




        }


    }
        private void GetAllBook()
        {
            BookDal bookDalobj = new BookDal();
            List<Book> books = bookDalobj.GetAllBooksDAL();
     
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("----------------------------Book-List-------------------------");
                Console.WriteLine("--Id----Name----------Author-------------------Copies--------");
                Console.ForegroundColor = ConsoleColor.White;


                foreach (var item in books)
                {
                    {
                    Console.WriteLine(item.BookId + "\t" + item.BookName + "\t \t" + item.BookAuthor + "\t \t" + item.BookCopies);




                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("-------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.White;

               /// BookpL bookpL = new BookpL();

                //BookDal bookDalObj = new BookDal();
                //bookDalObj.GetAllBooksDAL();
                // bookpL.Booksection();


            }
            BookpL bookpL = new BookpL();

            bookpL.Booksection();
        }
    private void GetBookmenu()
    {
        
    }
    public bool RemoveBook()

    {
          
                BookBill bookBLL = new BookBill();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Enter Book Details...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Book Id: ");
                int bookId = Convert.ToInt32(Console.ReadLine());

                //Book book= new Book();
                bool flag = bookBLL.RemoveBookBill(bookId);
                if (flag == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Book deleted successfully...");
                //BookpL bookpL = new BookpL();
                //bookBLL.RemoveBookBill(book);

            }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry, Try once again !!");
                }
                //Console.ForegroundColor = ConsoleColor.Yellow;
                //Console.WriteLine("Deleted Successfully");
                //Console.ForegroundColor = ConsoleColor.White;
            return true;

            }

    private  void UpdateBook()
    {
            BookBill bookBLL = new BookBill();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Book Details...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Book Id: ");
            int BookId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Book Name: ");
            string BookName = Console.ReadLine();
            Console.Write("Book Author: ");
            string BookAuthor = Console.ReadLine();
            Console.Write("Book Copies: ");
            int BookCopies = Convert.ToInt32(Console.ReadLine());
            Book book = new Book(BookAuthor, BookName, BookCopies, BookId);
            
            bool flag = bookBLL.UpdateBookBill(book);
            if (flag == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Book updated successfully...");
               
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sorry, Try once again !!");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Updated Successfully");
            Console.ForegroundColor = ConsoleColor.White;
           


        }


    }
}

