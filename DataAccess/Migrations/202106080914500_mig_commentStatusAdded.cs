namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_commentStatusAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "CommentStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comments", "CommentStatus");
        }
    }
}
