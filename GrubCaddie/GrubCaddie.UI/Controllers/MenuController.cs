using GrubCaddie.Data;
using GrubCaddie.UI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GrubCaddie.UI.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu

        private readonly IMenuRepository _menurepo;
        private readonly IMenuItemRepository _menuitemrepo;

        public MenuController()
        {

            _menurepo = new MenuRepository(new GrubCaddieContext());
            _menuitemrepo = new MenuItemRepository(new GrubCaddieContext());
        }
    

        public ActionResult Index()
        {
            IQueryable<Menu> menu = _menurepo.GetAllMenu();
            return View(menu);
        }

        // GET: Menu/Details/5
        public ActionResult Details(int id)
        {
            IQueryable<MenuItem> menuItem = _menuitemrepo.GetMenuItem(id);
            return View(menuItem);
        }


        public ActionResult CreateMenuItem()
        {


            return View();
        }

        [HttpPost]
        public ActionResult CreateMenuItem(MenuItem collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _menuitemrepo.Add(collection);
                    _menuitemrepo.Save();

                }
                else
                {
                    //Validation Error
                    return View();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult CreateImage()
        {
            return View();

        }

        [HttpPost]
        public ActionResult CreateImage(HttpPostedFileBase file)
        {
            if(file!=null && file.ContentLength >0)
            {


            }

            return View();
        }

        // GET: Menu/Create
        public ActionResult Create()
        {


            return View();
        }

        // POST: Menu/Create
        [HttpPost]
        public ActionResult Create(Menu collection)
        {
            try
            {
               if(ModelState.IsValid)
               {
                   _menurepo.Add(collection);
                   _menurepo.Save();
                  
               }
               else
               {
                   //Validation Error
                   return View();
               }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Menu/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Menu/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Menu/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Menu/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
