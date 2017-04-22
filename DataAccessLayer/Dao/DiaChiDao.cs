using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public class DiaChiDao
    {
        public List<DiaChiObject> DiaChi_GetAll()
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            var list = db.SP_DiaChi_GetAll();
            List<DiaChiObject> lst = new List<DiaChiObject>();
            foreach (var item in list)
            {
                DiaChiObject obj = new DiaChiObject()
                {
                    ID = item.ID,
                    Mobile = item.Mobile,
                    Adress = item.Adress,
                    Hotline = item.Hotline
                };
                lst.Add(obj);
            }
            return lst;
        }

        public DiaChiObject DiaChi_GetByID(Guid id)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            var lst = db.SP_DiaChi_GetByID(id);
            DiaChiObject obj = new DiaChiObject();
            foreach (var item in lst)
            {
                obj.ID = item.ID;
                obj.Mobile = item.Mobile;
                obj.Adress = item.Adress;
                obj.Hotline = item.Hotline;
            }
            return obj;
        }

        public void DiaChi_Insert(DiaChiObject obj)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_DiaChi_INSERT(obj.ID, obj.Mobile, obj.Adress, obj.Hotline);
        }

        public void DiaChi_Update(DiaChiObject obj)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_DiaChi_UPDATE(obj.ID, obj.Mobile, obj.Adress, obj.Hotline);
        }

        public void DiaChi_Delete(Guid id)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_DiaChi_DELETE(id);
        }
    }
}
