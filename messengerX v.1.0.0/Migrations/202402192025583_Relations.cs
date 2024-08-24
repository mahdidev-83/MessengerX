namespace messengerX_v._1._0._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Relations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Relations",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        MainUserID = c.Int(nullable: false),
                        requestedUserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Relations");
        }
    }
}
