using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.BussinessObject.EntityObject;
using DataAccessLayer.Dao;

namespace WCF.BussinessControler.BCL
{
    public class GopYBCL
    {
        public List<GopYObject> GopY_GetAll()
        {
            return new GopYDao().GopY_GetAll();
        }

        public GopYObject GopY_GetByID(Guid id)
        {
            return new GopYDao().GopY_GetByID(id);
        }

        public void GopY_Insert(GopYObject obj)
        {
            new GopYDao().GopY_Insert(obj);
        }

        public void GopY_Update(GopYObject obj)
        {
            new GopYDao().GopY_Update(obj);
        }

        public void GopY_Delete(Guid id)
        {
            new GopYDao().GopY_Delete(id);
        }
    }
}
