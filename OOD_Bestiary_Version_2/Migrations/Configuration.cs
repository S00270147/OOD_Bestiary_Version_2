namespace OOD_Bestiary_Version_2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OOD_Bestiary_Version_2.CreatureData>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "OOD_Bestiary_Version_2.CreatureData";
        }

        protected override void Seed(OOD_Bestiary_Version_2.CreatureData context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
