using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementData;
using LibraryManagementEntity;


namespace LibraryManagementBusinese
{
    public class AdminBiLL
    {
        public bool AdminLogin(String AdnminEmail,String AdminPassword)
        {
            bool flag = false;
            AdminDal adminBiLLobj = new AdminDal();
            //adminBiLLobj.GetAllAdminsDal();

            List<Admin> adminDalList = adminBiLLobj.GetAllAdminsDal();
            //adminDalList = adminBiLLobj.GetAllAdminsDal();
            foreach (var item in adminDalList) 
            {   
                if(item.AdminEmail == AdnminEmail && item.AdminPassword==AdminPassword)

                {

                    flag=true;
                    break;
                }

            }
            return flag;
           
        }

    }
}
