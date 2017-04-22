using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public class PositionDao
    {
        public List<PositionObject> Position_GetAll()
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            var list = db.SP_Position_GetAll();
            List<PositionObject> lst = new List<PositionObject>();
            foreach (var item in list)
            {
                PositionObject obj = new PositionObject()
                {
                    ID = item.ID,
                    MieuTa = item.MieuTa,
                    Name = item.Name,
                };
                lst.Add(obj);
            }
            return lst;
        }

        public PositionObject Position_GetByID(Guid id)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            var lst = db.SP_Position_GetByID(id);
            PositionObject obj = new PositionObject();
            foreach (var item in lst)
            {
                obj.ID = item.ID;
                obj.MieuTa = item.MieuTa;
                obj.Name = item.Name;
            }
            return obj;
        }

        public void Position_Insert(PositionObject obj)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_Position_INSERT(obj.ID, obj.Name, obj.MieuTa);
        }

        public void Position_Update(PositionObject obj)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_Position_UPDATE(obj.ID, obj.Name, obj.MieuTa);
        }

        public void Position_Delete(Guid id)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_Position_DELETE(id);
        }
    }
}
