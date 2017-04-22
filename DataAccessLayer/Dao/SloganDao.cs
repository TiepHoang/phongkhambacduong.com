using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public class SloganDao
    {
        public List<SloganObject> Slogan_GetAll()
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            var lst = db.SP_Slogan_GetAll();
            List<SloganObject> list = new List<SloganObject>();
            foreach (var item in lst)
            {
                SloganObject obj = new SloganObject()
                {
                    BacSi = item.BacSi,
                    Content_VeChungToi = item.Content_VeChungToi,
                    CSVC = item.CSVC,
                    DichVu = item.DichVu,
                    GioiThieu = item.GioiThieu,
                    ID = item.ID,
                    ImageGioiThieu = item.ImageGioiThieu,
                    ImagePage = item.ImagePage,
                    LienHe = item.LienHe,
                    LogoPage = item.LogoPage,
                    nameContent_VeChungToi = item.nameContent_VeChungToi,
                    Slogan_BacSi = item.Slogan_BacSi,
                    Slogan_CSVC = item.Slogan_CSVC,
                    Slogan_DichVu = item.Slogan_DichVu,
                    Slogan_Lienhe = item.Slogan_Lienhe,
                    Slogan_VeChungToi = item.Slogan_VeChungToi,
                    SloganPage = item.SloganPage,
                    VeChungToi = item.VeChungToi
                };
                list.Add(obj);
            }
            return list;
        }

        public SloganObject Slogan_GetByID(Guid id)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            var lst = db.SP_Slogan_GetByID(id);
            SloganObject obj = new SloganObject();
            foreach (var item in lst)
            {
                obj.BacSi = item.BacSi;
                obj.Content_VeChungToi = item.Content_VeChungToi;
                obj.CSVC = item.CSVC;
                obj.DichVu = item.DichVu;
                obj.GioiThieu = item.GioiThieu;
                obj.ID = item.ID;
                obj.ImageGioiThieu = item.ImageGioiThieu;
                obj.ImagePage = item.ImagePage;
                obj.LienHe = item.LienHe;
                obj.LogoPage = item.LogoPage;
                obj.nameContent_VeChungToi = item.nameContent_VeChungToi;
                obj.Slogan_BacSi = item.Slogan_BacSi;
                obj.Slogan_CSVC = item.Slogan_CSVC;
                obj.Slogan_DichVu = item.Slogan_DichVu;
                obj.Slogan_Lienhe = item.Slogan_Lienhe;
                obj.Slogan_VeChungToi = item.Slogan_VeChungToi;
                obj.SloganPage = item.SloganPage;
                obj.VeChungToi = item.VeChungToi;
            }
            return obj;
        }

        public void Slogan_Insert(SloganObject obj)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_Slogan_INSERT(obj.ID,
                obj.DichVu,
                obj.Slogan_DichVu,
                obj.VeChungToi,
                obj.Slogan_VeChungToi,
                obj.nameContent_VeChungToi,
                obj.Content_VeChungToi,
                obj.CSVC,
                obj.Slogan_CSVC,
                obj.BacSi,
                obj.Slogan_BacSi,
                obj.LienHe,
                obj.Slogan_Lienhe,
                obj.GioiThieu,
                obj.ImageGioiThieu,
                obj.ImagePage,
                obj.SloganPage,
                obj.LogoPage);
        }

        public void Slogan_Update(SloganObject obj)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_Slogan_UPDATE(obj.ID,
                obj.DichVu,
                obj.Slogan_DichVu,
                obj.VeChungToi,
                obj.Slogan_VeChungToi,
                obj.nameContent_VeChungToi,
                obj.Content_VeChungToi,
                obj.CSVC,
                obj.Slogan_CSVC,
                obj.BacSi,
                obj.Slogan_BacSi,
                obj.LienHe,
                obj.Slogan_Lienhe,
                obj.GioiThieu,
                obj.ImageGioiThieu,
                obj.ImagePage,
                obj.SloganPage,
                obj.LogoPage);
        }

        public void Slogan_Delete(Guid id)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_Slogan_DELETE(id);
        }
    }
}
