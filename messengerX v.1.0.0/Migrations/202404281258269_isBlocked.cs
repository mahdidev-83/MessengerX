namespace messengerX_v._1._0._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isBlocked : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "isBlocked", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "isBlocked");
        }
    }
}
