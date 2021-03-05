using GameShop.DAL;
using GameShop.Models;
using GameShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameShop.Controllers
{
    public class HomeController : Controller
    {

        private StoreContext db = new StoreContext();

        public ActionResult Index()
        {
            var genres = db.Genres.ToList();
            var newArrivals = db.Games.Where(a => !a.IsHidden).OrderByDescending(a => a.DateAdded).Take(3).ToList();
            var bestsellers = db.Games.Where(a => !a.IsHidden && a.IsBestseller).OrderBy(g => Guid.NewGuid()).Take(3).ToList();

            var vm = new HomeViewModel() 
            {
                Bestsellers = bestsellers,
                NewArrivals = newArrivals,
                Genres = genres
            };           
            
            return View(vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}