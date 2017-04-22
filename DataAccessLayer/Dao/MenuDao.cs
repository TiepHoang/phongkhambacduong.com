using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public class MenuDao
    {
        public List<MenuObject> Menu_GetAll()
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            var list = db.SP_Menu_GetAll().OrderBy(d => d.Rank);
            List<MenuObject> lst = new List<MenuObject>();
            foreach (var item in list)
            {
                MenuObject obj = new MenuObject()
                {
                    ID = item.ID,
                    Display = item.Display,
                    Neo = item.Neo,
                    Rank = item.Rank
                };
                lst.Add(obj);
            }
            return lst;
        }

        public MenuObject Menu_GetByID(Guid id)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            var lst = db.SP_Menu_GetByID(id);
            MenuObject obj = new MenuObject();
            foreach (var item in lst)
            {
                obj.ID = item.ID;
                obj.Display = item.Display;
                obj.Neo = item.Neo;
                obj.Rank = item.Rank;
            }
            return obj;
        }

        public void Menu_Insert(MenuObject obj)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_Menu_INSERT(obj.ID, obj.Display, obj.Rank, obj.Neo);
        }

        public void Menu_Update(MenuObject obj)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_Menu_UPDATE(obj.ID, obj.Display, obj.Rank, obj.Neo);
        }

        public void Menu_Delete(Guid id)
        {
            DataModel.PhongKhamEntities db = new DataModel.PhongKhamEntities();
            db.SP_Menu_DELETE(id);
        }
    }
}
