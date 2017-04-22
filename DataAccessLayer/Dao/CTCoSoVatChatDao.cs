using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public class CTCoSoVatChatDao
    {
        public List<CTCoSoVatChatObject> CTCoSoVatChat_GetAll()
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            var list = db.SP_CTCoSoVatChat_GetAll();
            List<CTCoSoVatChatObject> lst = new List<CTCoSoVatChatObject>();
            foreach (var item in list)
            {
                CTCoSoVatChatObject obj = new CTCoSoVatChatObject()
                {
                    ID = item.ID,
                    ID_CoSoVatChat = item.ID_CoSoVatChat,
                    LinkImage = item.LinkImage,
                    NoiDung = item.NoiDung
                };
                lst.Add(obj);
            }
            return lst;
        }

        public List<CTCoSoVatChatObject> CTCoSoVatChat_GetGroupByID(Guid id)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            var list = db.SP_CTCoSoVatChat_GetGroupByID(id);
            List<CTCoSoVatChatObject> lst = new List<CTCoSoVatChatObject>();
            foreach (var item in list)
            {
                CTCoSoVatChatObject obj = new CTCoSoVatChatObject()
                {
                    ID = item.ID,
                    ID_CoSoVatChat = item.ID_CoSoVatChat,
                    LinkImage = item.LinkImage,
                    NoiDung = item.NoiDung
                };
                lst.Add(obj);
            }
            return lst;
        }

        public CTCoSoVatChatObject CTCoSoVatChat_GetByID(Guid id)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            var lst = db.SP_CTCoSoVatChat_GetByID(id);
            CTCoSoVatChatObject obj = new CTCoSoVatChatObject();
            foreach (var item in lst)
            {
                obj.ID = item.ID;
                obj.ID_CoSoVatChat = item.ID_CoSoVatChat;
                obj.LinkImage = item.LinkImage;
                obj.NoiDung = item.NoiDung;
            }
            return obj;
        }

        public void CTCoSoVatChat_Insert(CTCoSoVatChatObject obj)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_CTCoSoVatChat_INSERT(obj.ID, obj.ID_CoSoVatChat, obj.LinkImage, obj.NoiDung);
        }

        public void CTCoSoVatChat_Update(CTCoSoVatChatObject obj)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_CTCoSoVatChat_UPDATE(obj.ID, obj.ID_CoSoVatChat, obj.LinkImage, obj.NoiDung);
        }

        public void CTCoSoVatChat_Delete(Guid id)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_CTCoSoVatChat_DELETE(id);
        }

        public void CTCoSoVatChat_DeleteForID(Guid iD_CoSoVatChat)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_CTCoSoVatChat_DELETEForID(iD_CoSoVatChat);
        }
    }
}
