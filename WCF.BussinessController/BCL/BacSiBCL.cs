using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.BussinessObject.EntityObject;
using DataAccessLayer.Dao;

namespace WCF.BussinessControler.BCL
{
    public class BacSiBCL
    {
        public List<BacSiObject> BacSi_GetAll()
        {
            return new BacSiDao().BacSi_GetAll();
        }

        public BacSiObject BacSi_GetByID(Guid id)
        {
            return new BacSiDao().BacSi_GetByID(id);
        }

        public void BacSi_Insert(BacSiObject obj)
        {
            new BacSiDao().BacSi_Insert(obj);
        }

        public void BacSi_Update(BacSiObject obj)
        {
            new BacSiDao().BacSi_Update(obj);
        }

        public void BacSi_Delete(Guid id)
        {
            new BacSiDao().BacSi_Delete(id);
        }
    }
}
