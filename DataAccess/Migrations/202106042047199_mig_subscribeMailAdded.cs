namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_subscribeMailAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SubscribeMails",
                c => new
                    {
                        MailId = c.Int(nullable: false, identity: true),
                        Email = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MailId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SubscribeMails");
        }
    }
}
