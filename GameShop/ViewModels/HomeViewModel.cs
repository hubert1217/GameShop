using GameShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public IEnumerable<Game> NewArrivals { get; set; }

        public IEnumerable<Game> Bestsellers { get; set; }

    }
}