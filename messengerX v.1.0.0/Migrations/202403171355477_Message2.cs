namespace messengerX_v._1._0._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Message2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "Owner", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "Owner");
        }
    }
}
