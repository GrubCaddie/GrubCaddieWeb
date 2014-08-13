using GrubCaddie.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrubCaddie.UI.Repository
{
    public class MenuItemRepository : IMenuItemRepository
    {
           protected readonly GrubCaddieContext GCContext;

        public MenuItemRepository(GrubCaddieContext gc)
        {
            this.GCContext = gc;

        }
        public IQueryable<Data.MenuItem> GetMenuItem(int Id)
        {
            var menuItem = (from c in GCContext.MenuItems where c.Menu_Id == Id select c);
            return menuItem.AsQueryable();
        }

        public void Add(Data.MenuItem menuitem)
        {
            GCContext.MenuItems.Add(menuitem);
        }

        public void Save()
        {
            GCContext.SaveChanges();
        }
    }
}