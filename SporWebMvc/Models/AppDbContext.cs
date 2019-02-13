using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SporWebMvc.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext():base("SporConn")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDbContext, Migrations.Configuration>("SporConn"));
        }

        public DbSet<Etkinlikler> Etkinlik { get; set; }
        public DbSet<EtkinlikTip> EtkinlikTip { get; set; }
        public DbSet<HataLoglari> HataLoglari { get; set; }
        public DbSet<Ilceler> Ilceler { get; set; }
        public DbSet<Iller> Iller { get; set; }
        public DbSet<Katilanlar> Katilanlar { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<KullaniciSpor> KullaniciSporlar { get; set; }
        public DbSet<Sporlar> Sporlar { get; set; }
        public DbSet<Mekan> Mekanlar { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity
        }
    }

    
}