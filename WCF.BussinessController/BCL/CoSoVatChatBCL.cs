using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.BussinessObject.EntityObject;
using DataAccessLayer.Dao;

namespace WCF.BussinessControler.BCL
{
    public class CoSoVatChatBCL
    {
        public List<CoSoVatChatObject> CoSoVatChat_GetAll()
        {
            return new CoSoVatChatDao().CoSoVatChat_GetAll();
        }

        public CoSoVatChatObject CoSoVatChat_GetByID(Guid id)
        {
            return new CoSoVatChatDao().CoSoVatChat_GetByID(id);
        }

        public void CoSoVatChat_Insert(CoSoVatChatObject obj)
        {
            new CoSoVatChatDao().CoSoVatChat_Insert(obj);
        }

        public void CoSoVatChat_Update(CoSoVatChatObject obj)
        
        {
            new CoSoVatChatDao().CoSoVatChat_Update(obj);
        }

        public void CoSoVatChat_Delete(Guid id)
        {
            new CTCoSoVatChatBCL().CTCoSoVatChat_DeleteForID(id);
            new CoSoVatChatDao().CoSoVatChat_Delete(id);
        }
    }
}
