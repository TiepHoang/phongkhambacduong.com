using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.BussinessObject.EntityObject;
using DataAccessLayer.Dao;

namespace WCF.BussinessControler.BCL
{
    public class CTCoSoVatChatBCL
    {
        public List<CTCoSoVatChatObject> CTCoSoVatChat_GetAll()
        {
            return new CTCoSoVatChatDao().CTCoSoVatChat_GetAll();
        }

        public List<CTCoSoVatChatObject> CTCoSoVatChat_GetGroupByID(Guid id)
        {
            return new CTCoSoVatChatDao().CTCoSoVatChat_GetGroupByID(id);
        }

        public CTCoSoVatChatObject CTCoSoVatChat_GetByID(Guid id)
        {
            return new CTCoSoVatChatDao().CTCoSoVatChat_GetByID(id);
        }

        public void CTCoSoVatChat_Insert(CTCoSoVatChatObject obj)
        {
            new CTCoSoVatChatDao().CTCoSoVatChat_Insert(obj);
        }

        public void CTCoSoVatChat_Update(CTCoSoVatChatObject obj)
        {
            new CTCoSoVatChatDao().CTCoSoVatChat_Update(obj);
        }

        public void CTCoSoVatChat_Delete(Guid id)
        {
            new CTCoSoVatChatDao().CTCoSoVatChat_Delete(id);
        }

        public void CTCoSoVatChat_DeleteForID(Guid id)
        {
            new CTCoSoVatChatDao().CTCoSoVatChat_DeleteForID(id);
        }
    }
}
