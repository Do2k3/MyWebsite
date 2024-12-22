namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Category", "Alias", c => c.String());
            AddColumn("dbo.tb_News", "Alias", c => c.String());
            AddColumn("dbo.tb_Post", "Alias", c => c.String());
            AddColumn("dbo.tb_Product", "Alias", c => c.String());
            AlterColumn("dbo.tb_Category", "Title", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.tb_Category", "Description", c => c.String(maxLength: 500));
            AlterColumn("dbo.tb_Category", "SeoTitle", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Category", "SeoDescription", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Category", "SeoKeywords", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Post", "Title", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.tb_Post", "Description", c => c.String(maxLength: 4000));
            AlterColumn("dbo.tb_Post", "Detail", c => c.String(maxLength: 4000));
            AlterColumn("dbo.tb_Post", "SeoTitle", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Post", "SeoDescription", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Post", "SeoKeywords", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Product", "Title", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.tb_Product", "Description", c => c.String(maxLength: 500));
            AlterColumn("dbo.tb_Product", "Detail", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Product", "SeoTitle", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Product", "SeoDescription", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Product", "SeoKeywords", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Product", "SeoKeywords", c => c.String());
            AlterColumn("dbo.tb_Product", "SeoDescription", c => c.String());
            AlterColumn("dbo.tb_Product", "SeoTitle", c => c.String());
            AlterColumn("dbo.tb_Product", "Detail", c => c.String());
            AlterColumn("dbo.tb_Product", "Description", c => c.String());
            AlterColumn("dbo.tb_Product", "Title", c => c.String());
            AlterColumn("dbo.tb_Post", "SeoKeywords", c => c.String());
            AlterColumn("dbo.tb_Post", "SeoDescription", c => c.String());
            AlterColumn("dbo.tb_Post", "SeoTitle", c => c.String());
            AlterColumn("dbo.tb_Post", "Detail", c => c.String());
            AlterColumn("dbo.tb_Post", "Description", c => c.String());
            AlterColumn("dbo.tb_Post", "Title", c => c.String());
            AlterColumn("dbo.tb_Category", "SeoKeywords", c => c.String());
            AlterColumn("dbo.tb_Category", "SeoDescription", c => c.String());
            AlterColumn("dbo.tb_Category", "SeoTitle", c => c.String());
            AlterColumn("dbo.tb_Category", "Description", c => c.String());
            AlterColumn("dbo.tb_Category", "Title", c => c.String());
            DropColumn("dbo.tb_Product", "Alias");
            DropColumn("dbo.tb_Post", "Alias");
            DropColumn("dbo.tb_News", "Alias");
            DropColumn("dbo.tb_Category", "Alias");
        }
    }
}
