using GameShop.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameShop.Controllers
{
    public class StoreController : Controller
    {
        StoreContext db = new StoreContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id) 
        {
            var game = db.Games.Find(id);

            return View(game);
        }

        public ActionResult List() 
        {
            var gameslist = db.Games.ToList();
            return View(gameslist);
        }

        public ActionResult GenresMenu() 
        {
            var genres = db.Genres.ToList();

            return PartialView(genres);
        }

    }
}