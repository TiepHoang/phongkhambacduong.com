using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.BussinessObject.EntityObject;
using DataAccessLayer.Dao;

namespace WCF.BussinessControler.BCL
{
    public class AccountBCL
    {
        public List<AccountObject> Account_GetAll()
        {
            return new AccountDao().Account_GetAll();
        }

        public AccountObject Account_GetByID(string username)
        {
            return new AccountDao().Account_GetByID(username);
        }

        public void Account_Insert(AccountObject obj)
        {
            new AccountDao().Account_Insert(obj);
        }

        public void Account_Update(AccountObject obj)
        {
            new AccountDao().Account_Update(obj);
        }

        public void Account_Delete(string username)
        {
            new AccountDao().Account_Delete(username);
        }
    }
}
