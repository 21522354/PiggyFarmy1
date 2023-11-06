namespace PiggyFarmy1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chinhsuachuongvaloaichuong : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LOAICHUONGs", "SucChuaToiDa", c => c.Int(nullable: false));
            DropColumn("dbo.CHUONGHEOs", "SuaChuaToiDa");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CHUONGHEOs", "SuaChuaToiDa", c => c.Int());
            DropColumn("dbo.LOAICHUONGs", "SucChuaToiDa");
        }
    }
}
