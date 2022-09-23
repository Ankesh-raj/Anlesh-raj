using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementEntity;


namespace LibraryManagementData
{
    public class UserDal
    {
        public List<RecivedBook> RecivedBooks;
        public List<RequestedBook> RequestedBooks;
        public List<User> Users;
        public List<RequestedBook> AcceptReuestDal()
        {
            return RequestedBooks;


        }
        public List<User> AddUserDal()
        {
            return Users;


        }
        public List<RecivedBook> DeleteRecivedDal()
        {
            return RecivedBooks;


        }
        public List<User> GetAllUsersDal()
        {
            return Users;


        }
        public List<User> GetRecivedBookDal()
        {
            return Users;


        }
        public List<User> GetRequestedBookDal()
        {
            return Users;


        }
        public List<User> RemovelUsersDal()
        {
            return Users;


        }
        public List<User> RequestBookDal()
        {
            return Users;


        }
        public List<User> UpdatUsereDal()
        {
            return Users;


        }

    }
}
