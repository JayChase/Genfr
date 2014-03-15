using Genfr.Data.Entities;
using Genfr.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genfr.Data.Context
{
    public class SampleContext : DbContext
    {
        public SampleContext()
        {            
        }

        public SampleContext(string connectionString):base(connectionString)
        {            
            //System.Data.Entity.Database.SetInitializer<SampleContext>(new SampleInitializer());
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.AutoDetectChangesEnabled = true;
            this.Configuration.ValidateOnSaveEnabled = true;            
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BookMapping()); 
            base.OnModelCreating(modelBuilder);
        }
    }
}
