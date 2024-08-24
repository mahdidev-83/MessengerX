namespace messengerX_v._1._0._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Message1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Messages", "datetime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Messages", "datetime", c => c.String());
        }
    }
}
