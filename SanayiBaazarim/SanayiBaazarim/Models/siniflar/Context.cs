using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SanayiBaazarim.Models.siniflar
{
    public class Context : DbContext
    {
        public DbSet<admin> Admins { get; set; }
        public DbSet<teklifler> tekliflers { get; set; }
        public DbSet<ürünkategorisi> ürünkategorisis { get; set; }
        public DbSet<ürünler> ürünlers { get; set; }
    }
}