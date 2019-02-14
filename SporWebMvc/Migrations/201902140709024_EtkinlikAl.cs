namespace SporWebMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EtkinlikAl : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure("dbo.EtkinlikAl", e => new
            {

            },
            body:
            @"exec [dbo].[EtkinlikTarihKontrol]
               select e.Id, EtkinlikAdi, SporAdi, et.Tip,EtkinlikTarihi,m.MekanAdi,ilce.Ad,il.Sehir, e.Kontenjan, count(k.Kid) as Katilanlar from Etkinlik as e
	            inner join Sporlar as s on e.Sid = s.Id 
	            inner join Mekan as m on e.MekanId = m.Id
	            inner join EtkinlikTipi as et on e.TipId = et.Id
	            inner join Ilceler as ilce on m.IlceId = ilce.Id
	            inner join Iller as il on ilce.Sehir = il.Id
	            left join Katilanlar as k on k.Eid = e.Id
	            where isActive = 1
	            group by e.Id, EtkinlikAdi, SporAdi, et.Tip,EtkinlikTarihi,m.MekanAdi,ilce.ad,il.Sehir,e.Kontenjan"
                );
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.EtkinlikAl");
        }
    }
}
