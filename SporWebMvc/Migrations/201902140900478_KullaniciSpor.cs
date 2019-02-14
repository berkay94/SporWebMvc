namespace SporWebMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KullaniciSpor : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure("dbo.KullaniciSporEkle", l => new
            {
                kid = l.Int(),
                sid=l.Int()
            },
           body:
           @"insert into KullaniciSpor Values(@kid, @sid)"
           );
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.KullaniciSporEkle");
        }
    }
}
