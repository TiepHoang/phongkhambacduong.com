using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dao
{
    public class DiaChiDao
    {
        public EF.DiaChi getOne(int id)
        {
            return new EF.PhongKham().DiaChis.FirstOrDefault(d => d.ID.Equals(id));
        }
    }
}
