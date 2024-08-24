namespace messengerX_v._1._0._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProfilePicture : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "ProfilePicture", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "ProfilePicture");
        }
    }
}
