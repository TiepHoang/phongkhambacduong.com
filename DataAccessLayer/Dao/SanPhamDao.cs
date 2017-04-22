using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public class SanPhamDao
    {
        public List<SanPhamObject> SanPham_GetAll()
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            var list = db.SP_SanPham_GetAll();
            List<SanPhamObject> lst = new List<SanPhamObject>();
            foreach (var item in list)
            {
                SanPhamObject obj = new SanPhamObject()
                {
                    ID = item.ID,
                    GiaTien = item.GiaTien,
                    LinkImage = item.LinkImage,
                    Name = item.Name,
                    Rank = item.Rank,
                    ThongTin = item.ThongTin,
                };
                lst.Add(obj);
            }
            return lst;
        }

        public SanPhamObject SanPham_GetByID(Guid id)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            var lst = db.SP_SanPham_GetByID(id);
            SanPhamObject obj = new SanPhamObject();
            foreach (var item in lst)
            {
                obj.ID = item.ID;
                obj.GiaTien = item.GiaTien;
                obj.LinkImage = item.LinkImage;
                obj.Name = item.Name;
                obj.Rank = item.Rank;
                obj.ThongTin = item.ThongTin;
            }
            return obj;
        }

        public void SanPham_Insert(SanPhamObject obj)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_SanPham_INSERT(obj.ID,obj.LinkImage,obj.Name,obj.GiaTien,obj.Rank,obj.ThongTin);
        }

        public void SanPham_Update(SanPhamObject obj)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_SanPham_UPDATE(obj.ID, obj.LinkImage, obj.Name, obj.GiaTien, obj.Rank, obj.ThongTin);
        }

        public void SanPham_Delete(Guid id)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_SanPham_DELETE(id);
        }
    }
}
