namespace WpfApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrProperty : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.TableName", "ColumnNameTmp", c => c.Binary());
            //Sql("Update dbo.TableName SET ColumnNameTmp = Convert(varbinary, ColumnName)");
                        
            AddColumn("dbo.Bludoes", "BludoTimeTmp", c => c.Int(nullable: false));
            //Sql("Update dbo.Bludoes SET BludoTimeTmp = Convert(int, BludoTime)");
            //DropColumn("dbo.BludoTime", "BludoTime");
            //RenameColumn("dbo.TableName", "BludoTimeTmp", "BludoTime");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bludoes", "BludoTime", c => c.DateTime(nullable: false));
        }
    }
}
