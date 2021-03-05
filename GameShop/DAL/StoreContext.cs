﻿using GameShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GameShop.DAL
{
    public class StoreContext: DbContext
    {
        public DbSet<Game> Games { get; set; }

        public DbSet<Genre> Genres { get; set; }
    }
}