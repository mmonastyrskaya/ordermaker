namespace WpfApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class T1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BludoInOrders", "ID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
        }
    }
}
