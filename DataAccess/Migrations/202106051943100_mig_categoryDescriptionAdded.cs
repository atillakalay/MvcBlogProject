namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_categoryDescriptionAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CategoryDescription", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "CategoryDescription");
        }
    }
}
