using System.Collections.Generic;

namespace GameShop.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public string GenreDescription { get; set; }
        public string IconFilename { get; set; }


        public ICollection<Game> Games { get; set; }

    }
}