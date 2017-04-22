using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.BussinessObject.EntityObject;
using DataAccessLayer.Dao;

namespace WCF.BussinessControler.BCL
{
    public class SanPhamBCL
    {
        public List<SanPhamObject> SanPham_GetAll()
        {
            return new SanPhamDao().SanPham_GetAll();
        }

        public SanPhamObject SanPham_GetByID(Guid id)
        {
            return new SanPhamDao().SanPham_GetByID(id);
        }

        public void SanPham_Insert(SanPhamObject obj)
        {
            new SanPhamDao().SanPham_Insert(obj);
        }

        public void SanPham_Update(SanPhamObject obj)
        {
            new SanPhamDao().SanPham_Update(obj);
        }

        public void SanPham_Delete(Guid id)
        {
            new SanPhamDao().SanPham_Delete(id);
        }
    }
}
