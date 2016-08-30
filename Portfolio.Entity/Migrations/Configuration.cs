namespace Portfolio.Entity.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Portfolio.Entity.PortfolioContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Portfolio.Entity.PortfolioContext";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Portfolio.Entity.PortfolioContext context)
        {
         
        }
    }
}
