using Google.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google.Data.Mapper
{
   public class CountrieConfiguration : IEntityTypeConfiguration<Countrie>
    {
        public void Configure(EntityTypeBuilder<Countrie> builder)
        {
            builder.ToTable("Countries");

            builder.HasKey(t => t.CountryID);

        }
    }
}
