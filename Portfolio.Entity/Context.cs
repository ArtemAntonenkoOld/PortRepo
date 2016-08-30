using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Portfolio.Entity
{
    public partial class PortfolioContext : DbContext
    {
        public PortfolioContext()
            : base("name=PortfolioDBConnectionString") {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<PortfolioContext, Entity.Migrations.Configuration>("PortfolioDBConnectionString"));


        }

        public virtual DbSet<tbEducation> tbEducation { get; set; }
        public virtual DbSet<tbLanguages> tbLanguage { get; set; }
        public virtual DbSet<tbProjects> tbProjects { get; set; }
        public virtual DbSet<tbSkills> tbSkills { get; set; }
        public virtual  DbSet<tbWork> tbWork { get; set; }
        public virtual  DbSet<tbUser> tbUser { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
          
        }

    }
}
