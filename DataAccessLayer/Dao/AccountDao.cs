using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public class AccountDao
    {
        public List<AccountObject> Account_GetAll()
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            var list = db.SP_Account_GetAll();
            List<AccountObject> lst = new List<AccountObject>();
            foreach (var item in list)
            {
                AccountObject obj = new AccountObject()
                {
                    Username = item.Username,
                    Password = item.Password,
                    Email = item.Email,
                    Sex = item.Sex,
                    Name = item.Name,
                    Birthday = item.Birthday,
                    Adress = item.Adress,
                    Phone = item.Phone,
                    ID_Position = item.ID_Position,
                    Avatar = item.Avatar
                };
                lst.Add(obj);
            }
            return lst;
        }

        public AccountObject Account_GetByID(string username)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            var lst = db.SP_Account_GetByUsername(username);
            AccountObject obj = new AccountObject();
            foreach (var item in lst)
            {
                obj.Username = item.Username;
                obj.Password = item.Password;
                obj.Email = item.Email;
                obj.Sex = item.Sex;
                obj.Name = item.Name;
                obj.Birthday = item.Birthday;
                obj.Adress = item.Adress;
                obj.Phone = item.Phone;
                obj.ID_Position = item.ID_Position;
                obj.Avatar = item.Avatar;
            }
            return obj;
        }

        public void Account_Insert(AccountObject obj)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_Account_INSERT(obj.Username, obj.Password, obj.Email, obj.Sex, obj.Name, obj.Birthday, obj.Adress, obj.Phone, obj.ID_Position, obj.Avatar);
        }

        public void Account_Update(AccountObject obj)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_Account_UPDATE(obj.Username, obj.Password, obj.Email, obj.Sex, obj.Name, obj.Birthday, obj.Adress, obj.Phone, obj.ID_Position, obj.Avatar);
        }

        public void Account_Delete(string username)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_Account_DELETE(username);
        }
    }
}
