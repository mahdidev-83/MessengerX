namespace messengerX_v._1._0._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Message : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        text = c.String(),
                        from = c.Int(nullable: false),
                        to = c.Int(nullable: false),
                        datetime = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Messages");
        }
    }
}
