using GameShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameShop.ViewModels
{
    public class HomeViewModel
    {
        IEnumerable<Genre> Genres { get; set; }

        IEnumerable<Game> NewArrivals { get; set; }

        IEnumerable<Game> Bestsellers { get; set; }

    }
}