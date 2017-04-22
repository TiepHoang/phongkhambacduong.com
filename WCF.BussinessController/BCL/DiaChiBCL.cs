using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.BussinessObject.EntityObject;
using DataAccessLayer.Dao;

namespace WCF.BussinessControler.BCL
{
    public class DiaChiBCL
    {
        public List<DiaChiObject> DiaChi_GetAll()
        {
            return new DiaChiDao().DiaChi_GetAll();
        }

        public DiaChiObject DiaChi_GetByID(Guid id)
        {
            return new DiaChiDao().DiaChi_GetByID(id);
        }

        public void DiaChi_Insert(DiaChiObject obj)
        {
            new DiaChiDao().DiaChi_Insert(obj);
        }

        public void DiaChi_Update(DiaChiObject obj)
        {
            new DiaChiDao().DiaChi_Update(obj);
        }

        public void DiaChi_Delete(Guid id)
        {
            new DiaChiDao().DiaChi_Delete(id);
        }
    }
}
