using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public class CoSoVatChatDao
    {
        public List<CoSoVatChatObject> CoSoVatChat_GetAll()
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            var list = db.SP_CoSoVatChat_GetAll();
            List<CoSoVatChatObject> lst = new List<CoSoVatChatObject>();
            foreach (var item in list)
            {
                CoSoVatChatObject obj = new CoSoVatChatObject()
                {
                    ID = item.ID,
                    GioiThieu = item.GioiThieu,
                    LinkImage = item.LinkImage,
                    Index = item.Index,
                    hrefAjax = item.hrefAjax
                };
                lst.Add(obj);
            }
            return lst;
        }

        public CoSoVatChatObject CoSoVatChat_GetByID(Guid id)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            var lst = db.SP_CoSoVatChat_GetByID(id);
            CoSoVatChatObject obj = new CoSoVatChatObject();
            foreach (var item in lst)
            {
                obj.ID = item.ID;
                obj.GioiThieu = item.GioiThieu;
                obj.LinkImage = item.LinkImage;
                obj.Index = item.Index;
                obj.hrefAjax = item.hrefAjax;
            }
            return obj;
        }

        public void CoSoVatChat_Insert(CoSoVatChatObject obj)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_CoSoVatChat_INSERT(obj.ID, obj.GioiThieu, obj.LinkImage, obj.Index, obj.hrefAjax);
        }

        public void CoSoVatChat_Update(CoSoVatChatObject obj)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_CoSoVatChat_UPDATE(obj.ID, obj.GioiThieu, obj.LinkImage, obj.Index, obj.hrefAjax);
        }

        public void CoSoVatChat_Delete(Guid id)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_CoSoVatChat_DELETE(id);
        }
    }
}
