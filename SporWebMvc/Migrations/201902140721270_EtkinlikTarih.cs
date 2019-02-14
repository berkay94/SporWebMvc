namespace SporWebMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EtkinlikTarih : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure("dbo.EtkinlikTarihKontrol", et => new
            {

            },
            body:
            @"Update Etkinlik set isActive = 2 where EtkinlikTarihi < GETDATE()"
            );
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.EtkinlikTarihKontrol");
        }
    }
}
