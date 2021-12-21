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
   public class EducationConfiguration : IEntityTypeConfiguration<Education>
    {

        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.ToTable("Education");

            builder.HasKey(t => t.EducationID);

        }

    }
}
