using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.BussinessObject.EntityObject;
using DataAccessLayer.Dao;

namespace WCF.BussinessControler.BCL
{
    public class DichVuBCL
    {
        public List<DichVuObject> DichVu_GetAll()
        {
            return new DichVuDao().DichVu_GetAll();
        }

        public DichVuObject DichVu_GetByID(Guid id)
        {
            return new DichVuDao().DichVu_GetByID(id);
        }

        public void DichVu_Insert(DichVuObject obj)
        {
            new DichVuDao().DichVu_Insert(obj);
        }

        public void DichVu_Update(DichVuObject obj)
        {
            new DichVuDao().DichVu_Update(obj);
        }

        public void DichVu_Delete(Guid id)
        {
            new DichVuDao().DichVu_Delete(id);
        }
    }
}
