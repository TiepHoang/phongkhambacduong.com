using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dao
{
    public class BacSiDao
    {
        public EF.BacSi getOne(int id)
        {
            using (var db = new EF.PhongKham())
            {
                return db.BacSis.FirstOrDefault(d => d.ID.Equals(id));
            }
        }
    }
}
