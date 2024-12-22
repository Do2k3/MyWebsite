namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Database2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_ProductCategory", "Alias", c => c.String());
            AlterColumn("dbo.tb_ProductCategory", "Title", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_ProductCategory", "Title", c => c.String());
            DropColumn("dbo.tb_ProductCategory", "Alias");
        }
    }
}
