namespace WpfApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migr1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bludoes",
                c => new
                    {
                        BludoID = c.Int(nullable: false, identity: true),
                        BludoName = c.String(nullable: false),
                        BludoWeight = c.Double(nullable: false),
                        BludoPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BludoCategory = c.String(nullable: false),
                        BludoTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BludoID);
            
            CreateTable(
                "dbo.BludoInOrders",
                c => new
                    {
                        BludoID = c.Int(nullable: false),
                        OrderID = c.Int(nullable: false),
                        BludoAmount = c.Int(nullable: false),
                        OrderTime = c.DateTime(nullable: false),
                        BludoStatus = c.String(),
                    })
                .PrimaryKey(t => new { t.BludoID, t.OrderID })
                .ForeignKey("dbo.Bludoes", t => t.BludoID, cascadeDelete: true)
                .ForeignKey("dbo.OrderInTimes", t => t.OrderID, cascadeDelete: true)
                .Index(t => t.BludoID)
                .Index(t => t.OrderID);
            
            CreateTable(
                "dbo.OrderInTimes",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        WaiterID = c.Int(nullable: false),
                        TableID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Tables", t => t.TableID, cascadeDelete: true)
                .ForeignKey("dbo.Waiters", t => t.WaiterID, cascadeDelete: true)
                .Index(t => t.WaiterID)
                .Index(t => t.TableID);
            
            CreateTable(
                "dbo.Tables",
                c => new
                    {
                        TableID = c.Int(nullable: false, identity: true),
                        TableLocation = c.String(),
                        TableLabel = c.Int(nullable: false),
                        TablePlaces = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TableID);
            
            CreateTable(
                "dbo.Waiters",
                c => new
                    {
                        WaiterID = c.Int(nullable: false, identity: true),
                        WaiterName = c.String(nullable: false),
                        WaiterSurname = c.String(nullable: false),
                        WaiterLogin = c.String(nullable: false),
                        WaiterPassword = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.WaiterID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderInTimes", "WaiterID", "dbo.Waiters");
            DropForeignKey("dbo.OrderInTimes", "TableID", "dbo.Tables");
            DropForeignKey("dbo.BludoInOrders", "OrderID", "dbo.OrderInTimes");
            DropForeignKey("dbo.BludoInOrders", "BludoID", "dbo.Bludoes");
            DropIndex("dbo.OrderInTimes", new[] { "TableID" });
            DropIndex("dbo.OrderInTimes", new[] { "WaiterID" });
            DropIndex("dbo.BludoInOrders", new[] { "OrderID" });
            DropIndex("dbo.BludoInOrders", new[] { "BludoID" });
            DropTable("dbo.Waiters");
            DropTable("dbo.Tables");
            DropTable("dbo.OrderInTimes");
            DropTable("dbo.BludoInOrders");
            DropTable("dbo.Bludoes");
        }
    }
}
