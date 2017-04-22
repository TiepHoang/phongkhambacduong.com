using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.BussinessObject.EntityObject;
using DataAccessLayer.Dao;

namespace WCF.BussinessControler.BCL
{
    public class PhongBanBCL
    {
        public List<PhongBanObject> PhongBan_GetAll()
        {
            return new PhongBanDao().PhongBan_GetAll();
        }

        public PhongBanObject PhongBan_GetByID(Guid id)
        {
            return new PhongBanDao().PhongBan_GetByID(id);
        }

        public void PhongBan_Insert(PhongBanObject obj)
        {
            new PhongBanDao().PhongBan_Insert(obj);
        }

        public void PhongBan_Update(PhongBanObject obj)
        {
            new PhongBanDao().PhongBan_Update(obj);
        }

        public void PhongBan_Delete(Guid id)
        {
            new PhongBanDao().PhongBan_Delete(id);
        }
    }
}
