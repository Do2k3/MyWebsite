namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Database : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tb_Product", "ProductCategory_Id", "dbo.tb_ProductCategory");
            DropIndex("dbo.tb_Product", new[] { "ProductCategory_Id" });
            RenameColumn(table: "dbo.tb_Product", name: "ProductCategory_Id", newName: "ProductCategoryId");
            AddColumn("dbo.tb_Product", "ProductCode", c => c.String());
            AddColumn("dbo.tb_Product", "IsHot", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_Product", "IsFeature", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_Product", "IsSale", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_Product", "IsHome", c => c.Boolean(nullable: false));
            AlterColumn("dbo.tb_Post", "Detail", c => c.String());
            AlterColumn("dbo.tb_Product", "Detail", c => c.String());
            AlterColumn("dbo.tb_Product", "ProductCategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.tb_Product", "ProductCategoryId");
            AddForeignKey("dbo.tb_Product", "ProductCategoryId", "dbo.tb_ProductCategory", "Id", cascadeDelete: true);
            DropColumn("dbo.tb_Product", "CategoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Product", "CategoryId", c => c.Int(nullable: false));
            DropForeignKey("dbo.tb_Product", "ProductCategoryId", "dbo.tb_ProductCategory");
            DropIndex("dbo.tb_Product", new[] { "ProductCategoryId" });
            AlterColumn("dbo.tb_Product", "ProductCategoryId", c => c.Int());
            AlterColumn("dbo.tb_Product", "Detail", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Post", "Detail", c => c.String(maxLength: 4000));
            DropColumn("dbo.tb_Product", "IsHome");
            DropColumn("dbo.tb_Product", "IsSale");
            DropColumn("dbo.tb_Product", "IsFeature");
            DropColumn("dbo.tb_Product", "IsHot");
            DropColumn("dbo.tb_Product", "ProductCode");
            RenameColumn(table: "dbo.tb_Product", name: "ProductCategoryId", newName: "ProductCategory_Id");
            CreateIndex("dbo.tb_Product", "ProductCategory_Id");
            AddForeignKey("dbo.tb_Product", "ProductCategory_Id", "dbo.tb_ProductCategory", "Id");
        }
    }
}
