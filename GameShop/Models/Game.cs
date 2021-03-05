using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameShop.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public int GenreId { get; set; }
        public string GameTitle { get; set; }
        public string GameStudio { get; set; }
        public string Platform { get; set; }

        public DateTime DateAdded { get; set; }

        public string CovertFileName { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }

        public bool IsBestseller { get; set; }

        public bool IsHidden { get; set; }


        public virtual Genre Genre { get; set; }

    }
}