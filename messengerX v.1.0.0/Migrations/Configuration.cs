namespace messengerX_v._1._0._0.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<messengerX_v._1._0._0.db>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "messengerX_v._1._0._0.db";
        }

        protected override void Seed(messengerX_v._1._0._0.db context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
