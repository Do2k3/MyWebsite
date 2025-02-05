﻿namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Database1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_ProductCategory", "Icon", c => c.String());
            AddColumn("dbo.tb_ProductCategory", "SeoTitle", c => c.String());
            AddColumn("dbo.tb_ProductCategory", "SeoDescription", c => c.String());
            AddColumn("dbo.tb_ProductCategory", "SeoKeywords", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_ProductCategory", "SeoKeywords");
            DropColumn("dbo.tb_ProductCategory", "SeoDescription");
            DropColumn("dbo.tb_ProductCategory", "SeoTitle");
            DropColumn("dbo.tb_ProductCategory", "Icon");
        }
    }
}
