namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_authorUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "AuthorJob", c => c.String(maxLength: 50));
            AddColumn("dbo.Authors", "AboutShort", c => c.String(maxLength: 50));
            AddColumn("dbo.Authors", "Email", c => c.String(maxLength: 50));
            AddColumn("dbo.Authors", "Password", c => c.String(maxLength: 50));
            AddColumn("dbo.Authors", "PhoneNumber", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "PhoneNumber");
            DropColumn("dbo.Authors", "Password");
            DropColumn("dbo.Authors", "Email");
            DropColumn("dbo.Authors", "AboutShort");
            DropColumn("dbo.Authors", "AuthorJob");
        }
    }
}
