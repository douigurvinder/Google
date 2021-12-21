using Google.Business.Entities;
using Google.Data.Mapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google.Data.Helpers
{
    public class GoogleDbContext : DbContext
    {
        private string DbConnStr { get; set; }


        public GoogleDbContext()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"));
            var root = builder.Build();
            DbConnStr = root.GetConnectionString("OnlineDBConn");

        }





        public GoogleDbContext(DbContextOptions<GoogleDbContext> options)
      : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(DbConnStr);

        }

        public DbSet<Individual> IndividualSet { get; set; }
        public DbSet<Education> EducationSet { get; set; }
        public DbSet<Countrie> CountrieSet { get; set; }
        public DbSet<VW_Individual> VW_IndividualSet { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new IndividualConfiguration());
            modelBuilder.ApplyConfiguration(new CountrieConfiguration());
            modelBuilder.ApplyConfiguration(new EducationConfiguration());
            modelBuilder.ApplyConfiguration(new VW_IndividualConfiguration());


        }





    }
}
