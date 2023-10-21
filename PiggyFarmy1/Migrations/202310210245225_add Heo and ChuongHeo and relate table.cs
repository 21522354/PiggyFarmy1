namespace PiggyFarmy1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addHeoandChuongHeoandrelatetable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CHUONGHEOs",
                c => new
                    {
                        MaChuong = c.String(nullable: false, maxLength: 128),
                        MaLoaiChuong = c.String(maxLength: 128),
                        TinhTrang = c.String(),
                        SuaChuaToiDa = c.Int(),
                        SoLuongHeo = c.Int(),
                    })
                .PrimaryKey(t => t.MaChuong)
                .ForeignKey("dbo.LOAICHUONGs", t => t.MaLoaiChuong)
                .Index(t => t.MaLoaiChuong);
            
            CreateTable(
                "dbo.HEOs",
                c => new
                    {
                        MaHeo = c.String(nullable: false, maxLength: 128),
                        MaLoaiHeo = c.String(maxLength: 128),
                        MaGiongHeo = c.String(maxLength: 128),
                        GioiTinh = c.String(),
                        NgaySinh = c.DateTime(),
                        TrongLuong = c.Int(),
                        MaChuong = c.String(maxLength: 128),
                        MaHeoCha = c.String(),
                        MaHeoMe = c.String(),
                        NguonGoc = c.String(),
                        TinhTrang = c.String(),
                    })
                .PrimaryKey(t => t.MaHeo)
                .ForeignKey("dbo.CHUONGHEOs", t => t.MaChuong)
                .ForeignKey("dbo.GIONGHEOs", t => t.MaGiongHeo)
                .ForeignKey("dbo.LOAIHEOs", t => t.MaLoaiHeo)
                .Index(t => t.MaLoaiHeo)
                .Index(t => t.MaGiongHeo)
                .Index(t => t.MaChuong);
            
            CreateTable(
                "dbo.GIONGHEOs",
                c => new
                    {
                        MaGiongHeo = c.String(nullable: false, maxLength: 128),
                        TenGiongHeo = c.String(),
                        MoTa = c.String(),
                    })
                .PrimaryKey(t => t.MaGiongHeo);
            
            CreateTable(
                "dbo.LOAIHEOs",
                c => new
                    {
                        MaLoaiHeo = c.String(nullable: false, maxLength: 128),
                        TenLoaiHeo = c.String(),
                        MoTa = c.String(),
                    })
                .PrimaryKey(t => t.MaLoaiHeo);
            
            CreateTable(
                "dbo.LOAICHUONGs",
                c => new
                    {
                        MaLoaiChuong = c.String(nullable: false, maxLength: 128),
                        TenLoai = c.String(),
                        MoTa = c.String(),
                    })
                .PrimaryKey(t => t.MaLoaiChuong);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CHUONGHEOs", "MaLoaiChuong", "dbo.LOAICHUONGs");
            DropForeignKey("dbo.HEOs", "MaLoaiHeo", "dbo.LOAIHEOs");
            DropForeignKey("dbo.HEOs", "MaGiongHeo", "dbo.GIONGHEOs");
            DropForeignKey("dbo.HEOs", "MaChuong", "dbo.CHUONGHEOs");
            DropIndex("dbo.HEOs", new[] { "MaChuong" });
            DropIndex("dbo.HEOs", new[] { "MaGiongHeo" });
            DropIndex("dbo.HEOs", new[] { "MaLoaiHeo" });
            DropIndex("dbo.CHUONGHEOs", new[] { "MaLoaiChuong" });
            DropTable("dbo.LOAICHUONGs");
            DropTable("dbo.LOAIHEOs");
            DropTable("dbo.GIONGHEOs");
            DropTable("dbo.HEOs");
            DropTable("dbo.CHUONGHEOs");
        }
    }
}
