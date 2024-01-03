namespace WebOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCategory : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Category", "Title", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.tb_Category", "SeoTitle", c => c.String(maxLength: 150));
            AlterColumn("dbo.tb_Category", "SeoKeywords", c => c.String(maxLength: 150));
            AlterColumn("dbo.tb_Category", "SeoDescriptione", c => c.String(maxLength: 250));
            DropColumn("dbo.tb_Category", "ModifierBy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Category", "ModifierBy", c => c.Int(nullable: false));
            AlterColumn("dbo.tb_Category", "SeoDescriptione", c => c.String());
            AlterColumn("dbo.tb_Category", "SeoKeywords", c => c.String());
            AlterColumn("dbo.tb_Category", "SeoTitle", c => c.String());
            AlterColumn("dbo.tb_Category", "Title", c => c.String());
        }
    }
}
