using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.BussinessObject.EntityObject;
using DataAccessLayer.Dao;

namespace WCF.BussinessControler.BCL
{
    public class PositionBCL
    {
        public List<PositionObject> Position_GetAll()
        {
            return new PositionDao().Position_GetAll();
        }

        public PositionObject Position_GetByID(Guid id)
        {
            return new PositionDao().Position_GetByID(id);
        }

        public void Position_Insert(PositionObject obj)
        {
            new PositionDao().Position_Insert(obj);
        }

        public void Position_Update(PositionObject obj)
        {
            new PositionDao().Position_Update(obj);
        }

        public void Position_Delete(Guid id)
        {
            new PositionDao().Position_Delete(id);
        }
    }
}
