namespace SporWebMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SonKullanici : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure("dbo.SonKullanici", l => new
            {
                Ret = l.Int()
               
            },
           body:
           @"SELECT @Ret = IDENT_CURRENT('Kullanici')

	         return @ret"
           );
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.SonKullanici");
        }
    }
}
