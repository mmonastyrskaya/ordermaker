namespace WpfApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Try : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bludoes", "BludoTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bludoes", "BludoTime", c => c.Int(nullable: false));
        }
    }
}
