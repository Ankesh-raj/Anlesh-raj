using LibraryManagementEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LibraryManagementData
{
    public class BookDal
    {
        public List<Book> book;
        public List<Book> books;


        public static string sqlcon = "Data source=VDC01LTC2151;Initial Catalog=LibraryMgmmgt;Integrated Security=True;";

        public string Addbook(Book book)

        {
            #region coonected approach
            string msg;
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("insert into book values('" + book.BookName + "','" + book.BookAuthor + "'," + book.BookCopies + ")", con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            if (row > 0)
            {
                msg = "Inserted";
            }
            return "Inserted";
            #endregion
            #region dissconected approach
            /*string msg = "";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlDataAdapter adp =new SqlDataAdapter("insert into book values('" + book.BookName + "','" + book.BookAuthor + "'," + book.BookCopies + ")", con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet(); 
            adp.Fill(dt);
            msg = "Inserted"*/;




           /* return msg;*/
            #endregion

        }
        public List<Book> GetAllBooksDAL()
        {
          
            #region Connected Approach
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("select * from book", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            books = new List<Book>();
            while (dr.Read())
            {
                books.Add(new Book
                {
                    BookId = Convert.ToInt32(dr[0]),
                    BookName = dr[1].ToString(),
                    BookAuthor = dr[2].ToString(),
                    BookCopies = Convert.ToInt32(dr[3])
                });
            }
            con.Close();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Book>));
            FileStream fileStream = new FileStream("books.xml", FileMode.Create);
            xmlSerializer.Serialize(fileStream, book);
            return books;
            #endregion
            //SqlConnection con = new SqlConnection(sqlcon);
            //SqlDataAdapter adp = new SqlDataAdapter("select * from book1", con);

            //DataTable dt = new DataTable();
            //List<Book> book = new List<Book>();
            //adp.Fill(dt);
            //if (dt != null && dt.Rows.Count > 0)
            //{
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        books.Add(new Book
            //        {
            //            BookId = Convert.ToInt32(dt.Rows[i]["BookId"]),
            //            BookName = dt.Rows[i]["BookName"].ToString(),
            //            BookAuthor = dt.Rows[i]["BookAuthor"].ToString(),
            //            BookCopies = Convert.ToInt32(dt.Rows[i][" BookCopies "])
            //        });
            //    }
            //}







            return books;

        }
        public bool RemoveBooksDAL(int book)
        {
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("Delete from book where BokkId="+book, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;


        }
        public bool UpdateBookDal(Book book)
        {

            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("update Book set BookName='" + book.BookName + "', BookAuthor='" + book.BookAuthor + "',BookCopies="  + book.BookCopies + "where BokkId = "+book.BookId, con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            return true;




        }
     
        public List<Book> Update()
        {
            return book;
        }
    }

}
