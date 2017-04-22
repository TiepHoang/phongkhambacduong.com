using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.BussinessObject.EntityObject;
using DataAccessLayer.Dao;

namespace WCF.BussinessControler.BCL
{
    public class SloganBCL
    {
        public List<SloganObject> Slogan_GetAll()
        {
            return new SloganDao().Slogan_GetAll();
        }

        public SloganObject Slogan_GetByID(Guid id)
        {
            return new SloganDao().Slogan_GetByID(id);
        }

        public void Slogan_Insert(SloganObject obj)
        {
            new SloganDao().Slogan_Insert(obj);
        }

        public void Slogan_Update(SloganObject obj)
        {
            new SloganDao().Slogan_Update(obj);
        }

        public void Slogan_Delete(Guid id)
        {
            new SloganDao().Slogan_Delete(id);
        }
    }
}
