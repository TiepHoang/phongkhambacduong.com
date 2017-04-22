using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public class BacSiDao
    {
        public List<BacSiObject> BacSi_GetAll()
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            var list = db.SP_BacSi_GetAll();
            List<BacSiObject> lst = new List<BacSiObject>();
            foreach (var item in list)
            {
                BacSiObject ob = new BacSiObject();
                ob.ID = item.ID;
                ob.ID_PhongBan = item.ID_PhongBan;
                ob.LinkImage = item.LinkImage;
                ob.Name = item.Name;
                lst.Add(ob);
            }
            return lst;
        }

        public BacSiObject BacSi_GetByID(Guid id)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            var lst = db.SP_BacSi_GetByID(id);
            BacSiObject ob = new BacSiObject();
            foreach (var item in lst)
            {
                ob.ID = item.ID;
                ob.ID_PhongBan = item.ID_PhongBan;
                ob.LinkImage = item.LinkImage;
                ob.Name = item.Name;
            }
            return ob;
        }

        public void BacSi_Insert(BacSiObject obj)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_BacSi_INSERT(obj.ID, obj.Name, obj.ID_PhongBan, obj.LinkImage);
        }

        public void BacSi_Update(BacSiObject obj)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_BacSi_UPDATE(obj.ID, obj.Name, obj.ID_PhongBan, obj.LinkImage);
        }

        public void BacSi_Delete(Guid id)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_BacSi_DELETE(id);
        }
    }
}
