using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public class DichVuDao
    {
        public List<DichVuObject> DichVu_GetAll()
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            var list = db.SP_DichVu_GetAll();
            List<DichVuObject> lst = new List<DichVuObject>();
            foreach (var item in list)
            {
                DichVuObject ob = new DichVuObject();
                ob.ID = item.ID;
                ob.Icon = item.Icon;
                ob.Name = item.Name;
                ob.GioiThieu = item.GioiThieu;
                ob.hrefAjax = item.hrefAjax;
                lst.Add(ob);
            }
            return lst;
        }

        public DichVuObject DichVu_GetByID(Guid id)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            var lst = db.SP_DichVu_GetByID(id);
            DichVuObject ob = new DichVuObject();
            foreach (var item in lst)
            {
                ob.ID = item.ID;
                ob.Icon = item.Icon;
                ob.Name = item.Name;
                ob.GioiThieu = item.GioiThieu;
                ob.hrefAjax = item.hrefAjax;
            }
            return ob;
        }

        public void DichVu_Insert(DichVuObject obj)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_DichVu_INSERT(obj.ID, obj.Icon, obj.Name, obj.GioiThieu, obj.hrefAjax);
        }

        public void DichVu_Update(DichVuObject obj)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_DichVu_UPDATE(obj.ID, obj.Icon, obj.Name, obj.GioiThieu, obj.hrefAjax);
        }

        public void DichVu_Delete(Guid id)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_DichVu_DELETE(id);
        }
    }
}
