using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public class PhongBanDao
    {
        public List<PhongBanObject> PhongBan_GetAll()
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            var list = db.SP_PhongBan_GetAll();
            List<PhongBanObject> lst = new List<PhongBanObject>();
            foreach (var item in list)
            {
                PhongBanObject obj = new PhongBanObject()
                {
                    ID = item.ID,
                    Name = item.Name,
                    MoTa = item.MoTa
                };
                lst.Add(obj);
            }
            return lst;
        }

        public PhongBanObject PhongBan_GetByID(Guid id)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            var lst = db.SP_PhongBan_GetByID(id);
            PhongBanObject obj = new PhongBanObject();
            foreach (var item in lst)
            {
                obj.ID = item.ID;
                obj.Name = item.Name;
                obj.MoTa = item.MoTa;
            }
            return obj;
        }

        public void PhongBan_Insert(PhongBanObject obj)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_PhongBan_INSERT(obj.ID, obj.Name, obj.MoTa);
        }

        public void PhongBan_Update(PhongBanObject obj)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_PhongBan_UPDATE(obj.ID, obj.Name, obj.MoTa);
        }

        public void PhongBan_Delete(Guid id)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_PhongBan_DELETE(id);
        }
    }
}
