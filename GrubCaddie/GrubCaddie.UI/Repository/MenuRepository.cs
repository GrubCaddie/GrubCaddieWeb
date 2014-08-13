using GrubCaddie.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrubCaddie.UI.Repository
{
    public class MenuRepository : IMenuRepository
    {
        protected readonly GrubCaddieContext GCContext;

        public MenuRepository(GrubCaddieContext gc)
        {
            this.GCContext = gc;

        }
        public IQueryable<Data.Menu> GetAllMenu()
        {

             var menu = (from c in GCContext.Menus select c);
             return menu.AsQueryable();


        }


        public void Add(Menu menu)
        {
            GCContext.Menus.Add(menu);


        }


        public void Save()
        {
            GCContext.SaveChanges();
        }
    }
}