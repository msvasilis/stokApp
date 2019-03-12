using stokApp.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace stokApp.Models.ORM.Context
{
    public class StokContext : DbContext
    {
        public StokContext(): base("dataConnection")
        {

        }
        public DbSet<AdminUser> adminUsers { get; set; }
        public DbSet<faturalar> faturalars { get; set;  }
        public DbSet<Hizmet> hizmets { get; set; }
        public DbSet<Musteri> musteris { get; set; } 
        public DbSet<SatisFatura> satisFaturas { get; set; } 
        public DbSet<StokEkle> stokEkles { get; set; } 
        public DbSet<Teklifler> tekliflers { get; set; } 
        public DbSet<AlisTedarik> alisTedariks { get; set; } 
        public DbSet<AlisFatura> alisFaturas { get; set; } 

    }
}