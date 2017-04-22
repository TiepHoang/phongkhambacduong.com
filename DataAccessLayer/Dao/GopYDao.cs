using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public class GopYDao
    {
        public List<GopYObject> GopY_GetAll()
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            var list = db.SP_GopY_GetAll();
            List<GopYObject> lst = new List<GopYObject>();
            foreach (var item in list)
            {
                GopYObject obj = new GopYObject()
                {
                    ID = item.ID,
                    ThoiGian = item.ThoiGian,
                    HoTen = item.HoTen,
                    DienThoai = item.DienThoai,
                    Email = item.Email,
                    NoiDung = item.NoiDung
                };
                lst.Add(obj);
            }
            return lst;
        }

        public GopYObject GopY_GetByID(Guid id)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            var lst = db.SP_GopY_GetByID(id);
            GopYObject obj = new GopYObject();
            foreach (var item in lst)
            {
                obj.ID = item.ID;
                obj.ThoiGian = item.ThoiGian;
                obj.HoTen = item.HoTen;
                obj.DienThoai = item.DienThoai;
                obj.Email = item.Email;
                obj.NoiDung = item.NoiDung;
            }
            return obj;
        }

        public void GopY_Insert(GopYObject obj)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_GopY_INSERT(obj.ID, obj.ThoiGian, obj.HoTen, obj.DienThoai, obj.Email, obj.NoiDung);
        }

        public void GopY_Update(GopYObject obj)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_GopY_UPDATE(obj.ID, obj.ThoiGian, obj.HoTen, obj.DienThoai, obj.Email, obj.NoiDung);
        }

        public void GopY_Delete(Guid id)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_GopY_DELETE(id);
        }
    }
}
