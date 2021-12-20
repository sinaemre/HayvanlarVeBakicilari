namespace DataAnnotation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bakicilar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 100),
                        SoyAd = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Hayvanlar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 100),
                        Cinsiyet = c.Int(nullable: false),
                        SahibiVarMi = c.Boolean(nullable: false),
                        DogumTarihi = c.DateTime(nullable: false),
                        Kutle = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Tur = c.String(),
                        FavoriYiyecekId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Yiyecekler", t => t.FavoriYiyecekId)
                .Index(t => t.FavoriYiyecekId);
            
            CreateTable(
                "dbo.Yiyecekler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 100),
                        UretimTarihi = c.DateTime(nullable: false),
                        SonKullanmaTarihi = c.DateTime(),
                        Kalori = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HayvanBakicis",
                c => new
                    {
                        Hayvan_Id = c.Int(nullable: false),
                        Bakici_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Hayvan_Id, t.Bakici_Id })
                .ForeignKey("dbo.Hayvanlar", t => t.Hayvan_Id, cascadeDelete: true)
                .ForeignKey("dbo.Bakicilar", t => t.Bakici_Id, cascadeDelete: true)
                .Index(t => t.Hayvan_Id)
                .Index(t => t.Bakici_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Hayvanlar", "FavoriYiyecekId", "dbo.Yiyecekler");
            DropForeignKey("dbo.HayvanBakicis", "Bakici_Id", "dbo.Bakicilar");
            DropForeignKey("dbo.HayvanBakicis", "Hayvan_Id", "dbo.Hayvanlar");
            DropIndex("dbo.HayvanBakicis", new[] { "Bakici_Id" });
            DropIndex("dbo.HayvanBakicis", new[] { "Hayvan_Id" });
            DropIndex("dbo.Hayvanlar", new[] { "FavoriYiyecekId" });
            DropTable("dbo.HayvanBakicis");
            DropTable("dbo.Yiyecekler");
            DropTable("dbo.Hayvanlar");
            DropTable("dbo.Bakicilar");
        }
    }
}
