namespace SporWebMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsLoginUser : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure("dbo.IsLoginUser", l => new
            {
                kid=l.Int()
            },
           body:
           @"Update Kullanici set isLogin = 2 where Id = @kid"
           );
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.IsLoginUser");
        }
    }
}
