namespace messengerX_v._1._0._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Message3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "fromU", c => c.Int(nullable: false));
            AddColumn("dbo.Messages", "toU", c => c.Int(nullable: false));
            DropColumn("dbo.Messages", "from");
            DropColumn("dbo.Messages", "to");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "to", c => c.Int(nullable: false));
            AddColumn("dbo.Messages", "from", c => c.Int(nullable: false));
            DropColumn("dbo.Messages", "toU");
            DropColumn("dbo.Messages", "fromU");
        }
    }
}
