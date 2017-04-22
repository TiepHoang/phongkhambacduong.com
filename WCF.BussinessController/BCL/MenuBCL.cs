using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.BussinessObject.EntityObject;
using DataAccessLayer.Dao;

namespace WCF.BussinessControler.BCL
{
    public class MenuBCL
    {
        public List<MenuObject> Menu_GetAll()
        {
            return new MenuDao().Menu_GetAll();
        }

        public MenuObject Menu_GetByID(Guid id)
        {
            return new MenuDao().Menu_GetByID(id);
        }

        public void Menu_Insert(MenuObject obj)
        {
            new MenuDao().Menu_Insert(obj);
        }

        public void Menu_Update(MenuObject obj)
        {
            new MenuDao().Menu_Update(obj);
        }

        public void Menu_Delete(Guid id)
        {
            new MenuDao().Menu_Delete(id);
        }
    }
}
